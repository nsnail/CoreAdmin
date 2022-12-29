using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.Role;

/// <inheritdoc />
public record QueryRolesReq : TbSysRole
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string RoleName { get; set; }
}