using FreeSql.Internal.Model;

namespace CoreAdmin.DataContract.Dto;

/// <summary>
///     请求：分页列表
/// </summary>
public record PagedListReq<T> : DataAbstraction
{
    /// <summary>
    ///     动态查询条件
    /// </summary>
    public DynamicFilterInfo DynamicFilter { get; set; }

    /// <summary>
    ///     查询条件
    /// </summary>
    public T Filter { get; set; }

    /// <summary>
    ///     当前页码
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    ///     页容量
    /// </summary>
    public int PageSize { get; set; }
}