using CoreAdmin.Aop.Attribute;
using CoreAdmin.Infrastructure.Constant;

namespace CoreAdmin.DataContract.Dto.Sys.Account;

/// <summary>
///     请求：检查用户名是否可用
/// </summary>
public record CheckUserNameReq : DataAbstraction
{
    /// <summary>
    ///     用户名
    /// </summary>
    [RequiredField]
    [RegularExpression(Strings.REGEX_USERNAME, ErrorMessage = Strings.MSG_USERNAME_STRONG)]
    public string UserName { get; set; }
}