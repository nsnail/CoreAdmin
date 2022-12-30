using CoreAdmin.DataContract;
using CoreAdmin.DataContract.DbMap;
using CoreAdmin.DataContract.Dto.Sys.Account;
using CoreAdmin.Infrastructure.Constant;
using Furion.DataEncryption;
using Furion.FriendlyException;
using Microsoft.AspNetCore.Authorization;
using NSExt.Extensions;

namespace CoreAdmin.Api.Sys.Implement;

/// <inheritdoc cref="IAccountApi" />
public class AccountApi : ApiBase<IAccountApi, TbSysUser>, IAccountApi
{
    private readonly ISecurityApi _securityApi;

    /// <summary>
    ///     Initializes a new instance of the <see cref="AccountApi" /> class.
    /// </summary>
    public AccountApi(ISecurityApi securityApi)
    {
        _securityApi = securityApi;
    }

    /// <inheritdoc />
    [AllowAnonymous]
    public async Task<bool> CheckMobile(CheckMobileReq req)
    {
        return !await Repository.Select.AnyAsync(a => a.Mobile == req.Mobile);
    }

    /// <inheritdoc />
    [AllowAnonymous]
    public async Task<bool> CheckUserName(CheckUserNameReq req)
    {
        return !await Repository.Select.AnyAsync(a => a.UserName == req.UserName);
    }

    /// <inheritdoc />
    [AllowAnonymous]
    public async Task Create(CreateAccountReq accountReq)
    {
        //短信验证码
        var checkResult = await _securityApi.VerifySmsCode(accountReq.VerifySmsCodeReq);
        if (!checkResult) {
            throw Oops.Oh(Enums.ErrorCodes.InvalidInput, Strings.MSG_SMSCODE_WRONG);
        }

        var tbUser = new TbSysUser {
                                       Mobile   = accountReq.VerifySmsCodeReq.Mobile
                                     , Token    = Guid.NewGuid()
                                     , UserName = accountReq.UserName
                                     , Password = accountReq.Password.Pwd().Guid()
                                   };
        await Repository.InsertAsync(tbUser);
    }

    /// <inheritdoc />
    [AllowAnonymous]
    public async Task Login(LoginReq req)
    {
        var tbUser = await Repository.GetAsync(x => x.UserName == req.UserName &&
                                                    x.Password == req.Password.Pwd().Guid());
        if (tbUser is null) {
            throw Oops.Oh(Enums.ErrorCodes.InvalidInput, Strings.MSG_UNAME_PASSWORD_WRONG);
        }

        if (tbUser.BitSet.HasFlag(Enums.UserBitSets.Disabled)) {
            throw Oops.Oh(Enums.ErrorCodes.InvalidInput, Strings.MSG_USER_DISABLED);
        }

        var accessToken = JWTEncryption.Encrypt(new Dictionary<string, object> {
                                                                                   {
                                                                                       nameof(ContextUser)
                                                                                     , new ContextUser {
                                                                                           Id = tbUser.Id
                                                                                         , UserName = tbUser
                                                                                               .UserName
                                                                                       }
                                                                                   }
                                                                               });

        var refreshToken = JWTEncryption.GenerateRefreshToken(accessToken);

        // 设置响应报文头
        App.HttpContext.Response.Headers[Strings.FLAG_ACCESS_TOKEN]   = accessToken;
        App.HttpContext.Response.Headers[Strings.FLAG_X_ACCESS_TOKEN] = refreshToken;
    }
}