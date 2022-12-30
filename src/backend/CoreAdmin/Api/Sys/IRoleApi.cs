using CoreAdmin.DataContract.Dto.Pub;
using CoreAdmin.DataContract.Dto.Sys.Role;

namespace CoreAdmin.Api.Sys;

/// <summary>
///     角色接口
/// </summary>
public interface IRoleApi
{
    /// <summary>
    ///     增加角色
    /// </summary>
    Task Add(AddRoleReq req);

    /// <summary>
    ///     批量删除
    /// </summary>
    Task<int> BulkDel(BulkDelReq req);

    /// <summary>
    ///     删除角色
    /// </summary>
    Task<int> Del(DelReq req);

    /// <summary>
    ///     角色列表
    /// </summary>
    Task<List<QueryRoleRsp>> List();

    /// <summary>
    ///     更新角色
    /// </summary>
    Task Update(UpdateRoleReq req);
}