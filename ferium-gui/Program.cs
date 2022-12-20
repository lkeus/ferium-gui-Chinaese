using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ferium_gui
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (!File.Exists("ferium.exe"))
			{
                DialogResult opengithub = MessageBox.Show("ferium.exe not found, must be in same directory as ferium-gui.exe!\nOpen Ferium Github?", "Error", MessageBoxButtons.YesNo);
				if (opengithub == DialogResult.Yes)
				{
                    Process.Start("https://github.com/gorilla-devs/ferium");
                }
				Environment.Exit(0);
			}

			Application.Run(new FeriumForm());
		}
	}
}
