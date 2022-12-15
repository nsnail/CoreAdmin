using CoreAdmin.DataContract.DbMap.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap;

/// <summary>
///     Gets or sets 操作日志表
/// </summary>
[Table]
public record TbSysOperationLog : NoModifyTable
{
    /// <summary>
    ///     Gets or sets 操作
    /// </summary>
    /// <value>
    ///     操作
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string Action { get; set; }

    /// <summary>
    ///     Gets or sets 客户端IP
    /// </summary>
    /// <value>
    ///     客户端IP
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string ClientIp { get; set; }

    /// <summary>
    ///     Gets or sets 控制器
    /// </summary>
    /// <value>
    ///     控制器
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string Controller { get; set; }

    /// <summary>
    ///     Gets or sets 执行耗时（ms）
    /// </summary>
    /// <value>
    ///     执行耗时（ms）
    /// </value>
    [Column(CanUpdate = false)]
    public virtual uint Duration { get; set; }

    /// <summary>
    ///     Gets or sets 服务端运行环境
    /// </summary>
    /// <value>
    ///     服务端运行环境
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string Environment { get; set; }

    /// <summary>
    ///     Gets or sets 请求方法
    /// </summary>
    /// <value>
    ///     请求方法
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string Method { get; set; }

    /// <summary>
    ///     Gets or sets 来源地址
    /// </summary>
    /// <value>
    ///     来源地址
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string ReferUrl { get; set; }

    /// <summary>
    ///     Gets or sets 请求content-type
    /// </summary>
    /// <value>
    ///     请求content-type
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string RequestContentType { get; set; }

    /// <summary>
    ///     Gets or sets 请求参数
    /// </summary>
    /// <value>
    ///     请求参数
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string RequestParameters { get; set; }

    /// <summary>
    ///     Gets or sets 请求地址
    /// </summary>
    /// <value>
    ///     请求地址
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string RequestUrl { get; set; }

    /// <summary>
    ///     Gets or sets 响应原始类型
    /// </summary>
    /// <value>
    ///     响应原始类型
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string ResponseRawType { get; set; }

    /// <summary>
    ///     Gets or sets 响应结果
    /// </summary>
    /// <value>
    ///     响应结果
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string ResponseResult { get; set; }

    /// <summary>
    ///     Gets or sets 响应状态码
    /// </summary>
    /// <value>
    ///     响应状态码
    /// </value>
    [Column(CanUpdate = false)]
    public virtual ushort ResponseStatusCode { get; set; }

    /// <summary>
    ///     Gets or sets 响应封装类型
    /// </summary>
    /// <value>
    ///     响应封装类型
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string ResponseWrapType { get; set; }

    /// <summary>
    ///     Gets or sets 服务器IP
    /// </summary>
    /// <value>
    ///     服务器IP
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string ServerIp { get; set; }

    /// <summary>
    ///     Gets or sets 浏览器标识
    /// </summary>
    /// <value>
    ///     浏览器标识
    /// </value>
    [Column(CanUpdate = false)]
    public virtual string UserAgent { get; set; }
}