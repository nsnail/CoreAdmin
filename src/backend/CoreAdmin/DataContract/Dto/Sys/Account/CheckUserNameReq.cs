using CoreAdmin.Aop.Attribute;
using CoreAdmin.Infrastructure.Constant;

namespace CoreAdmin.DataContract.Dto.Sys.Account;

/// <summary>
///     创建用户请求
/// </summary>
public record CheckUserNameReq : DataContract
{
    /// <summary>
    ///     Gets or sets 用户名
    /// </summary>
    /// <value>
    ///     用户名
    /// </value>
    [RequiredField]
    [RegularExpression(Strings.REGEX_USERNAME, ErrorMessage = Strings.MSG_USERNAME_STRONG)]
    public string UserName { get; set; }
}