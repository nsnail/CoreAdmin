using CoreAdmin.Aop.Attribute;
using CoreAdmin.DataContract.Dto.Sys.Account;
using CoreAdmin.Infrastructure.Constant;

namespace CoreAdmin.DataContract.Dto.Sys.Security;

/// <summary>
///     Gets or sets 发送短信验证码请求
/// </summary>
public record SendSmsCodeReq : CheckMobileReq
{
    /// <summary>
    ///     Gets or sets 类型
    /// </summary>
    /// <value>
    ///     类型
    /// </value>
    [RequiredField]
    public Enums.SmsCodeTypes Type { get; set; }

    /// <summary>
    ///     Gets or sets 人机校验请求
    /// </summary>
    /// <value>
    ///     人机校验请求
    /// </value>
    [RequiredField]
    public VerifyCaptchaReq VerifyCaptchaReq { get; set; }
}