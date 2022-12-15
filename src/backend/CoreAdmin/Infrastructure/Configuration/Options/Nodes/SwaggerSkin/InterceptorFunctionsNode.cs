namespace CoreAdmin.Infrastructure.Configuration.Options.Nodes.SwaggerSkin;

/// <summary>
///     拦截器功能配置节点
/// </summary>
public record InterceptorFunctionsNode
{
    /// <summary>
    ///     Gets or sets mUST be a valid Javascript function.
    ///     Function to intercept remote definition, "Try it out", and OAuth 2.0 requests.
    ///     Accepts one argument requestInterceptor(request) and must return the modified request, or a Promise that resolves
    ///     to the modified request.
    ///     Ex: "req => { req.headers['MyCustomHeader'] = 'CustomValue'; return req; }"
    /// </summary>
    /// <value>
    ///     MUST be a valid Javascript function.
    ///     Function to intercept remote definition, "Try it out", and OAuth 2.0 requests.
    ///     Accepts one argument requestInterceptor(request) and must return the modified request, or a Promise that resolves
    ///     to the modified request.
    ///     Ex: "req => { req.headers['MyCustomHeader'] = 'CustomValue'; return req; }"
    /// </value>
    public string RequestInterceptorFunction { get; set; }

    /// <summary>
    ///     Gets or sets mUST be a valid Javascript function.
    ///     Function to intercept remote definition, "Try it out", and OAuth 2.0 responses.
    ///     Accepts one argument responseInterceptor(response) and must return the modified response, or a Promise that
    ///     resolves to the modified response.
    ///     Ex: "res => { console.log(res); return res; }"
    /// </summary>
    /// <value>
    ///     MUST be a valid Javascript function.
    ///     Function to intercept remote definition, "Try it out", and OAuth 2.0 responses.
    ///     Accepts one argument responseInterceptor(response) and must return the modified response, or a Promise that
    ///     resolves to the modified response.
    ///     Ex: "res => { console.log(res); return res; }"
    /// </value>
    public string ResponseInterceptorFunction { get; set; }
}