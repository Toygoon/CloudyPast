using CloudyPast.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CloudyPast {
    class CloudyPast : Application {
        [STAThread]
        public static void Main() {
            // Initializes an application
            CloudyPast app = new CloudyPast();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e) {
            // Calls the super method
            base.OnStartup(e);

            // Get pre-defined configs
            ConfigManager cm = new ConfigManager();
            cm.Generate();

            // Initializes GUI components
            InitComponents();
        }

        private void InitComponents() {
            // Create a new window
            Window main = new Window();
            main.Title = Const.WINDOW_TITLE;
            main.Show();

            // Create a new console if debug mode is enabled
            if (Const.DEBUG_MODE)
                NativeMethods.AllocConsole();
        }
    }
}
