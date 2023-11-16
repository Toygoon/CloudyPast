using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CloudyPast.Config {
    internal class ConfigManager {
        public bool Exists() {
            return System.IO.File.Exists(Const.CONFIG_FILE);
        }

        public void Generate(bool force = false) {
            if (Exists() && !force)
                return;

            AppSettingsReader ar = new AppSettingsReader();
            System.Configuration.Configuration c = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            c.AppSettings.Settings["Dir"].Value = "C:\\a";

            c.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            Console.WriteLine(c.AppSettings.Settings["Dir"]);
        }
    }
}
