namespace CoreAdmin.DataContract.DbMap.Dependency;

/// <summary>
///     主键字段接口
/// </summary>
public interface IFieldPrimary
{
    /// <summary>
    ///     主键Id
    /// </summary>
    long Id { get; set; }
}