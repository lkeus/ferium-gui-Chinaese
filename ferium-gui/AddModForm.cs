using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace ferium_gui
{
	public partial class AddModForm : Form
	{
		Ferium ferium = new Ferium();

		public AddModForm()
		{
			InitializeComponent();
		}

		[DllImport("DwmApi")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue);

		private void AddModForm_Load(object sender, System.EventArgs e)
		{
			DwmSetWindowAttribute(Handle, 20, new[] { 1 });

			Location = Cursor.Position;
			DependencyComboBox.Text = "Required";
		}

		private void AddModButton_Click(object sender, System.EventArgs e)
		{
			if (ModIDTextBox.Text == string.Empty)
				return;

			ferium.IssueCommand("add" + (VersionCheckBox.Checked ? "" : " --dont-check-game-version ") + (ModLoaderCheckBox.Checked ? "" : " --dont-check-mod-loader ") + " --dependencies " + DependencyComboBox.Text.ToLower() + " " + ModIDTextBox.Text);
			Close();
		}

		private void ButtonCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
