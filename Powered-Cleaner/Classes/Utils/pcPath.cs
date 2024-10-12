using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powered_Cleaner.Classes.Utils
{
    class pcPath
    {
        public static string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string windows = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        public static string programData = Environment.GetEnvironmentVariable("ProgramData");
        public static string currentUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string programFilesX86 = Environment.GetEnvironmentVariable("PROGRAMFILES(X86)");
        public static string programFiles = Environment.GetEnvironmentVariable("PROGRAMFILES");
    }
}
