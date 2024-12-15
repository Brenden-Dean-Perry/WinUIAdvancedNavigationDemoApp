using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DemoUI
{
    internal static class ConfigManager
    {
        internal static string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        internal static string GetConnectionString(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }
    }
}
