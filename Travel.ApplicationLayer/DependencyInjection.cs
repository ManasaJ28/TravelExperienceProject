using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.ApplicationLayer.Interfaces;
using Travel.ApplicationLayer.services;

namespace Travel.ApplicationLayer
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddScoped<ITripService, TripService>();
            return services;
        }
    }
}
