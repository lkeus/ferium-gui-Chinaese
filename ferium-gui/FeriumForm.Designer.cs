namespace ferium_gui
{
    partial class FeriumForm
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
            this.UpgradeModButton = new System.Windows.Forms.Button();
            this.ModList = new System.Windows.Forms.ListBox();
            this.RemoveModButton = new System.Windows.Forms.Button();
            this.AddModButton = new System.Windows.Forms.Button();
            this.ConfigureProfileButton = new System.Windows.Forms.Button();
            this.ProfileComboBox = new System.Windows.Forms.ComboBox();
            this.ModInfo = new System.Windows.Forms.RichTextBox();
            this.ModLabel = new System.Windows.Forms.Label();
            this.LabelModDetails = new System.Windows.Forms.Label();
            this.LabelActiveProfile = new System.Windows.Forms.Label();
            this.OpenModsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpgradeModButton
            // 
            this.UpgradeModButton.Location = new System.Drawing.Point(202, 160);
            this.UpgradeModButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.UpgradeModButton.Name = "UpgradeModButton";
            this.UpgradeModButton.Size = new System.Drawing.Size(114, 29);
            this.UpgradeModButton.TabIndex = 1;
            this.UpgradeModButton.Text = "Update Mods";
            this.UpgradeModButton.UseVisualStyleBackColor = true;
            this.UpgradeModButton.Click += new System.EventHandler(this.UpgradeModButton_Click);
            // 
            // ModList
            // 
            this.ModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ModList.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ModList.FormattingEnabled = true;
            this.ModList.ItemHeight = 16;
            this.ModList.Location = new System.Drawing.Point(10, 89);
            this.ModList.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ModList.Name = "ModList";
            this.ModList.Size = new System.Drawing.Size(182, 228);
            this.ModList.TabIndex = 3;
            this.ModList.SelectedIndexChanged += new System.EventHandler(this.ModList_SelectedIndexChanged);
            // 
            // RemoveModButton
            // 
            this.RemoveModButton.Location = new System.Drawing.Point(202, 125);
            this.RemoveModButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RemoveModButton.Name = "RemoveModButton";
            this.RemoveModButton.Size = new System.Drawing.Size(114, 29);
            this.RemoveModButton.TabIndex = 4;
            this.RemoveModButton.Text = "Remove Mod";
            this.RemoveModButton.UseVisualStyleBackColor = true;
            this.RemoveModButton.Click += new System.EventHandler(this.RemoveModButton_Click);
            // 
            // AddModButton
            // 
            this.AddModButton.Location = new System.Drawing.Point(202, 89);
            this.AddModButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AddModButton.Name = "AddModButton";
            this.AddModButton.Size = new System.Drawing.Size(114, 29);
            this.AddModButton.TabIndex = 5;
            this.AddModButton.Text = "Add Mod";
            this.AddModButton.UseVisualStyleBackColor = true;
            this.AddModButton.Click += new System.EventHandler(this.AddModButton_Click);
            // 
            // ConfigureProfileButton
            // 
            this.ConfigureProfileButton.Location = new System.Drawing.Point(178, 23);
            this.ConfigureProfileButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ConfigureProfileButton.Name = "ConfigureProfileButton";
            this.ConfigureProfileButton.Size = new System.Drawing.Size(138, 29);
            this.ConfigureProfileButton.TabIndex = 6;
            this.ConfigureProfileButton.Text = "Configure Profiles";
            this.ConfigureProfileButton.UseVisualStyleBackColor = true;
            this.ConfigureProfileButton.Click += new System.EventHandler(this.ConfigureProfileButton_Click);
            // 
            // ProfileComboBox
            // 
            this.ProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfileComboBox.FormattingEnabled = true;
            this.ProfileComboBox.Location = new System.Drawing.Point(9, 26);
            this.ProfileComboBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ProfileComboBox.MaxDropDownItems = 100;
            this.ProfileComboBox.Name = "ProfileComboBox";
            this.ProfileComboBox.Size = new System.Drawing.Size(159, 24);
            this.ProfileComboBox.TabIndex = 7;
            this.ProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.ProfileComboBox_SelectedIndexChanged);
            // 
            // ModInfo
            // 
            this.ModInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ModInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ModInfo.Location = new System.Drawing.Point(9, 343);
            this.ModInfo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ModInfo.MaxLength = 2048;
            this.ModInfo.Name = "ModInfo";
            this.ModInfo.ReadOnly = true;
            this.ModInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ModInfo.Size = new System.Drawing.Size(307, 69);
            this.ModInfo.TabIndex = 9;
            this.ModInfo.Text = "";
            // 
            // ModLabel
            // 
            this.ModLabel.AutoSize = true;
            this.ModLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ModLabel.Location = new System.Drawing.Point(6, 69);
            this.ModLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ModLabel.Name = "ModLabel";
            this.ModLabel.Size = new System.Drawing.Size(57, 16);
            this.ModLabel.TabIndex = 10;
            this.ModLabel.Text = "Mod List";
            // 
            // LabelModDetails
            // 
            this.LabelModDetails.AutoSize = true;
            this.LabelModDetails.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelModDetails.Location = new System.Drawing.Point(9, 324);
            this.LabelModDetails.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelModDetails.Name = "LabelModDetails";
            this.LabelModDetails.Size = new System.Drawing.Size(79, 16);
            this.LabelModDetails.TabIndex = 11;
            this.LabelModDetails.Text = "Mod Details";
            // 
            // LabelActiveProfile
            // 
            this.LabelActiveProfile.AutoSize = true;
            this.LabelActiveProfile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelActiveProfile.Location = new System.Drawing.Point(6, 6);
            this.LabelActiveProfile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelActiveProfile.Name = "LabelActiveProfile";
            this.LabelActiveProfile.Size = new System.Drawing.Size(85, 16);
            this.LabelActiveProfile.TabIndex = 12;
            this.LabelActiveProfile.Text = "Active Profile";
            // 
            // OpenModsButton
            // 
            this.OpenModsButton.Location = new System.Drawing.Point(202, 195);
            this.OpenModsButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.OpenModsButton.Name = "OpenModsButton";
            this.OpenModsButton.Size = new System.Drawing.Size(114, 29);
            this.OpenModsButton.TabIndex = 13;
            this.OpenModsButton.Text = "Open Mod Dir";
            this.OpenModsButton.UseVisualStyleBackColor = true;
            this.OpenModsButton.Click += new System.EventHandler(this.OpenModsButton_Click);
            // 
            // FeriumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(325, 420);
            this.Controls.Add(this.OpenModsButton);
            this.Controls.Add(this.LabelActiveProfile);
            this.Controls.Add(this.LabelModDetails);
            this.Controls.Add(this.ModLabel);
            this.Controls.Add(this.ModInfo);
            this.Controls.Add(this.ProfileComboBox);
            this.Controls.Add(this.ConfigureProfileButton);
            this.Controls.Add(this.AddModButton);
            this.Controls.Add(this.RemoveModButton);
            this.Controls.Add(this.ModList);
            this.Controls.Add(this.UpgradeModButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "FeriumForm";
            this.Text = "Ferium-GUI";
            this.Load += new System.EventHandler(this.FeriumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UpgradeModButton;
        private System.Windows.Forms.ListBox ModList;
        private System.Windows.Forms.Button RemoveModButton;
        private System.Windows.Forms.Button AddModButton;
        private System.Windows.Forms.Button ConfigureProfileButton;
        private System.Windows.Forms.ComboBox ProfileComboBox;
        private System.Windows.Forms.RichTextBox ModInfo;
        private System.Windows.Forms.Label ModLabel;
        private System.Windows.Forms.Label LabelModDetails;
        private System.Windows.Forms.Label LabelActiveProfile;
        private System.Windows.Forms.Button OpenModsButton;
    }
}

