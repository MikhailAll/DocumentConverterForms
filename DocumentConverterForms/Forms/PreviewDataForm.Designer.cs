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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewSubjectsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewSemesterData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreviewSubjectsData
            // 
            this.dgvPreviewSubjectsData.AllowUserToAddRows = false;
            this.dgvPreviewSubjectsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPreviewSubjectsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviewSubjectsData.Location = new System.Drawing.Point(12, 12);
            this.dgvPreviewSubjectsData.Name = "dgvPreviewSubjectsData";
            this.dgvPreviewSubjectsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreviewSubjectsData.Size = new System.Drawing.Size(1020, 802);
            this.dgvPreviewSubjectsData.TabIndex = 2;
            this.dgvPreviewSubjectsData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreviewSubjectsData_CellDoubleClick);
            // 
            // dgvPreviewSemesterData
            // 
            this.dgvPreviewSemesterData.AllowUserToAddRows = false;
            this.dgvPreviewSemesterData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPreviewSemesterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviewSemesterData.Location = new System.Drawing.Point(1038, 12);
            this.dgvPreviewSemesterData.Name = "dgvPreviewSemesterData";
            this.dgvPreviewSemesterData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreviewSemesterData.Size = new System.Drawing.Size(407, 679);
            this.dgvPreviewSemesterData.TabIndex = 3;
            // 
            // bSaveData
            // 
            this.bSaveData.Location = new System.Drawing.Point(1038, 697);
            this.bSaveData.Name = "bSaveData";
            this.bSaveData.Size = new System.Drawing.Size(407, 117);
            this.bSaveData.TabIndex = 4;
            this.bSaveData.Text = "button1";
            this.bSaveData.UseVisualStyleBackColor = true;
            this.bSaveData.Click += new System.EventHandler(this.bSaveData_Click);
            // 
            // PreviewDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 826);
            this.Controls.Add(this.bSaveData);
            this.Controls.Add(this.dgvPreviewSemesterData);
            this.Controls.Add(this.dgvPreviewSubjectsData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PreviewDataForm";
            this.Text = "PrevievData";
            this.Load += new System.EventHandler(this.PreviewDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewSubjectsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewSemesterData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreviewSubjectsData;
        private System.Windows.Forms.DataGridView dgvPreviewSemesterData;
        private System.Windows.Forms.Button bSaveData;
    }
}