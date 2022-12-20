using System;
using System.Collections.Generic;
using System.IO;

namespace ferium_gui
{
	public class ConfigClass
	{
		static readonly string userfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		const string defaultconfigpath = ".config\\ferium\\config.json";
		public string configpath = "";

		public string ConfigPath()
		{
			var config = System.Environment.GetEnvironmentVariable("FERIUM_CONFIG_FILE");

			if (config != null)
				return configpath = config;
			else
				return configpath = Path.Combine(userfolder, defaultconfigpath);
		}

		public class Identifier
		{
			public string ModrinthProject { get; set; }
			public int CurseForgeProject { get; set; }
			public List<string> GitHubRepository { get; set; }
		}

		public class Mod
		{
			public string name { get; set; }
			public Identifier identifier { get; set; }
		}

		public class Profile
		{
			public string name { get; set; }
			public string output_dir { get; set; }
			public string game_version { get; set; }
			public string mod_loader { get; set; }
			public List<Mod> mods { get; set; }
		}

		public class Root
		{
			public int active_profile { get; set; }
			public int active_modpack { get; set; }
			public List<Profile> profiles { get; set; }
			public List<object> modpacks { get; set; }
		}
	}
}
