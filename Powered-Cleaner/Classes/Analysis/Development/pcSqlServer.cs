using Microsoft.Win32;
using Powered_Cleaner.Classes.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powered_Cleaner.Classes.Analysis.Development
{
    class pcSqlServer : IApplication
    {
        #region Variables
        private static RegistryKey checkpoint;
        private string sqlServerPath;
        private string SetupBootstrapPath;
        private string mssqlPath;

        public static int noFile;
        public static long fileSize;
        public static string[,] table;

        private int tableLength;
        #endregion

        #region Constructor
        public pcSqlServer()
        {
            sqlServerPath = Path.Combine(pcPath.programFilesX86, "Microsoft SQL Server");
            SetupBootstrapPath = Path.Combine(sqlServerPath, @"110\Setup Bootstrap\LOG");
            mssqlPath = Path.Combine(sqlServerPath, @"MSSQL11.MSSQLSERVER\MSSQL\Log");
        } 
        #endregion

        public void Analysis()
        {
            DirectoryInfo SetupBootstrapDir = null;
            DirectoryInfo mssqlDir = null;

            noFile = 0;
            fileSize = 0;
            tableLength = 0;

            #region Table Length
            if (Directory.Exists(SetupBootstrapPath))
            {
                SetupBootstrapDir = new DirectoryInfo(SetupBootstrapPath);
                tableLength += SetupBootstrapDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
            }
            if (Directory.Exists(mssqlPath))
            {
                mssqlDir = new DirectoryInfo(mssqlPath);
                try
                {
                    tableLength += mssqlDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
                }
                catch (UnauthorizedAccessException) { }
            } 
            #endregion

            table = new string[tableLength, 2];

            #region Filling Table
            if (Directory.Exists(SetupBootstrapPath))
            {
                foreach (FileInfo file in SetupBootstrapDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref table, ref noFile, ref fileSize, file);
            }
            if (Directory.Exists(mssqlPath))
            {
                try
                {
                    foreach (FileInfo file in mssqlDir.GetFiles("*.*", SearchOption.AllDirectories))
                        pcAnalysisEngine.GetFilesData(ref table, ref noFile, ref fileSize, file);
                }
                catch (UnauthorizedAccessException) { }
            }
            fileSize /= 1024;
            #endregion
        }

        public void FillData(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, table);
        }

        public bool ShowData(DataGridView DtgAnalyze, int rowPos)
        {
            bool OK = false;
            if (fileSize != 0 && noFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "MS SQL Server";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = fileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noFile;
                OK = true;
            }
            return OK;
        }

        public static bool Exists()
        {
            bool OK = false;
            try
            {
                checkpoint = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Microsoft SQL Server", false);
                if (checkpoint != null)
                    OK = true;
                else
                {
                    try
                    {
                        checkpoint = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Microsoft SQL Server", false);
                        if (checkpoint != null)
                            OK = true;
                    }
                    catch (NullReferenceException){ OK = false; }
                }
            }
            catch (NullReferenceException) { OK = false; }
            return OK;
        }
    }
}
