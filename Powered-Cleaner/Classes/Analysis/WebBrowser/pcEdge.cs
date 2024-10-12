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
    public class pcEdge
    {
        #region CONST
        private const string _edgePath_ = "Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe";
        private const string _cache_ = _edgePath_ + "\\AC";
        #endregion

        #region Path
        private string edgePath = Path.Combine(Environment.GetFolderPath
            (Environment.SpecialFolder.LocalApplicationData), _edgePath_);
        private string cachePath = Path.Combine(Environment.GetFolderPath
            (Environment.SpecialFolder.LocalApplicationData), _cache_);
        #endregion

        #region Objects
        pcAnalysisEngine pcAnalysisEngine = new pcAnalysisEngine();
        #endregion

        #region Variables
        private static int noCacheFile;
        private static long cacheSize;
        private static string[,] cacheTable;

        private static int noHistFile;
        private static long histSize;
        private static string[,] histTable;

        private static int rowPos; 
        #endregion

        #region Internet Cache
        public void InternetCache()
        {
            #region Paths
            string Part1 = "\\#!001\\";
            string Part2 = "\\#!002\\";
            string edgeCache = "\\MicrosoftEdge\\Cache";
            string appCache = "\\MicrosoftEdge\\User\\Default\\AppCache";

            string CachePathP1 = cachePath + Part1 + edgeCache;
            string CachePathP2 = cachePath + Part2 + edgeCache;
            string appCachePathP2 = cachePath + Part2 + appCache;
            #endregion

            cacheSize = 0;
            noCacheFile = 0;
            DirectoryInfo cacheDirectoryP1 = new DirectoryInfo(CachePathP1);
            DirectoryInfo cacheDirectoryP2 = new DirectoryInfo(CachePathP2);
            DirectoryInfo appCacheDirectoryP2 = new DirectoryInfo(appCachePathP2);
            int tableLength = 0;

            if (Directory.Exists(CachePathP1))
                tableLength += cacheDirectoryP1.GetFiles("*.*", SearchOption.AllDirectories).Length;
            if (Directory.Exists(CachePathP2))
                tableLength += cacheDirectoryP2.GetFiles("*.*", SearchOption.AllDirectories).Length;
            if (Directory.Exists(appCachePathP2))
                tableLength += appCacheDirectoryP2.GetFiles("*.*", SearchOption.AllDirectories).Length;

            cacheTable = new string[tableLength, 2];

            if (Directory.Exists(CachePathP1))
                foreach (FileInfo file in cacheDirectoryP1.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);

            if (Directory.Exists(CachePathP2))
                foreach (FileInfo file in cacheDirectoryP2.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cacheTable, ref noCacheFile, ref cacheSize, file);


            if (Directory.Exists(appCachePathP2))
                    foreach (FileInfo file in appCacheDirectoryP2.GetFiles("*.*", SearchOption.AllDirectories))
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

            string history = "\\AC\\#!001\\\\MicrosoftEdge\\History";

            if (Directory.Exists(edgePath + history))
            {
                DirectoryInfo dirHistory = new DirectoryInfo(edgePath + history);
                int tableLength = 0;
                tableLength += dirHistory.GetFiles("*.*", SearchOption.AllDirectories).Length;
                histTable = new string[tableLength, 2];
                foreach (FileInfo file in dirHistory.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    pcAnalysisEngine.GetFilesData(ref histTable, ref noHistFile, ref histSize, file);
                }
                histSize = histSize / 1024;
            }
        }
        public void FillInternetHistory(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, histTable);
        }
        #endregion

        #region Show Data
        public void ShowInternetCache(DataGridView DtgAnalyze)
        {
            if (cacheSize != 0 && noCacheFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Edge - Internet Cache";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = cacheSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noCacheFile;
                rowPos++;
            }
        }
        public void ShowInternetHistory(DataGridView DtgAnalyze)
        {
            if (histSize != 0 && noHistFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Edge - Internet History";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = histSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noHistFile;
                rowPos++;
            }
        }
        public void ShowEdgeData(DataGridView DtgAnalyze)
        {
            DtgAnalyze.Rows.Clear();

            if (cacheSize != 0 && noCacheFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Edge - Internet Cache";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = cacheSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noCacheFile;
                rowPos++;
            }
            if (histSize != 0 && noHistFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Edge - Internet History";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = histSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noHistFile;
                rowPos++;
            }
        } 
        #endregion

        #region Assessors
        public static int GetCacheFiles()
        {
            return noCacheFile;
        }
        public static long GetCacheSize()
        {
            return cacheSize;
        }
        public static int GetHistFiles()
        {
            return noHistFile;
        }
        public static long GetHistSize()
        {
            return histSize;
        }

        public static void SetRowPos(int value)
        {
            rowPos = value;
        }
        public static string[,] GetCacheTable()
        {
            return cacheTable;
        }
        public static string[,] GetHistoryTable()
        {
            return histTable;
        }
        #endregion
    }
}