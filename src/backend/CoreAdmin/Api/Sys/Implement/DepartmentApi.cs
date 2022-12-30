using CoreAdmin.DataContract.DbMap;
using CoreAdmin.DataContract.Dto.Pub;
using CoreAdmin.DataContract.Dto.Sys.Department;
using Mapster;
using Microsoft.AspNetCore.Authorization;

namespace CoreAdmin.Api.Sys.Implement;

/// <inheritdoc cref="IDepartmentApi" />
public class DepartmentApi : ApiBase<IDepartmentApi, TbSysDepartment>, IDepartmentApi
{
    /// <inheritdoc />
    public async Task Add(AddDepartmentReq req)
    {
        await Repository.InsertAsync(req);
    }

    /// <inheritdoc />
    public async Task<int> BulkDel(BulkDelReq req)
    {
        var ret = await DelInternal(req.Ids);
        return ret;
    }

    /// <inheritdoc />
    public async Task<int> Del(DelReq req)
    {
        var ret = await DelInternal(new List<long> { req.Id });
        return ret;
    }

    /// <inheritdoc />
    [AllowAnonymous]
    public async Task<List<QueryDepartmentRsp>> List()
    {
        var query = await Repository.Select.OrderByDescending(a => a.Sort).ToTreeListAsync();
        var ret   = query.ConvertAll(x => x.Adapt<QueryDepartmentRsp>());
        return ret;
    }

    /// <inheritdoc />
    public async Task Update(UpdateDepartmentReq req)
    {
        await Repository.UpdateDiy.SetSource(req).ExecuteAffrowsAsync();
    }

    private async Task<int> DelInternal(ICollection<long> ids)
    {
        var ret = await Repository.Where(a => ids.Contains(a.Id)).AsTreeCte().ToDelete().ExecuteAffrowsAsync();
        return ret;
    }
}