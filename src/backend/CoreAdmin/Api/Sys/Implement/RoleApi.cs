using CoreAdmin.DataContract.DbMap;
using CoreAdmin.DataContract.Dto.Sys.Role;
using Mapster;
using Microsoft.AspNetCore.Authorization;

namespace CoreAdmin.Api.Sys.Implement;

/// <inheritdoc cref="IRoleApi" />
public class RoleApi : ApiBase<IRoleApi, TbSysRole>, IRoleApi
{
    /// <inheritdoc />
    public async Task Add(AddRolesReq req)
    {
        await Repository.InsertAsync(req);
    }

    /// <inheritdoc />
    public async Task<int> BulkDel(BulkDelRolesReq req)
    {
        var ret = await DelInternal(req.Ids);
        return ret;
    }

    /// <inheritdoc />
    public async Task<int> Del(DelRolesReq req)
    {
        var ret = await DelInternal(new List<long> { req.Id });
        return ret;
    }

    /// <inheritdoc />
    [AllowAnonymous]
    public async Task<List<QueryRolesRsp>> List()
    {
        var query = await Repository.Select.OrderByDescending(a => a.Sort).ToListAsync();
        var ret   = query.ConvertAll(x => x.Adapt<QueryRolesRsp>());
        return ret;
    }

    /// <inheritdoc />
    public async Task Update(UpdateRolesReq req)
    {
        await Repository.UpdateDiy.SetSource(req).ExecuteAffrowsAsync();
    }

    private async Task<int> DelInternal(ICollection<long> ids)
    {
        var ret = await Repository.DeleteAsync(a => ids.Contains(a.Id));
        return ret;
    }
}