using CoreAdmin.Aop.Filter;
using CoreAdmin.DataContract.DbMap;
using CoreAdmin.Repository;
using Furion.EventBus;
using Mapster;
using NSExt.Extensions;

namespace CoreAdmin.Events;

/// <summary>
///     请求审计事件
/// </summary>
public class RequestAuditEvent : IEventSubscriber, ISingleton, IDisposable
{
    private readonly IServiceScope _scope;

    /// <summary>
    ///     Initializes a new instance of the <see cref="RequestAuditEvent" /> class.
    /// </summary>
    /// <param name="serviceProvider">serviceProvider</param>
    public RequestAuditEvent(IServiceProvider serviceProvider)
    {
        _scope = serviceProvider.CreateScope();
    }

    /// <inheritdoc />
    ~RequestAuditEvent()
    {
        Dispose(false);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this); // Violates rule
    }

    /// <summary>
    ///     保存到数据库
    /// </summary>
    [EventSubscribe($"{nameof(RequestAuditHandler)}.{nameof(RequestAuditHandler.OnActionExecutionAsync)}")]
    public async Task SaveToDb(EventHandlerExecutingContext context)
    {
        var tbSysOperationLog = context.Source.Payload.Adapt<TbSysOperationLog>();

        // 截断过长的ResponseResult
        const int cutThreshold = 1000;
        if (tbSysOperationLog.ResponseResult?.Length > cutThreshold) {
            tbSysOperationLog.ResponseResult = $"{tbSysOperationLog.ResponseResult.Sub(0, cutThreshold)}...";
        }

        await _scope.ServiceProvider.GetRequiredService<Repository<TbSysOperationLog>>().InsertAsync(tbSysOperationLog);
    }

    /// <summary>
    ///     Dispose
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
        if (disposing) {
            _scope?.Dispose();
        }
    }
}