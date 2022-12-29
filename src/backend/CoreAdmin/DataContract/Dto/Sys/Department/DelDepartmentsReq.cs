using CoreAdmin.Aop.Attribute;
using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.Department;

/// <inheritdoc />
public record DelDepartmentsReq : TbSysDepartment
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [RequiredField]
    public override long Id { get; set; }
}