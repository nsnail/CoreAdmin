using FreeSql.Internal.Model;

namespace CoreAdmin.DataContract.Dto;

/// <summary>
///     分页列表请求
/// </summary>
public record PagedListReq<T> : DataContract
{
    /// <summary>
    ///     Gets or sets 动态查询条件
    /// </summary>
    /// <value>
    ///     动态查询条件
    /// </value>
    public DynamicFilterInfo DynamicFilter { get; set; }

    /// <summary>
    ///     Gets or sets 查询条件
    /// </summary>
    /// <value>
    ///     查询条件
    /// </value>
    public T Filter { get; set; }

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
}