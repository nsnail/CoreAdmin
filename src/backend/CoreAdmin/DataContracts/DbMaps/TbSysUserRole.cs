using CoreAdmin.DataContracts.DbMaps.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContracts.DbMaps;

/// <summary>
///     用户与角色映射表
/// </summary>
[Table]
public record TbSysUserRole : NoModifyTable
{
    /// <summary>
    ///     角色id
    /// </summary>
    public virtual long RoleId { get; set; }

    /// <summary>
    ///     用户id
    /// </summary>
    public virtual long UserId { get; set; }
}