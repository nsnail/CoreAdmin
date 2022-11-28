using CoreAdmin.DataContract.DbMap.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap;

/// <summary>
///     部门表
/// </summary>
[Table]
public record TbSysDepartment : FullTable, IFieldBitSet
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public virtual long BitSet { get; set; }

    /// <summary>
    ///     子节点
    /// </summary>
    [Navigate(nameof(ParentId))]
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public virtual List<TbSysDepartment> Children { get; set; }


    /// <summary>
    ///     部门名称
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public virtual string Label { get; set; }


    /// <summary>
    ///     父id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public virtual long ParentId { get; set; }

    /// <summary>
    ///     部门描述
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public string Remark { get; set; }


    /// <summary>
    ///     排序
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public virtual int Sort { get; set; }
}