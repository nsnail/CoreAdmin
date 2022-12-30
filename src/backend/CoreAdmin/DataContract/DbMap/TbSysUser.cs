using CoreAdmin.DataContract.DbMap.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap;

/// <summary>
///     用户表
/// </summary>
[Table]
public record TbSysUser : DefaultEntity, IFieldBitSet
{
    /// <inheritdoc />
    [JsonIgnore]
    public virtual long BitSet { get; set; }

    /// <summary>
    ///     手机号
    /// </summary>
    [JsonIgnore]
    public virtual long? Mobile { get; set; }

    /// <summary>
    ///     密码
    /// </summary>
    [JsonIgnore]
    public virtual Guid Password { get; set; }

    /// <summary>
    ///     做授权验证的Token，全局唯一，可以随时重置（强制下线）
    /// </summary>
    [JsonIgnore]
    public virtual Guid Token { get; set; }

    /// <summary>
    ///     用户名
    /// </summary>
    [JsonIgnore]
    public virtual string UserName { get; set; }
}