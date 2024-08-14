namespace Core
{
    public interface IRedisCacheService
    {
        Task SetAsync(string key, string value, TimeSpan? expiry = null);
        Task<string> GetAsync(string key);
        Task<bool> KeyExistsAsync(string key);
        Task DeleteAsync(string key);
    }
}
