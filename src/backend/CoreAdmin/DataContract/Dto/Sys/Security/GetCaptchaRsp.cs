namespace CoreAdmin.DataContract.Dto.Sys.Security;

/// <summary>
///     响应：获取验证图片
/// </summary>
public record GetCaptchaRsp : ICacheKey
{
    /// <summary>
    ///     背景图（base64）
    /// </summary>
    public virtual string BackgroundImage { get; set; }

    /// <inheritdoc cref="ICacheKey.CacheKey" />
    public string CacheKey { get; set; }

    /// <summary>
    ///     滑块图（base64）
    /// </summary>
    public virtual string SliderImage { get; set; }
}