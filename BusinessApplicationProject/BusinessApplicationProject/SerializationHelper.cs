using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

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
    }
}
