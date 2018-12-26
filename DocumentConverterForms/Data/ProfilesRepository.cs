using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using DocumentConverterForms.Models;
using DocumentConverterForms.Xml;

namespace DocumentConverterForms.Data
{
    public static class ProfilesRepository
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

        public static void RemoveProfile(Profile profile)
        {
            if (profile == null)
                throw new NullReferenceException("Profile is null");

            var xmlFilePath = Path.Combine(Properties.Settings.Default.XmlFilePath, $"{profile.Name}Profile.xml");
            XmlFileIO.DeleteXmlFile(xmlFilePath);
            Profiles.Remove(profile);
        }

        public static void AddNewProfile(string profileName)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("String is null or empty");

            if (Profiles.Any(p => p.Name == profileName))
                throw new Exception("Name is not unique");

            var profile = new Profile
            {
                Name = profileName,
                ExcelParseSettings = new ExcelParseSettings
                {
                    ParseExceptions = new BindingList<string> {"ВСЬОГО", "РАЗОМ"},
                    SemesterSettings = new BindingList<SemesterSettings>()
                },
                FileConversionSettings = new FileConversionSettings()
            };
            Profiles.Add(profile);

            var xmlString = XmlDataSerializer.Serialize(profile);
            var xmlFilePath = Path.Combine(Properties.Settings.Default.XmlFilePath, $"{profile.Name}Profile.xml");
            XmlFileIO.WriteXmlFile(xmlString, xmlFilePath);
        }

        public static void EditProfileName(Profile profile, string newProfileName)
        {
            if (profile == null)
                throw new NullReferenceException("Profile is null");

            if (string.IsNullOrWhiteSpace(newProfileName))
                throw new ArgumentException("String is null or empty");

            if (Profiles.Any(p => p.Name == newProfileName))
                throw new Exception("Name is not unique");

            var oldXmlFilePath =
                Path.Combine(Properties.Settings.Default.XmlFilePath, $"{profile.Name}Profile.xml");
            var newXmlFilePath =
                Path.Combine(Properties.Settings.Default.XmlFilePath, $"{newProfileName}Profile.xml");
            profile.Name = newProfileName;
            var xmlString = XmlDataSerializer.Serialize(profile);

            XmlFileIO.DeleteXmlFile(oldXmlFilePath);
            XmlFileIO.WriteXmlFile(xmlString, newXmlFilePath);
        }

        public static void SaveProfileSettings(Profile profile)
        {
            var xmlFilePath =
                Path.Combine(Properties.Settings.Default.XmlFilePath, $"{profile.Name}Profile.xml");
            var xmlString = XmlDataSerializer.Serialize(profile);

            XmlFileIO.DeleteXmlFile(xmlFilePath);
            XmlFileIO.WriteXmlFile(xmlString, xmlFilePath);
        }

        public static void RemoveException(Profile profile, string exception)
        {
            if (profile == null)
                throw new NullReferenceException("Profile is null");
            if (string.IsNullOrWhiteSpace(exception))
                throw new ArgumentException("String is null or empty");

            profile.ExcelParseSettings.ParseExceptions.Remove(exception);
        }

        public static void AddException(Profile profile, string exception)
        {
            if (profile == null)
                throw new NullReferenceException("Profile is null");
            if (string.IsNullOrWhiteSpace(exception))
                throw new ArgumentException("String is null or empty");
            if (profile.ExcelParseSettings.ParseExceptions.Any(e => e == exception))
                throw new Exception("Exception is not unique");

            profile.ExcelParseSettings.ParseExceptions.Add(exception);
        }

        public static void AddSemester(Profile profile, SemesterSettings semesterSettings)
        {
            if (profile == null || semesterSettings == null)
                throw new NullReferenceException("Profile or semesterSettings is null");
            if (semesterSettings.SemesterNumber == 0 ||
                string.IsNullOrWhiteSpace(semesterSettings.LaboratoryWorks) ||
                string.IsNullOrWhiteSpace(semesterSettings.Lectures) ||
                string.IsNullOrWhiteSpace(semesterSettings.PracticalWorks))
                throw new ArgumentException("Semester data is not correct");

            profile.ExcelParseSettings.SemesterSettings.Add(semesterSettings);
        }

        public static void RemoveSemester(Profile profile, SemesterSettings semesterSettings)
        {
            if (profile == null || semesterSettings == null)
                throw new NullReferenceException("Profile or semesterSettings is null");

            profile.ExcelParseSettings.SemesterSettings.Remove(semesterSettings);
        }
    }
}
