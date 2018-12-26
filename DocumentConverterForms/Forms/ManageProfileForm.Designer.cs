namespace DocumentConverterForms.Forms
{
    partial class ManageProfileForm
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lbProfiles = new System.Windows.Forms.ListBox();
            this.tbNewProfileName = new System.Windows.Forms.TextBox();
            this.bAddNewProfile = new System.Windows.Forms.Button();
            this.bRemoveProfile = new System.Windows.Forms.Button();
            this.bEditProfileName = new System.Windows.Forms.Button();
            this.tbEditProfileName = new System.Windows.Forms.TextBox();
            this.profilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.profilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(228, 292);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // lbProfiles
            // 
            this.lbProfiles.FormattingEnabled = true;
            this.lbProfiles.ItemHeight = 20;
            this.lbProfiles.Location = new System.Drawing.Point(12, 12);
            this.lbProfiles.Name = "lbProfiles";
            this.lbProfiles.Size = new System.Drawing.Size(204, 264);
            this.lbProfiles.TabIndex = 1;
            this.lbProfiles.SelectedIndexChanged += new System.EventHandler(this.lbProfiles_SelectedIndexChanged);
            // 
            // tbNewProfileName
            // 
            this.tbNewProfileName.Location = new System.Drawing.Point(254, 12);
            this.tbNewProfileName.Name = "tbNewProfileName";
            this.tbNewProfileName.Size = new System.Drawing.Size(153, 26);
            this.tbNewProfileName.TabIndex = 2;
            // 
            // bAddNewProfile
            // 
            this.bAddNewProfile.Location = new System.Drawing.Point(254, 44);
            this.bAddNewProfile.Name = "bAddNewProfile";
            this.bAddNewProfile.Size = new System.Drawing.Size(153, 52);
            this.bAddNewProfile.TabIndex = 3;
            this.bAddNewProfile.Text = "Добавить новый провиль";
            this.bAddNewProfile.UseVisualStyleBackColor = true;
            this.bAddNewProfile.Click += new System.EventHandler(this.bAddNewProfile_Click);
            // 
            // bRemoveProfile
            // 
            this.bRemoveProfile.Location = new System.Drawing.Point(254, 221);
            this.bRemoveProfile.Name = "bRemoveProfile";
            this.bRemoveProfile.Size = new System.Drawing.Size(153, 55);
            this.bRemoveProfile.TabIndex = 6;
            this.bRemoveProfile.Text = "Удалить профиль";
            this.bRemoveProfile.UseVisualStyleBackColor = true;
            this.bRemoveProfile.Click += new System.EventHandler(this.bRemoveProfile_Click);
            // 
            // bEditProfileName
            // 
            this.bEditProfileName.Location = new System.Drawing.Point(254, 161);
            this.bEditProfileName.Name = "bEditProfileName";
            this.bEditProfileName.Size = new System.Drawing.Size(153, 54);
            this.bEditProfileName.TabIndex = 5;
            this.bEditProfileName.Text = "Изменить имя профиля";
            this.bEditProfileName.UseVisualStyleBackColor = true;
            this.bEditProfileName.Click += new System.EventHandler(this.bEditProfileName_Click);
            // 
            // tbEditProfileName
            // 
            this.tbEditProfileName.Location = new System.Drawing.Point(254, 129);
            this.tbEditProfileName.Name = "tbEditProfileName";
            this.tbEditProfileName.Size = new System.Drawing.Size(153, 26);
            this.tbEditProfileName.TabIndex = 4;
            // 
            // ManageProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(418, 292);
            this.Controls.Add(this.bEditProfileName);
            this.Controls.Add(this.tbEditProfileName);
            this.Controls.Add(this.bRemoveProfile);
            this.Controls.Add(this.bAddNewProfile);
            this.Controls.Add(this.tbNewProfileName);
            this.Controls.Add(this.lbProfiles);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageProfileForm";
            this.Text = "Управление профилями";
            this.Load += new System.EventHandler(this.ManageProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox lbProfiles;
        private System.Windows.Forms.TextBox tbNewProfileName;
        private System.Windows.Forms.Button bAddNewProfile;
        private System.Windows.Forms.Button bRemoveProfile;
        private System.Windows.Forms.Button bEditProfileName;
        private System.Windows.Forms.TextBox tbEditProfileName;
        private System.Windows.Forms.BindingSource profilesBindingSource;
    }
}