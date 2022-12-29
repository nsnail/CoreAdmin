using CoreAdmin.Aop.Attribute;
using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.Department;

/// <inheritdoc />
public record AddDepartmentsReq : TbSysDepartment
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long BitSet { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [RequiredField]
    public override string Label { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long ParentId { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string Remark { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override int Sort { get; set; }
}