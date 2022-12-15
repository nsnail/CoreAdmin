namespace CoreAdmin.Infrastructure.Configuration.Options;

/// <summary>
///     密码配置
/// </summary>
public record SecretOptions : OptionAbstraction
{
    /// <summary>
    ///     Gets or sets secretKeyA
    /// </summary>
    /// <value>
    ///     SecretKeyA
    /// </value>
    public string SecretKeyA { get; set; }
}