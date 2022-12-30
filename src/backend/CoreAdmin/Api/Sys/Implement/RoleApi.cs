using CoreAdmin.DataContract.DbMap;
using CoreAdmin.DataContract.Dto.Pub;
using CoreAdmin.DataContract.Dto.Sys.Role;
using Mapster;
using Microsoft.AspNetCore.Authorization;

namespace CoreAdmin.Api.Sys.Implement;

/// <inheritdoc cref="IRoleApi" />
public class RoleApi : ApiBase<IRoleApi, TbSysRole>, IRoleApi
{
    /// <inheritdoc />
    public async Task Add(AddRoleReq req)
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
    public async Task<List<QueryRoleRsp>> List()
    {
        var query = await Repository.Select.OrderByDescending(a => a.Sort).ToListAsync();
        var ret   = query.ConvertAll(x => x.Adapt<QueryRoleRsp>());
        return ret;
    }

    /// <inheritdoc />
    public async Task Update(UpdateRoleReq req)
    {
        await Repository.UpdateDiy.SetSource(req).ExecuteAffrowsAsync();
    }

    private async Task<int> DelInternal(ICollection<long> ids)
    {
        var ret = await Repository.DeleteAsync(a => ids.Contains(a.Id));
        return ret;
    }
}