namespace CoreAdmin.DataContract;

/// <summary>
///     缓存键接口
/// </summary>
public interface ICacheKey
{
    /// <summary>
    ///     缓存键
    /// </summary>
    string CacheKey { get; set; }
}