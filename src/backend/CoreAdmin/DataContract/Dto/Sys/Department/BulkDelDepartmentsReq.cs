using CoreAdmin.Aop.Attribute;

namespace CoreAdmin.DataContract.Dto.Sys.Department;

/// <inheritdoc />
public record BulkDelDepartmentsReq : DataContract
{
    /// <summary>
    ///     Gets or sets 要删除的id列表
    /// </summary>
    /// <value>
    ///     要删除的id列表
    /// </value>
    [RequiredField]
    public List<long> Ids { get; set; }
}