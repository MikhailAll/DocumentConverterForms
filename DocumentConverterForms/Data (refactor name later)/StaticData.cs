using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentConverterForms.Xml;

namespace DocumentConverterForms
{
    static class StaticData
    {
        public static BindingList<Profile> Profiles { get; set; } = new BindingList<Profile>();
        
        public static void InitializeAppData()
        {
            var xmlDataPath = Properties.Settings.Default.XmlFilePath;
            if (!string.IsNullOrEmpty(xmlDataPath))
            {
                var xmlFiles = Directory.EnumerateFiles(xmlDataPath, "*.xml");

                foreach (var file in xmlFiles)
                {
                    var xmlData = XmlFileIO.ReadXmlFile(file);
                    Profiles.Add(XmlDataSerializer.Deserialize<Profile>(xmlData));
                }
            }
        }
    }
}
