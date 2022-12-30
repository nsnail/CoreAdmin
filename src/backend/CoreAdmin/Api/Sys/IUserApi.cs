using CoreAdmin.DataContract.Dto;
using CoreAdmin.DataContract.Dto.Sys.User;

namespace CoreAdmin.Api.Sys;

/// <summary>
///     用户接口
/// </summary>
public interface IUserApi
{
    /// <summary>
    ///     获取个人信息
    /// </summary>
    Task<GetProfileRsp> GetProfile();

    /// <summary>
    ///     分页获取用户列表
    /// </summary>
    Task<PagedListRsp<QueryUserRsp>> QueryUsers(PagedListReq<QueryUsersReq> req);
}