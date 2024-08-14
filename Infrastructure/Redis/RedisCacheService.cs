using Core;
using StackExchange.Redis;

namespace Infrastructure
{
    public class RedisCacheService : IRedisCacheService
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;

        public RedisCacheService(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }

        private IDatabase Database => _connectionMultiplexer.GetDatabase();

        public async Task SetAsync(string key, string value, TimeSpan? expiry = null)
        {
            await Database.StringSetAsync(key, value, expiry);
        }

        public async Task<string> GetAsync(string key)
        {
            return await Database.StringGetAsync(key);
        }

        public async Task<bool> KeyExistsAsync(string key)
        {
            return await Database.KeyExistsAsync(key);
        }

        public async Task DeleteAsync(string key)
        {
            await Database.KeyDeleteAsync(key);
        }
    }
}
