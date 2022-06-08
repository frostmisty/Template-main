using ApplicationCore.Interface;
using AutoMapper;
using MediatR;
using Template.Interface;
using Template.Mapper;
using Template.Services;

namespace Template.Configuration
{
    public static class ConfigurationWebServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped(typeof(IMsModuleService), (typeof(MsModuleService)));
            services.AddScoped(typeof(IMsPageService), (typeof(MsPageService)));
            services.AddScoped(typeof(IMsMenuService), (typeof(MsMenuService)));
            services.AddScoped(typeof(IMsUserRoleService), (typeof(MsUserRoleService)));
            services.AddScoped(typeof(IMsUserRoleAccessService), (typeof(MsUserRoleAccessService)));
            services.AddScoped(typeof(IMsPermissionService), (typeof(MsPermissionService)));
            services.AddScoped(typeof(IMsEnumItemService), (typeof(MsEnumItemService)));
            services.AddScoped(typeof(IMsUserService), (typeof(MsUserService)));
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingMsModule());
                mc.AddProfile(new MappingMsPage());
                mc.AddProfile(new MappingMsMenu());
                mc.AddProfile(new MappingMsUserRole());
                mc.AddProfile(new MappingMsUserRoleAccess());
                mc.AddProfile(new MappingMsPermission());
                mc.AddProfile(new MappingMsEnumItem());
                mc.AddProfile(new MappingMsUser());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc();

            return services;
        }
    }
}
