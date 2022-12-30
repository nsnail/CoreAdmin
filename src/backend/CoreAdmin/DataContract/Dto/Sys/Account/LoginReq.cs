using CoreAdmin.Aop.Attribute;
using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.Account;

/// <summary>
///     请求：帐号登录
/// </summary>
public record LoginReq : TbSysUser
{
    /// <inheritdoc cref="TbSysUser.Password" />
    [RequiredField]
    public new string Password { get; init; }

    /// <inheritdoc cref="TbSysUser.UserName" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [RequiredField]
    public override string UserName { get; set; }
}