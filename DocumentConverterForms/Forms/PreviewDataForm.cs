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
    public partial class PreviewDataForm : Form
    {
        private BindingList<Subject> _subjects;
        private Profile _profile;
        private string _fileName;

        public PreviewDataForm()
        {
            InitializeComponent();
        }

        public PreviewDataForm(string fileName, Profile profile, List<Subject> subjects) : this()
        {
            _fileName = fileName;
            _profile = profile;
            _subjects = new BindingList<Subject>(subjects);
        }

        private void bSaveData_Click(object sender, EventArgs e)
        {
            var outputFilePath =
                Path.Combine(Properties.Settings.Default.OutputFilePath, $"(Converted) {Path.GetFileName(_fileName)}");
            File.Copy(_fileName, outputFilePath);
            var saveProvider = new ExcelDataProvider(outputFilePath);
            saveProvider.SaveData(_profile, _subjects.ToList());

            var xmlString = XmlDataSerializer.Serialize(_profile);
            XmlFileIO.WriteXmlFile(xmlString,
                Path.Combine(Properties.Settings.Default.XmlFilePath, $"{_profile.Name}Profile.xml"));
            Close();
        }

        private void dgvPreviewSubjectsData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPreviewSemesterData.DataSource = (dgvPreviewSubjectsData.CurrentRow.DataBoundItem as Subject).Semesters;
        }

        private void PreviewDataForm_Load(object sender, EventArgs e)
        {
            dgvPreviewSubjectsData.DataSource = _subjects;
        }
    }
}
