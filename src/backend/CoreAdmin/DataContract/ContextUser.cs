namespace CoreAdmin.DataContract;

/// <summary>
///     上下文用户信息
/// </summary>
public record ContextUser : IScoped
{
    /// <summary>
    ///     Gets or sets 用户id
    /// </summary>
    /// <value>
    ///     用户id
    /// </value>
    public long Id { get; set; }

    /// <summary>
    ///     Gets or sets 用户名
    /// </summary>
    /// <value>
    ///     用户名
    /// </value>
    public string UserName { get; set; }

    /// <summary>
    ///     Gets 做授权验证的Token，全局唯一，可以随时重置（强制下线）
    /// </summary>
    /// <value>
    ///     做授权验证的Token，全局唯一，可以随时重置（强制下线）
    /// </value>
    internal Guid Token { get; init; }
}