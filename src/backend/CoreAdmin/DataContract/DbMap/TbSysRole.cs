using CoreAdmin.DataContract.DbMap.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap;

/// <summary>
///     角色表
/// </summary>
[Table]
public record TbSysRole : FullTable, IFieldBitSet, IFieldSort
{
    /// <inheritdoc />
    public virtual long BitSet { get; set; }

    /// <summary>
    ///     Gets or sets 角色描述
    /// </summary>
    /// <value>
    ///     角色描述
    /// </value>
    [JsonIgnore]
    public virtual string Remark { get; set; }

    /// <summary>
    ///     Gets or sets 角色名称
    /// </summary>
    /// <value>
    ///     角色名称
    /// </value>
    public virtual string RoleName { get; set; }

    /// <inheritdoc />
    public virtual int Sort { get; set; }
}