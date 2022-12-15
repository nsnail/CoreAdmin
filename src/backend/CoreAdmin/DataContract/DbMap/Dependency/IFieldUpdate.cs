namespace CoreAdmin.DataContract.DbMap.Dependency;

/// <summary>
///     更新字段接口
/// </summary>
public interface IFieldUpdate
{
    /// <summary>
    ///     Gets or sets 修改时间
    /// </summary>
    /// <value>
    ///     修改时间
    /// </value>
    DateTime? ModifiedTime { get; set; }

    /// <summary>
    ///     Gets or sets 修改者Id
    /// </summary>
    /// <value>
    ///     修改者Id
    /// </value>
    long? ModifiedUserId { get; set; }

    /// <summary>
    ///     Gets or sets 修改者
    /// </summary>
    /// <value>
    ///     修改者
    /// </value>
    string ModifiedUserName { get; set; }
}