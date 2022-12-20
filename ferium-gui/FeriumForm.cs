using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ferium_gui
{
	public partial class FeriumForm : Form
	{
		Ferium ferium = new Ferium();
		ConfigClass configclass = new ConfigClass();

		public FeriumForm()
		{
			InitializeComponent();
		}

		[DllImport("DwmApi")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue);

		private void FeriumForm_Load(object sender, EventArgs e)
		{
			DwmSetWindowAttribute(Handle, 20, new[] { 1 });

			//no config exists, lets make a profile
			if (!File.Exists(configclass.ConfigPath()))
			{
				var form = new AddProfileForm();
				form.ShowDialog();
			}

			//STILL doesn't exist, lets get out
			if (!File.Exists(configclass.ConfigPath()))
			{
				Environment.Exit(0);
			}

			LoadProfiles();
			LoadProfileMods();
		}

		private void ProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			if (cfg.profiles.Count == 1)
				return;

			int a = ProfileComboBox.SelectedIndex;

			ferium.IssueCommand("profile switch --profile-name " + cfg.profiles[a].name);

			LoadProfileMods();
		}

		private void ConfigureProfileButton_Click(object sender, EventArgs e)
		{
			var form = new ConfigProfileForm();
			form.ShowDialog();
			LoadProfiles();
		}

		private void AddModButton_Click(object sender, EventArgs e)
		{
			var form = new AddModForm();
			form.ShowDialog();
			LoadProfileMods();
		}

		private void RemoveModButton_Click(object sender, EventArgs e)
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			if (ModList.SelectedIndex == -1 || cfg.profiles[cfg.active_profile].mods.Count == 0)
				return;

			ferium.IssueCommand("remove " + "\"" + cfg.profiles[cfg.active_profile].mods[ModList.SelectedIndex].name + "\"");

			LoadProfileMods();
		}

		private void UpgradeModButton_Click(object sender, EventArgs e)
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			if (cfg.profiles[cfg.active_profile].mods.Count == 0)
			{
				MessageBox.Show("Your currently active profile has no mods to update!", "Error", MessageBoxButtons.OK);
				return;
			}

			ferium.IssueCommand("upgrade");

			MessageBox.Show("Mods have been updated to the active profile.", "Success", MessageBoxButtons.OK);
		}

		private void OpenModsButton_Click(object sender, EventArgs e)
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			try
			{
				Process.Start(cfg.profiles[cfg.active_profile].output_dir);
			}
			catch
			{
				MessageBox.Show("Output directory doesn't exist or is invalid!", "Error", MessageBoxButtons.OK);
			}
		}

		private void ModList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			if (ModList.SelectedIndex == -1 || cfg.profiles[cfg.active_profile].mods.Count == 0)
				return;

			ModInfo.Text = string.Empty;
			ModInfo.Text += "Name: " + cfg.profiles[cfg.active_profile].mods[ModList.SelectedIndex].name + "\n";

			var modtype = cfg.profiles[cfg.active_profile].mods[ModList.SelectedIndex].identifier;


			if (modtype.ModrinthProject != null)
			{
				ModInfo.Text += "Source: Modrinth\n";
				ModInfo.Text += "Project ID: " + modtype.ModrinthProject.ToString() + "\n";
			}

			else if (modtype.CurseForgeProject != 0)
			{
				ModInfo.Text += "Source: Curseforge\n";
				ModInfo.Text += "Project ID: " + modtype.CurseForgeProject.ToString() + "\n";
			}

			else if (modtype.GitHubRepository.Count == 2)
			{
				ModInfo.Text += "Source: Github\n";
				ModInfo.Text += "Project ID: " + modtype.GitHubRepository[0].ToString() + "/" + modtype.GitHubRepository[1].ToString() + "\n";
			}
		}

		private void LoadProfiles()
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			ProfileComboBox.Items.Clear();

			//load profile list
			foreach (var profile in cfg.profiles)
			{
				ProfileComboBox.Items.Add(profile.name);
			}

			ProfileComboBox.Text = cfg.profiles[cfg.active_profile].name;
		}

		private void LoadProfileMods()
		{
			var cfg = JsonConvert.DeserializeObject<ConfigClass.Root>(File.ReadAllText(configclass.ConfigPath()));

			ModList.Items.Clear();
			ModInfo.Text = string.Empty;

			//load profile mods
			foreach (var mod in cfg.profiles[cfg.active_profile].mods)
			{
				ModList.Items.Add(mod.name);
			}
		}
	}
}
