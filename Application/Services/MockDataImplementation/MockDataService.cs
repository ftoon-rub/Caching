using Core;
using Newtonsoft.Json;

namespace Application
{
    public class MockDataService : IMockDataService
    {
        public List<User> GetUsers()
        {
            string jsonFilePath = AppDomain.CurrentDomain.BaseDirectory + "MockData\\MOCK_DATA.json";
            string jsonString = File.ReadAllText(jsonFilePath);

            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonString);
            return users;
        }
    }
}
