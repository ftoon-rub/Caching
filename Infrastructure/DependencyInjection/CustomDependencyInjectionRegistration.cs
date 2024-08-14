using Core;
using Core.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyInjection
{
    public static class CustomDependencyInjectionRegistration
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services,AppSettingsConfiguration appSettings)
        {
            // Register services, repositories, etc.
            services.AddScoped<IRedisCacheService, RedisCacheService>();

            // Add other custom services here...

            return services;
        }
    }
}
