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
    class pcVisualStudio : IApplication
    {
        #region Variables
        private static RegistryKey checkpoint;
        private string localAppData;
        private string vs2017;
        private string vs2015;
        private string compModelCachePath;
        private string extensionsPath;
        private string nugetCachePath;
        private string nugetPackagesPath;

        public static int noFile;
        public static long fileSize;
        public static string[,] cachesTable;

        private int tableLength;
        #endregion

        #region Constructor
        public pcVisualStudio()
        {
            localAppData = Path.Combine(pcPath.localAppData, @"Microsoft\VisualStudio\");
            vs2017 = Path.Combine(localAppData, "15.0_a1086a56");
            vs2015 = Path.Combine(localAppData, "14.0");

            if (Directory.Exists(vs2017))
            {
                compModelCachePath = Path.Combine(vs2017, "ComponentModelCache");
                extensionsPath = Path.Combine(vs2017, "Extensions");
                nugetCachePath = Path.Combine(vs2017, @"NuGet\v3-cache");
                nugetPackagesPath = Path.Combine(vs2017, @".nuget\packages");
            }
            else if (Directory.Exists(vs2015))
            {
                compModelCachePath = Path.Combine(vs2015, "ComponentModelCache");
                extensionsPath = Path.Combine(vs2015, "Extensions");
                nugetCachePath = Path.Combine(vs2015, @"NuGet\v3-cache");
                nugetPackagesPath = Path.Combine(vs2015, @".nuget\packages");
            }
        } 
        #endregion

        private void Caches()
        {
            noFile = 0;
            fileSize = 0;
            tableLength = 0;

            DirectoryInfo compModelCacheDir = null;
            DirectoryInfo extensionsDir = null;
            DirectoryInfo nugetCacheDir = null;
            DirectoryInfo nugetPackagesDir = null;

            #region Table Length
            if (Directory.Exists(compModelCachePath))
            {
                compModelCacheDir = new DirectoryInfo(compModelCachePath);
                tableLength += compModelCacheDir.GetFiles("*.*", SearchOption.TopDirectoryOnly).Length;
            }
            if (Directory.Exists(extensionsPath))
            {
                extensionsDir = new DirectoryInfo(extensionsPath);
                tableLength += extensionsDir.GetFiles("*.cache", SearchOption.TopDirectoryOnly).Length;
            }
            if (Directory.Exists(nugetCachePath))
            {
                nugetCacheDir = new DirectoryInfo(nugetCachePath);
                tableLength += nugetCacheDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
            }
            if (Directory.Exists(nugetPackagesPath))
            {
                nugetPackagesDir = new DirectoryInfo(nugetPackagesPath);
                tableLength += nugetPackagesDir.GetFiles("*.*", SearchOption.AllDirectories).Length;
            } 
            #endregion

            cachesTable = new string[tableLength, 2];

            #region Filling Table
            if (Directory.Exists(compModelCachePath))
            {
                foreach (FileInfo file in compModelCacheDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                    pcAnalysisEngine.GetFilesData(ref cachesTable, ref noFile, ref fileSize, file);
            }
            if (Directory.Exists(extensionsPath))
            {
                foreach (FileInfo file in extensionsDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                    pcAnalysisEngine.GetFilesData(ref cachesTable, ref noFile, ref fileSize, file);
            }
            if (Directory.Exists(nugetCachePath))
            {
                foreach (FileInfo file in nugetCacheDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cachesTable, ref noFile, ref fileSize, file);
            }
            if (Directory.Exists(nugetPackagesPath))
            {
                foreach (FileInfo file in nugetPackagesDir.GetFiles("*.*", SearchOption.AllDirectories))
                    pcAnalysisEngine.GetFilesData(ref cachesTable, ref noFile, ref fileSize, file);
            }
            fileSize /= 1024;
            #endregion
        }

        public void FillData(DataGridView DtgData)
        {
            pcAnalysisEngine.FillData(DtgData, cachesTable);
        }

        public void Analysis()
        {
            Caches();
        }

        public bool ShowData(DataGridView DtgAnalyze, int rowPos)
        {
            bool OK = false;
            if (fileSize != 0 && noFile != 0)
            {
                DtgAnalyze.Rows.Add();
                DtgAnalyze.Rows[rowPos].Cells[0].Value = "MS Visual Studio";
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
                checkpoint = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\VisualStudio", false);
                if (checkpoint != null)
                    OK = true;
            }
            catch (NullReferenceException) { OK = false; }
            return OK;
        }
    }
}