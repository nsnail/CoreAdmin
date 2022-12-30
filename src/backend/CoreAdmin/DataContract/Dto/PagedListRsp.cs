namespace CoreAdmin.DataContract.Dto;

/// <summary>
///     响应：分页列表
/// </summary>
public record PagedListRsp<T> : DataAbstraction
    where T : DataAbstraction, new()
{
    /// <summary>
    ///     当前页码
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    ///     页容量
    /// </summary>
    public int PageSize { get; set; }

    /// <summary>
    ///     数据行
    /// </summary>
    public IEnumerable<T> Rows { get; set; }

    /// <summary>
    ///     数据总条
    /// </summary>
    public long Total { get; set; }
}