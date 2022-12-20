namespace ferium_gui
{
    partial class AddProfileForm
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
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ModLoaderLabel = new System.Windows.Forms.Label();
            this.RenameLabel = new System.Windows.Forms.Label();
            this.ModLoaderComboBox = new System.Windows.Forms.ComboBox();
            this.ProfileVersionTextBox = new System.Windows.Forms.TextBox();
            this.ChangeModDirButton = new System.Windows.Forms.Button();
            this.AddProfileButton = new System.Windows.Forms.Button();
            this.RenameTextBox = new System.Windows.Forms.TextBox();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.ProfileComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VersionLabel.Location = new System.Drawing.Point(11, 59);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(110, 16);
            this.VersionLabel.TabIndex = 21;
            this.VersionLabel.Text = "Minecraft Version";
            // 
            // ModLoaderLabel
            // 
            this.ModLoaderLabel.AutoSize = true;
            this.ModLoaderLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ModLoaderLabel.Location = new System.Drawing.Point(181, 59);
            this.ModLoaderLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ModLoaderLabel.Name = "ModLoaderLabel";
            this.ModLoaderLabel.Size = new System.Drawing.Size(80, 16);
            this.ModLoaderLabel.TabIndex = 20;
            this.ModLoaderLabel.Text = "Mod Loader";
            // 
            // RenameLabel
            // 
            this.RenameLabel.AutoSize = true;
            this.RenameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RenameLabel.Location = new System.Drawing.Point(181, 13);
            this.RenameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RenameLabel.Name = "RenameLabel";
            this.RenameLabel.Size = new System.Drawing.Size(44, 16);
            this.RenameLabel.TabIndex = 19;
            this.RenameLabel.Text = "Name";
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
            this.ModLoaderComboBox.Location = new System.Drawing.Point(183, 78);
            this.ModLoaderComboBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.ModLoaderComboBox.MaxDropDownItems = 3;
            this.ModLoaderComboBox.Name = "ModLoaderComboBox";
            this.ModLoaderComboBox.Size = new System.Drawing.Size(137, 23);
            this.ModLoaderComboBox.TabIndex = 18;
            // 
            // ProfileVersionTextBox
            // 
            this.ProfileVersionTextBox.Location = new System.Drawing.Point(15, 80);
            this.ProfileVersionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfileVersionTextBox.MaxLength = 64;
            this.ProfileVersionTextBox.Name = "ProfileVersionTextBox";
            this.ProfileVersionTextBox.Size = new System.Drawing.Size(137, 22);
            this.ProfileVersionTextBox.TabIndex = 17;
            // 
            // ChangeModDirButton
            // 
            this.ChangeModDirButton.Location = new System.Drawing.Point(109, 113);
            this.ChangeModDirButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeModDirButton.Name = "ChangeModDirButton";
            this.ChangeModDirButton.Size = new System.Drawing.Size(120, 25);
            this.ChangeModDirButton.TabIndex = 16;
            this.ChangeModDirButton.Text = "Change Mod Dir";
            this.ChangeModDirButton.UseVisualStyleBackColor = true;
            this.ChangeModDirButton.Click += new System.EventHandler(this.ChangeModDirButton_Click);
            // 
            // AddProfileButton
            // 
            this.AddProfileButton.Location = new System.Drawing.Point(117, 145);
            this.AddProfileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProfileButton.Name = "AddProfileButton";
            this.AddProfileButton.Size = new System.Drawing.Size(103, 25);
            this.AddProfileButton.TabIndex = 15;
            this.AddProfileButton.Text = "Add Profile";
            this.AddProfileButton.UseVisualStyleBackColor = true;
            this.AddProfileButton.Click += new System.EventHandler(this.AddProfileButton_Click);
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.Location = new System.Drawing.Point(183, 32);
            this.RenameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RenameTextBox.MaxLength = 64;
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(137, 22);
            this.RenameTextBox.TabIndex = 14;
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ProfileLabel.Location = new System.Drawing.Point(11, 13);
            this.ProfileLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(122, 16);
            this.ProfileLabel.TabIndex = 13;
            this.ProfileLabel.Text = "Import Profile Mods";
            // 
            // ProfileComboBox
            // 
            this.ProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfileComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileComboBox.FormattingEnabled = true;
            this.ProfileComboBox.Location = new System.Drawing.Point(15, 31);
            this.ProfileComboBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.ProfileComboBox.Name = "ProfileComboBox";
            this.ProfileComboBox.Size = new System.Drawing.Size(137, 23);
            this.ProfileComboBox.TabIndex = 12;
            // 
            // AddProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(331, 182);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ModLoaderLabel);
            this.Controls.Add(this.RenameLabel);
            this.Controls.Add(this.ModLoaderComboBox);
            this.Controls.Add(this.ProfileVersionTextBox);
            this.Controls.Add(this.ChangeModDirButton);
            this.Controls.Add(this.AddProfileButton);
            this.Controls.Add(this.RenameTextBox);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.ProfileComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProfileForm";
            this.Text = "Add Profile";
            this.Load += new System.EventHandler(this.AddProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label ModLoaderLabel;
        private System.Windows.Forms.Label RenameLabel;
        private System.Windows.Forms.ComboBox ModLoaderComboBox;
        private System.Windows.Forms.TextBox ProfileVersionTextBox;
        private System.Windows.Forms.Button ChangeModDirButton;
        private System.Windows.Forms.Button AddProfileButton;
        private System.Windows.Forms.TextBox RenameTextBox;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.ComboBox ProfileComboBox;
    }
}