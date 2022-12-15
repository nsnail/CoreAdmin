namespace CoreAdmin.DataContract.DbMap.Dependency;

/// <summary>
///     版本字段接口
/// </summary>
public interface IFieldVersion
{
    /// <summary>
    ///     Gets or sets 数据版本
    /// </summary>
    /// <value>
    ///     数据版本
    /// </value>
    long Version { get; set; }
}