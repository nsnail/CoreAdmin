using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.Department;

public record QueryDepartmentsRsp : TbSysDepartment
{
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public new List<QueryDepartmentsRsp> Children { get; set; }

    /// <inheritdoc />

    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string Label { get; set; }
}