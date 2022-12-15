namespace CoreAdmin.DataContract.DbMap.Dependency;

/// <summary>
///     删除字段接口
/// </summary>
public interface IFieldDelete
{
    /// <summary>
    ///     Gets or sets a value indicating whether 是否删除
    /// </summary>
    /// <value>
    ///     A value indicating whether 是否删除
    /// </value>
    bool IsDeleted { get; set; }
}