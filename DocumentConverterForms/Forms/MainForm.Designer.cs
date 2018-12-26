namespace DocumentConverterForms.Forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSelectFolder = new System.Windows.Forms.Button();
            this.bSelectFile = new System.Windows.Forms.Button();
            this.bSelectFilePreview = new System.Windows.Forms.Button();
            this.lConvertNoPreview = new System.Windows.Forms.Label();
            this.lConvertPreview = new System.Windows.Forms.Label();
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.cProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.profilesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(503, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // profilesToolStripMenuItem
            // 
            this.profilesToolStripMenuItem.Name = "profilesToolStripMenuItem";
            this.profilesToolStripMenuItem.Size = new System.Drawing.Size(165, 25);
            this.profilesToolStripMenuItem.Text = "Настройка профиля";
            this.profilesToolStripMenuItem.Click += new System.EventHandler(this.profilesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // bSelectFolder
            // 
            this.bSelectFolder.Location = new System.Drawing.Point(285, 74);
            this.bSelectFolder.Name = "bSelectFolder";
            this.bSelectFolder.Size = new System.Drawing.Size(209, 49);
            this.bSelectFolder.TabIndex = 3;
            this.bSelectFolder.Text = "Выбрать папку для конвертации";
            this.bSelectFolder.UseVisualStyleBackColor = true;
            this.bSelectFolder.Click += new System.EventHandler(this.bSelectFolder_Click);
            // 
            // bSelectFile
            // 
            this.bSelectFile.Location = new System.Drawing.Point(285, 129);
            this.bSelectFile.Name = "bSelectFile";
            this.bSelectFile.Size = new System.Drawing.Size(209, 49);
            this.bSelectFile.TabIndex = 4;
            this.bSelectFile.Text = "Выбрать файл для конвертации";
            this.bSelectFile.UseVisualStyleBackColor = true;
            // 
            // bSelectFilePreview
            // 
            this.bSelectFilePreview.Location = new System.Drawing.Point(16, 326);
            this.bSelectFilePreview.Name = "bSelectFilePreview";
            this.bSelectFilePreview.Size = new System.Drawing.Size(248, 49);
            this.bSelectFilePreview.TabIndex = 2;
            this.bSelectFilePreview.Text = "Выбрать файл для конвертации";
            this.bSelectFilePreview.UseVisualStyleBackColor = true;
            this.bSelectFilePreview.Click += new System.EventHandler(this.bSelectFilePreview_Click);
            // 
            // lConvertNoPreview
            // 
            this.lConvertNoPreview.AutoSize = true;
            this.lConvertNoPreview.Location = new System.Drawing.Point(281, 31);
            this.lConvertNoPreview.Name = "lConvertNoPreview";
            this.lConvertNoPreview.Size = new System.Drawing.Size(143, 40);
            this.lConvertNoPreview.TabIndex = 0;
            this.lConvertNoPreview.Text = "Конвертация без \r\nпредпросмотра:";
            // 
            // lConvertPreview
            // 
            this.lConvertPreview.AutoSize = true;
            this.lConvertPreview.Location = new System.Drawing.Point(12, 31);
            this.lConvertPreview.Name = "lConvertPreview";
            this.lConvertPreview.Size = new System.Drawing.Size(140, 40);
            this.lConvertPreview.TabIndex = 0;
            this.lConvertPreview.Text = "Конвертация с\r\nпредпросмотром\r\n";
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
            this.dgvProfiles.Location = new System.Drawing.Point(16, 74);
            this.dgvProfiles.MultiSelect = false;
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.ReadOnly = true;
            this.dgvProfiles.RowHeadersVisible = false;
            this.dgvProfiles.Size = new System.Drawing.Size(248, 246);
            this.dgvProfiles.TabIndex = 1;
            this.dgvProfiles.Tag = "";
            // 
            // cProfileName
            // 
            this.cProfileName.HeaderText = "Название профиля";
            this.cProfileName.Name = "cProfileName";
            this.cProfileName.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(503, 391);
            this.Controls.Add(this.dgvProfiles);
            this.Controls.Add(this.lConvertPreview);
            this.Controls.Add(this.lConvertNoPreview);
            this.Controls.Add(this.bSelectFilePreview);
            this.Controls.Add(this.bSelectFile);
            this.Controls.Add(this.bSelectFolder);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Конвертация расписаний";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button bSelectFolder;
        private System.Windows.Forms.Button bSelectFile;
        private System.Windows.Forms.Button bSelectFilePreview;
        private System.Windows.Forms.Label lConvertNoPreview;
        private System.Windows.Forms.Label lConvertPreview;
        private System.Windows.Forms.BindingSource profilesBindingSource;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProfileName;
    }
}

