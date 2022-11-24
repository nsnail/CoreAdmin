using CoreAdmin.Aop.Attributes;
using CoreAdmin.DataContracts.DbMaps;

namespace CoreAdmin.DataContracts.Dto.Account;

/// <summary>
///     登录请求
/// </summary>
public record LoginReq : TbSysUser
{
    /// <inheritdoc cref="TbSysUser.Password" />
    [RequiredField]
    public new string Password { get; set; }

    /// <inheritdoc cref="TbSysUser.UserName" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [RequiredField]
    public override string UserName { get; set; }
}