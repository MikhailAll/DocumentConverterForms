namespace DocumentConverterForms
{
    partial class ApplicationSettingsForm
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
            this.lXmlFilePath = new System.Windows.Forms.Label();
            this.tbXmlFiles = new System.Windows.Forms.TextBox();
            this.tbConvertedFiles = new System.Windows.Forms.TextBox();
            this.lConvertedFilesFolder = new System.Windows.Forms.Label();
            this.bOpenXmlFilesFolder = new System.Windows.Forms.Button();
            this.bOpenConvertedFilesFolder = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lXmlFilePath
            // 
            this.lXmlFilePath.AutoSize = true;
            this.lXmlFilePath.Location = new System.Drawing.Point(12, 9);
            this.lXmlFilePath.Name = "lXmlFilePath";
            this.lXmlFilePath.Size = new System.Drawing.Size(236, 20);
            this.lXmlFilePath.TabIndex = 0;
            this.lXmlFilePath.Text = "Путь к папке для xml файлов:";
            // 
            // tbXmlFiles
            // 
            this.tbXmlFiles.Location = new System.Drawing.Point(16, 32);
            this.tbXmlFiles.Name = "tbXmlFiles";
            this.tbXmlFiles.Size = new System.Drawing.Size(336, 26);
            this.tbXmlFiles.TabIndex = 1;
            // 
            // tbConvertedFiles
            // 
            this.tbConvertedFiles.Location = new System.Drawing.Point(16, 98);
            this.tbConvertedFiles.Name = "tbConvertedFiles";
            this.tbConvertedFiles.Size = new System.Drawing.Size(336, 26);
            this.tbConvertedFiles.TabIndex = 3;
            // 
            // lConvertedFilesFolder
            // 
            this.lConvertedFilesFolder.AutoSize = true;
            this.lConvertedFilesFolder.Location = new System.Drawing.Point(12, 75);
            this.lConvertedFilesFolder.Name = "lConvertedFilesFolder";
            this.lConvertedFilesFolder.Size = new System.Drawing.Size(356, 20);
            this.lConvertedFilesFolder.TabIndex = 2;
            this.lConvertedFilesFolder.Text = "Путь к папке для конвертированных файлов:";
            // 
            // bOpenXmlFilesFolder
            // 
            this.bOpenXmlFilesFolder.Location = new System.Drawing.Point(385, 32);
            this.bOpenXmlFilesFolder.Name = "bOpenXmlFilesFolder";
            this.bOpenXmlFilesFolder.Size = new System.Drawing.Size(113, 26);
            this.bOpenXmlFilesFolder.TabIndex = 4;
            this.bOpenXmlFilesFolder.Text = "Открыть";
            this.bOpenXmlFilesFolder.UseVisualStyleBackColor = true;
            this.bOpenXmlFilesFolder.Click += new System.EventHandler(this.bOpenXmlFilesFolder_Click);
            // 
            // bOpenConvertedFilesFolder
            // 
            this.bOpenConvertedFilesFolder.Location = new System.Drawing.Point(385, 98);
            this.bOpenConvertedFilesFolder.Name = "bOpenConvertedFilesFolder";
            this.bOpenConvertedFilesFolder.Size = new System.Drawing.Size(113, 26);
            this.bOpenConvertedFilesFolder.TabIndex = 5;
            this.bOpenConvertedFilesFolder.Text = "Открыть";
            this.bOpenConvertedFilesFolder.UseVisualStyleBackColor = true;
            this.bOpenConvertedFilesFolder.Click += new System.EventHandler(this.bOpenConvertedFilesFolder_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(340, 143);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(158, 34);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // ApplicationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 189);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bOpenConvertedFilesFolder);
            this.Controls.Add(this.bOpenXmlFilesFolder);
            this.Controls.Add(this.tbConvertedFiles);
            this.Controls.Add(this.lConvertedFilesFolder);
            this.Controls.Add(this.tbXmlFiles);
            this.Controls.Add(this.lXmlFilePath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ApplicationSettingsForm";
            this.Text = "ApplicationSettings";
            this.Load += new System.EventHandler(this.ApplicationSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lXmlFilePath;
        private System.Windows.Forms.TextBox tbXmlFiles;
        private System.Windows.Forms.TextBox tbConvertedFiles;
        private System.Windows.Forms.Label lConvertedFilesFolder;
        private System.Windows.Forms.Button bOpenXmlFilesFolder;
        private System.Windows.Forms.Button bOpenConvertedFilesFolder;
        private System.Windows.Forms.Button bSave;
    }
}