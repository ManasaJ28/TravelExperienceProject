using Travel.ApplicationLayer;
using Travel.InfrastructureLayer;

namespace TravelAPI
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddTravelAppDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
                .AddInfrastructureDI();

            return services;
        }
    }
}
