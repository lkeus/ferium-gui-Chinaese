using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ferium_gui
{
	public partial class ConfigProfileForm : Form
	{
		Ferium ferium = new Ferium();
		ConfigClass configclass = new ConfigClass();

		int config_profile = 0;
		string mod_output = "";

		public ConfigProfileForm()
		{
			InitializeComponent();
		}

		[DllImport("DwmApi")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue);

		private void ConfigProfileForm_Load(object sender, EventArgs e)
		{
			DwmSetWindowAttribute(Handle, 20, new[] { 1 });

			Location = Cursor.Position;
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));
			config_profile = cfg.active_profile;
			mod_output = cfg.profiles[config_profile].output_dir;
            LoadProfiles();
		}

		private void AddProfileButton_Click(object sender, EventArgs e)
		{
			var form = new AddProfileForm();
			form.ShowDialog();
			LoadProfiles();
		}

		private void ProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			config_profile = ProfileComboBox.SelectedIndex;
			mod_output = cfg.profiles[config_profile].output_dir;
			LoadProfileInfo();
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

		private void SaveProfileButton_Click(object sender, EventArgs e)
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			if (RenameTextBox.Text == string.Empty)
			{
				MessageBox.Show("Profile name can't be empty!", "Error", MessageBoxButtons.OK);
				return;
			}

			if (cfg.profiles[config_profile].name != RenameTextBox.Text)
			{
				foreach (var profile in cfg.profiles)
				{
					if (profile.name == RenameTextBox.Text)
					{
						MessageBox.Show("A profile named " + RenameTextBox.Text + " already exists!", "Error", MessageBoxButtons.OK);
						return;
					}
				}
			}

			if (ProfileVersionTextBox.Text == string.Empty)
			{
				MessageBox.Show("Minecraft Version can't be empty!", "Error", MessageBoxButtons.OK);
				return;
			}

			int previous_profile = cfg.active_profile;
			ferium.IssueCommand("profile switch --profile-name " + cfg.profiles[config_profile].name);
			ferium.IssueCommand("profile configure --game-version \"" + ProfileVersionTextBox.Text + "\" --mod-loader \"" + ModLoaderComboBox.Text.ToLower() + "\" --name \"" + RenameTextBox.Text + "\" --output-dir \"" + mod_output + "\"");
			ferium.IssueCommand("profile switch --profile-name " + cfg.profiles[previous_profile].name);
			Close();
		}

		private void DeleteProfileButton_Click(object sender, EventArgs e)
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			if (cfg.profiles.Count == 1)
			{
				MessageBox.Show("You can't delete the only profile you have!", "Delete Profile", MessageBoxButtons.OK);
				return;
			}

			DialogResult deleteconfirm = MessageBox.Show("Are you sure you want to delete the \"" + cfg.profiles[config_profile].name + "\" profile?", "Delete Profile", MessageBoxButtons.YesNo);
			if (deleteconfirm == DialogResult.Yes)
			{
				cfg.active_profile = 0;
				ferium.IssueCommand("profile switch --profile-name " + cfg.profiles[0].name);

				ferium.IssueCommand("profile delete --profile-name \"" + cfg.profiles[config_profile].name + "\"");

				LoadProfiles();
			}
		}

		private void LoadProfiles()
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			//load profile list
			ProfileComboBox.Items.Clear();

			foreach (var profile in cfg.profiles)
			{
				ProfileComboBox.Items.Add(profile.name);
			}
			
			ProfileComboBox.Text = cfg.profiles[cfg.active_profile].name;
			ProfileComboBox.SelectedIndex = config_profile;
		}

		private void LoadProfileInfo()
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			RenameTextBox.Clear();
			RenameTextBox.Text = cfg.profiles[config_profile].name;

			ProfileVersionTextBox.Clear();
			ProfileVersionTextBox.Text = cfg.profiles[config_profile].game_version;

			ModLoaderComboBox.Text = cfg.profiles[config_profile].mod_loader;
		}
	}
}
