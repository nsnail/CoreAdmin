namespace CoreAdmin.DataContract.Dto.Sys.Role;

/// <summary>
///     请求：更新角色
/// </summary>
public record UpdateRoleReq : AddRoleReq
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Id { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Version { get; set; }
}