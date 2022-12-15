namespace CoreAdmin.Infrastructure.Configuration.Options.Nodes.SwaggerSkin;

/// <summary>
///     swagger 配置对象 节点
/// </summary>
public record ConfigObjectNode
{
    /// <summary>
    ///     Gets or sets 附加item
    /// </summary>
    /// <value>
    ///     附加item
    /// </value>
    [JsonExtensionData]
    public Dictionary<string, object> AdditionalItems { get; set; } = new();

    /// <summary>
    ///     Gets or sets a value indicating whether if set to true, enables deep linking for tags and operations
    /// </summary>
    /// <value>
    ///     A value indicating whether if set to true, enables deep linking for tags and operations
    /// </value>
    public bool DeepLinking { get; set; }

    /// <summary>
    ///     Gets or sets the default expansion depth for the model on the model-example section
    /// </summary>
    /// <value>
    ///     The default expansion depth for the model on the model-example section
    /// </value>
    public int DefaultModelExpandDepth { get; set; } = 1;

    /// <summary>
    ///     Gets or sets controls how the model is shown when the API is first rendered.
    ///     (The user can always switch the rendering for a given model by clicking the 'Model' and 'Example Value' links)
    /// </summary>
    /// <value>
    ///     Controls how the model is shown when the API is first rendered.
    ///     (The user can always switch the rendering for a given model by clicking the 'Model' and 'Example Value' links)
    /// </value>
    public ModelRenderingNode DefaultModelRendering { get; set; } = ModelRenderingNode.Example;

    /// <summary>
    ///     Gets or sets the default expansion depth for models (set to -1 completely hide the models)
    /// </summary>
    /// <value>
    ///     The default expansion depth for models (set to -1 completely hide the models)
    /// </value>
    public int DefaultModelsExpandDepth { get; set; } = 1;

    /// <summary>
    ///     Gets or sets a value indicating whether controls the display of operationId in operations list
    /// </summary>
    /// <value>
    ///     A value indicating whether controls the display of operationId in operations list
    /// </value>
    public bool DisplayOperationId { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether controls the display of the request duration (in milliseconds) for
    ///     Try-It-Out requests
    /// </summary>
    /// <value>
    ///     A value indicating whether controls the display of the request duration (in milliseconds) for
    ///     Try-It-Out requests
    /// </value>
    public bool DisplayRequestDuration { get; set; }

    /// <summary>
    ///     Gets or sets controls the default expansion setting for the operations and tags.
    ///     It can be 'list' (expands only the tags), 'full' (expands the tags and operations) or 'none' (expands nothing)
    /// </summary>
    /// <value>
    ///     Controls the default expansion setting for the operations and tags.
    ///     It can be 'list' (expands only the tags), 'full' (expands the tags and operations) or 'none' (expands nothing)
    /// </value>
    public DocExpansionNode DocExpansion { get; set; } = DocExpansionNode.List;

    /// <summary>
    ///     Gets or sets if set, enables filtering. The top bar will show an edit box that you can use to filter the tagged
    ///     operations
    ///     that are shown. Can be an empty string or specific value, in which case filtering will be enabled using that
    ///     value as the filter expression. Filtering is case sensitive matching the filter expression anywhere inside the tag
    /// </summary>
    /// <value>
    ///     If set, enables filtering. The top bar will show an edit box that you can use to filter the tagged operations
    ///     that are shown. Can be an empty string or specific value, in which case filtering will be enabled using that
    ///     value as the filter expression. Filtering is case sensitive matching the filter expression anywhere inside the
    ///     tag
    /// </value>
    public string Filter { get; set; }

    /// <summary>
    ///     Gets or sets if set, limits the number of tagged operations displayed to at most this many. The default is to show
    ///     all
    ///     operations
    /// </summary>
    /// <value>
    ///     If set, limits the number of tagged operations displayed to at most this many. The default is to show all
    ///     operations
    /// </value>
    public int? MaxDisplayedTags { get; set; }

    /// <summary>
    ///     Gets or sets oAuth redirect URL
    /// </summary>
    /// <value>
    ///     OAuth redirect URL
    /// </value>
    [JsonPropertyName("oauth2RedirectUrl")]
    public string OAuth2RedirectUrl { get; set; } = null;

    /// <summary>
    ///     Gets or sets a value indicating whether if set to true, it persists authorization data and it would not be lost on
    ///     browser close/refresh
    /// </summary>
    /// <value>
    ///     A value indicating whether if set to true, it persists authorization data and it would not be lost on
    ///     browser close/refresh
    /// </value>
    public bool PersistAuthorization { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether controls the display of extensions (pattern, maxLength, minLength, maximum,
    ///     minimum) fields and values for
    ///     Parameters
    /// </summary>
    /// <value>
    ///     A value indicating whether controls the display of extensions (pattern, maxLength, minLength, maximum, minimum)
    ///     fields and values for
    ///     Parameters
    /// </value>
    public bool ShowCommonExtensions { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether controls the display of vendor extension (x-) fields and values for
    ///     Operations, Parameters, and Schema
    /// </summary>
    /// <value>
    ///     A value indicating whether controls the display of vendor extension (x-) fields and values for
    ///     Operations, Parameters, and Schema
    /// </value>
    public bool ShowExtensions { get; set; }

    /// <summary>
    ///     Gets or sets list of HTTP methods that have the Try it out feature enabled.
    ///     An empty array disables Try it out for all operations. This does not filter the operations from the display
    /// </summary>
    /// <value>
    ///     List of HTTP methods that have the Try it out feature enabled.
    ///     An empty array disables Try it out for all operations. This does not filter the operations from the display
    /// </value>
    public IEnumerable<SubmitMethodNode> SupportedSubmitMethods { get; set; }
        = Enum.GetValues(typeof(SubmitMethodNode)).Cast<SubmitMethodNode>();

    /// <summary>
    ///     Gets or sets a value indicating whether controls whether the "Try it out" section should be enabled by default.
    /// </summary>
    /// <value>
    ///     A value indicating whether controls whether the "Try it out" section should be enabled by default.
    /// </value>
    [JsonPropertyName("tryItOutEnabled")]
    public bool TryItOutEnabled { get; set; }

    /// <summary>
    ///     Gets or sets one or more Swagger JSON endpoints (url and name) to power the UI
    /// </summary>
    /// <value>
    ///     One or more Swagger JSON endpoints (url and name) to power the UI
    /// </value>
    public IEnumerable<UrlDescriptorNode> Urls { get; set; }

    /// <summary>
    ///     Gets or sets by default, Swagger-UI attempts to validate specs against swagger.io's online validator.
    ///     You can use this parameter to set a different validator URL, for example for locally deployed validators (Validator
    ///     Badge).
    ///     Setting it to null will disable validation
    /// </summary>
    /// <value>
    ///     By default, Swagger-UI attempts to validate specs against swagger.io's online validator.
    ///     You can use this parameter to set a different validator URL, for example for locally deployed validators
    ///     (Validator
    ///     Badge).
    ///     Setting it to null will disable validation
    /// </value>
    public string ValidatorUrl { get; set; }
}