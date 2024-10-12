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
    class pcDiscord : IApplication
    {
        private static RegistryKey checkpoint;
        private string discordPath;
        private string discordCachePath;
        private string discordGPUCachePath;

        public static int noFile;
        public static long fileSize;
        public static string[,] table;

        private int tableLength;

        public pcDiscord()
        {
            discordPath = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall\Discord").GetValue("InstallLocation").ToString();
            discordPath.Replace("/", @"\");
            discordCachePath = Path.Combine(pcPath.appData, @"discord\Cache");
            discordGPUCachePath = Path.Combine(pcPath.appData, @"discord\GPUCache");
        }

        public void Analysis()
        {
            noFile = 0;
            fileSize = 0;
            tableLength = 0;

            DirectoryInfo discordCacheDir = null;
            DirectoryInfo dicordGPUCacheDir = null;

            if (Directory.Exists(discordCachePath))
            {
                discordCacheDir = new DirectoryInfo(discordCachePath);
                tableLength += discordCacheDir.GetFiles("*.*", SearchOption.TopDirectoryOnly).Length;
            }
            if (Directory.Exists(discordGPUCachePath))
            {
                dicordGPUCacheDir = new DirectoryInfo(discordGPUCachePath);
                tableLength += dicordGPUCacheDir.GetFiles("*.*", SearchOption.TopDirectoryOnly).Length;
            }

            table = new string[tableLength, 2];

            if (Directory.Exists(discordCachePath))
            {
                foreach (FileInfo file in discordCacheDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                    pcAnalysisEngine.GetFilesData(ref table, ref noFile, ref fileSize, file);
            }
            if (Directory.Exists(discordGPUCachePath))
            {
                foreach (FileInfo file in dicordGPUCacheDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                    pcAnalysisEngine.GetFilesData(ref table, ref noFile, ref fileSize, file);
            }
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
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Discord";
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
                checkpoint = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall\Discord", false);
                if (checkpoint != null)
                    OK = true;
            }
            catch (NullReferenceException) { OK = false; }
            return OK;
        }
    }
}
