using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DocumentConverterForms.Xml;

namespace DocumentConverterForms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void Test()
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StaticData.InitializeAppData();

            dgvProfiles.AutoGenerateColumns = false;
            dgvProfiles.Columns["cProfileName"].DataPropertyName = "Name";
            dgvProfiles.DataSource = profilesBindingSource;

            profilesBindingSource.ListChanged += RecolorGrid;
            profilesBindingSource.DataSource = StaticData.Profiles;

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

        public string GetFilePath()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                var filePath = "";
                openFileDialog.Filter = @"Excel файлы (*.xls, *.xlsx) | *.xls; *.xlsx;";
                openFileDialog.Title = @"Выберите файл для конвертации";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }

                return filePath;
            }
        }

        private void bSelectFilePreview_Click(object sender, EventArgs e)
        {
            try
            {
                var filePath = GetFilePath();
                if (string.IsNullOrEmpty(filePath))
                    return;
                var outputFolderPath = Properties.Settings.Default.OutputFilePath;
                if (string.IsNullOrWhiteSpace(outputFolderPath))
                    throw new ApplicationException("OutputFolderPath is null or empty");

                var dataProvider = new ExcelDataProvider(filePath);
                var profile = dgvProfiles.CurrentRow.DataBoundItem as Profile;
                var subjects = new DataConverter(profile, dataProvider.LoadData(profile))
                    .Convert();

                using (var previewDataForm = new PreviewDataForm(filePath, profile, subjects))
                {
                    previewDataForm.ShowDialog();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Профиль не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (ApplicationException)
            {
                MessageBox.Show("Путь для конвертированных файлов не установлен", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void profilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var profileSettingsForm = new ProfileSettingsForm())
            {
                profileSettingsForm.ShowDialog();
            }
        }

        private void bSelectFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var folderPath = "";
                var outputFolderPath = Properties.Settings.Default.OutputFilePath;
                if (string.IsNullOrWhiteSpace(outputFolderPath))
                    throw new ApplicationException("OutputFolderPath is null or empty");

                using (var selectFolderForm = new FolderBrowserDialog())
                {
                    if (selectFolderForm.ShowDialog() == DialogResult.OK)
                        folderPath = selectFolderForm.SelectedPath;
                }

                if (string.IsNullOrEmpty(folderPath)) return;

                var excelFiles = Directory.EnumerateFiles(folderPath);

                foreach (var file in excelFiles)
                {
                    try
                    {
                        var excelReadDataProvider = new ExcelDataProvider(Path.Combine(folderPath, file));

                        foreach (var profile in StaticData.Profiles)
                        {

                            if (excelReadDataProvider.IsProfileMatch(profile))
                            {
                                var subjects = new DataConverter(profile, excelReadDataProvider.LoadData(profile))
                                    .Convert();
                                File.Copy(Path.Combine(folderPath, file),
                                    Path.Combine(outputFolderPath, $"(Converted){file}"));
                                var excelWriteDataProvider =
                                    new ExcelDataProvider(Path.Combine(outputFolderPath, $"(Converted){file}"));
                                excelWriteDataProvider.SaveData(profile, subjects);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                
                if (excelFiles.Count() == 0)
                    MessageBox.Show("В папке не найдены excel файлы", "Инфо", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            
            catch (ApplicationException)
            {
                MessageBox.Show("Путь для конвертированных файлов не установлен", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var applicationSettingsForm = new ApplicationSettingsForm())
            {
                applicationSettingsForm.ShowDialog();
            }

            if (StaticData.Profiles.Count == 0)
            {
                StaticData.InitializeAppData();
                profilesBindingSource.ResetBindings(true);
            }
        }
    }
}
