namespace CoreAdmin.Infrastructure.Configuration.Options.SubNodes.SwaggerSkin;

/// <summary>
///     OAuth配置节点
/// </summary>
public record OAuthConfigObjectNode
{
    /// <summary>
    ///     additional query parameters added to authorizationUrl and tokenUrl
    /// </summary>
    public Dictionary<string, string> AdditionalQueryStringParams { get; set; }

    /// <summary>
    ///     application name, displayed in authorization popup
    /// </summary>
    public string AppName { get; set; }

    /// <summary>
    ///     default clientId
    /// </summary>
    public string ClientId { get; set; }

    /// <summary>
    ///     default clientSecret
    /// </summary>
    public string ClientSecret { get; set; }

    /// <summary>
    ///     realm query parameter (for oauth1) added to authorizationUrl and tokenUrl
    /// </summary>
    public string Realm { get; set; }

    /// <summary>
    ///     string array of initially selected oauth scopes, default is empty array
    /// </summary>
    public IEnumerable<string> Scopes { get; set; } = Array.Empty<string>();

    /// <summary>
    ///     scope separator for passing scopes, encoded before calling, default value is a space (encoded value
    ///     %20)
    /// </summary>
    public string ScopeSeparator { get; set; } = " ";

    /// <summary>
    ///     only activated for the accessCode flow. During the authorization_code
    ///     request to the tokenUrl,
    ///     pass the Client Password using the HTTP Basic Authentication scheme
    ///     (Authorization header with Basic base64encode(client_id + client_secret))
    /// </summary>
    public bool UseBasicAuthenticationWithAccessCodeGrant { get; set; }

    /// <summary>
    ///     only applies to authorizatonCode flows. Proof Key for Code Exchange brings
    ///     enhanced security for OAuth public
    ///     clients.
    ///     The default is false
    /// </summary>
    public bool UsePkceWithAuthorizationCodeGrant { get; set; }
}