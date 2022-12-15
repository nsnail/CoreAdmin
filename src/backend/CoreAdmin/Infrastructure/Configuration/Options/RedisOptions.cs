namespace CoreAdmin.Infrastructure.Configuration.Options;

/// <summary>
///     Redis配置
/// </summary>
public record RedisOptions : OptionAbstraction
{
    /// <summary>
    ///     Gets or sets 链接字符串
    /// </summary>
    /// <value>
    ///     链接字符串
    /// </value>
    public string ConnStr { get; set; }
}