using CoreAdmin.DataContract.DbMap.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap;

/// <summary>
///     Gets or sets 用户与角色映射表
/// </summary>
[Table]
public record TbSysUserRole : NoModifyTable
{
    /// <summary>
    ///     Gets or sets 角色id
    /// </summary>
    /// <value>
    ///     角色id
    /// </value>
    public virtual long RoleId { get; set; }

    /// <summary>
    ///     Gets or sets 用户id
    /// </summary>
    /// <value>
    ///     用户id
    /// </value>
    public virtual long UserId { get; set; }
}