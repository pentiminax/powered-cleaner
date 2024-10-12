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
    public class pcChrome
    {
        #region CONST
        private const string chrome_User_Data = @"Google\Chrome\User Data\";
        private const string chrome_User_Data_Crash_Reports = chrome_User_Data + @"Crashpad\reports";
        private const string chrome_User_Data_Profile_Cache = chrome_User_Data + @"Profile 1\Cache";
        private const string chrome_User_Data_Default_Cache = chrome_User_Data + @"Default\Cache";
        private const string chrome_User_Data_Media_Cache = chrome_User_Data + @"Default\Media Cache";
        private const string chrome_User_Data_ApplicationCache = chrome_User_Data + @"Default\Application Cache";
        private const string chrome_User_Data_Default_FileSystem = chrome_User_Data + @"Default\File System";
        private const string chrome_User_Data_Default_ServiceWorker = chrome_User_Data + @"Default\Service Worker";
        private const string chrome_User_Data_ShaderCache = chrome_User_Data + @"ShaderCache";
        private const string chrome_User_Data_Default_GPUCache = chrome_User_Data + @"Default\GPUCache";
        #endregion

        #region Path
        private static string chromePath = Path.Combine(pcPath.localAppData, chrome_User_Data);
        private static string chromeCrashReportsPath = Path.Combine(pcPath.localAppData, chrome_User_Data_Crash_Reports);
        private string chromeCachePath = Path.Combine(pcPath.localAppData, chrome_User_Data_Default_Cache);
        private string chromeProfileCachePath = Path.Combine(pcPath.localAppData, chrome_User_Data_Profile_Cache);
        private string chromeMediaCachePath = Path.Combine(pcPath.localAppData, chrome_User_Data_Media_Cache);
        private string chromeApplicationCachePath = Path.Combine(pcPath.localAppData, chrome_User_Data_ApplicationCache);
        private string chromeFileSystemPath = Path.Combine(pcPath.localAppData, chrome_User_Data_Default_FileSystem);
        private string chromeServiceWorkerPath = Path.Combine(pcPath.localAppData, chrome_User_Data_Default_ServiceWorker);
        private string chromeShaderCachePath = Path.Combine(pcPath.localAppData, chrome_User_Data_ShaderCache);
        private string chromeGPUCachePath = Path.Combine(pcPath.localAppData, chrome_User_Data_Default_GPUCache);
        #endregion

        #region Variables
        private static int noCacheFile;
        private static long cacheSize;
        private static string[,] cacheTable;

        private static int noHistoryFile;
        private static long historySize;
        private static string[,] histTable;

        private static long dlHistorySize;
        private static int noDlHistFile;
        private static string[,] dlHistTable;

        private static long crashRepSize;
        private static int noCrashRepFile;
        private static string[,] crashRepTable;

        private static int rowPos = 0;
        #endregion

        #region Constructor
        public pcChrome()
        {

        }
        #endregion

        #region Internet Cache
        public void InternetCache()
        {
            noCacheFile = 0;
            cacheSize = 0;

            #region DirectoryInfo
            DirectoryInfo chromeDefaultUser = new DirectoryInfo(chromePath + "Default");
            DirectoryInfo chromeProfileUser = new DirectoryInfo(chromePath + "Profile 1");
            DirectoryInfo chromeFileSystemDir = new DirectoryInfo(chromeFileSystemPath);
            DirectoryInfo chromeServiceWorkerDir = new DirectoryInfo(chromeServiceWorkerPath);
            DirectoryInfo chromeCacheDirectory = new DirectoryInfo(chromeCachePath);
            DirectoryInfo chromeProfileCacheDir = new DirectoryInfo(chromeProfileCachePath);
            DirectoryInfo chromeMediaCacheDir = new DirectoryInfo(chromeMediaCachePath);
            DirectoryInfo chromeApplicationCacheDir = new DirectoryInfo(chromeApplicationCachePath);
            DirectoryInfo chromeShaderCacheDir = new DirectoryInfo(chromeShaderCachePath);
            DirectoryInfo chromeGPUCacheDir = new DirectoryInfo(chromeGPUCachePath);
            #endregion

            #region Table Length
            int tableLength = 0;
            if (Directory.Exists(chromeApplicationCachePath))
                tableLength += chromeApplicationCacheDir.GetFiles("*.*", SearchOption.AllDirectories).Length;

            if (Directory.Exists(chromeFileSystemPath))
                tableLength += +chromeFileSystemDir.GetFiles("*.*", SearchOption.AllDirectories).Length;

            if (Directory.Exists(chromeMediaCachePath))
                tableLength += chromeMediaCacheDir.GetFiles().Length;

            if (Directory.Exists(chromeCachePath))
                tableLength += chromeCacheDirectory.GetFiles().Length;

            if (Directory.Exists(chromeServiceWorkerPath))
                tableLength += chromeServiceWorkerDir.GetFiles("*.*", SearchOption.AllDirectories).Length;

            if (Directory.Exists(chromeGPUCachePath))
                tableLength += chromeGPUCacheDir.GetFiles("*.*", SearchOption.AllDirectories).Length;

            if (Directory.Exists(chromeShaderCachePath))
                tableLength += chromeShaderCacheDir.GetFiles("*.*", SearchOption.AllDirectories).Length;

            if (Directory.Exists(chromeProfileCachePath))
                tableLength += chromeProfileCacheDir.GetFiles().Length; 
            #endregion

            cacheTable = new string[tableLength, 2];

            #region Get Files Data
            if (Directory.Exists(chromeProfileCachePath))
                foreach (FileInfo file in chromeProfileCacheDir.GetFiles())
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            if (Directory.Exists(chromeCachePath))
            {
                foreach (FileInfo file in chromeCacheDirectory.GetFiles())
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            }
            if (Directory.Exists(chromeMediaCachePath))
            {
                foreach (FileInfo file in chromeMediaCacheDir.GetFiles())
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            }
            if (Directory.Exists(chromeShaderCachePath))
            {
                foreach (FileInfo file in chromeShaderCacheDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            }
            if (Directory.Exists(chromeGPUCachePath))
            {
                foreach (FileInfo file in chromeGPUCacheDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            }
            if (Directory.Exists(chromeApplicationCachePath))
            {
                foreach (FileInfo file in chromeApplicationCacheDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            }
            if (Directory.Exists(chromeFileSystemPath))
            {
                foreach (FileInfo file in chromeFileSystemDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);

            }
            if (Directory.Exists(chromeServiceWorkerPath))
                foreach (FileInfo file in chromeServiceWorkerDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);

            #endregion

            cacheSize /= 1024;
        }
        public void FillInternetCache(DataGridView DtgData)
        {
                pcAnalysisEngine.FillData(DtgData, cacheTable);
        }
        #endregion

        #region Internet History
        public void InternetHistory()
        {
            noHistoryFile = 0;
            historySize = 0;
            int tableLength = 0;
            DirectoryInfo chromeDefaultUser = new DirectoryInfo(chromePath + "Default");
            string visitedLinks = chromeDefaultUser.ToString() + "\\Visited Links";
            string currentTabs = chromeDefaultUser.ToString() + "\\Current Tabs";
            string topSites = chromeDefaultUser.ToString() + "\\Top Sites";
            string historyProviderCache = chromeDefaultUser.ToString() + "\\History Provider Cache";
            string networkActionPredictor = chromeDefaultUser.ToString() + "\\Network Action Predictor";
            string lastTabs = chromeDefaultUser.ToString() + "\\Last Tabs";

            #region FileInfo
            FileInfo visitedLinksInfo = new FileInfo(visitedLinks);
            FileInfo currentTabsInfo = new FileInfo(currentTabs);
            FileInfo topSitesInfo = new FileInfo(topSites);
            FileInfo historyProviderCacheInfo = new FileInfo(historyProviderCache);
            FileInfo networkActionPredictorInfo = new FileInfo(networkActionPredictor);
            FileInfo lastTabsInfo = new FileInfo(lastTabs);

            if (File.Exists(visitedLinks))
                tableLength++;
            if (File.Exists(currentTabs))
                tableLength++;
            if (File.Exists(topSites))
                tableLength++;
            if (File.Exists(historyProviderCache))
                tableLength++;
            if (File.Exists(networkActionPredictor))
                tableLength++;
            if (File.Exists(lastTabs))
                tableLength++;
            #endregion
            histTable = new string[tableLength, 2];
            if (File.Exists(visitedLinks))
            {
                histTable[noHistoryFile, 0] = visitedLinksInfo.FullName;
                histTable[noHistoryFile, 1] = (visitedLinksInfo.Length / 1024).ToString();
                noHistoryFile++;
                historySize += (int)(visitedLinksInfo.Length / 1024);
            }
            if (File.Exists(currentTabs))
            {
                histTable[noHistoryFile, 0] = currentTabsInfo.FullName;
                histTable[noHistoryFile, 1] = (currentTabsInfo.Length / 1024).ToString();
                noHistoryFile++;
                historySize += (int)(currentTabsInfo.Length / 1024);
            }
            if (File.Exists(topSites))
            {
                histTable[noHistoryFile, 0] = topSitesInfo.FullName;
                histTable[noHistoryFile, 1] = (topSitesInfo.Length / 1024).ToString();
                noHistoryFile++;
                historySize += (int)(topSitesInfo.Length / 1024);
            }
            if (File.Exists(historyProviderCache))
            {
                histTable[noHistoryFile, 0] = historyProviderCacheInfo.FullName;
                histTable[noHistoryFile, 1] = (historyProviderCacheInfo.Length / 1024).ToString();
                noHistoryFile++;
                historySize += (int)(historyProviderCacheInfo.Length / 1024);
            }
            if (File.Exists(networkActionPredictor))
            {
                histTable[noHistoryFile, 0] = networkActionPredictorInfo.FullName;
                histTable[noHistoryFile, 1] = (networkActionPredictorInfo.Length / 1024).ToString();
                noHistoryFile++;
                historySize += (int)(networkActionPredictorInfo.Length / 1024);
            }
            if (File.Exists(lastTabs))
            {
                histTable[noHistoryFile, 0] = lastTabsInfo.FullName;
                histTable[noHistoryFile, 1] = (lastTabsInfo.Length / 1024).ToString();
                noHistoryFile++;
                historySize += (int)(lastTabsInfo.Length / 1024);
            }
        }
        public void FillInternetHistory(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, histTable);
        }
        #endregion

        #region Download History
        public void DownloadHistory()
        {
            dlHistorySize = 0;
            noDlHistFile = 0;
            DirectoryInfo chromeDefaultUser = new DirectoryInfo(chromePath + "Default");
            FileInfo DownloadMetadata = new FileInfo(chromeDefaultUser.ToString() + "\\DownloadMetadata");
            if (File.Exists(chromeDefaultUser.ToString() + "\\DownloadMetadata"))
            {
                dlHistTable = new string[1, 2];
                dlHistTable[0, 0] = DownloadMetadata.FullName;
                dlHistTable[0, 1] = DownloadMetadata.Length.ToString();
                dlHistorySize += Convert.ToInt32((DownloadMetadata.Length / 1024));
                noDlHistFile += 1;
            }
        }
        public void FillDownloadHistory(DataGridView DtgData)
        {
            DtgData.Rows.Clear();
            DtgData.ColumnCount = 2;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(DtgData);
            row.Cells[0].Value = dlHistTable[0, 0];
            row.Cells[1].Value = dlHistTable[0, 1];
            DtgData.Rows.Add(row);
        }
        #endregion

        #region Crash Reports
        public void CrashReports()
        {
            crashRepSize = 0;
            noCrashRepFile = 0;
            DirectoryInfo chromeCrashReportsDir;

            int tableLength = 0;
            if (Directory.Exists(chromeCrashReportsPath))
            {
                chromeCrashReportsDir = new DirectoryInfo(chromeCrashReportsPath);
                tableLength += chromeCrashReportsDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
                crashRepTable = new string[tableLength, 2];
                foreach (FileInfo file in chromeCrashReportsDir.GetFiles())
                    pcAnalysisEngine.GetFilesData(ref crashRepTable, ref noCrashRepFile, ref crashRepSize, file);
                crashRepSize /= 1024;
            }
        }
        public void FillCrashReports(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, crashRepTable);
        }
        #endregion

        #region Analysis
        public void Analysis()
        {
            InternetCache();
            InternetHistory();
            DownloadHistory();
            CrashReports();
        }
        #endregion

        #region Show Data
        public static void ShowInternetCache(DataGridView DtgAnalyze)
        {
            if (cacheSize != 0 && noCacheFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Chrome - Internet Cache";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = cacheSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noCacheFile;
                rowPos++;
            }
        }
        public static void ShowInternetHistory(DataGridView DtgAnalyze)
        {
            if (historySize != 0 && noHistoryFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Chrome - Internet History";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = historySize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noHistoryFile;
                rowPos++;
            }
        }
        public static void ShowDownloadHistory(DataGridView DtgAnalyze)
        {
            if (dlHistorySize != 0 && noDlHistFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Chrome - Download History";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = dlHistorySize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noDlHistFile;
                rowPos++;
            }
            
        }
        public static void ShowCrashReports(DataGridView DtgAnalyze)
        {
            if (crashRepSize != 0 && noCrashRepFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Chrome - Crash Reports";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = crashRepSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noCrashRepFile;
                rowPos++;
            }

        }
        public void ShowData(DataGridView DtgAnalyze)
        {
            rowPos = 0;
            DtgAnalyze.Rows.Clear();

            ShowInternetCache(DtgAnalyze);

            ShowInternetHistory(DtgAnalyze);

            ShowDownloadHistory(DtgAnalyze);

            ShowCrashReports(DtgAnalyze);
        }
        #endregion

        #region Methods
        public static bool Exists()
        {
            bool OK = false;
            try
            {
                chromePath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe", "Path", "").ToString();
                if (chromePath != "")
                    OK = true;
            }
            catch (NullReferenceException) { }
            return OK;
        }

        public static string GetFile()
        {
            return Path.Combine(chromePath, "chrome.exe");
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

        public static long GetHistSize()
        {
            return historySize;
        }

        public static int GetHistFiles()
        {
            return noHistoryFile;
        }

        public static long GetDlHistorySize()
        {
            return dlHistorySize;
        }

        public static int GetDlFiles()
        {
            return noDlHistFile;
        }

        public static int GetCrashRepFiles()
        {
            return noCrashRepFile;
        }
        public static long GetCrashRepSize()
        {
            return crashRepSize;
        }

        public static void SetRowPos(int value)
        {
            rowPos = value;
        }

        public static string[,] GetCrashRepTable()
        {
            return crashRepTable;
        }

        public static string[,] GetCacheTable()
        {
            return cacheTable;
        }
        public static string[,] GetHistoryTable()
        {
            return histTable;
        }
        public static string[,] GetDlHistoryTable()
        {
            return dlHistTable;
        }
        #endregion
    }
}