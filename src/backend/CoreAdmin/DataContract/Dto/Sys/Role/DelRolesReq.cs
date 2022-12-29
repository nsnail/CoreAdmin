using CoreAdmin.Aop.Attribute;
using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.Role;

/// <inheritdoc />
public record DelRolesReq : TbSysRole
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [RequiredField]
    public override long Id { get; set; }
}