using CoreAdmin.DataContract.Dto.Pub;
using CoreAdmin.DataContract.Dto.Sys.Department;

namespace CoreAdmin.Api.Sys;

/// <summary>
///     部门接口
/// </summary>
public interface IDepartmentApi
{
    /// <summary>
    ///     增加部门
    /// </summary>
    Task Add(AddDepartmentReq req);

    /// <summary>
    ///     批量删除
    /// </summary>
    Task<int> BulkDel(BulkDelReq req);

    /// <summary>
    ///     删除部门
    /// </summary>
    Task<int> Del(DelReq req);

    /// <summary>
    ///     部门列表
    /// </summary>
    Task<List<QueryDepartmentRsp>> List();

    /// <summary>
    ///     更新部门
    /// </summary>
    Task Update(UpdateDepartmentReq req);
}