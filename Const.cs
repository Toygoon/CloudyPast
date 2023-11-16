using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CloudyPast {
    internal class Const {
        public const string CONFIG_FILE = "App.config";
        public const string WINDOW_TITLE = "CloudyPast";
        public const bool DEBUG_MODE = true;
    }


    static class NativeMethods {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]

        public static extern bool AllocConsole();
    }
}
