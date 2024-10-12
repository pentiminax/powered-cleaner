using Powered_Cleaner.Classes.Analysis.Applications;
using Powered_Cleaner.Classes.Analysis.Development;
using Powered_Cleaner.Classes.Analysis.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powered_Cleaner.Classes.Analysis
{
    public class pcAnalysisData
    {
        private static int rowPos;

        #region Windows Explorer Data
        public void ShowWinExplorerData(DataGridView DtgAnalyze)
        {
            if (pcWinExplorer.GetNbRecentDocsFiles() != 0 && pcWinExplorer.GetRecentDocsSize() != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Recent Documents";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcWinExplorer.GetRecentDocsSize();
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcWinExplorer.GetNbRecentDocsFiles();
                rowPos++;
            }
            if (pcWinExplorer.GetNbThumbCacheFile() != 0 && pcWinExplorer.GetThumbCacheSize() != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Thumbnail Cache";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcWinExplorer.GetThumbCacheSize();
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcWinExplorer.GetNbThumbCacheFile();
                rowPos++;
            }
        }
        #endregion

        #region System
        public void ShowSystemData(DataGridView DtgAnalyze)
        {
            if (pcSystem.GetTempSize() != 0 && pcSystem.GetNbTempFiles() != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Temporary Files";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcSystem.GetTempSize();
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcSystem.GetNbTempFiles();
                rowPos++;
            }
            if (pcSystem.GetWerSize() != 0 && pcSystem.GetWerFiles() != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Windows Error Reporting";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcSystem.GetWerSize();
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcSystem.GetWerFiles();
                rowPos++;
            }
            if (pcSystem.GetDumpSize() != 0 && pcSystem.GetNbDumpFiles() != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Memory Dumps";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcSystem.GetDumpSize();
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcSystem.GetNbDumpFiles();
                rowPos++;
            }
        }
        #endregion

        #region Google Chrome
        public void ShowChromeData(DataGridView DtgAnalyze)
        {
                if (pcChrome.GetCacheSize() != 0 && pcChrome.GetCacheFiles() != 0)
                {
                    DtgAnalyze.Rows.Add();
                    DtgAnalyze.Rows[rowPos].Cells[0].Value = "Chrome - Internet Cache";
                    DtgAnalyze.Rows[rowPos].Cells[1].Value = pcChrome.GetCacheSize();
                    DtgAnalyze.Rows[rowPos].Cells[2].Value = pcChrome.GetCacheFiles();
                    rowPos++;
                }
                if (pcChrome.GetHistSize() != 0 && pcChrome.GetHistFiles() != 0)
                {
                    DtgAnalyze.Rows.Add();
                    DtgAnalyze.Rows[rowPos].Cells[0].Value = "Chrome - Internet History";
                    DtgAnalyze.Rows[rowPos].Cells[1].Value = pcChrome.GetDlHistorySize();
                    DtgAnalyze.Rows[rowPos].Cells[2].Value = pcChrome.GetHistFiles();
                    rowPos++;
                }
                if (pcChrome.GetDlHistorySize() != 0 && pcChrome.GetHistFiles() != 0)
                {
                    DtgAnalyze.Rows.Add();
                    DtgAnalyze.Rows[rowPos].Cells[0].Value = "Chrome - Download History";
                    DtgAnalyze.Rows[rowPos].Cells[1].Value = pcChrome.GetDlHistorySize();
                    DtgAnalyze.Rows[rowPos].Cells[2].Value = pcChrome.GetDlFiles();
                    rowPos++;
                }
            if (pcChrome.GetCrashRepSize() != 0 && pcChrome.GetCrashRepFiles() != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Chrome - Crash Reports";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcChrome.GetCrashRepSize();
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcChrome.GetCrashRepFiles();
                rowPos++;
            }
        }
        #endregion

        #region Mozilla Firefox
        public void ShowFirefoxData(DataGridView DtgAnalyze)
        {
            if (pcFirefox.GetCacheFiles() != 0 && pcFirefox.GetCacheSize() != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Firefox - Internet Cache";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcFirefox.GetCacheSize();
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcFirefox.GetCacheFiles();
                rowPos++;
            }
            if (pcFirefox.GetHistFiles() != 0 && pcFirefox.GetHistSize() != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Firefox - Internet History";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcFirefox.GetHistSize();
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcFirefox.GetHistFiles();
                rowPos++;
            }
        }
        #endregion

        #region Microsoft Edge
        public void ShowEdgeData(DataGridView DtgAnalyze)
        {
            if (pcEdge.GetCacheSize() != 0 && pcEdge.GetCacheFiles() != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Edge - Internet Cache";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcEdge.GetCacheSize();
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcEdge.GetCacheFiles();
                rowPos++;
            }
            if (pcEdge.GetHistSize() != 0 && pcEdge.GetHistFiles() != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Edge - Internet History";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcEdge.GetHistSize();
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcEdge.GetHistFiles();
                rowPos++;
            }
        }
        #endregion

        #region Opera
        public void ShowOperaData(DataGridView DtgAnalyze)
        {
                if (pcOpera.GetCacheFiles() != 0 && pcOpera.GetCacheSize() != 0)
                {
                    DtgAnalyze.Rows.Add();
                    DtgAnalyze.Rows[rowPos].Cells[0].Value = "Opera - Internet Cache";
                    DtgAnalyze.Rows[rowPos].Cells[1].Value = pcOpera.GetCacheSize();
                    DtgAnalyze.Rows[rowPos].Cells[2].Value = pcOpera.GetCacheFiles();
                    rowPos++;
                }
                if (pcOpera.GetHistFiles() != 0 && pcOpera.GetHistSize() != 0)
                {
                    DtgAnalyze.Rows.Add();
                    DtgAnalyze.Rows[rowPos].Cells[0].Value = "Opera - Internet History";
                    DtgAnalyze.Rows[rowPos].Cells[1].Value = pcFirefox.GetHistSize();
                    DtgAnalyze.Rows[rowPos].Cells[2].Value = pcFirefox.GetHistFiles();
                    rowPos++;
                }
                if (pcOpera.GetHistFiles() != 0 && pcOpera.GetHistSize() != 0)
                {
                    DtgAnalyze.Rows.Add();
                    DtgAnalyze.Rows[rowPos].Cells[0].Value = "Opera - Download History";
                    DtgAnalyze.Rows[rowPos].Cells[1].Value = pcOpera.GetHistSize();
                    DtgAnalyze.Rows[rowPos].Cells[2].Value = pcOpera.GetHistFiles();
                    rowPos++;
                }
        }
        #endregion

        #region Applications
        public void ShowApplicationsData(DataGridView DtgAnalyze)
        {
            if (pcVisualStudio.fileSize != 0 && pcVisualStudio.noFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "MS Visual Studio";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcVisualStudio.fileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcVisualStudio.noFile;
                rowPos++;
            }
            if (pcSqlServer.fileSize != 0 && pcSqlServer.noFile != 0 )
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "MS SQL Server";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcSqlServer.fileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcSqlServer.noFile;
                rowPos++;
            }
            if (pcDiscord.fileSize != 0 && pcDiscord.noFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Discord";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcDiscord.fileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcDiscord.noFile;
                rowPos++;
            }
            if (pcOffice.fileSize != 0 && pcOffice.noFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "MS Office 2016";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcOffice.fileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcOffice.noFile;
                rowPos++;
            }
            if (pcSteam.fileSize != 0 && pcSteam.noFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Steam";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = pcSteam.fileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = pcSteam.noFile;
                rowPos++;
            }
        }
        #endregion

        #region Assessors
        public void SetRowPos(int value)
        {
            rowPos = value;
        }
        public int GetRowPos()
        {
            return rowPos;
        } 
        #endregion
    }
}