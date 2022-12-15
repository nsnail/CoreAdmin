using CoreAdmin.Aop.Attribute;
using CoreAdmin.DataContract.DbMap;
using CoreAdmin.DataContract.Dto.Sys.Security;
using CoreAdmin.Infrastructure.Configuration.Options;
using CoreAdmin.Infrastructure.Constant;
using NSExt.Extensions;

namespace CoreAdmin.DataContract.Dto.Sys.Account;

/// <summary>
///     创建用户请求
/// </summary>
public record CreateReq : TbSysUser
{
    private readonly SecretOptions _secretOptions;

    /// <inheritdoc />
    public CreateReq()
    {
        _secretOptions = App.GetOptions<SecretOptions>();
    }

    /// <summary>
    ///     Gets 密码原文
    /// </summary>
    /// <value>
    ///     密码原文
    /// </value>
    [RegularExpression(Strings.REGEX_PASSWORD, ErrorMessage = Strings.MSG_PASSWORD_STRONG)]
    [JsonIgnore]
    public virtual string PasswordOrigin => Password?.AesDe(_secretOptions.SecretKeyA);

    /// <inheritdoc cref="TbSysUser.Password" />
    [RequiredField]
    public new string Password { get; set; }

    /// <inheritdoc cref="TbSysUser.UserName" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [RequiredField]
    public override string UserName { get; set; }

    /// <summary>
    ///     Gets or sets 短信验证码信息
    /// </summary>
    /// <value>
    ///     短信验证码信息
    /// </value>
    [RequiredField]
    public VerifySmsCodeReq VerifySmsCodeReq { get; set; }
}