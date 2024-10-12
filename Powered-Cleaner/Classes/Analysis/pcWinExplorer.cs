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
    public class pcWinExplorer
    {
        #region Path
        private static string WinThumbCachePath = Path.Combine(pcPath.localAppData, @"Microsoft\\Windows\\Explorer");
        private string WinThumbCacheToDeletePath = Path.Combine(WinThumbCachePath, "ThumbCacheToDelete");
        private string WinRecentDocumentsPath = Path.Combine(pcPath.appData, "Microsoft\\Windows\\Recent");
        #endregion

        #region Variables
        private static int noThumbCacheFile;
        private static long thumbCacheSize;
        private static string[,] thumbCacheTable;

        private static int noRecentDocFile;
        private static long recentDocsSize;
        private static string[,] recentDocsTable;

        private static int rowPos;
        #endregion

        #region Recent Documents
        public void RecentDocuments()
        {
            recentDocsSize = 0;
            noRecentDocFile = 0;
            DirectoryInfo recentDocsDir = new DirectoryInfo(WinRecentDocumentsPath);
            recentDocsTable = new string[recentDocsDir.GetFiles().Length, 2];

            if (Directory.Exists(WinRecentDocumentsPath))
            {
                foreach (FileInfo file in recentDocsDir.GetFiles())
                {
                    pcAnalysisEngine.GetFilesData(ref recentDocsTable, ref noRecentDocFile, ref recentDocsSize, file);
                }
                recentDocsSize = recentDocsSize / 1024;
            }
        }

        public void FillRecentDocuments(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, recentDocsTable);
        }
        #endregion

        #region Thumbnail
        public void ThumbnailCache()
        {
            thumbCacheSize = 0;
            noThumbCacheFile = 0;
            int tableLength = 0;

            DirectoryInfo explorerThumbCacheToDelete = new DirectoryInfo(WinThumbCacheToDeletePath);

            if (Directory.Exists(WinThumbCacheToDeletePath))
                tableLength += explorerThumbCacheToDelete.GetFiles("*.tmp").Length;

            thumbCacheTable = new string[tableLength, 2];
            if (Directory.Exists(WinThumbCacheToDeletePath))
            {
                foreach (FileInfo file in explorerThumbCacheToDelete.GetFiles("*.tmp"))
                    pcAnalysisEngine.GetFilesData(ref thumbCacheTable, ref noThumbCacheFile, ref thumbCacheSize, file);
            }
            thumbCacheSize = thumbCacheSize / 1024;
            thumbCacheTable = pcAnalysisEngine.ClearArrayNulls(ref thumbCacheTable);
        }
        public void FillThumbnailCache(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, thumbCacheTable);
        }
        #endregion

        #region Get Directory Size
        public static long GetDirectorySize(DirectoryInfo dir)
        {
            long total = 0;
            FileAttributes attributes = File.GetAttributes(dir.FullName);
            if (!((attributes & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint))
            {
                try
                {
                    FileInfo[] fileInfos = dir.GetFiles();
                    foreach (FileInfo fileInfo in fileInfos)
                    {
                        total += fileInfo.Length;
                    }

                    DirectoryInfo[] dirInfos = dir.GetDirectories();
                    foreach (DirectoryInfo dirInfo in dirInfos)
                    {
                        total += GetDirectorySize(dirInfo);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    
                }
            }

            return total;
        }
        #endregion

        #region Show Data

        public void ShowThumbnail(DataGridView DtgAnalyze)
        {
            DtgAnalyze.Rows.Add();
            DtgAnalyze.Rows[rowPos].Cells[0].Value = "Thumbnail Cache";
            DtgAnalyze.Rows[rowPos].Cells[1].Value = thumbCacheSize;
            DtgAnalyze.Rows[rowPos].Cells[2].Value = noThumbCacheFile;
            rowPos++;
        }

        public void ShowRecentDocuments(DataGridView DtgAnalyze)
        {
            if (recentDocsSize != 0 && noRecentDocFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Recent Documents";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = recentDocsSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noRecentDocFile;
                rowPos++;
            }
        }
        public void ShowWinExplorerData(DataGridView DtgAnalyze)
        {
            ShowThumbnail(DtgAnalyze);
            ShowRecentDocuments(DtgAnalyze);
        }

        public void Analysis()
        {
            RecentDocuments();
            ThumbnailCache();
        }
        #endregion

        #region Assessors
        public static long GetThumbCacheSize()
        {
            return thumbCacheSize;
        }

        public static int GetNbThumbCacheFile()
        {
            return noThumbCacheFile;
        }

        public static int GetNbRecentDocsFiles()
        {
            return noRecentDocFile;
        }

        public static long GetRecentDocsSize()
        {
            return recentDocsSize;
        }

        public static void SetRowPos(int value)
        {
            rowPos = value;
        }

        public static string[,] GetThumbCacheTable()
        {
            return thumbCacheTable;
        }

        public static string[,] GetRecentDocsTable()
        {
            return recentDocsTable;
        }
        #endregion
    }
}