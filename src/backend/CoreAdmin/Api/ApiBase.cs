// ReSharper disable ContextualLoggerProblem

#pragma warning disable SA1402

using CoreAdmin.DataContract;
using CoreAdmin.DataContract.DbMap.Dependency;
using CoreAdmin.Repository;
using Furion.DynamicApiController;

namespace CoreAdmin.Api;

/// <summary>
///     Api Controller 基类
/// </summary>
public abstract class ApiBase<TLogger, TTable> : ApiBase<TLogger>
    where TTable : DataAbstraction, IEntity, new()
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiBase{TLogger, TTable}" /> class.
    ///     Api Controller 基类
    /// </summary>
    protected ApiBase()
    {
        Repository = App.GetService<Repository<TTable>>();
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiBase{TLogger, TTable}" /> class.
    /// </summary>
    protected ApiBase(ILogger<TLogger> logger, Repository<TTable> repository) //
        : base(logger)
    {
        Repository = repository;
    }

    /// <summary>
    ///     默认仓储
    /// </summary>
    protected Repository<TTable> Repository { get; }
}

/// <summary>
///     Api Controller 基类
/// </summary>
public abstract class ApiBase<T> : IDynamicApiController
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiBase{T}" /> class.
    ///     Api Controller 基类
    /// </summary>
    protected ApiBase()
    {
        Logger = App.GetService<ILogger<T>>();
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiBase{T}" /> class.
    /// </summary>
    protected ApiBase(ILogger<T> logger)
    {
        Logger = logger;
    }

    /// <summary>
    ///     日志记录器
    /// </summary>
    protected ILogger<T> Logger { get; }
}