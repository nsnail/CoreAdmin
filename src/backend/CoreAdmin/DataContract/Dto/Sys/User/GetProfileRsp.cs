using System.Globalization;
using CoreAdmin.DataContract.DbMap;
using CoreAdmin.Infrastructure.Constant;
using Mapster;

namespace CoreAdmin.DataContract.Dto.Sys.User;

/// <inheritdoc />
public record GetProfileRsp : DataContract
{
    /// <summary>
    ///     Gets or sets 菜单
    /// </summary>
    /// <value>
    ///     菜单
    /// </value>
    public List<MenuInfo> Menu { get; set; }

    /// <summary>
    ///     Gets or sets 权限
    /// </summary>
    /// <value>
    ///     权限
    /// </value>
    public List<string> Permissions { get; set; }

    /// <inheritdoc />
    public record MenuInfo : IRegister
    {
        /// <summary>
        ///     Gets or sets 子节点
        /// </summary>
        /// <value>
        ///     子节点
        /// </value>
        public List<MenuInfo> Children { get; set; }

        /// <summary>
        ///     Gets or sets 组件
        /// </summary>
        /// <value>
        ///     组件
        /// </value>
        public string Component { get; set; }

        /// <summary>
        ///     Gets or sets 元数据
        /// </summary>
        /// <value>
        ///     元数据
        /// </value>
        public MetaInfo Meta { get; set; }

        /// <summary>
        ///     Gets or sets 权限编码
        /// </summary>
        /// <value>
        ///     权限编码
        /// </value>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets 菜单访问地址
        /// </summary>
        /// <value>
        ///     菜单访问地址
        /// </value>
        public string Path { get; set; }

        /// <summary>
        ///     Gets or sets 权限类型
        /// </summary>
        /// <value>
        ///     权限类型
        /// </value>
        public Enums.PermissionTypes Type { get; set; }

        /// <inheritdoc />
        public void Register(TypeAdapterConfig config)
        {
            config.ForType<TbSysMenu, MenuInfo>()
                  .Map(dest => dest.Meta, src => src.Adapt<MetaInfo>())
                  .Map(dest => dest.Name, src => src.Code);
        }

        /// <inheritdoc />
        public record MetaInfo : IRegister
        {
            /// <summary>
            ///     Gets or sets 图标
            /// </summary>
            /// <value>
            ///     图标
            /// </value>
            public string Icon { get; set; }

            /// <summary>
            ///     Gets or sets 标题
            /// </summary>
            /// <value>
            ///     标题
            /// </value>
            public string Title { get; set; }

            /// <summary>
            ///     Gets or sets 类型
            /// </summary>
            /// <value>
            ///     类型
            /// </value>
            public string Type { get; set; }

            /// <inheritdoc />
            public void Register(TypeAdapterConfig config)
            {
                config.ForType<TbSysMenu, MetaInfo>()
                      .Map(dest => dest.Type, src => src.Type.ToString().ToLower(CultureInfo.InvariantCulture));
            }
        }
    }
}