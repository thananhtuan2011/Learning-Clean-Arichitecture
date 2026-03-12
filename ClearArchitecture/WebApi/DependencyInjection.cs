using Application;
using Infra;

namespace WebApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplication()
                .AddInfrastrectureDI(configuration);
            return services;
        }
    }
}
