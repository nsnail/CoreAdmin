using CoreAdmin.Aop.Attribute;
using CoreAdmin.DataContract.DbMap;
using CoreAdmin.DataContract.Dto.Sys.Security;
using CoreAdmin.Infrastructure.Configuration.Options;
using CoreAdmin.Infrastructure.Constant;
using NSExt.Extensions;

namespace CoreAdmin.DataContract.Dto.Sys.Account;

/// <summary>
///     请求：创建帐号
/// </summary>
public record CreateAccountReq : TbSysUser
{
    private readonly SecretOptions _secretOptions;

    /// <summary>
    ///     Initializes a new instance of the <see cref="CreateAccountReq" /> class.
    /// </summary>
    public CreateAccountReq()
    {
        _secretOptions = App.GetOptions<SecretOptions>();
    }

    /// <summary>
    ///     密码原文
    /// </summary>
    [RegularExpression(Strings.REGEX_PASSWORD, ErrorMessage = Strings.MSG_PASSWORD_STRONG)]
    [JsonIgnore]
    public virtual string PasswordOrigin => Password?.AesDe(_secretOptions.SecretKeyA);

    /// <inheritdoc cref="TbSysUser.Password" />
    [RequiredField]
    public new string Password { get; init; }

    /// <inheritdoc cref="TbSysUser.UserName" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [RequiredField]
    public override string UserName { get; set; }

    /// <summary>
    ///     短信验证码信息
    /// </summary>
    [RequiredField]
    public VerifySmsCodeReq VerifySmsCodeReq { get; init; }
}