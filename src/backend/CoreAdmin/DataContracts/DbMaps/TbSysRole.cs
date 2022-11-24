using CoreAdmin.DataContracts.DbMaps.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContracts.DbMaps;

/// <summary>
///     角色表
/// </summary>
[Table]
public record TbSysRole : FullTable
{
    /// <summary>
    ///     角色名称
    /// </summary>

    public virtual string RoleName { get; set; }
}