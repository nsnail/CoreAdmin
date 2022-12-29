using CoreAdmin.DataContract.DbMap.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap;

/// <summary>
///     部门表
/// </summary>
[Table]
public record TbSysDepartment : FullTable, IFieldBitSet, IFieldSort
{
    /// <inheritdoc />
    [JsonIgnore]
    public virtual long BitSet { get; set; }

    /// <summary>
    ///     Gets or sets 子节点
    /// </summary>
    /// <value>
    ///     子节点
    /// </value>
    [Navigate(nameof(ParentId))]
    [JsonIgnore]
    public virtual List<TbSysDepartment> Children { get; set; }

    /// <summary>
    ///     Gets or sets 部门名称
    /// </summary>
    /// <value>
    ///     部门名称
    /// </value>
    [JsonIgnore]
    public virtual string Label { get; set; }

    /// <summary>
    ///     Gets or sets 父id
    /// </summary>
    /// <value>
    ///     父id
    /// </value>
    [JsonIgnore]
    public virtual long ParentId { get; set; }

    /// <summary>
    ///     Gets or sets 部门描述
    /// </summary>
    /// <value>
    ///     部门描述
    /// </value>
    [JsonIgnore]
    public virtual string Remark { get; set; }

    /// <inheritdoc />
    [JsonIgnore]
    public virtual int Sort { get; set; }
}