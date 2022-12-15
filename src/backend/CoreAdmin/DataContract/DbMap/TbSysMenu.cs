using CoreAdmin.DataContract.DbMap.Dependency;
using CoreAdmin.Infrastructure.Constant;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap;

/// <summary>
///     菜单表
/// </summary>
[Table]
public record TbSysMenu : FullTable, IFieldBitSet
{
    /// <inheritdoc />
    public virtual long BitSet { get; set; }

    /// <summary>
    ///     Gets or sets 子节点
    /// </summary>
    /// <value>
    ///     子节点
    /// </value>
    [Navigate(nameof(ParentId))]
    public virtual List<TbSysMenu> Children { get; set; }

    /// <summary>
    ///     Gets or sets 菜单编码
    /// </summary>
    /// <value>
    ///     菜单编码
    /// </value>
    public virtual string Code { get; set; }

    /// <summary>
    ///     Gets or sets 组件
    /// </summary>
    /// <value>
    ///     组件
    /// </value>
    public virtual string Component { get; set; }

    /// <summary>
    ///     Gets or sets 图标
    /// </summary>
    /// <value>
    ///     图标
    /// </value>
    public virtual string Icon { get; set; }

    /// <summary>
    ///     Gets or sets 父id
    /// </summary>
    /// <value>
    ///     父id
    /// </value>
    public virtual long ParentId { get; set; }

    /// <summary>
    ///     Gets or sets 菜单路径
    /// </summary>
    /// <value>
    ///     菜单路径
    /// </value>
    public virtual string Path { get; set; }

    /// <summary>
    ///     Gets or sets 排序
    /// </summary>
    /// <value>
    ///     排序
    /// </value>
    public virtual int Sort { get; set; }

    /// <summary>
    ///     Gets or sets 菜单标题
    /// </summary>
    /// <value>
    ///     菜单标题
    /// </value>
    public virtual string Title { get; set; }

    /// <summary>
    ///     Gets or sets 菜单类型
    /// </summary>
    /// <value>
    ///     菜单类型
    /// </value>
    [Column(CanUpdate = false)]
    public virtual Enums.MenuTypes Type { get; set; }
}