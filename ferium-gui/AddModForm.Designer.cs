namespace ferium_gui
{
    partial class AddModForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModForm));
            this.ModIDToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ModIDTextBox = new System.Windows.Forms.TextBox();
            this.AddModButton = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.DependencyComboBox = new System.Windows.Forms.ComboBox();
            this.ModIDLabel = new System.Windows.Forms.Label();
            this.DependencyLabel = new System.Windows.Forms.Label();
            this.VersionCheckBox = new System.Windows.Forms.CheckBox();
            this.ModLoaderCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ModIDToolTip
            // 
            this.ModIDToolTip.AutoPopDelay = 5000;
            this.ModIDToolTip.InitialDelay = 500;
            this.ModIDToolTip.ReshowDelay = 100;
            // 
            // ModIDTextBox
            // 
            this.ModIDTextBox.Location = new System.Drawing.Point(14, 25);
            this.ModIDTextBox.Name = "ModIDTextBox";
            this.ModIDTextBox.Size = new System.Drawing.Size(114, 22);
            this.ModIDTextBox.TabIndex = 1;
            this.ModIDToolTip.SetToolTip(this.ModIDTextBox, resources.GetString("ModIDTextBox.ToolTip"));
            // 
            // AddModButton
            // 
            this.AddModButton.Location = new System.Drawing.Point(42, 83);
            this.AddModButton.Name = "AddModButton";
            this.AddModButton.Size = new System.Drawing.Size(86, 25);
            this.AddModButton.TabIndex = 2;
            this.AddModButton.Text = "Add Mod";
            this.AddModButton.UseVisualStyleBackColor = true;
            this.AddModButton.Click += new System.EventHandler(this.AddModButton_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(145, 83);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(86, 25);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // DependencyComboBox
            // 
            this.DependencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DependencyComboBox.FormattingEnabled = true;
            this.DependencyComboBox.Items.AddRange(new object[] {
            "None",
            "Required",
            "All"});
            this.DependencyComboBox.Location = new System.Drawing.Point(145, 25);
            this.DependencyComboBox.MaxDropDownItems = 3;
            this.DependencyComboBox.Name = "DependencyComboBox";
            this.DependencyComboBox.Size = new System.Drawing.Size(138, 24);
            this.DependencyComboBox.TabIndex = 4;
            // 
            // ModIDLabel
            // 
            this.ModIDLabel.AutoSize = true;
            this.ModIDLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ModIDLabel.Location = new System.Drawing.Point(12, 9);
            this.ModIDLabel.Name = "ModIDLabel";
            this.ModIDLabel.Size = new System.Drawing.Size(53, 16);
            this.ModIDLabel.TabIndex = 5;
            this.ModIDLabel.Text = "Mod ID:";
            // 
            // DependencyLabel
            // 
            this.DependencyLabel.AutoSize = true;
            this.DependencyLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DependencyLabel.Location = new System.Drawing.Point(142, 8);
            this.DependencyLabel.Name = "DependencyLabel";
            this.DependencyLabel.Size = new System.Drawing.Size(136, 16);
            this.DependencyLabel.TabIndex = 6;
            this.DependencyLabel.Text = "Install Dependencies:";
            // 
            // VersionCheckBox
            // 
            this.VersionCheckBox.AutoSize = true;
            this.VersionCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VersionCheckBox.Location = new System.Drawing.Point(14, 56);
            this.VersionCheckBox.Name = "VersionCheckBox";
            this.VersionCheckBox.Size = new System.Drawing.Size(120, 20);
            this.VersionCheckBox.TabIndex = 7;
            this.VersionCheckBox.Text = "Check Version?";
            this.VersionCheckBox.UseVisualStyleBackColor = true;
            // 
            // ModLoaderCheckBox
            // 
            this.ModLoaderCheckBox.AutoSize = true;
            this.ModLoaderCheckBox.Checked = true;
            this.ModLoaderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ModLoaderCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ModLoaderCheckBox.Location = new System.Drawing.Point(145, 56);
            this.ModLoaderCheckBox.Name = "ModLoaderCheckBox";
            this.ModLoaderCheckBox.Size = new System.Drawing.Size(147, 20);
            this.ModLoaderCheckBox.TabIndex = 8;
            this.ModLoaderCheckBox.Text = "Check Mod Loader?";
            this.ModLoaderCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddModForm
            // 
            this.AcceptButton = this.AddModButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(297, 122);
            this.Controls.Add(this.ModLoaderCheckBox);
            this.Controls.Add(this.VersionCheckBox);
            this.Controls.Add(this.DependencyLabel);
            this.Controls.Add(this.ModIDLabel);
            this.Controls.Add(this.DependencyComboBox);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.AddModButton);
            this.Controls.Add(this.ModIDTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddModForm";
            this.Text = "Add Mod";
            this.Load += new System.EventHandler(this.AddModForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ModIDToolTip;
        private System.Windows.Forms.TextBox ModIDTextBox;
        private System.Windows.Forms.Button AddModButton;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ComboBox DependencyComboBox;
        private System.Windows.Forms.Label ModIDLabel;
        private System.Windows.Forms.Label DependencyLabel;
        private System.Windows.Forms.CheckBox VersionCheckBox;
        private System.Windows.Forms.CheckBox ModLoaderCheckBox;
    }
}