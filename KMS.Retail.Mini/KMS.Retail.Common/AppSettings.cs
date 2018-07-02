using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Retail.Common
{
    public static class AppSettings
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        public static string[] ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    logger.Info("AppSettings is empty.");
                }
                return appSettings.AllKeys;
               
            }
            catch (ConfigurationErrorsException e)
            {
                logger.Error("Error reading app settings {0}",e);
                return null;
            }
        }

        public static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";

                logger.Info(result);

                return result;
            }
            catch (ConfigurationErrorsException ex)
            {
                logger.Error("Error reading app settings {0}",ex);
                return string.Empty;
            }
        }

        public static bool AddUpdateSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                return true;
            }
            catch (ConfigurationErrorsException ex)
            {
                logger.Error("Error writing app settings {0}",ex);
                return false;
            }
        }
    }
}
