using Application.Data;
using Infrastructure.Services.DataPersistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("DataBaseCnnInAppsettingJson")));

            services.AddScoped<IAppDbContext,AppDbContext>();
            services.AddScoped(typeof(IAppDbRepository<>), typeof(AppDbRepository<>));

            return services;
        }
    }
}
