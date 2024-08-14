namespace Core.Configurations
{
    public class AppSettingsConfiguration
    {
        public Redis Redis { get; set; }
    }
    public class Redis
    {
        public string RedisConnectionString { get; set; }
    }
}
