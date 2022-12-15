using DataType = FreeSql.DataType;

namespace CoreAdmin.Infrastructure.Configuration.Options;

/// <summary>
///     数据库连接字符串配置
/// </summary>
public record DatabaseOptions : OptionAbstraction
{
    /// <summary>
    ///     Gets or sets 链接字符串
    /// </summary>
    /// <value>
    ///     链接字符串
    /// </value>
    public string ConnStr { get; set; }

    /// <summary>
    ///     Gets or sets 建库脚本路径、为空不自动建库
    /// </summary>
    /// <value>
    ///     建库脚本路径、为空不自动建库
    /// </value>
    public string DbCreationFile { get; set; }

    /// <summary>
    ///     Gets or sets 数据库类型
    /// </summary>
    /// <value>
    ///     数据库类型
    /// </value>
    public DataType DbType { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether 启用多租户
    /// </summary>
    /// <value>
    ///     A value indicating whether 启用多租户
    /// </value>
    public bool IsMultiTenant { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether 是否同步数据结构
    /// </summary>
    /// <value>
    ///     A value indicating whether 是否同步数据结构
    /// </value>
    public bool IsSyncStructure { get; set; }
}