using Microsoft.EntityFrameworkCore.Storage;

namespace RedisTest.IService
{
    public interface IStackExchange<T> where T : class
    {
        string GetByValue(string T);
        void InsertValue(string value, string key);
        void DeleteValue(string T); 
    }
}
