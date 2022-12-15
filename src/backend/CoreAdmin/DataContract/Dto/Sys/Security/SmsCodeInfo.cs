using CoreAdmin.DataContract.Dto.Sys.Account;

namespace CoreAdmin.DataContract.Dto.Sys.Security;

/// <summary>
///     发送短信验证码响应
/// </summary>
public record SmsCodeInfo : CheckMobileReq
{
    /// <summary>
    ///     Gets or sets 验证码
    /// </summary>
    /// <value>
    ///     验证码
    /// </value>
    public string Code { get; set; }

    /// <summary>
    ///     Gets or sets 创建时间
    /// </summary>
    /// <value>
    ///     创建时间
    /// </value>
    public DateTime CreateTime { get; set; }
}