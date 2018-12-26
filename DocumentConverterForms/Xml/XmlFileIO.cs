using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DocumentConverterForms.Xml
{
    static class XmlFileIO
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
            var result = "";

            using (var reader = new StreamReader(filePath))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }
    }
}
