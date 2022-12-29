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
    Task Add(AddRolesReq req);

    /// <summary>
    ///     批量删除
    /// </summary>
    Task<int> BulkDel(BulkDelRolesReq req);

    /// <summary>
    ///     删除角色
    /// </summary>
    Task<int> Del(DelRolesReq req);

    /// <summary>
    ///     角色列表
    /// </summary>
    Task<List<QueryRolesRsp>> List();

    /// <summary>
    ///     更新角色
    /// </summary>
    Task Update(UpdateRolesReq req);
}