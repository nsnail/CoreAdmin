namespace CoreAdmin.DataContract.Dto.Sys.Department;

/// <inheritdoc />
public record UpdateDepartmentsReq : AddDepartmentsReq
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Id { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Version { get; set; }
}