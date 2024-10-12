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
    public class pcSystem
    {
        #region Path
        private static string winLocalFolder = Path.Combine(pcPath.localAppData, "Microsoft");
        private static string werReportArchive = @"Microsoft\Windows\WER\ReportArchive";

        private string tempPath = Path.GetTempPath();
        private string werPath = Path.Combine(pcPath.localAppData, werReportArchive);
        private string winTempPath = Path.Combine(pcPath.windows, "TEMP");
        private string dumpKernelPath = Path.Combine(pcPath.windows, "LiveKernelReports");
        private string dumpWinPath = pcPath.windows;
        #endregion

        #region Variables
        private static int noDumpFile;
        private static long DumpSize;
        private static string[,] dumpTable;

        private static int noTempFile;
        private static long tempSize;
        private static string[,] tempTable;

        private static int noWerFile;
        private static long werSize;
        private static string[,] werTable;

        private static int rowPos;
        #endregion

        #region Memory Dumps
        public void MemDump()
        {
            noDumpFile = 0;
            DumpSize = 0;
            int tableLength = 0;
            DirectoryInfo dumpKernelDir = new DirectoryInfo(dumpKernelPath);
            DirectoryInfo dumpWinDir = new DirectoryInfo(dumpWinPath);
            try
            {
                tableLength += dumpWinDir.GetFiles("*.dmp", SearchOption.TopDirectoryOnly).Length;
                tableLength += dumpKernelDir.GetFiles("*.dmp", SearchOption.AllDirectories).Length;
            }
            catch (UnauthorizedAccessException){}
            
            dumpTable = new string[tableLength, 2];

            if (Directory.Exists(dumpKernelPath))
            {
                try
                {
                    foreach (FileInfo file in dumpKernelDir.GetFiles("*.dmp", SearchOption.AllDirectories))
                        pcAnalysisEngine.GetFilesData(ref dumpTable, ref noDumpFile, ref DumpSize, file);
                    foreach (FileInfo file in dumpWinDir.GetFiles("*.dmp", SearchOption.TopDirectoryOnly))
                        pcAnalysisEngine.GetFilesData(ref dumpTable, ref noDumpFile, ref DumpSize, file);
                }
                catch (UnauthorizedAccessException){}
                DumpSize = DumpSize / 1024;
            }
        }
        public static void FillMemDump(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, dumpTable);
        }
        #endregion

        #region Windows Temporary Files
        public void TemporaryFiles()
        {
            noTempFile = 0;
            tempSize = 0;
            int tableLength = 0;
            DirectoryInfo tempDir = new DirectoryInfo(tempPath);
            DirectoryInfo winTempDir = new DirectoryInfo(winTempPath);
            try
            {
                tableLength += winTempDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
            }
            catch (UnauthorizedAccessException){}
            if (Directory.Exists(tempPath))
                tableLength += tempDir.GetFiles("*.*", SearchOption.AllDirectories).Length;

            tempTable = new string[tableLength, 2]; 
            try
            {
                foreach (FileInfo file in winTempDir.GetFiles("*.*", SearchOption.AllDirectories))
                        pcAnalysisEngine.GetFilesData(ref tempTable, ref noTempFile, ref tempSize, file);
                
                tempSize = tempSize / 1024;
            }
            catch (UnauthorizedAccessException) { }

            if (Directory.Exists(tempPath))
                foreach (FileInfo file in tempDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref tempTable, ref noTempFile, ref tempSize, file);
            tempSize = tempSize / 1024;
        }
        public static void FillTemporaryFiles(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, tempTable);
        }
        #endregion

        #region Windows Error Reporting
        public void WinErrorReporting()
        {
            noWerFile = 0;
            werSize = 0;
            DirectoryInfo werDir = new DirectoryInfo(werPath);
            try
            {
                if (Directory.Exists(werPath))
                    werTable = new string[werDir.GetFiles("*.wer", SearchOption.AllDirectories).Length, 2];
            }
            catch (UnauthorizedAccessException){}
            
            if (Directory.Exists(werPath))
            {
                try
                {
                    foreach (FileInfo file in werDir.GetFiles("*.wer", SearchOption.AllDirectories))
                        pcAnalysisEngine.GetFilesData(ref werTable, ref noWerFile, ref werSize, file);
                }
                catch (UnauthorizedAccessException) { }
                werSize = werSize / 1024;
            }
        }
        public static void FillWinErrorReporting(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, werTable);
        }
        #endregion

        #region System Analysis
        public void Analysis()
        {
            TemporaryFiles();
            WinErrorReporting();
            MemDump();
        }
        #endregion

        #region Show Data
        #region Memory Dumps
        public void ShowMemoryDumps(DataGridView DtgAnalyze)
        {
            if (DumpSize != 0 && noDumpFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Memory Dumps";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = DumpSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noDumpFile;
                rowPos++;
            }
        }
        #endregion

        #region Temporary Files
        public void ShowTemporaryFiles(DataGridView DtgAnalyze)
        {
            if (tempSize != 0 && noTempFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Temporary Files";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = tempSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noTempFile;
                rowPos++;
            }
        }
        #endregion

        #region Windows Error Reporting
        public void ShowWinErrorReporting(DataGridView DtgAnalyze)
        {
            if (werSize != 0 && noWerFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Windows Error Reporting";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = werSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noWerFile;
                rowPos++;
            }
        }
        #endregion

        #region System Data
        public void ShowSystemData(DataGridView DtgAnalyze)
        {
            ShowTemporaryFiles(DtgAnalyze);
            ShowWinErrorReporting(DtgAnalyze);
            ShowMemoryDumps(DtgAnalyze);
        } 
        #endregion
        #endregion

        #region Assessors
        public static long GetDumpSize()
        {
            return DumpSize;
        }

        public static int GetNbDumpFiles()
        {
            return noDumpFile;
        }

        public static int GetNbTempFiles()
        {
            return noTempFile;
        }

        public static long GetTempSize()
        {
            return tempSize;
        }

        public static int GetWerFiles()
        {
            return noWerFile;
        }
        public static long GetWerSize()
        {
            return werSize;
        }
        public static void SetRowPos(int value)
        {
            rowPos = value;
        }

        public static string[,] GetTempTable()
        {
            return tempTable;
        }
        public static string[,] GetDumpTable()
        {
            return dumpTable;
        }
        public static string[,] GetWerTable()
        {
            return werTable;
        }
        #endregion
    }
}