using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentConverterForms.Xml;

namespace DocumentConverterForms.Forms
{
    public partial class ManageProfileForm : Form
    {
        private void RemoveProfile(Profile profile)
        {
            if (profile == null)
                throw new NullReferenceException("Profile is null");

            var xmlFilePath = Path.Combine(Properties.Settings.Default.XmlFilePath, $"{profile.Name}Profile.xml");
            XmlFileIO.DeleteXmlFile(xmlFilePath);
            StaticData.Profiles.Remove(profile);
        }

        private void AddNewProfile(string profileName)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("String is null or empty");

            if (StaticData.Profiles.Any(p => p.Name == profileName))
                throw new Exception("Name is not unique");

            var profile = new Profile()
            {
                Name = profileName,
                ExcelParseSettings = new ExcelParseSettings()
                {
                    ParseExceptions = new BindingList<string>() { "ВСЬОГО", "РАЗОМ" },
                    SemesterSettings = new BindingList<SemesterSettings>()
                },
                FileConversionSettings = new FileConversionSettings()
            };
            StaticData.Profiles.Add(profile);

            var xmlString = XmlDataSerializer.Serialize(profile);
            var xmlFilePath = Path.Combine(Properties.Settings.Default.XmlFilePath, $"{profile.Name}Profile.xml");
            XmlFileIO.WriteXmlFile(xmlString, xmlFilePath);
        }

        private void EditProfileName(Profile profile, string newProfileName)
        {
            if (profile == null)
                throw new NullReferenceException("Profile is null");

            if (string.IsNullOrWhiteSpace(newProfileName))
                throw new ArgumentException("String is null or empty");

            if (StaticData.Profiles.Any(p => p.Name == newProfileName))
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

        public ManageProfileForm()
        {
            InitializeComponent();
        }

        private void ManageProfileForm_Load(object sender, EventArgs e)
        {
            profilesBindingSource.DataSource = StaticData.Profiles;       
            lbProfiles.DisplayMember = "Name";
            lbProfiles.DataSource = profilesBindingSource;
        }

        private void bAddNewProfile_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewProfile(tbNewProfileName.Text);
                tbNewProfileName.Clear();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Укажите имя профиля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Имя должно быть уникальным!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void bEditProfileName_Click(object sender, EventArgs e)
        {
            try
            {
                var profile = lbProfiles.SelectedItem as Profile;
                var newProfileName = tbEditProfileName.Text;
                EditProfileName(profile, newProfileName);
                tbEditProfileName.Clear();
                profilesBindingSource.ResetBindings(true);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Профиль не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Имя не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show("Имя должно быть уникальным", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bRemoveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveProfile(lbProfiles.SelectedItem as Profile);
                tbEditProfileName.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Профиль не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void lbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProfiles.SelectedItem != null)
                tbEditProfileName.Text = (lbProfiles.SelectedItem as Profile).Name;
        }
    }
}
