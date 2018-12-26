using System;
using System.Windows.Forms;
using DocumentConverterForms.Data;
using DocumentConverterForms.Models;

namespace DocumentConverterForms.Forms
{
    public partial class ManageProfileForm : Form
    {
        public ManageProfileForm()
        {
            InitializeComponent();
        }

        private void ManageProfileForm_Load(object sender, EventArgs e)
        {
            profilesBindingSource.DataSource = ProfilesRepository.Profiles;       
            lbProfiles.DisplayMember = "Name";
            lbProfiles.DataSource = profilesBindingSource;
        }

        private void bAddNewProfile_Click(object sender, EventArgs e)
        {
            try
            {
                ProfilesRepository.AddNewProfile(tbNewProfileName.Text);
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
                ProfilesRepository.EditProfileName(profile, newProfileName);
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
                ProfilesRepository.RemoveProfile(lbProfiles.SelectedItem as Profile);
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