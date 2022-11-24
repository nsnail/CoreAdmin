using CoreAdmin.DataContracts.DbMaps;

namespace CoreAdmin.DataContracts.Dto.User;

/// <summary>
///     用户响应
/// </summary>
public record UserRsp : TbSysUser
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long? Mobile { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string UserName { get; set; }
}