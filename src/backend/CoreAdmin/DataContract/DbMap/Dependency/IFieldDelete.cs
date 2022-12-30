namespace CoreAdmin.DataContract.DbMap.Dependency;

/// <summary>
///     删除字段接口
/// </summary>
public interface IFieldDelete
{
    /// <summary>
    ///     是否删除
    /// </summary>
    bool IsDeleted { get; set; }
}