using System.Diagnostics;

namespace ferium_gui
{
	public class Ferium
	{
		public void IssueCommand(string ferium_args)
		{
			Process cmd = new Process();
			cmd.StartInfo.FileName = "cmd.exe";
			cmd.StartInfo.RedirectStandardInput = true;
			cmd.StartInfo.CreateNoWindow = true;
			cmd.StartInfo.UseShellExecute = false;
			cmd.Start();
			cmd.StandardInput.WriteLine("ferium " + ferium_args);
			cmd.StandardInput.Flush();
			cmd.StandardInput.Close();
			cmd.WaitForExit();
			cmd.Close();
		}
	}
}
