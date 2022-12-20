namespace ferium_gui
{
    partial class ConfigProfileForm
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
            this.ProfileComboBox = new System.Windows.Forms.ComboBox();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.RenameTextBox = new System.Windows.Forms.TextBox();
            this.AddProfileButton = new System.Windows.Forms.Button();
            this.SaveProfileButton = new System.Windows.Forms.Button();
            this.ChangeModDirButton = new System.Windows.Forms.Button();
            this.ProfileVersionTextBox = new System.Windows.Forms.TextBox();
            this.ModLoaderComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteProfileButton = new System.Windows.Forms.Button();
            this.RenameLabel = new System.Windows.Forms.Label();
            this.ModLoaderLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProfileComboBox
            // 
            this.ProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfileComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileComboBox.FormattingEnabled = true;
            this.ProfileComboBox.Location = new System.Drawing.Point(13, 32);
            this.ProfileComboBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.ProfileComboBox.Name = "ProfileComboBox";
            this.ProfileComboBox.Size = new System.Drawing.Size(137, 23);
            this.ProfileComboBox.TabIndex = 0;
            this.ProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.ProfileComboBox_SelectedIndexChanged);
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ProfileLabel.Location = new System.Drawing.Point(9, 14);
            this.ProfileLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(45, 16);
            this.ProfileLabel.TabIndex = 1;
            this.ProfileLabel.Text = "Profile";
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.Location = new System.Drawing.Point(181, 33);
            this.RenameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RenameTextBox.MaxLength = 64;
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(137, 22);
            this.RenameTextBox.TabIndex = 2;
            // 
            // AddProfileButton
            // 
            this.AddProfileButton.Location = new System.Drawing.Point(115, 146);
            this.AddProfileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProfileButton.Name = "AddProfileButton";
            this.AddProfileButton.Size = new System.Drawing.Size(103, 25);
            this.AddProfileButton.TabIndex = 3;
            this.AddProfileButton.Text = "Add Profile";
            this.AddProfileButton.UseVisualStyleBackColor = true;
            this.AddProfileButton.Click += new System.EventHandler(this.AddProfileButton_Click);
            // 
            // SaveProfileButton
            // 
            this.SaveProfileButton.Location = new System.Drawing.Point(5, 146);
            this.SaveProfileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveProfileButton.Name = "SaveProfileButton";
            this.SaveProfileButton.Size = new System.Drawing.Size(103, 25);
            this.SaveProfileButton.TabIndex = 4;
            this.SaveProfileButton.Text = "Save Profile";
            this.SaveProfileButton.UseVisualStyleBackColor = true;
            this.SaveProfileButton.Click += new System.EventHandler(this.SaveProfileButton_Click);
            // 
            // ChangeModDirButton
            // 
            this.ChangeModDirButton.Location = new System.Drawing.Point(107, 114);
            this.ChangeModDirButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeModDirButton.Name = "ChangeModDirButton";
            this.ChangeModDirButton.Size = new System.Drawing.Size(120, 25);
            this.ChangeModDirButton.TabIndex = 5;
            this.ChangeModDirButton.Text = "Change Mod Dir";
            this.ChangeModDirButton.UseVisualStyleBackColor = true;
            this.ChangeModDirButton.Click += new System.EventHandler(this.ChangeModDirButton_Click);
            // 
            // ProfileVersionTextBox
            // 
            this.ProfileVersionTextBox.Location = new System.Drawing.Point(13, 81);
            this.ProfileVersionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfileVersionTextBox.MaxLength = 64;
            this.ProfileVersionTextBox.Name = "ProfileVersionTextBox";
            this.ProfileVersionTextBox.Size = new System.Drawing.Size(137, 22);
            this.ProfileVersionTextBox.TabIndex = 6;
            // 
            // ModLoaderComboBox
            // 
            this.ModLoaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModLoaderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModLoaderComboBox.FormattingEnabled = true;
            this.ModLoaderComboBox.Items.AddRange(new object[] {
            "Quilt",
            "Fabric",
            "Forge"});
            this.ModLoaderComboBox.Location = new System.Drawing.Point(181, 79);
            this.ModLoaderComboBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.ModLoaderComboBox.MaxDropDownItems = 3;
            this.ModLoaderComboBox.Name = "ModLoaderComboBox";
            this.ModLoaderComboBox.Size = new System.Drawing.Size(137, 23);
            this.ModLoaderComboBox.TabIndex = 7;
            // 
            // DeleteProfileButton
            // 
            this.DeleteProfileButton.Location = new System.Drawing.Point(223, 146);
            this.DeleteProfileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteProfileButton.Name = "DeleteProfileButton";
            this.DeleteProfileButton.Size = new System.Drawing.Size(103, 25);
            this.DeleteProfileButton.TabIndex = 8;
            this.DeleteProfileButton.Text = "Delete Profile";
            this.DeleteProfileButton.UseVisualStyleBackColor = true;
            this.DeleteProfileButton.Click += new System.EventHandler(this.DeleteProfileButton_Click);
            // 
            // RenameLabel
            // 
            this.RenameLabel.AutoSize = true;
            this.RenameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RenameLabel.Location = new System.Drawing.Point(179, 14);
            this.RenameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RenameLabel.Name = "RenameLabel";
            this.RenameLabel.Size = new System.Drawing.Size(59, 16);
            this.RenameLabel.TabIndex = 9;
            this.RenameLabel.Text = "Rename";
            // 
            // ModLoaderLabel
            // 
            this.ModLoaderLabel.AutoSize = true;
            this.ModLoaderLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ModLoaderLabel.Location = new System.Drawing.Point(179, 60);
            this.ModLoaderLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ModLoaderLabel.Name = "ModLoaderLabel";
            this.ModLoaderLabel.Size = new System.Drawing.Size(80, 16);
            this.ModLoaderLabel.TabIndex = 10;
            this.ModLoaderLabel.Text = "Mod Loader";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VersionLabel.Location = new System.Drawing.Point(9, 60);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(110, 16);
            this.VersionLabel.TabIndex = 11;
            this.VersionLabel.Text = "Minecraft Version";
            // 
            // ConfigProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(331, 182);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ModLoaderLabel);
            this.Controls.Add(this.RenameLabel);
            this.Controls.Add(this.DeleteProfileButton);
            this.Controls.Add(this.ModLoaderComboBox);
            this.Controls.Add(this.ProfileVersionTextBox);
            this.Controls.Add(this.ChangeModDirButton);
            this.Controls.Add(this.SaveProfileButton);
            this.Controls.Add(this.AddProfileButton);
            this.Controls.Add(this.RenameTextBox);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.ProfileComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigProfileForm";
            this.Text = "Configure Profiles";
            this.Load += new System.EventHandler(this.ConfigProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProfileComboBox;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.TextBox RenameTextBox;
        private System.Windows.Forms.Button AddProfileButton;
        private System.Windows.Forms.Button SaveProfileButton;
        private System.Windows.Forms.Button ChangeModDirButton;
        private System.Windows.Forms.TextBox ProfileVersionTextBox;
        private System.Windows.Forms.ComboBox ModLoaderComboBox;
        private System.Windows.Forms.Button DeleteProfileButton;
        private System.Windows.Forms.Label RenameLabel;
        private System.Windows.Forms.Label ModLoaderLabel;
        private System.Windows.Forms.Label VersionLabel;
    }
}