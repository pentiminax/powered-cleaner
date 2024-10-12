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
    class pcOpera
    {
        #region Opera Cache Path
        private static string operaPath;
        private string cachePath;
        private string gpuCachePath;
        private string mediaCachePath;
        private string shaderCachePath;
        private string appDataGPUCachePath;
        private string appDataJumpListIconsPath;
        private string appDataFileSystemPath;
        #endregion

        #region Opera History Files Path
        private string visitedLinksPath;
        private string currentTabsPath;
        private string lastTabsPath;
        private string historyProdiverCachePath;
        private string networkActionPredictorPath;
        #endregion

        #region Variables
        private static int noCacheFile;
        private static long cacheSize;
        private static string[,] cacheTable;

        public static int noHistFile;
        public static long histSize;
        private static string[,] histTable;

        private static int rowPos;
        #endregion

        #region Constructor
        public pcOpera()
        {
            #region Cache
            cachePath = Path.Combine(operaPath, @"\cache");
            gpuCachePath = Path.Combine(operaPath, @"\GPUCache");
            mediaCachePath = Path.Combine(operaPath, @"\Media Cache");
            appDataGPUCachePath = Path.Combine(pcPath.appData, operaPath + @"\GPUCache");
            shaderCachePath = Path.Combine(pcPath.appData, operaPath + @"\ShaderCache\GPUCache");
            appDataJumpListIconsPath = Path.Combine(pcPath.appData, operaPath + @"\Jump List Icons");
            appDataFileSystemPath = Path.Combine(pcPath.appData, operaPath + @"\File System");
            #endregion

            #region History
            visitedLinksPath = Path.Combine(pcPath.appData, operaPath + "Visited Links");
            currentTabsPath = Path.Combine(pcPath.appData, operaPath + "Current Tabs");
            lastTabsPath = Path.Combine(pcPath.appData, operaPath + "Last Tabs");
            historyProdiverCachePath = Path.Combine(pcPath.appData, operaPath + "History Provider Cache");
            networkActionPredictorPath = Path.Combine(pcPath.appData, operaPath + "Network Action Predictor");
            #endregion
        } 
        #endregion

        #region Internet Cache
        public void InternetCache()
        {
            noCacheFile = 0;
            cacheSize = 0;
            int tableLength = 0;

            DirectoryInfo cacheDir = new DirectoryInfo(cachePath);
            DirectoryInfo gpuCacheDir = new DirectoryInfo(gpuCachePath);
            DirectoryInfo mediaCacheDir = new DirectoryInfo(mediaCachePath);
            DirectoryInfo shaderCacheDir = new DirectoryInfo(shaderCachePath);
            DirectoryInfo appDataGPUCacheDir = new DirectoryInfo(appDataGPUCachePath);
            DirectoryInfo appDataJumpListIconsDir = new DirectoryInfo(appDataJumpListIconsPath);
            DirectoryInfo appDataFileSystemDir = new DirectoryInfo(appDataFileSystemPath);

            if (Directory.Exists(cachePath))
                tableLength += cacheDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
            if (Directory.Exists(gpuCachePath))
                tableLength += gpuCacheDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
            if (Directory.Exists(mediaCachePath))
                tableLength += mediaCacheDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
            if (Directory.Exists(shaderCachePath))
                tableLength += shaderCacheDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
            if (Directory.Exists(appDataGPUCachePath))
                tableLength += appDataGPUCacheDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
            if (Directory.Exists(appDataJumpListIconsPath))
                tableLength += appDataJumpListIconsDir.GetFiles().Length;
            if (Directory.Exists(appDataFileSystemPath))
                tableLength += appDataFileSystemDir.GetFiles("*.*", SearchOption.AllDirectories).Length;

            cacheTable = new string[tableLength, 2];

            if (Directory.Exists(cachePath))
                foreach (FileInfo file in cacheDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            if (Directory.Exists(gpuCachePath))
                foreach (FileInfo file in gpuCacheDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            if (Directory.Exists(mediaCachePath))
                foreach (FileInfo file in mediaCacheDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            if (Directory.Exists(shaderCachePath))
                foreach (FileInfo file in shaderCacheDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            if (Directory.Exists(appDataGPUCachePath))
                foreach (FileInfo file in appDataGPUCacheDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            if (Directory.Exists(appDataJumpListIconsPath))
                foreach (FileInfo file in appDataJumpListIconsDir.GetFiles())
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);
            if (Directory.Exists(appDataFileSystemPath))
                foreach (FileInfo file in appDataFileSystemDir.GetFiles("*.*", SearchOption.AllDirectories))
            pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);

            cacheSize = cacheSize / 1024;
        } 
        public void FillInternetCache(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, cacheTable);
        }
        #endregion

        #region Internet History
        public void InternetHistory()
        {
            noHistFile = 0;
            histSize = 0;
            int tableLength = 0;

            #region Table Length
            if (File.Exists(visitedLinksPath))
                tableLength++;
            if (File.Exists(currentTabsPath))
                tableLength++;
            if (File.Exists(lastTabsPath))
                tableLength++;
            if (File.Exists(historyProdiverCachePath))
                tableLength++;
            if (File.Exists(networkActionPredictorPath))
                tableLength++; 
            #endregion

            histTable = new string[tableLength, 2];

            if (File.Exists(visitedLinksPath))
            {
                FileInfo visitedLinks = new FileInfo(visitedLinksPath);
                histTable[noHistFile, 0] = visitedLinks.FullName;
                histTable[noHistFile, 1] = (visitedLinks.Length / 1024).ToString();
                noHistFile++;
                histSize += (visitedLinks.Length / 1024);
            }
            if (File.Exists(currentTabsPath))
            {
                FileInfo currentTabs = new FileInfo(currentTabsPath);
                histTable[noHistFile, 0] = currentTabs.FullName;
                histTable[noHistFile, 1] = (currentTabs.Length / 1024).ToString();
                noHistFile++;
                histSize += (currentTabs.Length / 1024);
            }
            if (File.Exists(lastTabsPath))
            {
                FileInfo lastTabs = new FileInfo(lastTabsPath);
                histTable[noHistFile, 0] = lastTabs.FullName;
                histTable[noHistFile, 1] = (lastTabs.Length / 1024).ToString();
                noHistFile++;
                histSize += (lastTabs.Length / 1024);
            }
            if (File.Exists(historyProdiverCachePath))
            {
                FileInfo historyProdiverCache = new FileInfo(historyProdiverCachePath);
                histTable[noHistFile, 0] = historyProdiverCache.FullName;
                histTable[noHistFile, 1] = (historyProdiverCache.Length / 1024).ToString();
                noHistFile++;
                histSize += (historyProdiverCache.Length / 1024);
            }
            if (File.Exists(networkActionPredictorPath))
            {
                FileInfo networkActionPredictor = new FileInfo(networkActionPredictorPath);
                histTable[noHistFile, 0] = networkActionPredictor.FullName;
                histTable[noHistFile, 1] = (networkActionPredictor.Length / 1024).ToString();
                noHistFile++;
                histSize += (networkActionPredictor.Length / 1024);
            }
        }
        public void FillInternetHistory(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, histTable);
        }
        #endregion

        #region Show Data
        public void ShowInternetHistory (DataGridView DtgAnalyze)
        {
            if (histSize != 0 && noHistFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Opera - Internet History";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = histSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noHistFile;
                rowPos++;
            }
        }
        public void ShowInternetCache(DataGridView DtgAnalyze)
        {
            if (cacheSize != 0 && noCacheFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Opera - Internet Cache";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = cacheSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noCacheFile;
                rowPos++;
            }
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
            return noHistFile;
        }

        public static long GetHistSize()
        {
            return histSize;
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

        #region Methods
        public static bool Exists()
        {
            bool OK = false;
            try
            {
                operaPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\App Paths\opera.exe", "Path", "").ToString();
                operaPath = operaPath.Replace("\"", "");
                OK = true;
            }
            catch (NullReferenceException)
            {
                try
                {
                    operaPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\App Paths\opera.exe", "Path", "").ToString();
                    operaPath = operaPath.Replace("\"", "");
                    OK = true;
                }
                catch (NullReferenceException){}
            }
            return OK;
        }

        public static string GetOperaPath()
        {
            return operaPath;
        }

        public static string GetFile()
        {
            return Path.Combine(operaPath, "launcher.exe");
        }
        #endregion
    }
}