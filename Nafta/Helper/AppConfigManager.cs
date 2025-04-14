using System;
using System.Configuration;
using System.IO;

namespace Nafta.Helper
{
    public static class AppConfigManager
    {
        private static Configuration _customConfig;

        static AppConfigManager()
        {
            string devConfigPath = "App.Config.Development";

            if (File.Exists(devConfigPath))
            {
                try
                {
                    var map = new ExeConfigurationFileMap { ExeConfigFilename = devConfigPath };
                    _customConfig = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"⚠ Error loading config file '{devConfigPath}': {ex.Message}");
                    _customConfig = null;
                }
            }
        }

        public static string GetConnectionString(string name)
        {
            return _customConfig?.ConnectionStrings.ConnectionStrings[name]?.ConnectionString
                   ?? ConfigurationManager.ConnectionStrings[name]?.ConnectionString;
        }

        public static string GetAppSetting(string key)
        {
            return _customConfig?.AppSettings.Settings[key]?.Value
                   ?? ConfigurationManager.AppSettings[key];
        }
    }
}
