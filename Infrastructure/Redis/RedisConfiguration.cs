using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace Infrastructure
{
    public class RedisConfiguration
    {
        private readonly IConfiguration _configuration;

        public RedisConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureRedisServices(IServiceCollection services)
        {
            string redisConnectionString = _configuration.GetConnectionString("RedisConnection");
            services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(redisConnectionString));
        }
    }
}
