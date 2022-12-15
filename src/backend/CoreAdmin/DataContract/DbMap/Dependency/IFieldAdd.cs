namespace CoreAdmin.DataContract.DbMap.Dependency;

/// <summary>
///     新增字段接口
/// </summary>
public interface IFieldAdd
{
    /// <summary>
    ///     Gets or sets 创建时间
    /// </summary>
    /// <value>
    ///     创建时间
    /// </value>
    DateTime CreatedTime { get; set; }

    /// <summary>
    ///     Gets or sets 创建者Id
    /// </summary>
    /// <value>
    ///     创建者Id
    /// </value>
    long? CreatedUserId { get; set; }

    /// <summary>
    ///     Gets or sets 创建者
    /// </summary>
    /// <value>
    ///     创建者
    /// </value>
    string CreatedUserName { get; set; }
}