using CoreAdmin.Aop.Attribute;

namespace CoreAdmin.DataContract.Dto.Pub;

/// <summary>
///     请求：通过id批量删除
/// </summary>
public record BulkDelReq : DataAbstraction
{
    /// <summary>
    ///     要删除的id列表
    /// </summary>
    [RequiredField]
    public List<long> Ids { get; set; }
}