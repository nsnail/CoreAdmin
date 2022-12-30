namespace CoreAdmin.Infrastructure.Configuration.Options;

/// <summary>
///     密码配置
/// </summary>
public record SecretOptions : OptionAbstraction
{
    /// <summary>
    ///     secretKeyA
    /// </summary>
    public string SecretKeyA { get; set; }
}