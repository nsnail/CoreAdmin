namespace CoreAdmin.DataContract.Dto.Sys.Department;

/// <summary>
///     请求：更新部门
/// </summary>
public record UpdateDepartmentReq : AddDepartmentReq
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Id { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Version { get; set; }
}