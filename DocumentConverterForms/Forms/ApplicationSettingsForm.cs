﻿using System;
using System.Windows.Forms;

namespace DocumentConverterForms.Forms
{
    public partial class ApplicationSettingsForm : Form
    {
        public ApplicationSettingsForm()
        {
            InitializeComponent();
        }

        private void bOpenXmlFilesFolder_Click(object sender, EventArgs e)
        {
            using (var selectFolderForm = new FolderBrowserDialog())
            {
                if (selectFolderForm.ShowDialog() == DialogResult.OK)
                {
                    tbXmlFiles.Text = selectFolderForm.SelectedPath;
                }
            }
        }

        private void bOpenConvertedFilesFolder_Click(object sender, EventArgs e)
        {
            using (var selectFolderForm = new FolderBrowserDialog())
            {
                if (selectFolderForm.ShowDialog() == DialogResult.OK)
                {
                    tbConvertedFiles.Text = selectFolderForm.SelectedPath;
                }
            }
        }

        private void ApplicationSettings_Load(object sender, EventArgs e)
        {
            tbConvertedFiles.Text = Properties.Settings.Default.OutputFilePath;
            tbXmlFiles.Text = Properties.Settings.Default.XmlFilePath;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.XmlFilePath = tbXmlFiles.Text;
            Properties.Settings.Default.OutputFilePath = tbConvertedFiles.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}