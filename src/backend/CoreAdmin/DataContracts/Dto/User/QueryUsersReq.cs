using CoreAdmin.DataContracts.DbMaps;

namespace CoreAdmin.DataContracts.Dto.User;

public record QueryUsersReq : TbSysUser
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string UserName { get; set; }
}