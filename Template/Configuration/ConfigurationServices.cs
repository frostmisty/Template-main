using ApplicationCore.Additional;
using ApplicationCore.Base.Spesification;
using ApplicationCore.Interface;
using ApplicationCore.Interface.Base;
using Infrastructure.Repository.DataAccess;
using Infrastructure.Repository.RenderMenu;
using MediatR;

namespace Template.Configuration
{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IMsModuleRepository, MsModuleRepository>();
            services.AddScoped(typeof(IRepository<>), (typeof(Repository<>)));
            services.AddScoped(typeof(IGetMenu), typeof(GetMenu));

            return services;
        }
    }
}
