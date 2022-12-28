using CoreAdmin.DataContract.DbMap;
using CoreAdmin.DataContract.Dto;
using CoreAdmin.DataContract.Dto.Sys.User;
using CoreAdmin.Repository;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreAdmin.Api.Sys.Implement;

/// <inheritdoc cref="IUserApi" />
public class UserApi : ApiBase<IUserApi, TbSysUser>, IUserApi
{
    private readonly Repository<TbSysMenu> _repMenu;

    /// <summary>
    ///     Initializes a new instance of the <see cref="UserApi" /> class.
    /// </summary>
    public UserApi(Repository<TbSysMenu> repMenu)
    {
        _repMenu = repMenu;
    }

    /// <inheritdoc />
    [AllowAnonymous]
    public async Task<GetProfileRsp> GetProfile()
    {
        var ret = new GetProfileRsp {
                                        Menu = (await _repMenu.Select.ToTreeListAsync()).ConvertAll(
                                            x => x.Adapt<GetProfileRsp.MenuInfo>())
                                      , Permissions = new List<string> {
                                                                           "list.add"
                                                                         , "list.edit"
                                                                         , "list.delete"
                                                                         , "user.add"
                                                                         , "user.edit"
                                                                         , "user.delete"
                                                                       }
                                    };

        return ret;
    }

    /// <inheritdoc />
    [AllowAnonymous]
    [HttpPost]
    public async Task<PagedListRsp<UserRsp>> QueryUsers(PagedListReq<QueryUsersReq> req)
    {
        var ret = await Repository.GetPagedListAsync(req.DynamicFilter, req.Page, req.PageSize);
        return new PagedListRsp<UserRsp> {
                                             Page     = req.Page
                                           , PageSize = req.PageSize
                                           , Rows     = ret.List.ConvertAll(x => new UserRsp { UserName = x.UserName })
                                           , Total    = ret.Total
                                         };
    }
}