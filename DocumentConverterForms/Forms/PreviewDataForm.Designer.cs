namespace DocumentConverterForms.Forms
{
    partial class PreviewDataForm
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
            this.dgvPreviewSubjectsData = new System.Windows.Forms.DataGridView();
            this.dgvPreviewSemesterData = new System.Windows.Forms.DataGridView();
            this.bSaveData = new System.Windows.Forms.Button();
            this.lSubjects = new System.Windows.Forms.Label();
            this.lSemesters = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewSubjectsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewSemesterData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreviewSubjectsData
            // 
            this.dgvPreviewSubjectsData.AllowUserToAddRows = false;
            this.dgvPreviewSubjectsData.AllowUserToResizeRows = false;
            this.dgvPreviewSubjectsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPreviewSubjectsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviewSubjectsData.Location = new System.Drawing.Point(12, 32);
            this.dgvPreviewSubjectsData.MultiSelect = false;
            this.dgvPreviewSubjectsData.Name = "dgvPreviewSubjectsData";
            this.dgvPreviewSubjectsData.RowHeadersVisible = false;
            this.dgvPreviewSubjectsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreviewSubjectsData.Size = new System.Drawing.Size(1020, 782);
            this.dgvPreviewSubjectsData.TabIndex = 1;
            this.dgvPreviewSubjectsData.SelectionChanged += new System.EventHandler(this.dgvPreviewSubjectsData_SelectionChanged);
            // 
            // dgvPreviewSemesterData
            // 
            this.dgvPreviewSemesterData.AllowUserToAddRows = false;
            this.dgvPreviewSemesterData.AllowUserToDeleteRows = false;
            this.dgvPreviewSemesterData.AllowUserToResizeRows = false;
            this.dgvPreviewSemesterData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPreviewSemesterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviewSemesterData.Location = new System.Drawing.Point(1038, 32);
            this.dgvPreviewSemesterData.MultiSelect = false;
            this.dgvPreviewSemesterData.Name = "dgvPreviewSemesterData";
            this.dgvPreviewSemesterData.RowHeadersVisible = false;
            this.dgvPreviewSemesterData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreviewSemesterData.Size = new System.Drawing.Size(407, 659);
            this.dgvPreviewSemesterData.TabIndex = 2;
            // 
            // bSaveData
            // 
            this.bSaveData.Location = new System.Drawing.Point(1038, 697);
            this.bSaveData.Name = "bSaveData";
            this.bSaveData.Size = new System.Drawing.Size(407, 117);
            this.bSaveData.TabIndex = 3;
            this.bSaveData.Text = "Сохранить данные";
            this.bSaveData.UseVisualStyleBackColor = true;
            this.bSaveData.Click += new System.EventHandler(this.bSaveData_Click);
            // 
            // lSubjects
            // 
            this.lSubjects.AutoSize = true;
            this.lSubjects.Location = new System.Drawing.Point(12, 9);
            this.lSubjects.Name = "lSubjects";
            this.lSubjects.Size = new System.Drawing.Size(427, 20);
            this.lSubjects.TabIndex = 0;
            this.lSubjects.Text = "Список дисциплин (клик для отображения семестров):";
            // 
            // lSemesters
            // 
            this.lSemesters.AutoSize = true;
            this.lSemesters.Location = new System.Drawing.Point(1034, 9);
            this.lSemesters.Name = "lSemesters";
            this.lSemesters.Size = new System.Drawing.Size(152, 20);
            this.lSemesters.TabIndex = 0;
            this.lSemesters.Text = "Список семестров:";
            // 
            // PreviewDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1457, 826);
            this.Controls.Add(this.lSemesters);
            this.Controls.Add(this.lSubjects);
            this.Controls.Add(this.bSaveData);
            this.Controls.Add(this.dgvPreviewSemesterData);
            this.Controls.Add(this.dgvPreviewSubjectsData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PreviewDataForm";
            this.Text = "Сохранить изменения";
            this.Load += new System.EventHandler(this.PreviewDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewSubjectsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewSemesterData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreviewSubjectsData;
        private System.Windows.Forms.DataGridView dgvPreviewSemesterData;
        private System.Windows.Forms.Button bSaveData;
        private System.Windows.Forms.Label lSubjects;
        private System.Windows.Forms.Label lSemesters;
    }
}