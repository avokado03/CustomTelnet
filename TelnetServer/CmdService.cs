using TelnetServer.Common;
using System.Diagnostics;
using System.Text;

namespace TelnetServer
{
    /// <summary>
    /// Сервис вызова командной строки.
    /// </summary>
    public class CmdService
    {
        /// <summary>
        /// Фабричный метод для опций процесса <see cref="ProcessStartInfo"/>.
        /// </summary>
        private ProcessStartInfo GetProcessStartInfo()
        {
            var processStartInfo = new ProcessStartInfo()
            {
                FileName = ConfigReader.Read(Configurations.CMD_PATH),
                WorkingDirectory = ConfigReader.Read(Configurations.WORKING_DIRECTORY),
                CreateNoWindow = true,
                UseShellExecute = false,
                StandardOutputEncoding = Encoding.GetEncoding(866),
                StandardErrorEncoding = Encoding.Unicode,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            return processStartInfo;
        }

        public string Run(string command)
        {
            var process = new Process();
            process.StartInfo = GetProcessStartInfo();
            process.Start();

            process.StandardInput.WriteLine(command);
            process.StandardInput.WriteLine("exit");

            var result = process.StandardOutput.ReadToEnd();
            return result;
        }
    }
}
