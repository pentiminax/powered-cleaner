using Microsoft.Win32;
using Powered_Cleaner.Classes.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powered_Cleaner.Classes.Analysis
{
    public class pcFirefox
    {
        #region DEFAULT
        private string defaultRoot;
        private string defaultData;
        private string defaultCache;
        private string defaultHistory;
        #endregion

        #region Path
        private static string firefoxPath;
        private string defaultUserPath;
        private string firefoxCachePath;
        private string firefoxHistoryPath;
        #endregion

        #region Variables
        private static int noCacheFile;
        private static long cacheSize;
        private static string[,] cacheTable;

        private static int noHistoryFile;
        private static long historySize;
        private static string[,] histTable;

        private static int rowPos;
        #endregion

        #region Constructor
        public pcFirefox()
        {
            defaultRoot = Path.Combine(pcPath.localAppData, "Mozilla\\Firefox\\Profiles\\");
            defaultData = Directory.GetDirectories(defaultRoot).GetValue(0).ToString();
            defaultCache = defaultData + "\\cache2";
            defaultHistory = defaultData + "\\thumbnails";
            defaultUserPath = Path.Combine(pcPath.localAppData, defaultData);
            firefoxCachePath = Path.Combine(pcPath.localAppData, defaultCache);
            firefoxHistoryPath = Path.Combine(pcPath.localAppData, defaultHistory);
        }
        #endregion

        #region Internet Cache
        public  void InternetCache()
        {
            noCacheFile = 0;
            cacheSize = 0;
            DirectoryInfo firefoxDefaultUser = new DirectoryInfo(defaultUserPath);
            DirectoryInfo firefoxCacheDirectory = new DirectoryInfo(firefoxCachePath);

            if (Directory.Exists(firefoxCachePath))
            {
                cacheTable = new string[firefoxCacheDirectory.GetFiles("*.*", SearchOption.AllDirectories).Length, 2];
                foreach (FileInfo file in firefoxCacheDirectory.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
                }
                cacheSize = cacheSize / 1024;
            }
        }
        public static void FillInternetCache(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, cacheTable);
        }
        #endregion

        #region Internet History
        public void InternetHistory()
        {
            noHistoryFile = 0;
            historySize = 0;
            DirectoryInfo HistoryDirectory = new DirectoryInfo(firefoxHistoryPath);
            if (Directory.Exists(firefoxHistoryPath))
            {
                histTable = new string[HistoryDirectory.GetFiles("*.*", SearchOption.AllDirectories).Length, 2];
                foreach (FileInfo file in HistoryDirectory.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    pcAnalysisEngine.GetFilesData(ref histTable, ref noHistoryFile, ref historySize, file);
                }
                historySize = historySize / 1024;
            }
        }
        public void FillInternetHistory(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, histTable);
        }
        #endregion

        #region Analysis
        public void Analysis()
        {
            InternetCache();
            InternetHistory();
        }
        #endregion

        #region Show Data
        public void ShowInternetCache(DataGridView DtgAnalyze)
        {
            if (cacheSize != 0 && noCacheFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Firefox - Internet Cache";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = cacheSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noCacheFile;
                rowPos++;
            }
        }

        public void ShowInternetHistory(DataGridView DtgAnalyze)
        {
            if (historySize != 0 && noHistoryFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Firefox - Internet History";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = historySize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noHistoryFile;
                rowPos++;
            }
        }

        public void ShowData(DataGridView DtgAnalyze)
        {
            ShowInternetCache(DtgAnalyze);
            ShowInternetHistory(DtgAnalyze);
        }
        #endregion

        #region Methods
        public static bool Exists()
        {
            bool OK = false;
            try
            {
                firefoxPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\App Paths\firefox.exe", "Path", "").ToString();
                if (firefoxPath != "")
                    OK = true;
            }
            catch (Exception){}
            return OK;
        }

        public static string GetFirefoxPath()
        {
            return firefoxPath;
        }

        public static string GetFirefoxFile()
        {
            return Path.Combine(firefoxPath, "firefox.exe");
        }
        #endregion

        #region Assessors
        public static long GetCacheSize()
        {
            return cacheSize;
        }
        public static int GetCacheFiles()
        {
            return noCacheFile;
        }
        public static int GetHistFiles()
        {
            return noHistoryFile;
        }
        public static long GetHistSize()
        {
            return historySize;
        }
        public static string[,] GetCacheTable()
        {
            return cacheTable;
        }
        public static string[,] GetHistTable()
        {
            return histTable;
        }
        public static void SetRowPos(int value)
        {
            rowPos = value;
        }
        #endregion
    }
}