using CoreAdmin.Aop.Attribute;
using CoreAdmin.DataContract.Dto.Sys.Account;
using CoreAdmin.Infrastructure.Constant;

namespace CoreAdmin.DataContract.Dto.Sys.Security;

/// <summary>
///     请求：发送短信验证码
/// </summary>
public record SendSmsCodeReq : CheckMobileReq
{
    /// <summary>
    ///     类型
    /// </summary>
    [RequiredField]
    public Enums.SmsCodeTypes Type { get; set; }

    /// <summary>
    ///     人机校验请求
    /// </summary>
    [RequiredField]
    public VerifyCaptchaReq VerifyCaptchaReq { get; set; }
}