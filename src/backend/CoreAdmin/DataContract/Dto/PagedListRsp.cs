namespace CoreAdmin.DataContract.Dto;

/// <summary>
///     分页列表响应
/// </summary>
public record PagedListRsp<T> : DataContract
    where T : DataContract, new()
{
    /// <summary>
    ///     Gets or sets 当前页码
    /// </summary>
    /// <value>
    ///     当前页码
    /// </value>
    public int Page { get; set; }

    /// <summary>
    ///     Gets or sets 页容量
    /// </summary>
    /// <value>
    ///     页容量
    /// </value>
    public int PageSize { get; set; }

    /// <summary>
    ///     Gets or sets 数据行
    /// </summary>
    /// <value>
    ///     数据行
    /// </value>
    public IEnumerable<T> Rows { get; set; }

    /// <summary>
    ///     Gets or sets 数据总条
    /// </summary>
    /// <value>
    ///     数据总条
    /// </value>
    public long Total { get; set; }
}