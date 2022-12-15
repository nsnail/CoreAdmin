namespace CoreAdmin.DataContract.DbMap.Dependency;

/// <summary>
///     比特位字段接口
/// </summary>
public interface IFieldBitSet
{
    /// <summary>
    ///     Gets or sets 比特位
    /// </summary>
    /// <value>
    ///     比特位
    /// </value>
    long BitSet { get; set; }
}