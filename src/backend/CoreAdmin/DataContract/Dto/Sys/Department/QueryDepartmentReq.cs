using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.Department;

/// <summary>
///     请求：查询部门
/// </summary>
public record QueryDepartmentReq : TbSysDepartment
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string Label { get; set; }
}