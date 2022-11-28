using CoreAdmin.Aop.Attribute;
using CoreAdmin.DataContract.Dto.Sys.Account;
using CoreAdmin.Infrastructure.Constant;

namespace CoreAdmin.DataContract.Dto.Sys.Security;

/// <summary>
///     核实短信验证码请求
/// </summary>
public record VerifySmsCodeReq : CheckMobileReq
{
    /// <summary>
    ///     验证码
    /// </summary>
    [RequiredField]
    [RegularExpression(Strings.REGEX_SMSCODE, ErrorMessage = Strings.MSG_SMSCODE_NUMBER)]
    public string Code { get; set; }
}