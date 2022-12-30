using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.User;

/// <summary>
///     请求：查询用户
/// </summary>
public record QueryUsersReq : TbSysUser
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string UserName { get; set; }
}