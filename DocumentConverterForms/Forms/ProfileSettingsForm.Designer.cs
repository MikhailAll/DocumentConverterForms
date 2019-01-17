namespace DocumentConverterForms.Forms
{
    partial class ProfileSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.settingsFormSplitter = new System.Windows.Forms.Splitter();
            this.bManageProfiles = new System.Windows.Forms.Button();
            this.lProfiles = new System.Windows.Forms.Label();
            this.gSubjects = new System.Windows.Forms.GroupBox();
            this.tbException = new System.Windows.Forms.TextBox();
            this.tbSelfEducation = new System.Windows.Forms.TextBox();
            this.lSelfEducation = new System.Windows.Forms.Label();
            this.bRemoveException = new System.Windows.Forms.Button();
            this.tbConsultation = new System.Windows.Forms.TextBox();
            this.lConsultation = new System.Windows.Forms.Label();
            this.bAddException = new System.Windows.Forms.Button();
            this.tbLaboratoryWorks = new System.Windows.Forms.TextBox();
            this.lExeptions = new System.Windows.Forms.Label();
            this.lLaboratoryWorks = new System.Windows.Forms.Label();
            this.lbExceptions = new System.Windows.Forms.ListBox();
            this.tbPracticalWorks = new System.Windows.Forms.TextBox();
            this.lPracticalWorks = new System.Windows.Forms.Label();
            this.tbLectures = new System.Windows.Forms.TextBox();
            this.lLections = new System.Windows.Forms.Label();
            this.tbTotalClassroomHours = new System.Windows.Forms.TextBox();
            this.lTotalClassRoomHours = new System.Windows.Forms.Label();
            this.tbTotalHours = new System.Windows.Forms.TextBox();
            this.lTotalHours = new System.Windows.Forms.Label();
            this.tbECTS = new System.Windows.Forms.TextBox();
            this.lECTS = new System.Windows.Forms.Label();
            this.tbCW = new System.Windows.Forms.TextBox();
            this.lCW = new System.Windows.Forms.Label();
            this.tbExam = new System.Windows.Forms.TextBox();
            this.lExam = new System.Windows.Forms.Label();
            this.tbCredit = new System.Windows.Forms.TextBox();
            this.lCredit = new System.Windows.Forms.Label();
            this.tbSubjectName = new System.Windows.Forms.TextBox();
            this.lSubjectName = new System.Windows.Forms.Label();
            this.gConvertation = new System.Windows.Forms.GroupBox();
            this.nudMinPracticalWorksCount = new System.Windows.Forms.NumericUpDown();
            this.nudMinLecturesCount = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbProfileKey = new System.Windows.Forms.TextBox();
            this.lProfileKey = new System.Windows.Forms.Label();
            this.profilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.cProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSaveSettings = new System.Windows.Forms.Button();
            this.lSheetNumber = new System.Windows.Forms.Label();
            this.nudSheetNumber = new System.Windows.Forms.NumericUpDown();
            this.gSemesters = new System.Windows.Forms.GroupBox();
            this.cbMaster = new System.Windows.Forms.CheckBox();
            this.lSemesterNumber = new System.Windows.Forms.Label();
            this.lSemesterConsultation = new System.Windows.Forms.Label();
            this.tbSemesterConsultation = new System.Windows.Forms.TextBox();
            this.nudSemesterNumber = new System.Windows.Forms.NumericUpDown();
            this.lSemesterLaboratoryWorks = new System.Windows.Forms.Label();
            this.lSemesterPracticalWorks = new System.Windows.Forms.Label();
            this.lSemesterLectures = new System.Windows.Forms.Label();
            this.bRemoveSemester = new System.Windows.Forms.Button();
            this.tbSemesterLaboratoryWorks = new System.Windows.Forms.TextBox();
            this.bAddSemester = new System.Windows.Forms.Button();
            this.lbSemesters = new System.Windows.Forms.ListBox();
            this.tbSemesterPracticalWorks = new System.Windows.Forms.TextBox();
            this.tbSemesterLectures = new System.Windows.Forms.TextBox();
            this.gSubjects.SuspendLayout();
            this.gConvertation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPracticalWorksCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLecturesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSheetNumber)).BeginInit();
            this.gSemesters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemesterNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsFormSplitter
            // 
            this.settingsFormSplitter.Location = new System.Drawing.Point(0, 0);
            this.settingsFormSplitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsFormSplitter.Name = "settingsFormSplitter";
            this.settingsFormSplitter.Size = new System.Drawing.Size(279, 659);
            this.settingsFormSplitter.TabIndex = 0;
            this.settingsFormSplitter.TabStop = false;
            // 
            // bManageProfiles
            // 
            this.bManageProfiles.Location = new System.Drawing.Point(12, 584);
            this.bManageProfiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bManageProfiles.Name = "bManageProfiles";
            this.bManageProfiles.Size = new System.Drawing.Size(256, 58);
            this.bManageProfiles.TabIndex = 2;
            this.bManageProfiles.Text = "Управление профилями";
            this.bManageProfiles.UseVisualStyleBackColor = true;
            this.bManageProfiles.Click += new System.EventHandler(this.bManageProfiles_Click);
            // 
            // lProfiles
            // 
            this.lProfiles.AutoSize = true;
            this.lProfiles.Location = new System.Drawing.Point(10, 14);
            this.lProfiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lProfiles.Name = "lProfiles";
            this.lProfiles.Size = new System.Drawing.Size(163, 20);
            this.lProfiles.TabIndex = 3;
            this.lProfiles.Text = "Выберите профиль:";
            // 
            // gSubjects
            // 
            this.gSubjects.Controls.Add(this.tbException);
            this.gSubjects.Controls.Add(this.tbSelfEducation);
            this.gSubjects.Controls.Add(this.lSelfEducation);
            this.gSubjects.Controls.Add(this.bRemoveException);
            this.gSubjects.Controls.Add(this.tbConsultation);
            this.gSubjects.Controls.Add(this.lConsultation);
            this.gSubjects.Controls.Add(this.bAddException);
            this.gSubjects.Controls.Add(this.tbLaboratoryWorks);
            this.gSubjects.Controls.Add(this.lExeptions);
            this.gSubjects.Controls.Add(this.lLaboratoryWorks);
            this.gSubjects.Controls.Add(this.lbExceptions);
            this.gSubjects.Controls.Add(this.tbPracticalWorks);
            this.gSubjects.Controls.Add(this.lPracticalWorks);
            this.gSubjects.Controls.Add(this.tbLectures);
            this.gSubjects.Controls.Add(this.lLections);
            this.gSubjects.Controls.Add(this.tbTotalClassroomHours);
            this.gSubjects.Controls.Add(this.lTotalClassRoomHours);
            this.gSubjects.Controls.Add(this.tbTotalHours);
            this.gSubjects.Controls.Add(this.lTotalHours);
            this.gSubjects.Controls.Add(this.tbECTS);
            this.gSubjects.Controls.Add(this.lECTS);
            this.gSubjects.Controls.Add(this.tbCW);
            this.gSubjects.Controls.Add(this.lCW);
            this.gSubjects.Controls.Add(this.tbExam);
            this.gSubjects.Controls.Add(this.lExam);
            this.gSubjects.Controls.Add(this.tbCredit);
            this.gSubjects.Controls.Add(this.lCredit);
            this.gSubjects.Controls.Add(this.tbSubjectName);
            this.gSubjects.Controls.Add(this.lSubjectName);
            this.gSubjects.Location = new System.Drawing.Point(290, 86);
            this.gSubjects.Name = "gSubjects";
            this.gSubjects.Size = new System.Drawing.Size(469, 567);
            this.gSubjects.TabIndex = 4;
            this.gSubjects.TabStop = false;
            this.gSubjects.Text = "Настройка столбцов ";
            // 
            // tbException
            // 
            this.tbException.Location = new System.Drawing.Point(278, 452);
            this.tbException.Name = "tbException";
            this.tbException.Size = new System.Drawing.Size(138, 26);
            this.tbException.TabIndex = 19;
            // 
            // tbSelfEducation
            // 
            this.tbSelfEducation.Location = new System.Drawing.Point(319, 379);
            this.tbSelfEducation.Name = "tbSelfEducation";
            this.tbSelfEducation.Size = new System.Drawing.Size(138, 26);
            this.tbSelfEducation.TabIndex = 18;
            // 
            // lSelfEducation
            // 
            this.lSelfEducation.AutoSize = true;
            this.lSelfEducation.Location = new System.Drawing.Point(7, 379);
            this.lSelfEducation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSelfEducation.Name = "lSelfEducation";
            this.lSelfEducation.Size = new System.Drawing.Size(274, 20);
            this.lSelfEducation.TabIndex = 0;
            this.lSelfEducation.Text = "Часы самостоятельного обучения:";
            // 
            // bRemoveException
            // 
            this.bRemoveException.Location = new System.Drawing.Point(278, 528);
            this.bRemoveException.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bRemoveException.Name = "bRemoveException";
            this.bRemoveException.Size = new System.Drawing.Size(138, 28);
            this.bRemoveException.TabIndex = 21;
            this.bRemoveException.Text = "Удалить";
            this.bRemoveException.UseVisualStyleBackColor = true;
            this.bRemoveException.Click += new System.EventHandler(this.bRemoveException_Click);
            // 
            // tbConsultation
            // 
            this.tbConsultation.Location = new System.Drawing.Point(319, 347);
            this.tbConsultation.Name = "tbConsultation";
            this.tbConsultation.Size = new System.Drawing.Size(138, 26);
            this.tbConsultation.TabIndex = 16;
            // 
            // lConsultation
            // 
            this.lConsultation.AutoSize = true;
            this.lConsultation.Location = new System.Drawing.Point(7, 347);
            this.lConsultation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lConsultation.Name = "lConsultation";
            this.lConsultation.Size = new System.Drawing.Size(120, 20);
            this.lConsultation.TabIndex = 0;
            this.lConsultation.Text = "Консультации:";
            // 
            // bAddException
            // 
            this.bAddException.Location = new System.Drawing.Point(278, 490);
            this.bAddException.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAddException.Name = "bAddException";
            this.bAddException.Size = new System.Drawing.Size(138, 28);
            this.bAddException.TabIndex = 20;
            this.bAddException.Text = "Добавить";
            this.bAddException.UseVisualStyleBackColor = true;
            this.bAddException.Click += new System.EventHandler(this.bAddException_Click);
            // 
            // tbLaboratoryWorks
            // 
            this.tbLaboratoryWorks.Location = new System.Drawing.Point(319, 315);
            this.tbLaboratoryWorks.Name = "tbLaboratoryWorks";
            this.tbLaboratoryWorks.Size = new System.Drawing.Size(138, 26);
            this.tbLaboratoryWorks.TabIndex = 15;
            // 
            // lExeptions
            // 
            this.lExeptions.AutoSize = true;
            this.lExeptions.Location = new System.Drawing.Point(12, 419);
            this.lExeptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lExeptions.Name = "lExeptions";
            this.lExeptions.Size = new System.Drawing.Size(107, 20);
            this.lExeptions.TabIndex = 0;
            this.lExeptions.Text = "Исключения:";
            // 
            // lLaboratoryWorks
            // 
            this.lLaboratoryWorks.AutoSize = true;
            this.lLaboratoryWorks.Location = new System.Drawing.Point(7, 315);
            this.lLaboratoryWorks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLaboratoryWorks.Name = "lLaboratoryWorks";
            this.lLaboratoryWorks.Size = new System.Drawing.Size(186, 20);
            this.lLaboratoryWorks.TabIndex = 0;
            this.lLaboratoryWorks.Text = "Лабораторные работы:";
            // 
            // lbExceptions
            // 
            this.lbExceptions.FormattingEnabled = true;
            this.lbExceptions.ItemHeight = 20;
            this.lbExceptions.Location = new System.Drawing.Point(16, 452);
            this.lbExceptions.Name = "lbExceptions";
            this.lbExceptions.Size = new System.Drawing.Size(255, 104);
            this.lbExceptions.TabIndex = 0;
            // 
            // tbPracticalWorks
            // 
            this.tbPracticalWorks.Location = new System.Drawing.Point(319, 283);
            this.tbPracticalWorks.Name = "tbPracticalWorks";
            this.tbPracticalWorks.Size = new System.Drawing.Size(138, 26);
            this.tbPracticalWorks.TabIndex = 14;
            // 
            // lPracticalWorks
            // 
            this.lPracticalWorks.AutoSize = true;
            this.lPracticalWorks.Location = new System.Drawing.Point(7, 283);
            this.lPracticalWorks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPracticalWorks.Name = "lPracticalWorks";
            this.lPracticalWorks.Size = new System.Drawing.Size(187, 20);
            this.lPracticalWorks.TabIndex = 0;
            this.lPracticalWorks.Text = "Практические занятия:";
            // 
            // tbLectures
            // 
            this.tbLectures.Location = new System.Drawing.Point(319, 251);
            this.tbLectures.Name = "tbLectures";
            this.tbLectures.Size = new System.Drawing.Size(138, 26);
            this.tbLectures.TabIndex = 13;
            // 
            // lLections
            // 
            this.lLections.AutoSize = true;
            this.lLections.Location = new System.Drawing.Point(7, 251);
            this.lLections.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLections.Name = "lLections";
            this.lLections.Size = new System.Drawing.Size(69, 20);
            this.lLections.TabIndex = 0;
            this.lLections.Text = "Лекции:";
            // 
            // tbTotalClassroomHours
            // 
            this.tbTotalClassroomHours.Location = new System.Drawing.Point(319, 219);
            this.tbTotalClassroomHours.Name = "tbTotalClassroomHours";
            this.tbTotalClassroomHours.Size = new System.Drawing.Size(138, 26);
            this.tbTotalClassroomHours.TabIndex = 12;
            // 
            // lTotalClassRoomHours
            // 
            this.lTotalClassRoomHours.AutoSize = true;
            this.lTotalClassRoomHours.Location = new System.Drawing.Point(7, 219);
            this.lTotalClassRoomHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTotalClassRoomHours.Name = "lTotalClassRoomHours";
            this.lTotalClassRoomHours.Size = new System.Drawing.Size(300, 20);
            this.lTotalClassRoomHours.TabIndex = 0;
            this.lTotalClassRoomHours.Text = "Общее количество аудиторных часов:";
            // 
            // tbTotalHours
            // 
            this.tbTotalHours.Location = new System.Drawing.Point(319, 187);
            this.tbTotalHours.Name = "tbTotalHours";
            this.tbTotalHours.Size = new System.Drawing.Size(138, 26);
            this.tbTotalHours.TabIndex = 11;
            // 
            // lTotalHours
            // 
            this.lTotalHours.AutoSize = true;
            this.lTotalHours.Location = new System.Drawing.Point(7, 187);
            this.lTotalHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTotalHours.Name = "lTotalHours";
            this.lTotalHours.Size = new System.Drawing.Size(206, 20);
            this.lTotalHours.TabIndex = 0;
            this.lTotalHours.Text = "Общее количество часов:";
            // 
            // tbECTS
            // 
            this.tbECTS.Location = new System.Drawing.Point(319, 155);
            this.tbECTS.Name = "tbECTS";
            this.tbECTS.Size = new System.Drawing.Size(138, 26);
            this.tbECTS.TabIndex = 10;
            // 
            // lECTS
            // 
            this.lECTS.AutoSize = true;
            this.lECTS.Location = new System.Drawing.Point(7, 155);
            this.lECTS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lECTS.Name = "lECTS";
            this.lECTS.Size = new System.Drawing.Size(81, 20);
            this.lECTS.TabIndex = 0;
            this.lECTS.Text = "Кредиты:";
            // 
            // tbCW
            // 
            this.tbCW.Location = new System.Drawing.Point(319, 123);
            this.tbCW.Name = "tbCW";
            this.tbCW.Size = new System.Drawing.Size(138, 26);
            this.tbCW.TabIndex = 9;
            // 
            // lCW
            // 
            this.lCW.AutoSize = true;
            this.lCW.Location = new System.Drawing.Point(7, 123);
            this.lCW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCW.Name = "lCW";
            this.lCW.Size = new System.Drawing.Size(248, 20);
            this.lCW.TabIndex = 0;
            this.lCW.Text = "Курсовое проектирование (КП):";
            // 
            // tbExam
            // 
            this.tbExam.Location = new System.Drawing.Point(319, 91);
            this.tbExam.Name = "tbExam";
            this.tbExam.Size = new System.Drawing.Size(138, 26);
            this.tbExam.TabIndex = 8;
            // 
            // lExam
            // 
            this.lExam.AutoSize = true;
            this.lExam.Location = new System.Drawing.Point(7, 91);
            this.lExam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lExam.Name = "lExam";
            this.lExam.Size = new System.Drawing.Size(90, 20);
            this.lExam.TabIndex = 0;
            this.lExam.Text = "Экзамены:";
            // 
            // tbCredit
            // 
            this.tbCredit.Location = new System.Drawing.Point(319, 59);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.Size = new System.Drawing.Size(138, 26);
            this.tbCredit.TabIndex = 6;
            // 
            // lCredit
            // 
            this.lCredit.AutoSize = true;
            this.lCredit.Location = new System.Drawing.Point(7, 59);
            this.lCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCredit.Name = "lCredit";
            this.lCredit.Size = new System.Drawing.Size(71, 20);
            this.lCredit.TabIndex = 0;
            this.lCredit.Text = "Зачеты:";
            // 
            // tbSubjectName
            // 
            this.tbSubjectName.Location = new System.Drawing.Point(319, 27);
            this.tbSubjectName.Name = "tbSubjectName";
            this.tbSubjectName.Size = new System.Drawing.Size(138, 26);
            this.tbSubjectName.TabIndex = 5;
            // 
            // lSubjectName
            // 
            this.lSubjectName.AutoSize = true;
            this.lSubjectName.Location = new System.Drawing.Point(7, 27);
            this.lSubjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSubjectName.Name = "lSubjectName";
            this.lSubjectName.Size = new System.Drawing.Size(224, 20);
            this.lSubjectName.TabIndex = 0;
            this.lSubjectName.Text = "Наименование дисциплины:";
            // 
            // gConvertation
            // 
            this.gConvertation.Controls.Add(this.nudMinPracticalWorksCount);
            this.gConvertation.Controls.Add(this.nudMinLecturesCount);
            this.gConvertation.Controls.Add(this.label17);
            this.gConvertation.Controls.Add(this.label18);
            this.gConvertation.Location = new System.Drawing.Point(765, 369);
            this.gConvertation.Name = "gConvertation";
            this.gConvertation.Size = new System.Drawing.Size(423, 128);
            this.gConvertation.TabIndex = 0;
            this.gConvertation.TabStop = false;
            this.gConvertation.Text = "Настройка конвертации";
            // 
            // nudMinPracticalWorksCount
            // 
            this.nudMinPracticalWorksCount.Location = new System.Drawing.Point(284, 78);
            this.nudMinPracticalWorksCount.Name = "nudMinPracticalWorksCount";
            this.nudMinPracticalWorksCount.Size = new System.Drawing.Size(138, 26);
            this.nudMinPracticalWorksCount.TabIndex = 30;
            // 
            // nudMinLecturesCount
            // 
            this.nudMinLecturesCount.Location = new System.Drawing.Point(284, 46);
            this.nudMinLecturesCount.Name = "nudMinLecturesCount";
            this.nudMinLecturesCount.Size = new System.Drawing.Size(138, 26);
            this.nudMinLecturesCount.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 80);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(233, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Минимальное количество пз:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 48);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(270, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Минимальное количество лекций:";
            // 
            // tbProfileKey
            // 
            this.tbProfileKey.Location = new System.Drawing.Point(609, 14);
            this.tbProfileKey.Name = "tbProfileKey";
            this.tbProfileKey.Size = new System.Drawing.Size(138, 26);
            this.tbProfileKey.TabIndex = 3;
            // 
            // lProfileKey
            // 
            this.lProfileKey.AutoSize = true;
            this.lProfileKey.Location = new System.Drawing.Point(297, 14);
            this.lProfileKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lProfileKey.Name = "lProfileKey";
            this.lProfileKey.Size = new System.Drawing.Size(128, 20);
            this.lProfileKey.TabIndex = 0;
            this.lProfileKey.Text = "Ключ профиля:";
            // 
            // dgvProfiles
            // 
            this.dgvProfiles.AllowUserToAddRows = false;
            this.dgvProfiles.AllowUserToDeleteRows = false;
            this.dgvProfiles.AllowUserToResizeColumns = false;
            this.dgvProfiles.AllowUserToResizeRows = false;
            this.dgvProfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cProfileName});
            this.dgvProfiles.Location = new System.Drawing.Point(12, 53);
            this.dgvProfiles.MultiSelect = false;
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.ReadOnly = true;
            this.dgvProfiles.RowHeadersVisible = false;
            this.dgvProfiles.Size = new System.Drawing.Size(256, 511);
            this.dgvProfiles.TabIndex = 1;
            this.dgvProfiles.Tag = "";
            this.dgvProfiles.SelectionChanged += new System.EventHandler(this.dgvProfiles_SelectionChanged);
            // 
            // cProfileName
            // 
            this.cProfileName.HeaderText = "Название профиля";
            this.cProfileName.Name = "cProfileName";
            this.cProfileName.ReadOnly = true;
            // 
            // bSaveSettings
            // 
            this.bSaveSettings.Location = new System.Drawing.Point(795, 584);
            this.bSaveSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSaveSettings.Name = "bSaveSettings";
            this.bSaveSettings.Size = new System.Drawing.Size(375, 58);
            this.bSaveSettings.TabIndex = 31;
            this.bSaveSettings.Text = "Сохранить настройки";
            this.bSaveSettings.UseVisualStyleBackColor = true;
            this.bSaveSettings.Click += new System.EventHandler(this.bSaveSettings_Click);
            // 
            // lSheetNumber
            // 
            this.lSheetNumber.AutoSize = true;
            this.lSheetNumber.Location = new System.Drawing.Point(297, 46);
            this.lSheetNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSheetNumber.Name = "lSheetNumber";
            this.lSheetNumber.Size = new System.Drawing.Size(185, 20);
            this.lSheetNumber.TabIndex = 0;
            this.lSheetNumber.Text = "Номер страницы (от 0):";
            // 
            // nudSheetNumber
            // 
            this.nudSheetNumber.Location = new System.Drawing.Point(609, 44);
            this.nudSheetNumber.Name = "nudSheetNumber";
            this.nudSheetNumber.Size = new System.Drawing.Size(138, 26);
            this.nudSheetNumber.TabIndex = 4;
            // 
            // gSemesters
            // 
            this.gSemesters.Controls.Add(this.lSemesterNumber);
            this.gSemesters.Controls.Add(this.lSemesterConsultation);
            this.gSemesters.Controls.Add(this.tbSemesterConsultation);
            this.gSemesters.Controls.Add(this.nudSemesterNumber);
            this.gSemesters.Controls.Add(this.lSemesterLaboratoryWorks);
            this.gSemesters.Controls.Add(this.lSemesterPracticalWorks);
            this.gSemesters.Controls.Add(this.lSemesterLectures);
            this.gSemesters.Controls.Add(this.bRemoveSemester);
            this.gSemesters.Controls.Add(this.tbSemesterLaboratoryWorks);
            this.gSemesters.Controls.Add(this.bAddSemester);
            this.gSemesters.Controls.Add(this.lbSemesters);
            this.gSemesters.Controls.Add(this.tbSemesterPracticalWorks);
            this.gSemesters.Controls.Add(this.tbSemesterLectures);
            this.gSemesters.Location = new System.Drawing.Point(765, 86);
            this.gSemesters.Name = "gSemesters";
            this.gSemesters.Size = new System.Drawing.Size(416, 277);
            this.gSemesters.TabIndex = 0;
            this.gSemesters.TabStop = false;
            this.gSemesters.Text = "Настройка столбцов семестров:";
            // 
            // cbMaster
            // 
            this.cbMaster.AutoSize = true;
            this.cbMaster.Location = new System.Drawing.Point(766, 16);
            this.cbMaster.Name = "cbMaster";
            this.cbMaster.Size = new System.Drawing.Size(92, 24);
            this.cbMaster.TabIndex = 29;
            this.cbMaster.Text = "Магистр";
            this.cbMaster.UseVisualStyleBackColor = true;
            // 
            // lSemesterNumber
            // 
            this.lSemesterNumber.AutoSize = true;
            this.lSemesterNumber.Location = new System.Drawing.Point(119, 27);
            this.lSemesterNumber.Name = "lSemesterNumber";
            this.lSemesterNumber.Size = new System.Drawing.Size(139, 20);
            this.lSemesterNumber.TabIndex = 0;
            this.lSemesterNumber.Text = "Номер семестра:";
            // 
            // lSemesterConsultation
            // 
            this.lSemesterConsultation.AutoSize = true;
            this.lSemesterConsultation.Location = new System.Drawing.Point(118, 155);
            this.lSemesterConsultation.Name = "lSemesterConsultation";
            this.lSemesterConsultation.Size = new System.Drawing.Size(120, 20);
            this.lSemesterConsultation.TabIndex = 0;
            this.lSemesterConsultation.Text = "Консультации:";
            // 
            // tbSemesterConsultation
            // 
            this.tbSemesterConsultation.Location = new System.Drawing.Point(267, 152);
            this.tbSemesterConsultation.Name = "tbSemesterConsultation";
            this.tbSemesterConsultation.Size = new System.Drawing.Size(138, 26);
            this.tbSemesterConsultation.TabIndex = 26;
            // 
            // nudSemesterNumber
            // 
            this.nudSemesterNumber.Location = new System.Drawing.Point(268, 25);
            this.nudSemesterNumber.Name = "nudSemesterNumber";
            this.nudSemesterNumber.Size = new System.Drawing.Size(137, 26);
            this.nudSemesterNumber.TabIndex = 22;
            // 
            // lSemesterLaboratoryWorks
            // 
            this.lSemesterLaboratoryWorks.AutoSize = true;
            this.lSemesterLaboratoryWorks.Location = new System.Drawing.Point(119, 123);
            this.lSemesterLaboratoryWorks.Name = "lSemesterLaboratoryWorks";
            this.lSemesterLaboratoryWorks.Size = new System.Drawing.Size(126, 20);
            this.lSemesterLaboratoryWorks.TabIndex = 0;
            this.lSemesterLaboratoryWorks.Text = "Лабораторные:";
            // 
            // lSemesterPracticalWorks
            // 
            this.lSemesterPracticalWorks.AutoSize = true;
            this.lSemesterPracticalWorks.Location = new System.Drawing.Point(119, 91);
            this.lSemesterPracticalWorks.Name = "lSemesterPracticalWorks";
            this.lSemesterPracticalWorks.Size = new System.Drawing.Size(121, 20);
            this.lSemesterPracticalWorks.TabIndex = 0;
            this.lSemesterPracticalWorks.Text = "Практические:";
            // 
            // lSemesterLectures
            // 
            this.lSemesterLectures.AutoSize = true;
            this.lSemesterLectures.Location = new System.Drawing.Point(119, 59);
            this.lSemesterLectures.Name = "lSemesterLectures";
            this.lSemesterLectures.Size = new System.Drawing.Size(69, 20);
            this.lSemesterLectures.TabIndex = 0;
            this.lSemesterLectures.Text = "Лекции:";
            // 
            // bRemoveSemester
            // 
            this.bRemoveSemester.Location = new System.Drawing.Point(267, 229);
            this.bRemoveSemester.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bRemoveSemester.Name = "bRemoveSemester";
            this.bRemoveSemester.Size = new System.Drawing.Size(138, 28);
            this.bRemoveSemester.TabIndex = 28;
            this.bRemoveSemester.Text = "Удалить";
            this.bRemoveSemester.UseVisualStyleBackColor = true;
            this.bRemoveSemester.Click += new System.EventHandler(this.bRemoveSemester_Click);
            // 
            // tbSemesterLaboratoryWorks
            // 
            this.tbSemesterLaboratoryWorks.Location = new System.Drawing.Point(268, 120);
            this.tbSemesterLaboratoryWorks.Name = "tbSemesterLaboratoryWorks";
            this.tbSemesterLaboratoryWorks.Size = new System.Drawing.Size(138, 26);
            this.tbSemesterLaboratoryWorks.TabIndex = 25;
            // 
            // bAddSemester
            // 
            this.bAddSemester.Location = new System.Drawing.Point(267, 191);
            this.bAddSemester.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAddSemester.Name = "bAddSemester";
            this.bAddSemester.Size = new System.Drawing.Size(138, 28);
            this.bAddSemester.TabIndex = 27;
            this.bAddSemester.Text = "Добавить";
            this.bAddSemester.UseVisualStyleBackColor = true;
            this.bAddSemester.Click += new System.EventHandler(this.bAddSemester_Click);
            // 
            // lbSemesters
            // 
            this.lbSemesters.FormattingEnabled = true;
            this.lbSemesters.ItemHeight = 20;
            this.lbSemesters.Location = new System.Drawing.Point(6, 22);
            this.lbSemesters.Name = "lbSemesters";
            this.lbSemesters.Size = new System.Drawing.Size(87, 124);
            this.lbSemesters.TabIndex = 0;
            // 
            // tbSemesterPracticalWorks
            // 
            this.tbSemesterPracticalWorks.Location = new System.Drawing.Point(268, 88);
            this.tbSemesterPracticalWorks.Name = "tbSemesterPracticalWorks";
            this.tbSemesterPracticalWorks.Size = new System.Drawing.Size(138, 26);
            this.tbSemesterPracticalWorks.TabIndex = 24;
            // 
            // tbSemesterLectures
            // 
            this.tbSemesterLectures.Location = new System.Drawing.Point(268, 56);
            this.tbSemesterLectures.Name = "tbSemesterLectures";
            this.tbSemesterLectures.Size = new System.Drawing.Size(138, 26);
            this.tbSemesterLectures.TabIndex = 23;
            // 
            // ProfileSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 659);
            this.Controls.Add(this.cbMaster);
            this.Controls.Add(this.gSemesters);
            this.Controls.Add(this.nudSheetNumber);
            this.Controls.Add(this.lSheetNumber);
            this.Controls.Add(this.bSaveSettings);
            this.Controls.Add(this.dgvProfiles);
            this.Controls.Add(this.tbProfileKey);
            this.Controls.Add(this.lProfileKey);
            this.Controls.Add(this.gConvertation);
            this.Controls.Add(this.gSubjects);
            this.Controls.Add(this.lProfiles);
            this.Controls.Add(this.bManageProfiles);
            this.Controls.Add(this.settingsFormSplitter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfileSettingsForm";
            this.Text = "Настройки профилей";
            this.Load += new System.EventHandler(this.ProfileSettingsForm_Load);
            this.gSubjects.ResumeLayout(false);
            this.gSubjects.PerformLayout();
            this.gConvertation.ResumeLayout(false);
            this.gConvertation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPracticalWorksCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLecturesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSheetNumber)).EndInit();
            this.gSemesters.ResumeLayout(false);
            this.gSemesters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemesterNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter settingsFormSplitter;
        private System.Windows.Forms.Button bManageProfiles;
        private System.Windows.Forms.Label lProfiles;
        private System.Windows.Forms.GroupBox gSubjects;
        private System.Windows.Forms.TextBox tbSelfEducation;
        private System.Windows.Forms.Label lSelfEducation;
        private System.Windows.Forms.TextBox tbConsultation;
        private System.Windows.Forms.Label lConsultation;
        private System.Windows.Forms.TextBox tbLaboratoryWorks;
        private System.Windows.Forms.Label lLaboratoryWorks;
        private System.Windows.Forms.TextBox tbPracticalWorks;
        private System.Windows.Forms.Label lPracticalWorks;
        private System.Windows.Forms.TextBox tbLectures;
        private System.Windows.Forms.Label lLections;
        private System.Windows.Forms.TextBox tbTotalClassroomHours;
        private System.Windows.Forms.Label lTotalClassRoomHours;
        private System.Windows.Forms.TextBox tbTotalHours;
        private System.Windows.Forms.Label lTotalHours;
        private System.Windows.Forms.TextBox tbECTS;
        private System.Windows.Forms.Label lECTS;
        private System.Windows.Forms.TextBox tbCW;
        private System.Windows.Forms.Label lCW;
        private System.Windows.Forms.TextBox tbExam;
        private System.Windows.Forms.Label lExam;
        private System.Windows.Forms.TextBox tbCredit;
        private System.Windows.Forms.Label lCredit;
        private System.Windows.Forms.TextBox tbSubjectName;
        private System.Windows.Forms.Label lSubjectName;
        private System.Windows.Forms.GroupBox gConvertation;
        private System.Windows.Forms.TextBox tbProfileKey;
        private System.Windows.Forms.Label lProfileKey;
        private System.Windows.Forms.BindingSource profilesBindingSource;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProfileName;
        private System.Windows.Forms.Button bSaveSettings;
        private System.Windows.Forms.Label lSheetNumber;
        private System.Windows.Forms.NumericUpDown nudSheetNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nudMinPracticalWorksCount;
        private System.Windows.Forms.NumericUpDown nudMinLecturesCount;
        private System.Windows.Forms.GroupBox gSemesters;
        private System.Windows.Forms.Label lSemesterLaboratoryWorks;
        private System.Windows.Forms.Label lSemesterPracticalWorks;
        private System.Windows.Forms.Label lSemesterLectures;
        private System.Windows.Forms.Button bRemoveSemester;
        private System.Windows.Forms.TextBox tbSemesterLaboratoryWorks;
        private System.Windows.Forms.Button bAddSemester;
        private System.Windows.Forms.ListBox lbSemesters;
        private System.Windows.Forms.TextBox tbSemesterPracticalWorks;
        private System.Windows.Forms.TextBox tbSemesterLectures;
        private System.Windows.Forms.NumericUpDown nudSemesterNumber;
        private System.Windows.Forms.Label lSemesterConsultation;
        private System.Windows.Forms.TextBox tbSemesterConsultation;
        private System.Windows.Forms.Label lSemesterNumber;
        private System.Windows.Forms.TextBox tbException;
        private System.Windows.Forms.Button bRemoveException;
        private System.Windows.Forms.Button bAddException;
        private System.Windows.Forms.Label lExeptions;
        private System.Windows.Forms.ListBox lbExceptions;
        private System.Windows.Forms.CheckBox cbMaster;
    }
}