using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace BusinessApplicationProject.Helpers
{
    public static class SerializationHelper
    {
        public static void SerializeToXml<T>(List<T> data, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using FileStream fs = new FileStream(filePath, FileMode.Create);
            serializer.Serialize(fs, data);
        }

        public static List<T> DeserializeFromXml<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using FileStream fs = new FileStream(filePath, FileMode.Open);
            return (List<T>)serializer.Deserialize(fs);
        }


        public static void SerializeToJson<T>(List<T> data, string filePath, bool indented = true)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = indented,
                PropertyNameCaseInsensitive = true
            };

            using FileStream fs = new FileStream(filePath, FileMode.Create);
            JsonSerializer.Serialize(fs, data, options);
        }

        public static List<T> DeserializeFromJson<T>(string filePath)
        {
            using FileStream fs = new FileStream(filePath, FileMode.Open);
            return JsonSerializer.Deserialize<List<T>>(fs) ?? new List<T>();
        }
    }
}
