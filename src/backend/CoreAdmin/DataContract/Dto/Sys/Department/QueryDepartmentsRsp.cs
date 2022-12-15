using CoreAdmin.DataContract.DbMap;

namespace CoreAdmin.DataContract.Dto.Sys.Department;

/// <inheritdoc />
public record QueryDepartmentsRsp : TbSysDepartment
{
    /// <summary>
    ///     Gets or sets Children
    /// </summary>
    /// <value>
    ///     Children
    /// </value>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public new List<QueryDepartmentsRsp> Children { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string Label { get; set; }
}