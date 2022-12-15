using CoreAdmin.Aop.Attribute;
using CoreAdmin.Infrastructure.Constant;

namespace CoreAdmin.DataContract.Dto.Sys.Account;

/// <summary>
///     检查手机号请求
/// </summary>
public record CheckMobileReq : DataContract
{
    /// <summary>
    ///     Gets or sets 手机号
    /// </summary>
    /// <value>
    ///     手机号
    /// </value>
    [RequiredField]
    [RegularExpression(Strings.REGEX_MOBILE, ErrorMessage = Strings.MSG_MOBILE_USEFUL)]
    public long? Mobile { get; set; }
}