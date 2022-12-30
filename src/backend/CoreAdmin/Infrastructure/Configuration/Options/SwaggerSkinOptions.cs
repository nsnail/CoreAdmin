using CoreAdmin.Infrastructure.Configuration.Options.SubNodes.SwaggerSkin;

namespace CoreAdmin.Infrastructure.Configuration.Options;

/// <summary>
///     API 界面 knife4j-vue 配置
/// </summary>
public record SwaggerSkinOptions : OptionAbstraction
{
    /// <summary>
    ///     swagger 配置对象 节点
    ///     the JavaScript config object, represented as JSON, that will be passed to the SwaggerUI
    /// </summary>
    public ConfigObjectNode ConfigObject { get; set; } = new();

    /// <summary>
    ///     文档标题
    ///     a title for the swagger-ui page
    /// </summary>
    public string DocumentTitle { get; set; } = "api skin";

    /// <summary>
    ///     自定义页面 head 节点
    ///     additional content to place in the head of the swagger-ui page
    /// </summary>
    public string HeadContent { get; set; } = string.Empty;

    /// <summary>
    ///     request &amp; response 拦截器
    ///     the interceptor functions that define client-side request/response interceptors
    /// </summary>
    public InterceptorFunctionsNode Interceptors { get; set; } = new();

    /// <summary>
    ///     oAuth 配置节点
    ///     the JavaScript config object, represented as JSON, that will be passed to the initOAuth method
    /// </summary>
    public OAuthConfigObjectNode OAuthConfigObject { get; set; } = new();
}