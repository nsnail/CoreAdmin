namespace CoreAdmin.DataContract.Dto.Sys.Role;

/// <inheritdoc />
public record UpdateRolesReq : AddRolesReq
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Id { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Version { get; set; }
}