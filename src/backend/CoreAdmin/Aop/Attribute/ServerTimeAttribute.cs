namespace CoreAdmin.Aop.Attribute;

/// <summary>
///     标记一个字段是否启用服务器时间
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ServerTimeAttribute : System.Attribute
{
    /// <summary>
    ///     Gets or sets a value indicating whether 启用
    /// </summary>
    /// <value>
    ///     A value indicating whether 启用
    /// </value>
    public bool Enable { get; set; } = true;
}