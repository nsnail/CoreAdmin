using System.Data.Common;
using System.Reflection;
using CoreAdmin.Aop.Attribute;
using CoreAdmin.Infrastructure.Configuration.Options;
using CoreAdmin.Infrastructure.Extension;
using FreeSql;
using FreeSql.Aop;
using FreeSql.DataAnnotations;
using NSExt.Extensions;
using Yitter.IdGenerator;
using DataType = FreeSql.DataType;
using DbCommandExtensions = CoreAdmin.Infrastructure.Extension.DbCommandExtensions;

namespace CoreAdmin.Infrastructure.Util;

/// <summary>
///     FreeSqlHelper
/// </summary>
public class FreeSqlHelper
{
    private readonly DatabaseOptions        _databaseOptions;
    private          ILogger<FreeSqlHelper> _logger;
    private          TimeSpan               _timeOffset;

    private FreeSqlHelper(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
        _logger          = App.GetService<ILogger<FreeSqlHelper>>();
    }

    /// <summary>
    ///     创建FreeSql
    /// </summary>
    public static IFreeSql Create(DatabaseOptions options)
    {
        return new FreeSqlHelper(options).Build();
    }

    private static Type[] GetEntityTypes()
    {
        //获取所有表实体
        var entityTypes = (from type in App.EffectiveTypes
                           from attr in type.GetCustomAttributes()
                           where attr is TableAttribute { DisableSyncStructure: false }
                           select type).ToArray();
        return entityTypes;
    }

    private static string GetNoParamSql(string sql, IEnumerable<DbParameter> dbParams)
    {
        return dbParams.Where(x => x is not null)
                       .Aggregate(
                           sql, (current, dbParam) => current.Replace(dbParam.ParameterName, dbParam.Value?.ToString()))
                       .RemoveWrapped();
    }

    private static void InitSeedData(IFreeSql freeSql, IEnumerable<Type> entityTypes)
    {
        foreach (var entityType in entityTypes) {
            var path = $"{AppContext.BaseDirectory}/.data/seed-data/{entityType.Name}.json";
            if (!File.Exists(path)) {
                continue;
            }

            // TODO  #error 这里被表的JsonIgnoreAttribute 挡住了 ， 换成newtonsoft ？
            dynamic entities = File.ReadAllText(path).Object(typeof(List<>).MakeGenericType(entityType));

            // 如果表存在数据，跳过
            var select = typeof(IFreeSql).GetMethod(nameof(freeSql.Select), 1, Type.EmptyTypes)
                                         ?.MakeGenericMethod(entityType)
                                         .Invoke(freeSql, null);
            if (select?.GetType()
                      .GetMethod(nameof(ISelect<dynamic>.Any), 0, Type.EmptyTypes)
                      ?.Invoke(select, null) as bool? ?? true) {
                continue;
            }

            var rep = typeof(FreeSqlDbContextExtensions).GetMethods()
                                                        .Where(x => x.Name ==
                                                                    nameof(FreeSqlDbContextExtensions.GetRepository))
                                                        .FirstOrDefault(x => x.GetGenericArguments().Length == 1)
                                                        ?.MakeGenericMethod(entityType)
                                                        .Invoke(null, new object[] { freeSql, null });
            if (rep?.GetType().GetProperty(nameof(DbContextOptions))?.GetValue(rep) is DbContextOptions options) {
                options.EnableCascadeSave = true;
                options.NoneParameter     = true;
            }

            var insert = typeof(IBaseRepository<>).MakeGenericType(entityType)
                                                  .GetMethod( //
                                                      nameof(IBaseRepository<dynamic>.Insert)
                                                    , BindingFlags.Public | BindingFlags.Instance, null
                                                    , CallingConventions.Any
                                                    , new[] { typeof(List<>).MakeGenericType(entityType) }, null);

            insert?.Invoke(rep, new[] { entities });
        }
    }

    private IFreeSql Build()
    {
        var freeSql = new FreeSqlBuilder().UseConnectionString(_databaseOptions.DbType, _databaseOptions.ConnStr)
                                          .UseMonitorCommand( //
                                              cmd => cmd.Executing(), (_, log) => DbCommandExtensions.Executed(log))
                                          .UseAutoSyncStructure(false)
                                          .Build();

        // 获取服务器时间偏差
        var serverTime = freeSql.Ado.QuerySingle(() => DateTime.UtcNow);
        _timeOffset = DateTime.UtcNow.Subtract(serverTime);

        freeSql.Aop.AuditValue += DataAuditHandler;
        freeSql.Aop.CurdBefore += (_, e) => {
            var sql = GetNoParamSql(e.Sql, e.DbParms);
            _logger.Info($"SQL.{(uint)sql.GetHashCode()}：{sql}");
        };
        freeSql.Aop.CurdAfter += (_, e) => {
            var sql = GetNoParamSql(e.Sql, e.DbParms);
            _logger.Info($"SQL.{(uint)sql.GetHashCode()}：{e.ElapsedMilliseconds} ms");
        };
        Task.Run(async () => {
            await WaitSerilogReady();

            var entityTypes = GetEntityTypes();

            if (_databaseOptions.IsSyncStructure) {
                SyncStructure(freeSql, entityTypes);
                _logger.Info("数据库结构已同步");
            }

            InitSeedData(freeSql, entityTypes);
            _logger.Info("种子数据初始化完毕");
        });
        return freeSql;
    }

    private void DataAuditHandler(object sender, AuditValueEventArgs e)
    {
        //设置服务器时间字段
        if (e.Property.GetCustomAttribute<ServerTimeAttribute>(false) is { Enable: true }   &&
            (e.Column.CsType == typeof(DateTime) || e.Column.CsType   == typeof(DateTime?)) &&
            (e.Value         == null             || (DateTime)e.Value == default || (DateTime?)e.Value == default)) {
            e.Value = DateTime.Now.Subtract(_timeOffset);
        }

        //设置雪花id字段
        if (e.Column.CsType == typeof(long)                                              &&
            e.Property.GetCustomAttribute<SnowflakeAttribute>(false) is { Enable: true } &&
            (e.Value == null || (long)e.Value == default || (long?)e.Value == default)) {
            e.Value = YitIdHelper.NextId();
        }
    }

    private void SyncStructure(IFreeSql freeSql, Type[] entityTypes)
    {
        if (_databaseOptions.DbType == DataType.Oracle) {
            freeSql.CodeFirst.IsSyncStructureToUpper = true;
        }

        freeSql.CodeFirst.SyncStructure(entityTypes);
    }

    private async Task WaitSerilogReady()
    {
        _logger = App.GetService<ILogger<FreeSqlHelper>>();
        for (var i = 0; i != 10; ++i) {
            if (_logger.GetType()
                       .GetRuntimeFields()
                       .FirstOrDefault(x => x.Name == "_logger")
                       ?.GetValue(_logger)
                       ?.GetType()
                       .Name == "SerilogLogger") {
                break;
            }

            await Task.Delay(100);
            _logger = App.GetService<ILogger<FreeSqlHelper>>();
        }
    }
}