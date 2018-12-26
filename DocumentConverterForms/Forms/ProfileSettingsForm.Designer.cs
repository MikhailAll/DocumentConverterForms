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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbException = new System.Windows.Forms.TextBox();
            this.tbSelfEducation = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bRemoveException = new System.Windows.Forms.Button();
            this.tbConsultation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bAddException = new System.Windows.Forms.Button();
            this.tbLaboratoryWorks = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbExceptions = new System.Windows.Forms.ListBox();
            this.tbPracticalWorks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLectures = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTotalClassroomHours = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotalHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbECTS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbExam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCredit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSubjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMinPracticalWorksCount = new System.Windows.Forms.NumericUpDown();
            this.nudMinLecturesCount = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbProfileKey = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.cProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSaveSettings = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.nudSheetNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bRemoveSemester = new System.Windows.Forms.Button();
            this.tbSemesterLaboratoryWorks = new System.Windows.Forms.TextBox();
            this.bAddSemester = new System.Windows.Forms.Button();
            this.lbSemesters = new System.Windows.Forms.ListBox();
            this.tbSemesterPracticalWorks = new System.Windows.Forms.TextBox();
            this.tbSemesterLectures = new System.Windows.Forms.TextBox();
            this.nudSemesterNumber = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.tbSemesterConsultation = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPracticalWorksCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLecturesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSheetNumber)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemesterNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsFormSplitter
            // 
            this.settingsFormSplitter.Location = new System.Drawing.Point(0, 24);
            this.settingsFormSplitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsFormSplitter.Name = "settingsFormSplitter";
            this.settingsFormSplitter.Size = new System.Drawing.Size(279, 713);
            this.settingsFormSplitter.TabIndex = 0;
            this.settingsFormSplitter.TabStop = false;
            // 
            // bManageProfiles
            // 
            this.bManageProfiles.Location = new System.Drawing.Point(20, 615);
            this.bManageProfiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bManageProfiles.Name = "bManageProfiles";
            this.bManageProfiles.Size = new System.Drawing.Size(238, 58);
            this.bManageProfiles.TabIndex = 2;
            this.bManageProfiles.Text = "button1";
            this.bManageProfiles.UseVisualStyleBackColor = true;
            this.bManageProfiles.Click += new System.EventHandler(this.bManageProfiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите профиль:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbException);
            this.groupBox1.Controls.Add(this.tbSelfEducation);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.bRemoveException);
            this.groupBox1.Controls.Add(this.tbConsultation);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.bAddException);
            this.groupBox1.Controls.Add(this.tbLaboratoryWorks);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbExceptions);
            this.groupBox1.Controls.Add(this.tbPracticalWorks);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbLectures);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbTotalClassroomHours);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbTotalHours);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbECTS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbCW);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbExam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCredit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSubjectName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(290, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 600);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка столбцов ";
            // 
            // tbException
            // 
            this.tbException.Location = new System.Drawing.Point(169, 473);
            this.tbException.Name = "tbException";
            this.tbException.Size = new System.Drawing.Size(138, 26);
            this.tbException.TabIndex = 30;
            // 
            // tbSelfEducation
            // 
            this.tbSelfEducation.Location = new System.Drawing.Point(314, 400);
            this.tbSelfEducation.Name = "tbSelfEducation";
            this.tbSelfEducation.Size = new System.Drawing.Size(138, 26);
            this.tbSelfEducation.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 400);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(274, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Часы самостоятельного обучения:";
            // 
            // bRemoveException
            // 
            this.bRemoveException.Location = new System.Drawing.Point(169, 549);
            this.bRemoveException.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bRemoveException.Name = "bRemoveException";
            this.bRemoveException.Size = new System.Drawing.Size(138, 28);
            this.bRemoveException.TabIndex = 29;
            this.bRemoveException.Text = "Удалить";
            this.bRemoveException.UseVisualStyleBackColor = true;
            this.bRemoveException.Click += new System.EventHandler(this.bRemoveException_Click);
            // 
            // tbConsultation
            // 
            this.tbConsultation.Location = new System.Drawing.Point(314, 368);
            this.tbConsultation.Name = "tbConsultation";
            this.tbConsultation.Size = new System.Drawing.Size(138, 26);
            this.tbConsultation.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 368);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Консультации:";
            // 
            // bAddException
            // 
            this.bAddException.Location = new System.Drawing.Point(169, 511);
            this.bAddException.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAddException.Name = "bAddException";
            this.bAddException.Size = new System.Drawing.Size(138, 28);
            this.bAddException.TabIndex = 9;
            this.bAddException.Text = "Добавить";
            this.bAddException.UseVisualStyleBackColor = true;
            this.bAddException.Click += new System.EventHandler(this.bAddException_Click);
            // 
            // tbLaboratoryWorks
            // 
            this.tbLaboratoryWorks.Location = new System.Drawing.Point(314, 336);
            this.tbLaboratoryWorks.Name = "tbLaboratoryWorks";
            this.tbLaboratoryWorks.Size = new System.Drawing.Size(138, 26);
            this.tbLaboratoryWorks.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 440);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Исключения:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 336);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Лабораторные работы:";
            // 
            // lbExceptions
            // 
            this.lbExceptions.FormattingEnabled = true;
            this.lbExceptions.ItemHeight = 20;
            this.lbExceptions.Location = new System.Drawing.Point(11, 473);
            this.lbExceptions.Name = "lbExceptions";
            this.lbExceptions.Size = new System.Drawing.Size(136, 104);
            this.lbExceptions.TabIndex = 9;
            // 
            // tbPracticalWorks
            // 
            this.tbPracticalWorks.Location = new System.Drawing.Point(314, 304);
            this.tbPracticalWorks.Name = "tbPracticalWorks";
            this.tbPracticalWorks.Size = new System.Drawing.Size(138, 26);
            this.tbPracticalWorks.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 304);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Практические занятия:";
            // 
            // tbLectures
            // 
            this.tbLectures.Location = new System.Drawing.Point(314, 272);
            this.tbLectures.Name = "tbLectures";
            this.tbLectures.Size = new System.Drawing.Size(138, 26);
            this.tbLectures.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Лекции:";
            // 
            // tbTotalClassroomHours
            // 
            this.tbTotalClassroomHours.Location = new System.Drawing.Point(314, 240);
            this.tbTotalClassroomHours.Name = "tbTotalClassroomHours";
            this.tbTotalClassroomHours.Size = new System.Drawing.Size(138, 26);
            this.tbTotalClassroomHours.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Общее количество аудиторных часов:";
            // 
            // tbTotalHours
            // 
            this.tbTotalHours.Location = new System.Drawing.Point(314, 208);
            this.tbTotalHours.Name = "tbTotalHours";
            this.tbTotalHours.Size = new System.Drawing.Size(138, 26);
            this.tbTotalHours.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Общее количество часов:";
            // 
            // tbECTS
            // 
            this.tbECTS.Location = new System.Drawing.Point(314, 176);
            this.tbECTS.Name = "tbECTS";
            this.tbECTS.Size = new System.Drawing.Size(138, 26);
            this.tbECTS.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Кредиты:";
            // 
            // tbCW
            // 
            this.tbCW.Location = new System.Drawing.Point(314, 144);
            this.tbCW.Name = "tbCW";
            this.tbCW.Size = new System.Drawing.Size(138, 26);
            this.tbCW.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Курсовое проектирование (КП):";
            // 
            // tbExam
            // 
            this.tbExam.Location = new System.Drawing.Point(314, 112);
            this.tbExam.Name = "tbExam";
            this.tbExam.Size = new System.Drawing.Size(138, 26);
            this.tbExam.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Экзамены:";
            // 
            // tbCredit
            // 
            this.tbCredit.Location = new System.Drawing.Point(314, 80);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.Size = new System.Drawing.Size(138, 26);
            this.tbCredit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Зачеты:";
            // 
            // tbSubjectName
            // 
            this.tbSubjectName.Location = new System.Drawing.Point(314, 48);
            this.tbSubjectName.Name = "tbSubjectName";
            this.tbSubjectName.Size = new System.Drawing.Size(138, 26);
            this.tbSubjectName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наименование дисциплины:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMinPracticalWorksCount);
            this.groupBox2.Controls.Add(this.nudMinLecturesCount);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(759, 523);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 128);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // nudMinPracticalWorksCount
            // 
            this.nudMinPracticalWorksCount.Location = new System.Drawing.Point(284, 78);
            this.nudMinPracticalWorksCount.Name = "nudMinPracticalWorksCount";
            this.nudMinPracticalWorksCount.Size = new System.Drawing.Size(138, 26);
            this.nudMinPracticalWorksCount.TabIndex = 16;
            // 
            // nudMinLecturesCount
            // 
            this.nudMinLecturesCount.Location = new System.Drawing.Point(284, 46);
            this.nudMinLecturesCount.Name = "nudMinLecturesCount";
            this.nudMinLecturesCount.Size = new System.Drawing.Size(138, 26);
            this.nudMinLecturesCount.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 80);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(233, 20);
            this.label17.TabIndex = 10;
            this.label17.Text = "Минимальное количество пз:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 48);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(270, 20);
            this.label18.TabIndex = 8;
            this.label18.Text = "Минимальное количество лекций:";
            // 
            // tbProfileKey
            // 
            this.tbProfileKey.Location = new System.Drawing.Point(609, 53);
            this.tbProfileKey.Name = "tbProfileKey";
            this.tbProfileKey.Size = new System.Drawing.Size(138, 26);
            this.tbProfileKey.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(297, 53);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Ключ профиля:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
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
            this.dgvProfiles.Location = new System.Drawing.Point(18, 98);
            this.dgvProfiles.MultiSelect = false;
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.ReadOnly = true;
            this.dgvProfiles.RowHeadersVisible = false;
            this.dgvProfiles.Size = new System.Drawing.Size(240, 509);
            this.dgvProfiles.TabIndex = 10;
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
            this.bSaveSettings.Location = new System.Drawing.Point(827, 659);
            this.bSaveSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSaveSettings.Name = "bSaveSettings";
            this.bSaveSettings.Size = new System.Drawing.Size(238, 58);
            this.bSaveSettings.TabIndex = 11;
            this.bSaveSettings.Text = "button1";
            this.bSaveSettings.UseVisualStyleBackColor = true;
            this.bSaveSettings.Click += new System.EventHandler(this.bSaveSettings_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(297, 85);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Номер страницы:";
            // 
            // nudSheetNumber
            // 
            this.nudSheetNumber.Location = new System.Drawing.Point(609, 83);
            this.nudSheetNumber.Name = "nudSheetNumber";
            this.nudSheetNumber.Size = new System.Drawing.Size(138, 26);
            this.nudSheetNumber.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.tbSemesterConsultation);
            this.groupBox3.Controls.Add(this.nudSemesterNumber);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.bRemoveSemester);
            this.groupBox3.Controls.Add(this.tbSemesterLaboratoryWorks);
            this.groupBox3.Controls.Add(this.bAddSemester);
            this.groupBox3.Controls.Add(this.lbSemesters);
            this.groupBox3.Controls.Add(this.tbSemesterPracticalWorks);
            this.groupBox3.Controls.Add(this.tbSemesterLectures);
            this.groupBox3.Location = new System.Drawing.Point(770, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 292);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(183, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 20);
            this.label21.TabIndex = 37;
            this.label21.Text = "label21";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(183, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 20);
            this.label20.TabIndex = 36;
            this.label20.Text = "label20";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(183, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "label19";
            // 
            // bRemoveSemester
            // 
            this.bRemoveSemester.Location = new System.Drawing.Point(267, 229);
            this.bRemoveSemester.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bRemoveSemester.Name = "bRemoveSemester";
            this.bRemoveSemester.Size = new System.Drawing.Size(138, 28);
            this.bRemoveSemester.TabIndex = 32;
            this.bRemoveSemester.Text = "Удалить";
            this.bRemoveSemester.UseVisualStyleBackColor = true;
            this.bRemoveSemester.Click += new System.EventHandler(this.bRemoveSemester_Click);
            // 
            // tbSemesterLaboratoryWorks
            // 
            this.tbSemesterLaboratoryWorks.Location = new System.Drawing.Point(268, 120);
            this.tbSemesterLaboratoryWorks.Name = "tbSemesterLaboratoryWorks";
            this.tbSemesterLaboratoryWorks.Size = new System.Drawing.Size(138, 26);
            this.tbSemesterLaboratoryWorks.TabIndex = 33;
            // 
            // bAddSemester
            // 
            this.bAddSemester.Location = new System.Drawing.Point(267, 191);
            this.bAddSemester.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAddSemester.Name = "bAddSemester";
            this.bAddSemester.Size = new System.Drawing.Size(138, 28);
            this.bAddSemester.TabIndex = 31;
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
            this.lbSemesters.Size = new System.Drawing.Size(136, 124);
            this.lbSemesters.TabIndex = 31;
            // 
            // tbSemesterPracticalWorks
            // 
            this.tbSemesterPracticalWorks.Location = new System.Drawing.Point(268, 88);
            this.tbSemesterPracticalWorks.Name = "tbSemesterPracticalWorks";
            this.tbSemesterPracticalWorks.Size = new System.Drawing.Size(138, 26);
            this.tbSemesterPracticalWorks.TabIndex = 32;
            // 
            // tbSemesterLectures
            // 
            this.tbSemesterLectures.Location = new System.Drawing.Point(268, 56);
            this.tbSemesterLectures.Name = "tbSemesterLectures";
            this.tbSemesterLectures.Size = new System.Drawing.Size(138, 26);
            this.tbSemesterLectures.TabIndex = 31;
            // 
            // nudSemesterNumber
            // 
            this.nudSemesterNumber.Location = new System.Drawing.Point(268, 25);
            this.nudSemesterNumber.Name = "nudSemesterNumber";
            this.nudSemesterNumber.Size = new System.Drawing.Size(137, 26);
            this.nudSemesterNumber.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(182, 155);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 20);
            this.label22.TabIndex = 40;
            this.label22.Text = "label22";
            // 
            // tbSemesterConsultation
            // 
            this.tbSemesterConsultation.Location = new System.Drawing.Point(267, 152);
            this.tbSemesterConsultation.Name = "tbSemesterConsultation";
            this.tbSemesterConsultation.Size = new System.Drawing.Size(138, 26);
            this.tbSemesterConsultation.TabIndex = 39;
            // 
            // ProfileSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 737);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.nudSheetNumber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.bSaveSettings);
            this.Controls.Add(this.dgvProfiles);
            this.Controls.Add(this.tbProfileKey);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bManageProfiles);
            this.Controls.Add(this.settingsFormSplitter);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfileSettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.ProfileSettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPracticalWorksCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLecturesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSheetNumber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemesterNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter settingsFormSplitter;
        private System.Windows.Forms.Button bManageProfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSelfEducation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbConsultation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLaboratoryWorks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPracticalWorks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLectures;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTotalClassroomHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTotalHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbECTS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbExam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbProfileKey;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lbExceptions;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bAddException;
        private System.Windows.Forms.Button bRemoveException;
        private System.Windows.Forms.TextBox tbException;
        private System.Windows.Forms.BindingSource profilesBindingSource;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProfileName;
        private System.Windows.Forms.Button bSaveSettings;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudSheetNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nudMinPracticalWorksCount;
        private System.Windows.Forms.NumericUpDown nudMinLecturesCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button bRemoveSemester;
        private System.Windows.Forms.TextBox tbSemesterLaboratoryWorks;
        private System.Windows.Forms.Button bAddSemester;
        private System.Windows.Forms.ListBox lbSemesters;
        private System.Windows.Forms.TextBox tbSemesterPracticalWorks;
        private System.Windows.Forms.TextBox tbSemesterLectures;
        private System.Windows.Forms.NumericUpDown nudSemesterNumber;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbSemesterConsultation;
    }
}