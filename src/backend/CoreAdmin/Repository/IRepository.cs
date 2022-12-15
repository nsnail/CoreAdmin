using System.Linq.Expressions;
using CoreAdmin.DataContract;
using FreeSql;

namespace CoreAdmin.Repository;

/// <summary>
///     基础仓储接口
/// </summary>
public interface IRepository<TTable> : IBaseRepository<TTable>
    where TTable : class
{
    /// <summary>
    ///     Gets or sets 当前上下文关联的用户
    /// </summary>
    /// <value>
    ///     当前上下文关联的用户
    /// </value>
    ContextUser ContextUser { get; set; }

    /// <summary>
    ///     递归删除
    /// </summary>
    /// <param name="exp">exp</param>
    /// <param name="disableGlobalFilterNames">禁用全局过滤器名</param>
    Task<bool> DeleteRecursiveAsync(Expression<Func<TTable, bool>> exp, params string[] disableGlobalFilterNames);

    /// <summary>
    ///     获得Dto
    /// </summary>
    /// <param name="id">主键</param>
    Task<TDto> GetAsync<TDto>(long id);

    /// <summary>
    ///     根据条件获取Dto
    /// </summary>
    Task<TDto> GetAsync<TDto>(Expression<Func<TTable, bool>> exp);

    /// <summary>
    ///     根据条件获取实体
    /// </summary>
    Task<TTable> GetAsync(Expression<Func<TTable, bool>> exp);

    /// <summary>
    ///     软删除
    /// </summary>
    /// <param name="id">主键</param>
    Task<bool> SoftDeleteAsync(long id);

    /// <summary>
    ///     批量软删除
    /// </summary>
    /// <param name="ids">主键数组</param>
    Task<bool> SoftDeleteAsync(long[] ids);

    /// <summary>
    ///     软删除
    /// </summary>
    /// <param name="exp">exp</param>
    /// <param name="disableGlobalFilterNames">禁用全局过滤器名</param>
    Task<bool> SoftDeleteAsync(Expression<Func<TTable, bool>> exp, params string[] disableGlobalFilterNames);

    /// <summary>
    ///     递归软删除
    /// </summary>
    /// <param name="exp">exp</param>
    /// <param name="disableGlobalFilterNames">禁用全局过滤器名</param>
    Task<bool> SoftDeleteRecursiveAsync(Expression<Func<TTable, bool>> exp, params string[] disableGlobalFilterNames);
}