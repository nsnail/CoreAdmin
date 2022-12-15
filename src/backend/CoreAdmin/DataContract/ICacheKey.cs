namespace CoreAdmin.DataContract;

/// <summary>
///     缓存键接口
/// </summary>
public interface ICacheKey
{
    /// <summary>
    ///     Gets or sets 缓存键
    /// </summary>
    /// <value>
    ///     缓存键
    /// </value>
    string CacheKey { get; set; }
}