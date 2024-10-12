using Powered_Cleaner.Classes.Analysis;
using Powered_Cleaner.Classes.Analysis.Applications;
using Powered_Cleaner.Classes.Analysis.Development;
using Powered_Cleaner.Classes.Analysis.Games;
using Powered_Cleaner.Classes.Utils;
using Powered_Cleaner.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powered_Cleaner.Classes.Cleaner
{
    class pcCleaner
    {

        public static void FillAnalysisDataTable(DataGridView DtgData, string[,] table)
        {
            pcAnalysisEngine.FillData(DtgData, table);
        }

        public static string[,] GetAnalysisDataTable(DataGridView DtgAnalyze)
        {
            #region Fill Table
            string desc;
            int totalFiles = pcCleanerEngine.GetTotalFiles(DtgAnalyze);
            int rowPos = 0;
            int k = 0;
            string[,] table = new string[totalFiles, 2];
            for (int i = 0; i < DtgAnalyze.Rows.Count; i++)
            {
                desc = DtgAnalyze.Rows[i].Cells[0].Value.ToString();
                switch (desc)
                {
                    case "Temporary Files":
                        k = 0;
                        while (k < pcSystem.GetTempTable().GetLength(0))
                        {
                            table[rowPos, 0] = pcSystem.GetTempTable().GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcSystem.GetTempTable().GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Memory Dumps":
                        k = 0;
                        while (k < pcSystem.GetDumpTable().GetLength(0))
                        {
                            table[rowPos, 0] = pcSystem.GetDumpTable().GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcSystem.GetDumpTable().GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Windows Error Reporting":
                        k = 0;
                        while (k < pcSystem.GetWerTable().GetLength(0))
                        {
                            table[rowPos, 0] = pcSystem.GetWerTable().GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcSystem.GetWerTable().GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Recent Documents":
                        k = 0;
                        while (k < pcWinExplorer.GetRecentDocsTable().GetLength(0))
                        {
                            table[rowPos, 0] = pcWinExplorer.GetRecentDocsTable().GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcWinExplorer.GetRecentDocsTable().GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Thumbnail Cache":
                        k = 0;
                        while (k < pcWinExplorer.GetThumbCacheTable().GetLength(0))
                        {
                            table[rowPos, 0] = pcWinExplorer.GetThumbCacheTable().GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcWinExplorer.GetThumbCacheTable().GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Firefox - Internet Cache":
                        k = 0;
                        while (k < pcFirefox.GetCacheTable().GetLength(0))
                        {
                            table[rowPos, 0] = pcFirefox.GetCacheTable().GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcFirefox.GetCacheTable().GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Firefox - Internet History":
                        k = 0;
                        while (k < pcFirefox.GetHistTable().GetLength(0))
                        {
                            table[rowPos, 0] = pcFirefox.GetHistTable().GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcFirefox.GetHistTable().GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Chrome - Internet Cache":
                        k = 0;
                        if (pcChrome.GetCacheSize() != 0 && pcChrome.GetCacheFiles() != 0)
                        {
                            while (k < pcChrome.GetCacheTable().GetLength(0))
                            {
                                table[rowPos, 0] = pcChrome.GetCacheTable().GetValue(k, 0).ToString();
                                table[rowPos, 1] = pcChrome.GetCacheTable().GetValue(k, 1).ToString();
                                rowPos++;
                                k++;
                            }
                        }
                        break;
                    case "Chrome - Download History":
                        k = 0;
                        if (pcChrome.GetHistSize() != 0 && pcChrome.GetHistFiles() != 0)
                        {
                            while (k < pcChrome.GetDlHistoryTable().GetLength(0))
                            {
                                table[rowPos, 0] = pcChrome.GetDlHistoryTable().GetValue(k, 0).ToString();
                                table[rowPos, 1] = pcChrome.GetDlHistoryTable().GetValue(k, 1).ToString();
                                rowPos++;
                                k++;
                            }
                        }
                        break;
                    case "Chrome - Internet History":
                        k = 0;
                        if (pcChrome.GetHistSize() != 0 && pcChrome.GetHistFiles() != 0)
                        {
                            while (k < pcChrome.GetHistoryTable().GetLength(0))
                            {
                                table[rowPos, 0] = pcChrome.GetHistoryTable().GetValue(k, 0).ToString();
                                table[rowPos, 1] = pcChrome.GetHistoryTable().GetValue(k, 1).ToString();
                                rowPos++;
                                k++;
                            }
                        }
                        break;
                    case "Chrome - Crash Reports":
                        k = 0;
                        if (pcChrome.GetCrashRepSize() != 0 && pcChrome.GetCrashRepFiles() != 0)
                        {
                            while (k < pcChrome.GetCrashRepTable().GetLength(0))
                            {
                                table[rowPos, 0] = pcChrome.GetCrashRepTable().GetValue(k, 0).ToString();
                                table[rowPos, 1] = pcChrome.GetCrashRepTable().GetValue(k, 1).ToString();
                                rowPos++;
                                k++;
                            }
                        }
                        break;
                    case "Opera - Internet Cache":
                        k = 0;
                        while (k < pcOpera.GetCacheTable().GetLength(0))
                        {
                            table[rowPos, 0] = pcOpera.GetCacheTable().GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcOpera.GetCacheTable().GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Opera - Internet History":
                        k = 0;
                        while (k < pcOpera.GetHistTable().GetLength(0))
                        {
                            table[rowPos, 0] = pcOpera.GetHistTable().GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcOpera.GetHistTable().GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Edge - Internet Cache":
                        k = 0;
                        while (k < pcEdge.GetCacheTable().GetLength(0))
                        {
                            table[rowPos, 0] = pcEdge.GetCacheTable().GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcEdge.GetCacheTable().GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Edge - Internet History":
                        k = 0;
                        while (k < pcEdge.GetHistoryTable().GetLength(0))
                        {
                            table[rowPos, 0] = pcEdge.GetHistoryTable().GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcEdge.GetHistoryTable().GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Windows - Downloaded Files":
                        k = 0;
                        while (k < pcWindows.downloadedFileTable.GetLength(0))
                        {
                            table[rowPos, 0] = pcWindows.downloadedFileTable.GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcWindows.downloadedFileTable.GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Windows - Jump Lists":
                        k = 0;
                        while (k < pcWindows.jumpListsTable.GetLength(0))
                        {
                            table[rowPos, 0] = pcWindows.jumpListsTable.GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcWindows.jumpListsTable.GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Windows - Windows Installer":
                        k = 0;
                        while (k < pcWindows.installerFileTable.GetLength(0))
                        {
                            table[rowPos, 0] = pcWindows.installerFileTable.GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcWindows.installerFileTable.GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Windows - Windows Logs":
                        k = 0;
                        while (k < pcWindows.logsFileTable.GetLength(0))
                        {
                            table[rowPos, 0] = pcWindows.logsFileTable.GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcWindows.logsFileTable.GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Windows - Windows Update":
                        k = 0;
                        while (k < pcWindows.updateFileTable.GetLength(0))
                        {
                            table[rowPos, 0] = pcWindows.updateFileTable.GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcWindows.updateFileTable.GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "MS Visual Studio":
                        k = 0;
                        while (k < pcVisualStudio.cachesTable.GetLength(0))
                        {
                            table[rowPos, 0] = pcVisualStudio.cachesTable.GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcVisualStudio.cachesTable.GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "MS SQL Server":
                        k = 0;
                        while (k < pcSqlServer.table.GetLength(0))
                        {
                            table[rowPos, 0] = pcSqlServer.table.GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcSqlServer.table.GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Steam":
                        k = 0;
                        while (k < pcSteam.table.GetLength(0))
                        {
                            table[rowPos, 0] = pcSteam.table.GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcSteam.table.GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Discord":
                        k = 0;
                        while (k < pcDiscord.table.GetLength(0))
                        {
                            table[rowPos, 0] = pcDiscord.table.GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcDiscord.table.GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "MS Office 2016":
                        k = 0;
                        while (k < pcOffice.table.GetLength(0))
                        {
                            table[rowPos, 0] = pcOffice.table.GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcOffice.table.GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    case "Android Studio":
                        k = 0;
                        while (k < pcAndroidStudio.table.GetLength(0))
                        {
                            table[rowPos, 0] = pcAndroidStudio.table.GetValue(k, 0).ToString();
                            table[rowPos, 1] = pcAndroidStudio.table.GetValue(k, 1).ToString();
                            rowPos++;
                            k++;
                        }
                        break;
                    default:
                        break;
                }
            }
            #endregion
            pcAnalysisEngine.ClearArrayNulls(ref table);
            return table;
        }
    }
}