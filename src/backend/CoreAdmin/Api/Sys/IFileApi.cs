namespace CoreAdmin.Api.Sys;

/// <summary>
///     文件接口
/// </summary>
public interface IFileApi
{
    /// <summary>
    ///     上传文件
    /// </summary>
    Task Upload(IFormFile file);
}