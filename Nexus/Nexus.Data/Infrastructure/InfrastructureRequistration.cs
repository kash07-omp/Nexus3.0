using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Nexus.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Data.Infrastructure
{
    public static class InfrastructureRequistration
    {
        public static IServiceCollection InfrastructureConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepository<>), typeof(IRepository<>));

            //  services.AddScoped<ICategoryRepository, CategoryRepository>();
            // services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefualtConnection"))
            );

            return services;
        }
    }
}
