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
    public partial class ProfileSettingsForm : Form
    {
        private void SaveProfileSettings(Profile profile)
        {
            var xmlFilePath =
                Path.Combine(Properties.Settings.Default.XmlFilePath, $"{profile.Name}Profile.xml");
            var xmlString = XmlDataSerializer.Serialize(profile);

            XmlFileIO.DeleteXmlFile(xmlFilePath);
            XmlFileIO.WriteXmlFile(xmlString, xmlFilePath);
        }

        private void RemoveException(Profile profile, string exception)
        {
            if (profile == null)
                throw new NullReferenceException("Profile is null");
            if (string.IsNullOrWhiteSpace(exception))
                throw new ArgumentException("String is null or empty");

            profile.ExcelParseSettings.ParseExceptions.Remove(exception);
        }

        private void AddException(Profile profile, string exception)
        {
            if (profile == null)
                throw new NullReferenceException("Profile is null");
            if (string.IsNullOrWhiteSpace(exception))
                throw new ArgumentException("String is null or empty");
            if (profile.ExcelParseSettings.ParseExceptions.Any(e => e == exception))
                throw new Exception("Exception is not unique");

            profile.ExcelParseSettings.ParseExceptions.Add(exception);

        }

        private void AddSemester(Profile profile, SemesterSettings semesterSettings)
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

        private void RemoveSemester(Profile profile, SemesterSettings semesterSettings)
        {
            if (profile == null || semesterSettings == null)
                throw new NullReferenceException("Profile or semesterSettings is null");

            profile.ExcelParseSettings.SemesterSettings.Remove(semesterSettings);
        }

        public ProfileSettingsForm()
        {
            InitializeComponent();
        }

        private void ProfileSettingsForm_Load(object sender, EventArgs e)
        {
            dgvProfiles.AutoGenerateColumns = false;
            dgvProfiles.Columns["cProfileName"].DataPropertyName = "Name";
            dgvProfiles.DataSource = profilesBindingSource;
            lbSemesters.DisplayMember = "SemesterNumber";

            profilesBindingSource.ListChanged += RecolorGrid;
            profilesBindingSource.DataSource = StaticData.Profiles;

            nudMinLecturesCount.DataBindings.Add("Value", profilesBindingSource,
                "FileConversionSettings.MinLecturesCount");
            nudMinPracticalWorksCount.DataBindings.Add("Value", profilesBindingSource,
                "FileConversionSettings.MinPracticalWorksCount");

            tbProfileKey.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.ProfileKey");
            nudSheetNumber.DataBindings.Add("Value", profilesBindingSource, "ExcelParseSettings.SheetNumber");

            tbSubjectName.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.SubjectName");
            tbCredit.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.Credit");
            tbExam.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.Exam");
            tbCW.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.CW");
            tbECTS.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.ECTS");
            tbTotalHours.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.TotalHours");
            tbTotalClassroomHours.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.TotalClassroomHours");
            tbLectures.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.Lectures");
            tbPracticalWorks.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.PracticalWorks");
            tbLaboratoryWorks.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.LaboratoryWorks");
            tbConsultation.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.Consultation");
            tbSelfEducation.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.SelfEducation");
        }

        private void RecolorGrid(object sender, ListChangedEventArgs e)
        {
            for (int i = 0; i < profilesBindingSource.Count; i++)
            {
                var profile = profilesBindingSource[i] as Profile;
                if (profile.ProfileKey == 0)
                    dgvProfiles[0, i].Style.ForeColor = Color.Red;
            }
        }

        private void bManageProfiles_Click(object sender, EventArgs e)
        {
            using (var manageProfilesForm = new ManageProfileForm())
            {
                manageProfilesForm.ShowDialog();
            }
        }

        private void bAddException_Click(object sender, EventArgs e)
        {
            try
            {
                var profile = profilesBindingSource.Current as Profile;
                var exception = tbException.Text;
                AddException(profile, exception);
                tbException.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Профиль не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Введите исключение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Данное исключение уже добавленно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bRemoveException_Click(object sender, EventArgs e)
        {
            try
            {
                var profile = profilesBindingSource.Current as Profile;
                var exception = lbExceptions.SelectedItem.ToString();
                RemoveException(profile, exception);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Профиль не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Исключение не выбрано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSaveSettings_Click(object sender, EventArgs e)
        {
            if (dgvProfiles.CurrentRow != null)
                SaveProfileSettings(dgvProfiles.CurrentRow.DataBoundItem as Profile);
        }

        private void dgvProfiles_SelectionChanged(object sender, EventArgs e)
        {
            if (profilesBindingSource.Current is Profile profile)
            {
                lbExceptions.DataSource = profile.ExcelParseSettings.ParseExceptions;
                lbSemesters.DataSource = profile.ExcelParseSettings.SemesterSettings; nudSemesterNumber.DataBindings.Clear();
            }
        }

        private void bAddSemester_Click(object sender, EventArgs e)
        {
            try
            {
                var profile = profilesBindingSource.Current as Profile;
                var semesterSettings = new SemesterSettings()
                {
                    SemesterNumber = (int) nudSemesterNumber.Value,
                    Lectures = tbSemesterLectures.Text,
                    LaboratoryWorks = tbSemesterLaboratoryWorks.Text,
                    PracticalWorks = tbSemesterPracticalWorks.Text,
                    Consultation = tbSemesterConsultation.Text
                };
                AddSemester(profile, semesterSettings);

                nudSemesterNumber.Value = 0;
                tbSemesterLectures.Clear();
                tbSemesterPracticalWorks.Clear();
                tbSemesterLaboratoryWorks.Clear();
                tbSemesterConsultation.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Профиль не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Данные некорректны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bRemoveSemester_Click(object sender, EventArgs e)
        {
            try
            {
                var profile = profilesBindingSource.Current as Profile;
                var semesterSettings = lbSemesters.SelectedItem as SemesterSettings;
                RemoveSemester(profile, semesterSettings);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Профиль или настройки семестра не выбраны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
