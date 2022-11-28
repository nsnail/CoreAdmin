using CoreAdmin.DataContract.Dto;
using CoreAdmin.DataContract.Dto.Sys.Department;

namespace CoreAdmin.Api.Sys;

/// <summary>
///     部门接口
/// </summary>
public interface IDepartmentApi
{
    /// <summary>
    ///     部门列表
    /// </summary>
    /// <returns></returns>
    Task<List<QueryDepartmentsRsp>> List();
}