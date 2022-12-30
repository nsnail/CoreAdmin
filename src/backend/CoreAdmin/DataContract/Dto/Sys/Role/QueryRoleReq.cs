using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.Role;

/// <summary>
///     请求：查询角色
/// </summary>
public record QueryRoleReq : TbSysRole
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string RoleName { get; set; }
}