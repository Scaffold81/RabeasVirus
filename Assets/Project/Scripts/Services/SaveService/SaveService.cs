using Game.Common;
using Zenject;

namespace Game.Services
{
    public class SaveService : ISaveService
    {
        private SaveSystem saveSystem;

        [Inject]
        void Construct()
        {
            saveSystem = new SaveSystem();
        }

        public void Save(string key, string value) => saveSystem.SaveData(key, value);

        public string Load(string key) => saveSystem.LoadData(key);

        public T LoadJson<T>(string key) => saveSystem.LoadJSON<T>(key);
       
        public void SaveJson(string key,object data) => saveSystem.SaveJSON(key,data);
    }

    public interface ISaveService
    {
        string Load(string key);
        T LoadJson<T>(string key);
        void Save(string key, string value);
        void SaveJson(string key, object data);
    }
}