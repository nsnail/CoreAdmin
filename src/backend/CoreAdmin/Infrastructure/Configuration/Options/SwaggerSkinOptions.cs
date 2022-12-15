using CoreAdmin.Infrastructure.Configuration.Options.Nodes.SwaggerSkin;

namespace CoreAdmin.Infrastructure.Configuration.Options;

/// <summary>
///     API 界面 knife4j-vue 配置
/// </summary>
public record SwaggerSkinOptions : OptionAbstraction
{
    /// <summary>
    ///     Gets or sets swagger 配置对象 节点
    ///     Gets the JavaScript config object, represented as JSON, that will be passed to the SwaggerUI
    /// </summary>
    /// <value>
    ///     Swagger 配置对象 节点
    ///     Gets the JavaScript config object, represented as JSON, that will be passed to the SwaggerUI
    /// </value>
    public ConfigObjectNode ConfigObject { get; set; } = new();

    /// <summary>
    ///     Gets or sets 文档标题
    ///     Gets or sets a title for the swagger-ui page
    /// </summary>
    /// <value>
    ///     文档标题
    ///     Gets or sets a title for the swagger-ui page
    /// </value>
    public string DocumentTitle { get; set; } = "api skin";

    /// <summary>
    ///     Gets or sets 自定义页面 head 节点
    ///     Gets or sets additional content to place in the head of the swagger-ui page
    /// </summary>
    /// <value>
    ///     自定义页面 head 节点
    ///     Gets or sets additional content to place in the head of the swagger-ui page
    /// </value>
    public string HeadContent { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets request &amp; response 拦截器
    ///     Gets the interceptor functions that define client-side request/response interceptors
    /// </summary>
    /// <value>
    ///     Request &amp; response 拦截器
    ///     Gets the interceptor functions that define client-side request/response interceptors
    /// </value>
    public InterceptorFunctionsNode Interceptors { get; set; } = new();

    /// <summary>
    ///     Gets or sets oAuth 配置节点
    ///     Gets the JavaScript config object, represented as JSON, that will be passed to the initOAuth method
    /// </summary>
    /// <value>
    ///     OAuth 配置节点
    ///     Gets the JavaScript config object, represented as JSON, that will be passed to the initOAuth method
    /// </value>
    public OAuthConfigObjectNode OAuthConfigObject { get; set; } = new();
}