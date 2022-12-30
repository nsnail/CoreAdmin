using CoreAdmin.DataContract.Dto.Sys.Account;

namespace CoreAdmin.DataContract.Dto.Sys.Security;

/// <summary>
///     响应：发送短信验证码
/// </summary>
public record SmsCodeInfo : CheckMobileReq
{
    /// <summary>
    ///     验证码
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    ///     创建时间
    /// </summary>
    public DateTime CreateTime { get; set; }
}