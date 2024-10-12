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
    class pcAndroidStudio : IApplication
    {
        private static RegistryKey checkpoint;
        private string gradleLogPath;

        public static int noFile;
        public static long fileSize;
        public static string[,] table;

        private int tableLength;

        public pcAndroidStudio()
        {
            gradleLogPath = Path.Combine(pcPath.currentUser, @".gradle\daemon");
        }

        public void Analysis()
        {
            noFile = 0;
            fileSize = 0;
            tableLength = 0;
            DirectoryInfo gradleLogDir = null;
            if (Directory.Exists(gradleLogPath))
            {
                gradleLogDir = new DirectoryInfo(gradleLogPath);
                tableLength += gradleLogDir.GetFiles("*.log", SearchOption.AllDirectories).Length;
            }

            table = new string[tableLength, 2];

            if (Directory.Exists(gradleLogPath))
            {
                foreach (FileInfo file in gradleLogDir.GetFiles("*.log", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref table, ref noFile, ref fileSize, file);
            }

            fileSize /= 1024;
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
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "Android Studio";
                DtgAnalyze.Rows[rowPos].Cells[1].Value = fileSize;
                DtgAnalyze.Rows[rowPos].Cells[2].Value = noFile;
                rowPos++;
                OK = true;
            }
            return OK;
        }

        public static bool Exists()
        {
            bool OK = false;
            try
            {
                checkpoint = Registry.CurrentUser.OpenSubKey(@"Software\Android Open Source Project\Emulator", false);
                if (checkpoint != null)
                    OK = true;
            }
            catch (NullReferenceException) { OK = false; }
            return OK;
        }
    }
}
