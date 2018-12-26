using System.Xml.Serialization;

namespace DocumentConverterForms.Xml
{
    public static class XmlDataSerializer
    {
        public static string Serialize<T>(T dataToSerialize)
        {
            var stringWriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stringWriter, dataToSerialize);
            return stringWriter.ToString();
        }

        public static T Deserialize<T>(string xmlText)
        {
            var stringReader = new System.IO.StringReader(xmlText);
            var serializer = new XmlSerializer(typeof(T));
            return (T) serializer.Deserialize(stringReader);
        }
    }
}