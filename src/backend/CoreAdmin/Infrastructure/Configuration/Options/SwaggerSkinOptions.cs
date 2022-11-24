﻿using CoreAdmin.Infrastructure.Configuration.Options.Nodes.SwaggerSkin;

namespace CoreAdmin.Infrastructure.Configuration.Options;

/// <summary>
///     API 界面 knife4j-vue 配置
/// </summary>
public record SwaggerSkinOptions : OptionAbstraction
{
    /// <summary>
    ///     swagger 配置对象 节点
    ///     Gets the JavaScript config object, represented as JSON, that will be passed to the SwaggerUI
    /// </summary>
    public ConfigObjectNode ConfigObject { get; set; } = new();

    /// <summary>
    ///     文档标题
    ///     Gets or sets a title for the swagger-ui page
    /// </summary>
    public string DocumentTitle { get; set; } = "api skin";

    /// <summary>
    ///     自定义页面 head 节点
    ///     Gets or sets additional content to place in the head of the swagger-ui page
    /// </summary>
    public string HeadContent { get; set; } = "";


    /// <summary>
    ///     request & response 拦截器
    ///     Gets the interceptor functions that define client-side request/response interceptors
    /// </summary>
    public InterceptorFunctionsNode Interceptors { get; set; } = new();

    /// <summary>
    ///     OAuth 配置节点
    ///     Gets the JavaScript config object, represented as JSON, that will be passed to the initOAuth method
    /// </summary>
    public OAuthConfigObjectNode OAuthConfigObject { get; set; } = new();
}