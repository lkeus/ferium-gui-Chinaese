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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_open_url = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpgradeModButton
            // 
            this.UpgradeModButton.Location = new System.Drawing.Point(248, 76);
            this.UpgradeModButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.UpgradeModButton.Name = "UpgradeModButton";
            this.UpgradeModButton.Size = new System.Drawing.Size(142, 35);
            this.UpgradeModButton.TabIndex = 1;
            this.UpgradeModButton.Text = "检查更新并下载";
            this.UpgradeModButton.UseVisualStyleBackColor = true;
            this.UpgradeModButton.Click += new System.EventHandler(this.UpgradeModButton_Click);
            // 
            // ModList
            // 
            this.ModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ModList.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ModList.FormattingEnabled = true;
            this.ModList.ItemHeight = 20;
            this.ModList.Location = new System.Drawing.Point(6, 29);
            this.ModList.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ModList.Name = "ModList";
            this.ModList.Size = new System.Drawing.Size(241, 484);
            this.ModList.TabIndex = 3;
            this.ModList.SelectedIndexChanged += new System.EventHandler(this.ModList_SelectedIndexChanged);
            // 
            // RemoveModButton
            // 
            this.RemoveModButton.Location = new System.Drawing.Point(390, 41);
            this.RemoveModButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RemoveModButton.Name = "RemoveModButton";
            this.RemoveModButton.Size = new System.Drawing.Size(146, 35);
            this.RemoveModButton.TabIndex = 4;
            this.RemoveModButton.Text = "删除模组";
            this.RemoveModButton.UseVisualStyleBackColor = true;
            this.RemoveModButton.Click += new System.EventHandler(this.RemoveModButton_Click);
            // 
            // AddModButton
            // 
            this.AddModButton.Location = new System.Drawing.Point(248, 41);
            this.AddModButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AddModButton.Name = "AddModButton";
            this.AddModButton.Size = new System.Drawing.Size(142, 35);
            this.AddModButton.TabIndex = 5;
            this.AddModButton.Text = "添加模组";
            this.AddModButton.UseVisualStyleBackColor = true;
            this.AddModButton.Click += new System.EventHandler(this.AddModButton_Click);
            // 
            // ConfigureProfileButton
            // 
            this.ConfigureProfileButton.Location = new System.Drawing.Point(394, 6);
            this.ConfigureProfileButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ConfigureProfileButton.Name = "ConfigureProfileButton";
            this.ConfigureProfileButton.Size = new System.Drawing.Size(138, 29);
            this.ConfigureProfileButton.TabIndex = 6;
            this.ConfigureProfileButton.Text = "配置";
            this.ConfigureProfileButton.UseVisualStyleBackColor = true;
            this.ConfigureProfileButton.Click += new System.EventHandler(this.ConfigureProfileButton_Click);
            // 
            // ProfileComboBox
            // 
            this.ProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfileComboBox.FormattingEnabled = true;
            this.ProfileComboBox.Location = new System.Drawing.Point(252, 7);
            this.ProfileComboBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ProfileComboBox.MaxDropDownItems = 100;
            this.ProfileComboBox.Name = "ProfileComboBox";
            this.ProfileComboBox.Size = new System.Drawing.Size(132, 28);
            this.ProfileComboBox.TabIndex = 7;
            this.ProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.ProfileComboBox_SelectedIndexChanged);
            // 
            // ModInfo
            // 
            this.ModInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ModInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ModInfo.Location = new System.Drawing.Point(9, 539);
            this.ModInfo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ModInfo.MaxLength = 2048;
            this.ModInfo.Name = "ModInfo";
            this.ModInfo.ReadOnly = true;
            this.ModInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ModInfo.Size = new System.Drawing.Size(238, 112);
            this.ModInfo.TabIndex = 9;
            this.ModInfo.Text = "";
            // 
            // ModLabel
            // 
            this.ModLabel.AutoSize = true;
            this.ModLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ModLabel.Location = new System.Drawing.Point(5, 10);
            this.ModLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ModLabel.Name = "ModLabel";
            this.ModLabel.Size = new System.Drawing.Size(77, 20);
            this.ModLabel.TabIndex = 10;
            this.ModLabel.Text = "模组列表";
            // 
            // LabelModDetails
            // 
            this.LabelModDetails.AutoSize = true;
            this.LabelModDetails.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelModDetails.Location = new System.Drawing.Point(5, 516);
            this.LabelModDetails.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelModDetails.Name = "LabelModDetails";
            this.LabelModDetails.Size = new System.Drawing.Size(99, 20);
            this.LabelModDetails.TabIndex = 11;
            this.LabelModDetails.Text = "Mod Details";
            // 
            // LabelActiveProfile
            // 
            this.LabelActiveProfile.AutoSize = true;
            this.LabelActiveProfile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelActiveProfile.Location = new System.Drawing.Point(131, 6);
            this.LabelActiveProfile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelActiveProfile.Name = "LabelActiveProfile";
            this.LabelActiveProfile.Size = new System.Drawing.Size(111, 20);
            this.LabelActiveProfile.TabIndex = 12;
            this.LabelActiveProfile.Text = "当前配置文件";
            // 
            // OpenModsButton
            // 
            this.OpenModsButton.Location = new System.Drawing.Point(390, 76);
            this.OpenModsButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.OpenModsButton.Name = "OpenModsButton";
            this.OpenModsButton.Size = new System.Drawing.Size(146, 35);
            this.OpenModsButton.TabIndex = 13;
            this.OpenModsButton.Text = "打开模组文件夹";
            this.OpenModsButton.UseVisualStyleBackColor = true;
            this.OpenModsButton.Click += new System.EventHandler(this.OpenModsButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "确定修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(248, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "汉化名称";
            // 
            // button_open_url
            // 
            this.button_open_url.Location = new System.Drawing.Point(368, 172);
            this.button_open_url.Name = "button_open_url";
            this.button_open_url.Size = new System.Drawing.Size(129, 35);
            this.button_open_url.TabIndex = 17;
            this.button_open_url.Text = "打开模组网站";
            this.button_open_url.UseVisualStyleBackColor = true;
            this.button_open_url.Click += new System.EventHandler(this.button_open_url_Click);
            // 
            // FeriumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(546, 663);
            this.Controls.Add(this.button_open_url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_open_url;
    }
}

