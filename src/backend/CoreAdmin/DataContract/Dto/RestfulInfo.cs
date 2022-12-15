using CoreAdmin.Infrastructure.Constant;

namespace CoreAdmin.DataContract.Dto;

/// <summary>
///     RESTful 风格结果集
/// </summary>
public record RestfulInfo<T> : DataContract
{
    /// <summary>
    ///     Gets or sets 代码
    /// </summary>
    /// <value>
    ///     代码
    /// </value>
    public Enums.ErrorCodes Code { get; set; }

    /// <summary>
    ///     Gets or sets 数据
    /// </summary>
    /// <value>
    ///     数据
    /// </value>
    public T Data { get; set; }

    /// <summary>
    ///     Gets or sets 消息
    /// </summary>
    /// <value>
    ///     消息
    /// </value>
    public object Msg { get; set; }
}