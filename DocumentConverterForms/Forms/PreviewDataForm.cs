﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DocumentConverterForms.Data;
using DocumentConverterForms.ExcelData;
using DocumentConverterForms.Models;

namespace DocumentConverterForms.Forms
{
    public partial class PreviewDataForm : Form
    {
        private readonly BindingList<Subject> _subjects;
        private readonly Profile _profile;
        private readonly string _fileName;

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
            File.Delete(outputFilePath);
            File.Copy(_fileName, outputFilePath);
            var saveProvider = new ExcelDataProvider(outputFilePath);
            saveProvider.SaveData(_profile, _subjects.ToList());

            ProfilesRepository.SaveProfileSettings(_profile);
            Close();
        }

        private void PreviewDataForm_Load(object sender, EventArgs e)
        {
            dgvPreviewSubjectsData.DataSource = _subjects;
        }

        private void dgvPreviewSubjectsData_SelectionChanged(object sender, EventArgs e)
        {
            dgvPreviewSemesterData.DataSource = (dgvPreviewSubjectsData.CurrentRow.DataBoundItem as Subject).Semesters;
        }
    }
}