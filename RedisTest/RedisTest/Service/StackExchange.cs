using RedisTest.IService;
using StackExchange.Redis;

namespace RedisTest.Service
{
    public class StackExchange<T> : IStackExchange<T> where T : class
    {
        private string connectServer = "localhost:6379";

        public string GetByValue(string T)
        {
            IDatabase db = Connect();

            return db.StringGet(T);
        }

        public void DeleteValue(string T)
        {
            IDatabase db = Connect();

            db.KeyDelete(T);
        }

        public void InsertValue(string value, string key)
        {
            IDatabase db = Connect();

            db.StringSet(value, key);
        }

        public IDatabase Connect()
        {
            ConfigurationOptions configurationOptions = new ConfigurationOptions();
            configurationOptions.EndPoints.Add(connectServer);

            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(configurationOptions); 

            return redis.GetDatabase();
        }
    }
}
