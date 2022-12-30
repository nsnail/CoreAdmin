namespace CoreAdmin.Infrastructure.Configuration.Options;

/// <summary>
///     上传配置
/// </summary>
public record UploadOptions : OptionAbstraction
{
    /// <summary>
    ///     文件类型
    /// </summary>
    public List<string> ContentType { get; set; }

    /// <summary>
    ///     日期格式
    /// </summary>
    public string DateTimeFormat { get; set; }

    /// <summary>
    ///     文件名格式
    /// </summary>
    public string Format { get; set; }

    /// <summary>
    ///     最大允许上传张数，-1不限制
    /// </summary>
    public int Limit { get; set; }

    /// <summary>
    ///     图片大小不超过 1M = 1 * 1024 * 1024
    /// </summary>
    public long MaxSize { get; set; }

    /// <summary>
    ///     请求路径
    /// </summary>
    public string RequestPath { get; set; }

    /// <summary>
    ///     上传路径
    /// </summary>
    public string UploadPath { get; set; }
}