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
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingMsModule());
                mc.AddProfile(new MappingMsPage());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc();

            return services;
        }
    }
}
