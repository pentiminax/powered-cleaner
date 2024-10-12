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
    class pcWindows
    {
        #region Path
        private static string softwareDistributionPath = Path.Combine(pcPath.windows, @"SoftwareDistribution\Download");

        private static string downloadedInstallPath = Path.Combine(pcPath.localAppData, @"Downloaded Installations");

        private static string installerPath = Path.Combine(pcPath.windows, "Installer");

        private static string logsWDIPath = Path.Combine(pcPath.windows, @"System32\WDI");
        private static string logsSleepStudyPath = Path.Combine(pcPath.windows, @"System32\SleepStudy");
        private static string logsUSOSharedPath = Path.Combine(pcPath.programData, @"USOShared\Logs");
        private static string logsPantherPath = Path.Combine(pcPath.windows, "Panther");

        private static string jumpListsPath = Path.Combine(pcPath.appData, @"Microsoft\Windows\Recent");
        #endregion

        #region Variables
        private static int noUpdateFile;
        private static long updateFileSize;
        public static string[,] updateFileTable;

        private static int noDownloadedFile;
        private static long downloadedFileSize;
        public static string[,] downloadedFileTable;

        private static int noInstallerFile;
        private static long installerFileSize;
        public static string[,] installerFileTable;

        private static int noJumpListsFile;
        private static long jumpListsSize;
        public static string[,] jumpListsTable;

        private static int noLogsFile;
        private static long logsFileSize;
        public static string[,] logsFileTable;

        private static int rowPos;
        #endregion

        #region Downloaded Installations
        public static void DownloadedInstall()
        {
            noDownloadedFile = 0;
            downloadedFileSize = 0;
            if (Directory.Exists(downloadedInstallPath))
            {
                DirectoryInfo downloadedInstallDir = new DirectoryInfo(downloadedInstallPath);
                downloadedFileTable = new string[downloadedInstallDir.GetFiles("*.*", SearchOption.AllDirectories).Length, 2];
                foreach (FileInfo file in downloadedInstallDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref downloadedFileTable, ref noDownloadedFile, ref downloadedFileSize, file);
                downloadedFileSize /= 1024;
            }
        }
        public static void FillDownloadedFiles(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, downloadedFileTable);
        }
        #endregion

        #region Windows Update
        public static void WinUpdate()
        {
            noUpdateFile = 0;
            updateFileSize = 0;
            DirectoryInfo softwareDistributionDir = new DirectoryInfo(softwareDistributionPath);
            updateFileTable = new string[softwareDistributionDir.GetFiles("*.*", SearchOption.AllDirectories).Length, 2];
            if (Directory.Exists(softwareDistributionPath))
            {
                foreach (FileInfo file in softwareDistributionDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref updateFileTable, ref noUpdateFile, ref updateFileSize, file);
            }
            updateFileSize /= 1024;
        }
        public static void FillWinUpdate(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, updateFileTable);
        }
        #endregion

        #region Windows Installer
        public static void WinInstaller()
        {
            noInstallerFile = 0;
            installerFileSize = 0;
            int tableLength = 0;
            DirectoryInfo installerDir = new DirectoryInfo(installerPath);
            if (Directory.Exists(installerPath))
            {
                foreach (FileInfo file in installerDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                    if (file.Name.StartsWith("SourceHash"))
                        tableLength++;

                installerFileTable = new string[tableLength, 2];

                foreach (FileInfo file in installerDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                    if (file.Name.StartsWith("SourceHash"))
                        pcAnalysisEngine.GetFilesData(ref installerFileTable, ref noInstallerFile, ref installerFileSize, file);
            }
            installerFileSize /= 1024;
        }
        public static void FillWinInstaller(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, installerFileTable);
        }
        #endregion

        #region Windows Logs
        public static void WinLogs()
        {
            noLogsFile = 0;
            logsFileSize = 0;
            int tableLength = 0;
            DirectoryInfo logsWDIDir;
            DirectoryInfo logsSleepStudyDir;
            DirectoryInfo logsUSOSharedDir;
            DirectoryInfo logsPantherDir;

            #region WDI

            if (Directory.Exists(logsWDIPath))
            {
                try
                {
                    logsWDIDir = new DirectoryInfo(logsWDIPath);
                    foreach (FileInfo file in logsWDIDir.GetFiles("*.etl", SearchOption.AllDirectories))
                        if (file.Name == "snapshot.etl")
                            tableLength++;
                }
                catch (UnauthorizedAccessException){}
            }
            #endregion

            #region SleepStudy
            if (Directory.Exists(logsSleepStudyPath))
            {
                try
                {
                    logsSleepStudyDir = new DirectoryInfo(logsSleepStudyPath);
                foreach (FileInfo file in logsSleepStudyDir.GetFiles("*.etl", SearchOption.AllDirectories))
                    if (file.Name != "UserNotPresentSession.etl")
                        tableLength++;
                }
                catch (UnauthorizedAccessException) { }
            }
            #endregion

            #region USOShared
            if (Directory.Exists(logsUSOSharedPath))
            {
                logsUSOSharedDir = new DirectoryInfo(logsUSOSharedPath);
                foreach (FileInfo file in logsUSOSharedDir.GetFiles("*.etl", SearchOption.AllDirectories))
                        tableLength++;
            }
            #endregion

            #region Panther
            if (Directory.Exists(logsPantherPath))
            {
                logsPantherDir = new DirectoryInfo(logsPantherPath);
                foreach (FileInfo file in logsPantherDir.GetFiles("*.xml", SearchOption.TopDirectoryOnly))
                    if (file.Name == "MigLog.xml")
                        tableLength++;
            }
            #endregion


            logsFileTable = new string[tableLength, 2];

            #region Filling Table
            if (Directory.Exists(logsWDIPath))
            {
                try
                {
                    logsWDIDir = new DirectoryInfo(logsWDIPath);
                    foreach (FileInfo file in logsWDIDir.GetFiles("*.etl", SearchOption.AllDirectories))
                        if (file.Name == "snapshot.etl")
                            pcAnalysisEngine.GetFilesData(ref logsFileTable, ref noLogsFile, ref logsFileSize, file);
                }
                catch (UnauthorizedAccessException){}
            }

            try
            {
                if (Directory.Exists(logsSleepStudyPath))
            {
                logsSleepStudyDir = new DirectoryInfo(logsSleepStudyPath);
                foreach (FileInfo file in logsSleepStudyDir.GetFiles("*.etl", SearchOption.AllDirectories))
                    if (file.Name != "UserNotPresentSession.etl")
                        pcAnalysisEngine.GetFilesData(ref logsFileTable, ref noLogsFile, ref logsFileSize, file);
            }
            }
            catch (UnauthorizedAccessException) { }

            if (Directory.Exists(logsUSOSharedPath))
            {
                logsUSOSharedDir = new DirectoryInfo(logsUSOSharedPath);
                foreach (FileInfo file in logsUSOSharedDir.GetFiles("*.etl", SearchOption.AllDirectories))
                        pcAnalysisEngine.GetFilesData(ref logsFileTable, ref noLogsFile, ref logsFileSize, file);
            }

            if (Directory.Exists(logsPantherPath))
            {
                logsPantherDir = new DirectoryInfo(logsPantherPath);
                foreach (FileInfo file in logsPantherDir.GetFiles("*.xml", SearchOption.AllDirectories))
                    if (file.Name == "MigLog.xml")
                        pcAnalysisEngine.GetFilesData(ref logsFileTable, ref noLogsFile, ref logsFileSize, file);
            }
            #endregion
            logsFileSize /= 1024;
        }
        public static void FillWinLogs(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, logsFileTable);
        }
        #endregion

        #region Jump Lists
        public static void JumpLists()
        {
            noJumpListsFile = 0;
            jumpListsSize = 0;
            DirectoryInfo jumpListsDir = new DirectoryInfo(jumpListsPath);
            jumpListsTable = new string[jumpListsDir.GetFiles("*.*", SearchOption.AllDirectories).Length, 2];
            if (Directory.Exists(downloadedInstallPath))
            {
                foreach (FileInfo file in jumpListsDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref jumpListsTable, ref noJumpListsFile, ref jumpListsSize, file);
            }
            jumpListsSize /= 1024;
        }
        public static void FillJumpLists(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, jumpListsTable);
        }
        #endregion

        #region Show Data
        public static void ShowDownloadedFiles(DataGridView DtgAnalyze)
        {
            if (downloadedFileSize != 0 && noDownloadedFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Windows - Downloaded Files";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = downloadedFileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noDownloadedFile;
                rowPos++;
            }
        }
        public static void ShowWinUpdate(DataGridView DtgAnalyze)
        {
            if (updateFileSize != 0 && noUpdateFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Windows - Windows Update";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = updateFileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noUpdateFile;
                rowPos++;
            }
        }
        public static void ShowWinInstaller(DataGridView DtgAnalyze)
        {
            if (installerFileSize != 0 && noInstallerFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Windows - Windows Installer";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = installerFileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noInstallerFile;
                rowPos++;
            }
        }
        public static void ShowWinLogs(DataGridView DtgAnalyze)
        {
            if (logsFileSize != 0 && noLogsFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Windows - Windows Logs";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = logsFileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noLogsFile;
                rowPos++;
            }
        }
        public static void ShowJumpLists(DataGridView DtgAnalyze)
        {
            if (jumpListsSize != 0 && noJumpListsFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Windows - Jump Lists";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = jumpListsSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noJumpListsFile;
                rowPos++;
            }
        }
        #endregion

        #region Assessors
        public static void SetRowPos(int value)
        {
            rowPos = value;
        }
        #endregion
    }
}
