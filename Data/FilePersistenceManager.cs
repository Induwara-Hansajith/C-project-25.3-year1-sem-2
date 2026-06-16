using System.IO;
using System.Text.Json;

namespace TempleManagementSystem.Data
{
    public static class FilePersistenceManager
    {
        public static void Save<T>(string filePath, T data)
        {
            string json = JsonSerializer.Serialize(data,
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filePath, json);
        }

        public static T Load<T>(string filePath)
        {
            if (!File.Exists(filePath))
                return default;

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
