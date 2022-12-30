using CoreAdmin.Aop.Attribute;
using CoreAdmin.Infrastructure.Constant;

namespace CoreAdmin.DataContract.Dto.Sys.Account;

/// <summary>
///     请求：检查手机号是否可用
/// </summary>
public record CheckMobileReq : DataAbstraction
{
    /// <summary>
    ///     手机号
    /// </summary>
    [RequiredField]
    [RegularExpression(Strings.REGEX_MOBILE, ErrorMessage = Strings.MSG_MOBILE_USEFUL)]
    public long? Mobile { get; init; }
}