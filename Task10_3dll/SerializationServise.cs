using System;
using System.IO;
using System.Text.Json;
using Task10_1dll;

namespace Task10_3dll
{
    static class SerializationServise
    {
        const string path = @"D:\Task10";
        const string fullPath = @"D:\Task10\Task10_3.json";
        public static void Save(Author author)
        {
            string authorSer = JsonSerializer.Serialize<Author>(author);

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            using (FileStream stream = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                Utf8JsonWriter writer = new Utf8JsonWriter(stream);
                JsonSerializer.Serialize<Author>(writer, author);
            }
        }
        public static void Load()
        {
            string jsonString = File.ReadAllText(fullPath);
            Author AuthorFromJson = JsonSerializer.Deserialize<Author>(jsonString);
            Console.WriteLine($"{AuthorFromJson.FirstName} {AuthorFromJson.LastName}");
        }
    }
}
