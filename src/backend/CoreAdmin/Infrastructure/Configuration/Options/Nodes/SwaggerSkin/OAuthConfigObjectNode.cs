namespace CoreAdmin.Infrastructure.Configuration.Options.Nodes.SwaggerSkin;

/// <summary>
///     OAuth配置节点
/// </summary>
public record OAuthConfigObjectNode
{
    /// <summary>
    ///     Gets or sets additional query parameters added to authorizationUrl and tokenUrl
    /// </summary>
    /// <value>
    ///     Additional query parameters added to authorizationUrl and tokenUrl
    /// </value>
    public Dictionary<string, string> AdditionalQueryStringParams { get; set; }

    /// <summary>
    ///     Gets or sets application name, displayed in authorization popup
    /// </summary>
    /// <value>
    ///     Application name, displayed in authorization popup
    /// </value>
    public string AppName { get; set; }

    /// <summary>
    ///     Gets or sets default clientId
    /// </summary>
    /// <value>
    ///     Default clientId
    /// </value>
    public string ClientId { get; set; }

    /// <summary>
    ///     Gets or sets default clientSecret
    /// </summary>
    /// <value>
    ///     Default clientSecret
    /// </value>
    public string ClientSecret { get; set; }

    /// <summary>
    ///     Gets or sets realm query parameter (for oauth1) added to authorizationUrl and tokenUrl
    /// </summary>
    /// <value>
    ///     Realm query parameter (for oauth1) added to authorizationUrl and tokenUrl
    /// </value>
    public string Realm { get; set; }

    /// <summary>
    ///     Gets or sets string array of initially selected oauth scopes, default is empty array
    /// </summary>
    /// <value>
    ///     String array of initially selected oauth scopes, default is empty array
    /// </value>
    public IEnumerable<string> Scopes { get; set; } = Array.Empty<string>();

    /// <summary>
    ///     Gets or sets scope separator for passing scopes, encoded before calling, default value is a space (encoded value
    ///     %20)
    /// </summary>
    /// <value>
    ///     Scope separator for passing scopes, encoded before calling, default value is a space (encoded value %20)
    /// </value>
    public string ScopeSeparator { get; set; } = " ";

    /// <summary>
    ///     Gets or sets a value indicating whether only activated for the accessCode flow. During the authorization_code
    ///     request to the tokenUrl,
    ///     pass the Client Password using the HTTP Basic Authentication scheme
    ///     (Authorization header with Basic base64encode(client_id + client_secret))
    /// </summary>
    /// <value>
    ///     A value indicating whether only activated for the accessCode flow. During the authorization_code request to the
    ///     tokenUrl,
    ///     pass the Client Password using the HTTP Basic Authentication scheme
    ///     (Authorization header with Basic base64encode(client_id + client_secret))
    /// </value>
    public bool UseBasicAuthenticationWithAccessCodeGrant { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether only applies to authorizatonCode flows. Proof Key for Code Exchange brings
    ///     enhanced security for OAuth public
    ///     clients.
    ///     The default is false
    /// </summary>
    /// <value>
    ///     A value indicating whether only applies to authorizatonCode flows. Proof Key for Code Exchange brings enhanced
    ///     security for OAuth public
    ///     clients.
    ///     The default is false
    /// </value>
    public bool UsePkceWithAuthorizationCodeGrant { get; set; }
}