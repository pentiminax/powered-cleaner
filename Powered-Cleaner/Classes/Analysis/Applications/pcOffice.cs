using Microsoft.Win32;
using Powered_Cleaner.Classes.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powered_Cleaner.Classes.Analysis.Applications
{
    class pcOffice : IApplication
    {
        #region Variables
        private static string officeCheckpoint;
        private string LADofficeCachePath;
        private string ADofficeCachePath;
        private string recentPath;
        private string webServiceCachePath;
        private string fileCachePath;

        public static int noFile;
        public static long fileSize;
        public static string[,] table;

        private int tableLength;
        #endregion

        #region Constructor
        public pcOffice()
        {
            LADofficeCachePath = Path.Combine(pcPath.localAppData, @"Microsoft\Office");
            ADofficeCachePath = Path.Combine(pcPath.appData, @"Microsoft\Office");
            recentPath = Path.Combine(ADofficeCachePath, "Recent");
            webServiceCachePath = Path.Combine(LADofficeCachePath, @"16.0\WebServiceCache\AllUsers");
            fileCachePath = Path.Combine(LADofficeCachePath, @"16.0\OfficeFileCache");
        }
        #endregion

        #region Analysis - Fill Data
        public void Analysis()
        {
            noFile = 0;
            fileSize = 0;
            tableLength = 0;
            DirectoryInfo recentDir = null;
            DirectoryInfo webServiceCacheDir = null;
            DirectoryInfo fileCacheDir = null;

            if (Directory.Exists(recentPath))
            {
                recentDir = new DirectoryInfo(recentPath);
                tableLength += recentDir.GetFiles("*.*", SearchOption.TopDirectoryOnly).Length;
            }
            if (Directory.Exists(webServiceCachePath))
            {
                webServiceCacheDir = new DirectoryInfo(webServiceCachePath);
                tableLength += webServiceCacheDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
            }
            if (Directory.Exists(fileCachePath))
            {
                fileCacheDir = new DirectoryInfo(fileCachePath);
                tableLength += fileCacheDir.GetFiles("*.*", SearchOption.TopDirectoryOnly).Length;
            }

            table = new string[tableLength, 2];

            if (Directory.Exists(recentPath))
            {
                foreach (FileInfo file in recentDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                    pcAnalysisEngine.GetFilesData(ref table, ref noFile, ref fileSize, file);
            }
            if (Directory.Exists(webServiceCachePath))
            {
                foreach (FileInfo file in webServiceCacheDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref table, ref noFile, ref fileSize, file);
            }
            if (Directory.Exists(fileCachePath))
            {
                foreach (FileInfo file in fileCacheDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                    pcAnalysisEngine.GetFilesData(ref table, ref noFile, ref fileSize, file);
            }
            fileSize /= 1024;
        }

        public void FillData(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, table);
        }
        #endregion

        #region Show Data
        public bool ShowData(DataGridView DtgAnalyze, int rowPos)
        {
            bool OK = false;
            if (fileSize != 0 && noFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "MS Office 2016";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = fileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noFile;
                rowPos++;
                OK = true;
            }
            return OK;
        }
        #endregion

        #region Others methods
        public static bool Exists()
        {
            bool OK = false;
            try
            {
                officeCheckpoint = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Office\16.0\Common", false).ToString();
                OK = true;
            }
            catch (NullReferenceException) { OK = false; }
            return OK;
        }
        #endregion
    }
}
