using CoreAdmin.DataContract.DbMap.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap;

/// <summary>
///     部门表
/// </summary>
[Table]
public record TbSysDepartment : DefaultEntity, IFieldBitSet, IFieldSort
{
    /// <inheritdoc />
    [JsonIgnore]
    public virtual long BitSet { get; set; }

    /// <summary>
    ///     子节点
    /// </summary>
    [Navigate(nameof(ParentId))]
    [JsonIgnore]
    public virtual List<TbSysDepartment> Children { get; set; }

    /// <summary>
    ///     部门名称
    /// </summary>
    [JsonIgnore]
    public virtual string Label { get; set; }

    /// <summary>
    ///     父id
    /// </summary>
    [JsonIgnore]
    public virtual long ParentId { get; set; }

    /// <summary>
    ///     部门描述
    /// </summary>
    [JsonIgnore]
    public virtual string Remark { get; set; }

    /// <inheritdoc />
    [JsonIgnore]
    public virtual int Sort { get; set; }
}