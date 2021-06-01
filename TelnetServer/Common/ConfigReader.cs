using System.Configuration;

namespace TelnetServer.Common
{
    /// <summary>
    /// Класс для работы с конфигурацией приложения.
    /// </summary>
    public static class ConfigReader
    {
        /// <summary>
        /// Чтение конфигурации.
        /// </summary>
        public static string Read(string key)
        {
            var value = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrEmpty(value))
                throw new ConfigurationErrorsException($"Configuration {key} not found.");
            return value;
        }
    }
}
