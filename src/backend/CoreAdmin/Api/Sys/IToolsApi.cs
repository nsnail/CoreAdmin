namespace CoreAdmin.Api.Sys;

/// <summary>
///     工具接口
/// </summary>
public interface IToolsApi
{
    /// <summary>
    ///     服务器时间
    /// </summary>
    DateTime GetServerUtcTime();

    /// <summary>
    ///     获取版本号
    /// </summary>
    string GetVersion();
}