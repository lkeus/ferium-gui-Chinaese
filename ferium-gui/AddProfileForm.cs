using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ferium_gui
{
	public partial class AddProfileForm : Form
	{
		Ferium ferium = new Ferium();
		ConfigClass configclass = new ConfigClass();

		static readonly string defaultmoddir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\mods";
		string mod_output = defaultmoddir;

		public AddProfileForm()
		{
			InitializeComponent();
		}

		[DllImport("DwmApi")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue);

		private void AddProfileForm_Load(object sender, EventArgs e)
		{
			DwmSetWindowAttribute(Handle, 20, new[] { 1 });

			Location = Cursor.Position;
			ModLoaderComboBox.Text = "Fabric";

			if (!File.Exists(configclass.ConfigPath()))
			{
				ProfileComboBox.Enabled = false;
			}
			else
			{
				LoadProfiles();
			}

		}

		private void ChangeModDirButton_Click(object sender, EventArgs e)
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			CommonOpenFileDialog choosedirFolderDialog = new CommonOpenFileDialog();

			choosedirFolderDialog.DefaultDirectory = mod_output;
			choosedirFolderDialog.IsFolderPicker = true;

			if (choosedirFolderDialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				mod_output = choosedirFolderDialog.FileName;
			}
		}

		private void AddProfileButton_Click(object sender, EventArgs e)
		{
			string import_profile = string.Empty;

			if (File.Exists(configclass.ConfigPath()))
			{
				var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

				if (ProfileComboBox.Enabled && ProfileComboBox.Text != "None")
					import_profile = " --import \"" + ProfileComboBox.Text + "\"";

				foreach (var profile in cfg.profiles)
				{
					if (profile.name == RenameTextBox.Text)
					{
						MessageBox.Show("A profile named " + RenameTextBox.Text + " already exists!", "Error", MessageBoxButtons.OK);
						return;
					}
				}
			}

			if (RenameTextBox.Text == string.Empty)
			{
				MessageBox.Show("Profile name can't be empty!", "Error", MessageBoxButtons.OK);
				return;
			}

			if (ProfileVersionTextBox.Text == string.Empty)
			{
				MessageBox.Show("Minecraft Version can't be empty!", "Error", MessageBoxButtons.OK);
				return;
			}

			ferium.IssueCommand("profile create" + import_profile + " --game-version \"" + ProfileVersionTextBox.Text + "\" --mod-loader \"" + ModLoaderComboBox.Text.ToLower() + "\" --name \"" + RenameTextBox.Text + "\"");
			Close();
		}

		private void LoadProfiles()
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			//load profile list
			ProfileComboBox.Items.Clear();

			ProfileComboBox.Items.Add("None");

			foreach (var profile in cfg.profiles)
			{
				ProfileComboBox.Items.Add(profile.name);
			}

			ProfileComboBox.Text = "None";
			ProfileComboBox.SelectedIndex = 0;
		}
	}
}