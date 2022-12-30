using CoreAdmin.Aop.Attribute;

namespace CoreAdmin.DataContract.Dto.Sys.Security;

/// <summary>
///     请求：人机校验
/// </summary>
public record VerifyCaptchaReq : ICacheKey
{
    /// <inheritdoc cref="ICacheKey.CacheKey" />
    [RequiredField]
    public string CacheKey { get; set; }

    /// <summary>
    ///     验证数据
    /// </summary>
    [RequiredField]
    public string VerifyData { get; set; }
}