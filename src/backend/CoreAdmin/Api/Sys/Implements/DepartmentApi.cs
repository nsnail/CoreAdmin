using CoreAdmin.DataContracts.DbMaps;
using CoreAdmin.DataContracts.Dto;
using CoreAdmin.DataContracts.Dto.Department;
using Mapster;
using Microsoft.AspNetCore.Authorization;

namespace CoreAdmin.Api.Sys.Implements;

/// <inheritdoc cref="IDepartmentApi" />
public class DepartmentApi : ApiBase<IDepartmentApi, TbSysDepartment>, IDepartmentApi
{
    /// <inheritdoc />
    [AllowAnonymous]
    public async Task<List<QueryDepartmentsRsp>> List(PagedListReq<QueryDepartmentsReq> req)
    {
        var ret = (await Repository.Select.ToTreeListAsync()).ConvertAll(x => x.Adapt<QueryDepartmentsRsp>());
        return ret;
    }
}