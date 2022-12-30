using CoreAdmin.Aop.Attribute;

namespace CoreAdmin.DataContract.Dto.Pub;

/// <summary>
///     请求：通过id删除
/// </summary>
public record DelReq : DataAbstraction
{
    /// <summary>
    ///     要删除的id
    /// </summary>
    [RequiredField]
    public long Id { get; init; }
}