using Furion.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace CoreAdmin.Aop.Filter;

/// <inheritdoc />
[SuppressSniffer]
public class JwtHandler : AppAuthorizeHandler
{
    /// <inheritdoc />
    public override Task<bool> PipelineAsync(AuthorizationHandlerContext context, DefaultHttpContext httpContext)
    {
        // 这里写您的授权判断逻辑，授权通过返回 true，否则返回 false
        return Task.FromResult(true);
    }
}