using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class AppPaths
    {
        public static readonly string AppLogPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
        public static readonly string AppSettingsPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings");
        public static readonly string IcoPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Ico");
        public static readonly string LoginInfoPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logins");
    }
}
