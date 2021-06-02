using TelnetServer.Common;
using System.Diagnostics;
using System.Text;
using System;
using System.Linq;
using System.Collections.Generic;

namespace TelnetServer
{
    /// <summary>
    /// Сервис вызова командной строки.
    /// </summary>
    public class CmdService
    {
        private string _closeCmd = "exit";
        private char _delimiter = '|';
        private char _trimmed = ' ';

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
                StandardOutputEncoding = Encoding.GetEncoding(866), // OEM Russian
                StandardErrorEncoding = Encoding.GetEncoding(866),
                RedirectStandardInput = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            return processStartInfo;
        }

        /// <summary>
        /// Обрабатывает переданные комманды.
        /// </summary>
        public string Run(string command)
        {
            var process = new Process();
            process.StartInfo = GetProcessStartInfo();
            process.Start();

            var commands = ToCommandArray(command);

            foreach(var c in commands)
                process.StandardInput.WriteLine(c);

            process.StandardInput.WriteLine(_closeCmd);

            var errors = process.StandardError.ReadToEnd();
            var output = process.StandardOutput.ReadToEnd();

            return  !string.IsNullOrEmpty(errors) 
                    ? errors + Environment.NewLine + output 
                    : output;
        }

        /// <summary>
        /// Разбивает команды по разделителю и обрезает пробелы.
        /// </summary>
        private IEnumerable<string> ToCommandArray(string command)
        {
            return command.Split(_delimiter).Select(x => x.Trim(_trimmed));
        }
    }
}
