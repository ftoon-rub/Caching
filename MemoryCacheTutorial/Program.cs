// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Caching.Memory;

Console.WriteLine("Hello, World!");

// Create a MemoryCache instance
var memoryCache = new MemoryCache(new MemoryCacheOptions());

// Define a cache key
string cacheKey = "MyCacheKey";

// Set cache entry with an absolute expiration time
memoryCache.Set(cacheKey, "Cached data", TimeSpan.FromMinutes(5));

// Retrieve cache entry
if (memoryCache.TryGetValue(cacheKey, out string cachedValue))
{
    Console.WriteLine($"Cache hit: {cachedValue}");
}
else
{
    Console.WriteLine("Cache miss");
}

// Update cache entry
memoryCache.Set(cacheKey, "Updated cached data");

// Retrieve updated cache entry
if (memoryCache.TryGetValue(cacheKey, out cachedValue))
{
    Console.WriteLine($"Updated cache hit: {cachedValue}");
}

// Remove cache entry
memoryCache.Remove(cacheKey);

// Try to retrieve after removal
if (memoryCache.TryGetValue(cacheKey, out cachedValue))
{
    Console.WriteLine($"Cache hit: {cachedValue}");
}
else
{
    Console.WriteLine("Cache miss after removal");
}

Console.ReadLine();
