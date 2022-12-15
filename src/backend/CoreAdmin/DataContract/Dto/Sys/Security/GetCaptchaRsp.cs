namespace CoreAdmin.DataContract.Dto.Sys.Security;

/// <summary>
///     Gets or sets 获取验证图片响应
/// </summary>
public record GetCaptchaRsp : ICacheKey
{
    /// <summary>
    ///     Gets or sets 背景图（base64）
    /// </summary>
    /// <value>
    ///     背景图（base64）
    /// </value>
    public virtual string BackgroundImage { get; set; }

    /// <inheritdoc cref="ICacheKey.CacheKey" />
    public string CacheKey { get; set; }

    /// <summary>
    ///     Gets or sets 滑块图（base64）
    /// </summary>
    /// <value>
    ///     滑块图（base64）
    /// </value>
    public virtual string SliderImage { get; set; }
}