using CoreAdmin.DataContract.DbMap.Dependency;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap;

/// <summary>
///     角色表
/// </summary>
[Table]
public record TbSysRole : FullTable
{
    /// <summary>
    ///     Gets or sets 角色名称
    /// </summary>
    /// <value>
    ///     角色名称
    /// </value>
    public virtual string RoleName { get; set; }
}