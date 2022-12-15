namespace CoreAdmin.Infrastructure.Util;

/// <summary>
///     短信发送器
/// </summary>
public interface ISmsSender
{
    /// <summary>
    ///     发送短信
    /// </summary>
    /// <param name="mobile">手机号</param>
    /// <param name="content">内容</param>
    void Send(long mobile, string content);

    /// <summary>
    ///     发送验证码
    /// </summary>
    /// <param name="mobile">手机号</param>
    /// <param name="code">验证码</param>
    void SendCode(long mobile, string code);
}