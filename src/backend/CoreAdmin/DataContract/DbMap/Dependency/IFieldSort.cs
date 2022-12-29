namespace CoreAdmin.DataContract.DbMap.Dependency;

/// <summary>
///     排序字段接口
/// </summary>
public interface IFieldSort
{
    /// <summary>
    ///     Gets or sets 排序字段
    /// </summary>
    /// <value>
    ///     排序字段
    /// </value>
    int Sort { get; set; }
}