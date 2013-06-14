using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RottenMovies.Common
{
    public static class AppSetting
    {

        public static string RottenAPIToken
        {
            get { return GetAppSettingString(Constants.AppSettingKeys.RottenAPIToken); }
        }

        private static string GetAppSettingString(string appKey)
        {
            return ConfigurationManager.AppSettings.Get(appKey);
        }
    }
}
