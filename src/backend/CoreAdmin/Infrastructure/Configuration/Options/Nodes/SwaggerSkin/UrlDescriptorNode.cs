namespace CoreAdmin.Infrastructure.Configuration.Options.Nodes.SwaggerSkin;

/// <summary>
///     url描述符 配置节点
/// </summary>
public record UrlDescriptorNode
{
    /// <summary>
    ///     Gets or sets 名称
    /// </summary>
    /// <value>
    ///     名称
    /// </value>
    public string Name { get; set; }

    /// <summary>
    ///     Gets or sets url
    /// </summary>
    /// <value>
    ///     Url
    /// </value>
    public string Url { get; set; }
}