using System.ComponentModel;
using CoreAdmin.Aop.Attribute;
using CoreAdmin.Infrastructure.Constant;
using FreeSql.DataAnnotations;

namespace CoreAdmin.DataContract.DbMap.Dependency;

/// <summary>
///     不可变实体
/// </summary>
public abstract record ImmutableEntity : DataAbstraction, IEntity, IFieldPrimary, IFieldAdd, IFieldDelete
{
    /// <inheritdoc />
    [JsonIgnore]
    [Description(Strings.DSC_CREATED_TIME)]
    [Column(CanUpdate = false, ServerTime = DateTimeKind.Local)]
    public DateTime CreatedTime { get; set; }

    /// <inheritdoc />
    [JsonIgnore]
    [Description(Strings.DSC_CREATED_USER_ID)]
    [Column(CanUpdate = false)]
    public long? CreatedUserId { get; set; }

    /// <inheritdoc />
    [JsonIgnore]
    [Description(Strings.DSC_CREATED_USER_NAME)]
    [Column(CanUpdate = false)]
    public string CreatedUserName { get; set; }

    /// <inheritdoc />
    [JsonIgnore]
    [Description(Strings.DSC_ID)]
    [Column(IsIdentity = false, IsPrimary = true)]
    [Snowflake]
    public long Id { get; set; }

    /// <inheritdoc />
    [JsonIgnore]
    [Description(Strings.DSC_IS_DELETED)]
    public bool IsDeleted { get; set; }
}