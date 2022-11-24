﻿using FreeSql;
using Microsoft.AspNetCore.Mvc.Filters;
using NSExt.Extensions;

namespace CoreAdmin.Aop.Filters;

/// <summary>
///     事务拦截器
/// </summary>
[SuppressSniffer]
public class TransactionHandler : IAsyncActionFilter

{
    /// <summary>
    ///     事务拦截器
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="uowManager"></param>
    public TransactionHandler(ILogger<TransactionHandler> logger, UnitOfWorkManager uowManager)
    {
        _logger     = logger;
        _uowManager = uowManager;
    }

    private readonly ILogger<TransactionHandler> _logger;
    private readonly UnitOfWorkManager           _uowManager;


    /// <inheritdoc />
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        using var unitOfWork = _uowManager.Begin();
        var       hashCode   = unitOfWork.GetHashCode();
        try {
            _logger.Info($"事务 {hashCode} 开始");
            var result = await next();
            if (result.Exception is not null) throw result.Exception;
            unitOfWork.Commit();
            _logger.Info($"事务 {hashCode} 完成");
        }
        catch (Exception) {
            unitOfWork.Rollback();
            _logger.Error($"事务 {hashCode} 回滚");
            throw;
        }
    }
}