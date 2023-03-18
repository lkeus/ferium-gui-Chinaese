using System.Diagnostics;
using System.Text;
namespace ferium_gui
{
	public class Ferium
	{
        public void IssueCommand(string ferium_args)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "ferium.exe";
            cmd.StartInfo.Arguments = ferium_args;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.StandardOutputEncoding = Encoding.UTF8; // 指定字符编码
            cmd.Start();
            string output = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
            cmd.Close();
            // 这里可以将output输出到控制台或者记录日志
        }
    }
}
