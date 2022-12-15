using CoreAdmin.DataContract.Dto.Sys.Security;
using CoreAdmin.Infrastructure.Util;

namespace CoreAdmin.Api.Sys;

/// <summary>
///     安全接口
/// </summary>
public interface ISecurityApi
{
    /// <summary>
    ///     获取人机校验图
    /// </summary>
    Task<GetCaptchaRsp> GetCaptchaImage();

    /// <summary>
    ///     发送短信验证码
    /// </summary>
    Task SendSmsCode(ISmsSender smsSender, SendSmsCodeReq req);

    /// <summary>
    ///     完成人机校验
    /// </summary>
    Task<bool> VerifyCaptcha(VerifyCaptchaReq req);

    /// <summary>
    ///     完成短信验证
    /// </summary>
    Task<bool> VerifySmsCode(VerifySmsCodeReq req);
}