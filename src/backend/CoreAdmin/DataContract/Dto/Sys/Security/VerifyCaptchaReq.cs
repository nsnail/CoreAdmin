using CoreAdmin.Aop.Attribute;

namespace CoreAdmin.DataContract.Dto.Sys.Security;

/// <summary>
///     Gets or sets 人机校验请求
/// </summary>
public record VerifyCaptchaReq : ICacheKey
{
    /// <inheritdoc cref="ICacheKey.CacheKey" />
    [RequiredField]
    public string CacheKey { get; set; }

    /// <summary>
    ///     Gets or sets 验证数据
    /// </summary>
    /// <value>
    ///     验证数据
    /// </value>
    [RequiredField]
    public string VerifyData { get; set; }
}