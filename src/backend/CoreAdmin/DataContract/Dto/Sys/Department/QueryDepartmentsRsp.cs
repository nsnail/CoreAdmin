using CoreAdmin.DataContract.DbMap;
using Mapster;

namespace CoreAdmin.DataContract.Dto.Sys.Department;

/// <summary>
///     响应：查询部门
/// </summary>
public record QueryDepartmentsRsp : TbSysDepartment, IRegister
{
    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long BitSet { get; set; }

    /// <summary>
    ///     Gets or sets Children
    /// </summary>
    /// <value>
    ///     Children
    /// </value>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public new List<QueryDepartmentsRsp> Children { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override DateTime CreatedTime { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Id { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string Label { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long ParentId { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string Remark { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override int Sort { get; set; }

    /// <inheritdoc />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Version { get; set; }

    /// <inheritdoc />
    public void Register(TypeAdapterConfig config)
    {
        config.ForType<TbSysDepartment, QueryDepartmentsRsp>()
              .IgnoreIf((src, dest) => !src.Children.Any(), dest => dest.Children);
    }
}