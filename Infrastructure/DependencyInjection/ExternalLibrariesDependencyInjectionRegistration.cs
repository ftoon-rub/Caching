using Core.Configurations;
using Core;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace Infrastructure.DependencyInjection
{
    public static class ExternalLibrariesDependencyInjectionRegistration
    {
        public static IServiceCollection AddExternalLibrariesServices(this IServiceCollection services, AppSettingsConfiguration appSettings)
        {
            // Register services, etc.
            services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(appSettings.Redis.RedisConnectionString));


            return services;
        }
    }
}
