using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.User;

/// <summary>
///     响应：查询用户
/// </summary>
public record QueryUserRsp : TbSysUser
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long? Mobile { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string UserName { get; set; }
}