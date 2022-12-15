namespace CoreAdmin.DataContract.Dto.Sys.User;

/// <inheritdoc />
public record UserInfo : DataContract
{
    /// <summary>
    ///     Gets or sets 用户名
    /// </summary>
    /// <value>
    ///     用户名
    /// </value>
    public string UserName { get; set; }
}