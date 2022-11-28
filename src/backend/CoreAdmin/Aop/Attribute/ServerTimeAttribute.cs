namespace CoreAdmin.Aop.Attribute;

/// <summary>
///     标记一个字段是否启用服务器时间
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ServerTimeAttribute : System.Attribute
{
    /// <summary>
    ///     启用
    /// </summary>
    public bool Enable { get; set; } = true;
}