using CoreAdmin.DataContract.DbMap;
using CoreAdmin.Infrastructure.Constant;
using Mapster;

namespace CoreAdmin.DataContract.Dto.Sys.User;

public record GetProfileRsp : DataContract
{
    public List<MenuInfo> Menu        { get; set; }
    public List<string>   Permissions { get; set; }


    public record MenuInfo : IRegister
    {
        /// <summary>
        ///     子节点
        /// </summary>
        public List<MenuInfo> Children { get; set; }

        /// <summary>
        ///     组件
        /// </summary>
        public string Component { get; set; }


        /// <summary>
        ///     元数据
        /// </summary>
        public MetaInfo Meta { get; set; }


        /// <summary>
        ///     权限编码
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        ///     菜单访问地址
        /// </summary>
        public string Path { get; set; }


        /// <summary>
        ///     权限类型
        /// </summary>
        public Enums.PermissionTypes Type { get; set; }

        /// <inheritdoc />
        public void Register(TypeAdapterConfig config)
        {
            config.ForType<TbSysMenu, MenuInfo>()
                  .Map(dest => dest.Meta, src => src.Adapt<MetaInfo>())
                  .Map(dest => dest.Name, src => src.Code);
        }

        public record MetaInfo : IRegister
        {
            public string Icon  { get; set; }
            public string Title { get; set; }
            public string Type  { get; set; }

            /// <inheritdoc />
            public void Register(TypeAdapterConfig config)
            {
                config.ForType<TbSysMenu, MetaInfo>().Map(dest => dest.Type, src => src.Type.ToString().ToLower());
            }
        }
    }
}