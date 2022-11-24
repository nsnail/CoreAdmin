using CoreAdmin.Aop.Attributes;
using CoreAdmin.Infrastructure.Constant;

namespace CoreAdmin.DataContracts.Dto.Account;

/// <summary>
///     检查手机号请求
/// </summary>
public record CheckMobileReq : DataContract
{
    /// <summary>
    ///     手机号
    /// </summary>
    [RequiredField]
    [RegularExpression(Strings.REGEX_MOBILE, ErrorMessage = Strings.MSG_MOBILE_USEFUL)]
    public long? Mobile { get; set; }
}