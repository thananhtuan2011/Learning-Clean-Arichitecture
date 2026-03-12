using Domain.Options;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastrectureDI(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>((provider, options) =>
            {
                // Fix: Use the 'configuration' parameter directly instead of 'provider.Configuration'  
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Infra"));
            });
            //services.AddScoped<ICustomerRepository, CustomerRepository>();  
            return services;
        }
    }
}
