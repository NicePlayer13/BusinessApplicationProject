using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BusinessApplicationProject.Helpers
{
    /// <summary>
    /// Provides helper methods for serializing and deserializing objects to and from JSON and XML formats.
    /// </summary>
    public static class SerializationHelper
    {
        /// <summary>
        /// Serializes a list of objects to a JSON file.
        /// </summary>
        /// <typeparam name="T">Type of the objects in the list.</typeparam>
        /// <param name="data">The list of objects to serialize.</param>
        /// <param name="filePath">The file path to save the JSON content.</param>
        /// <param name="preserveReferences">Indicates whether to preserve object references during serialization.</param>
        public static void SerializeToJson<T>(List<T> data, string filePath, bool preserveReferences = false)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = preserveReferences ? ReferenceHandler.Preserve : ReferenceHandler.IgnoreCycles
            };

            string json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filePath, json);
        }

        /// <summary>
        /// Deserializes a list of objects from a JSON file.
        /// </summary>
        /// <typeparam name="T">Type of the objects to deserialize.</typeparam>
        /// <param name="filePath">The file path of the JSON file.</param>
        /// <param name="preserveReferences">Indicates whether to preserve object references during deserialization.</param>
        /// <returns>Deserialized list of objects.</returns>
        public static List<T> DeserializeFromJson<T>(string filePath, bool preserveReferences = false)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = preserveReferences ? ReferenceHandler.Preserve : ReferenceHandler.IgnoreCycles
            };

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<T>>(json, options) ?? new List<T>();
        }

        /// <summary>
        /// Serializes a list of objects to an XML file.
        /// </summary>
        /// <typeparam name="T">Type of the objects in the list.</typeparam>
        /// <param name="data">The list of objects to serialize.</param>
        /// <param name="filePath">The file path to save the XML content.</param>
        public static void SerializeToXml<T>(List<T> data, string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<T>));
            using var stream = new FileStream(filePath, FileMode.Create);
            serializer.Serialize(stream, data);
        }

        /// <summary>
        /// Deserializes a list of objects from an XML file.
        /// </summary>
        /// <typeparam name="T">Type of the objects to deserialize.</typeparam>
        /// <param name="filePath">The file path of the XML file.</param>
        /// <returns>Deserialized list of objects.</returns>
        public static List<T> DeserializeFromXml<T>(string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<T>));
            using var stream = new FileStream(filePath, FileMode.Open);
            return (List<T>)serializer.Deserialize(stream)!;
        }
    }
}