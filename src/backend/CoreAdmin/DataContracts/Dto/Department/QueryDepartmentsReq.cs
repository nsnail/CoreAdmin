using CoreAdmin.DataContracts.DbMaps;

namespace CoreAdmin.DataContracts.Dto.Department;

public record QueryDepartmentsReq : TbSysDepartment
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string Label { get; set; }
}