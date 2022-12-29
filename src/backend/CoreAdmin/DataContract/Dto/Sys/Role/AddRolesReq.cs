using CoreAdmin.Aop.Attribute;
using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.Role;

/// <inheritdoc />
public record AddRolesReq : TbSysRole
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long BitSet { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string Remark { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [RequiredField]
    public override string RoleName { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override int Sort { get; set; }
}