using System.IO;

namespace DocumentConverterForms.Xml
{
    public static class XmlFileIO
    {
        public static void WriteXmlFile(string xmlData, string filePath)
        {
            File.Delete(filePath);

            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine(xmlData);
                writer.Close();
            }
        }

        public static void DeleteXmlFile(string filePath)
        {
            File.Delete(filePath);
        }

        public static string ReadXmlFile(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                var result = reader.ReadToEnd();
                return result;
            }
        }
    }
}