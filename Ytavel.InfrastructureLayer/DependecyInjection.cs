using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Travel.DomainLayer;
using Travel.InfrastructureLayer.Repositories;

namespace Travel.InfrastructureLayer
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructureDI (this IServiceCollection services)
        {
            services.AddDbContext<TravelDBContext>(options =>
            {
                options.UseSqlServer("Server=MANASA\\SQLEXPRESS;Initial Catalog=TravelDB;Integrated Security=SSPI; MultipleActiveResultSets=true;TrustServerCertificate=True;");
            });
            services.AddScoped<ITripRepository, TripRepository>();
            return services;
        }
    }
}
