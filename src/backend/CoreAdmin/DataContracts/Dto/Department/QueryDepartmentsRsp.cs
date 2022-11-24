using CoreAdmin.DataContracts.DbMaps;

namespace CoreAdmin.DataContracts.Dto.Department;

public record QueryDepartmentsRsp : TbSysDepartment
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public new List<QueryDepartmentsRsp> Children { get; set; }

    /// <inheritdoc />

    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string Label { get; set; }
}