using Microsoft.Win32;
using Powered_Cleaner.Classes.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powered_Cleaner.Classes.Analysis.Games
{
    class pcSteam : IApplication
    {
        private static RegistryKey checkpoint;

        private string steamPath;
        private string steamPackagesPath;
        private string steamCachePath;
        private string LADsteamCachePath;

        public static int noFile;
        public static long fileSize;
        public static string[,] table;

        private int tableLength;

        public pcSteam()
        {
            steamPath = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam").GetValue("SteamPath").ToString();
            steamPath = steamPath.Replace("/", @"\");
            steamPackagesPath = Path.Combine(steamPath, "package");
            steamCachePath = Path.Combine(steamPath, @"appcache\httpcache");
            LADsteamCachePath = Path.Combine(pcPath.localAppData, @"Steam\htmlcache\Cache");
        }

        public void Analysis()
        {
            noFile = 0;
            fileSize = 0;
            tableLength = 0;

            DirectoryInfo steamCacheDir = null;
            DirectoryInfo LADsteamCacheDir = null;
            DirectoryInfo steamPackagesDir = null;

            #region Table Length
            if (Directory.Exists(steamCachePath))
            {
                steamCacheDir = new DirectoryInfo(steamCachePath);
                tableLength += steamCacheDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
            }
            if (Directory.Exists(LADsteamCachePath))
            {
                LADsteamCacheDir = new DirectoryInfo(LADsteamCachePath);
                tableLength += LADsteamCacheDir.GetFiles("*.*", SearchOption.TopDirectoryOnly).Length;
            }
            if (Directory.Exists(steamPackagesPath))
            {
                steamPackagesDir = new DirectoryInfo(steamPackagesPath);
                foreach (FileInfo file in steamPackagesDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                    if (file.Name != "steam_client_win32.installed" && file.Name != "steam_client_win32.manifest")
                        tableLength++;
            }
            #endregion

            table = new string[tableLength, 2];

            #region Caches
            if (Directory.Exists(steamCachePath))
            {
                foreach (FileInfo file in steamCacheDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref table, ref noFile, ref fileSize, file);
            }
            if (Directory.Exists(LADsteamCachePath))
            {
                foreach (FileInfo file in LADsteamCacheDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                    pcAnalysisEngine.GetFilesData(ref table, ref noFile, ref fileSize, file);
            }
            #endregion

            #region Packages
            if (Directory.Exists(steamPackagesPath))
            {
                foreach (FileInfo file in steamPackagesDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                {
                    if (file.Name != "steam_client_win32.installed" && file.Name != "steam_client_win32.manifest")
                    {
                        pcAnalysisEngine.GetFilesData(ref table, ref noFile, ref fileSize, file);
                    }
                }
            }
            #endregion

            fileSize /= 1024;
        }

        public void FillData(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, table);
        }

        public bool ShowData(DataGridView DtgAnalyze, int rowPos)
        {
            bool OK = false;
            if (fileSize != 0 && noFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Steam";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = fileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noFile;
                rowPos++;
                OK = true;
            }
            return OK;
        }

        public static bool Exists()
        {
            bool OK = false;
            try
            {
                checkpoint = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam", false);
                if (checkpoint != null)
                    OK = true;
            }
            catch (NullReferenceException) { OK = false; }
            return OK;
        }
    }
}