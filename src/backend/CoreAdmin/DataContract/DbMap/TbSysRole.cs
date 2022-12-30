using CoreAdmin.DataContract.DbMap.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap;

/// <summary>
///     角色表
/// </summary>
[Table]
public record TbSysRole : DefaultEntity, IFieldBitSet, IFieldSort
{
    /// <inheritdoc />
    public virtual long BitSet { get; set; }

    /// <summary>
    ///     角色描述
    /// </summary>
    [JsonIgnore]
    public virtual string Remark { get; set; }

    /// <summary>
    ///     角色名称
    /// </summary>
    public virtual string RoleName { get; set; }

    /// <inheritdoc />
    public virtual int Sort { get; set; }
}