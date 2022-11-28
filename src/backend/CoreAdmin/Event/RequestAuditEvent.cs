using CoreAdmin.Aop.Filter;
using CoreAdmin.DataContract.DbMap;
using CoreAdmin.Repository;
using Furion.EventBus;
using Mapster;
using NSExt.Extensions;

namespace CoreAdmin.Event;

/// <summary>
///     请求审计事件
/// </summary>
public class RequestAuditEvent : IEventSubscriber, ISingleton, IDisposable
{
    private readonly IServiceScope _scope;

    /// <param name="serviceProvider"></param>
    public RequestAuditEvent(IServiceProvider serviceProvider)
    {
        _scope = serviceProvider.CreateScope();
    }


    /// <inheritdoc />
    public void Dispose()
    {
        _scope?.Dispose();
    }

    /// <summary>
    ///     保存到数据库
    /// </summary>
    /// <param name="context"></param>
    [EventSubscribe($"{nameof(RequestAuditHandler)}.{nameof(RequestAuditHandler.OnActionExecutionAsync)}")]
    public async Task SaveToDb(EventHandlerExecutingContext context)
    {
        var tbSysOperationLog = context.Source.Payload.Adapt<TbSysOperationLog>();

        // 截断过长的ResponseResult
        const int cutThreshold = 1000;
        if (tbSysOperationLog.ResponseResult?.Length > cutThreshold)
            tbSysOperationLog.ResponseResult = $"{tbSysOperationLog.ResponseResult.Sub(0, cutThreshold)}...";
        await _scope.ServiceProvider.GetRequiredService<Repository<TbSysOperationLog>>().InsertAsync(tbSysOperationLog);
    }
}