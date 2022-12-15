using CoreAdmin.DataContract.DbMap;
using CoreAdmin.DataContract.Dto.Sys.Department;
using Mapster;
using Microsoft.AspNetCore.Authorization;

namespace CoreAdmin.Api.Sys.Implement;

/// <inheritdoc cref="IDepartmentApi" />
public class DepartmentApi : ApiBase<IDepartmentApi, TbSysDepartment>, IDepartmentApi
{
    /// <inheritdoc />
    [AllowAnonymous]
    public async Task<List<QueryDepartmentsRsp>> List()
    {
        var ret = (await Repository.Select.ToTreeListAsync()).ConvertAll(x => x.Adapt<QueryDepartmentsRsp>());
        return ret;
    }
}