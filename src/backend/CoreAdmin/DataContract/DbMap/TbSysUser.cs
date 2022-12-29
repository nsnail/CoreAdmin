using CoreAdmin.DataContract.DbMap.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap;

/// <summary>
///     Gets or sets 用户表
/// </summary>
[Table]
public record TbSysUser : FullTable, IFieldBitSet
{
    /// <inheritdoc />
    [JsonIgnore]
    public virtual long BitSet { get; set; }

    /// <summary>
    ///     Gets or sets 手机号
    /// </summary>
    /// <value>
    ///     手机号
    /// </value>
    [JsonIgnore]
    public virtual long? Mobile { get; set; }

    /// <summary>
    ///     Gets or sets 密码
    /// </summary>
    /// <value>
    ///     密码
    /// </value>
    [JsonIgnore]
    public virtual Guid Password { get; set; }

    /// <summary>
    ///     Gets or sets 做授权验证的Token，全局唯一，可以随时重置（强制下线）
    /// </summary>
    /// <value>
    ///     做授权验证的Token，全局唯一，可以随时重置（强制下线）
    /// </value>
    [JsonIgnore]
    public virtual Guid Token { get; set; }

    /// <summary>
    ///     Gets or sets 用户名
    /// </summary>
    /// <value>
    ///     用户名
    /// </value>
    [JsonIgnore]
    public virtual string UserName { get; set; }
}