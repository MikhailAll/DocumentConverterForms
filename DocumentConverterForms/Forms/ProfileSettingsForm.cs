using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DocumentConverterForms.Data;
using DocumentConverterForms.Models;

namespace DocumentConverterForms.Forms
{
    public partial class ProfileSettingsForm : Form
    {
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
            profilesBindingSource.DataSource = ProfilesRepository.Profiles;

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
            tbTotalClassroomHours.DataBindings.Add("Text", profilesBindingSource,
                "ExcelParseSettings.TotalClassroomHours");
            tbLectures.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.Lectures");
            tbPracticalWorks.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.PracticalWorks");
            tbLaboratoryWorks.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.LaboratoryWorks");
            tbConsultation.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.Consultation");
            tbSelfEducation.DataBindings.Add("Text", profilesBindingSource, "ExcelParseSettings.SelfEducation");
        }

        private void RecolorGrid(object sender, ListChangedEventArgs e)
        {
            for (var i = 0; i < profilesBindingSource.Count; i++)
            {
                var profile = profilesBindingSource[i] as Profile;
                if (string.IsNullOrEmpty(profile.ProfileKey))
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
                ProfilesRepository.AddException(profile, exception);
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
                MessageBox.Show("Данное исключение уже добавленно!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void bRemoveException_Click(object sender, EventArgs e)
        {
            try
            {
                var profile = profilesBindingSource.Current as Profile;
                var exception = lbExceptions.SelectedItem.ToString();
                ProfilesRepository.RemoveException(profile, exception);
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
                ProfilesRepository.SaveProfileSettings(dgvProfiles.CurrentRow.DataBoundItem as Profile);
        }

        private void dgvProfiles_SelectionChanged(object sender, EventArgs e)
        {
            if (profilesBindingSource.Current is Profile profile)
            {
                lbExceptions.DataSource = profile.ExcelParseSettings.ParseExceptions;
                lbSemesters.DataSource = profile.ExcelParseSettings.SemesterSettings;
                nudSemesterNumber.DataBindings.Clear();
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
                ProfilesRepository.AddSemester(profile, semesterSettings);

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
                ProfilesRepository.RemoveSemester(profile, semesterSettings);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Профиль или настройки семестра не выбраны!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}