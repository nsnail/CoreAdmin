namespace CoreAdmin.DataContract.DbMap.Dependency;

/// <summary>
///     主键字段接口
/// </summary>
public interface IFieldPrimary
{
    /// <summary>
    ///     Gets or sets 主键Id
    /// </summary>
    /// <value>
    ///     主键Id
    /// </value>
    long Id { get; set; }
}