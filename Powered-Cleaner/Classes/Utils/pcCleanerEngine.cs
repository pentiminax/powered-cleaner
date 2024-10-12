using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powered_Cleaner.Classes.Utils
{
    class pcCleanerEngine
    {
        public static int GetTotalFiles(DataGridView DtgAnalyze)
        {
            int totalFiles = 0;
            for (int i = 0; i < DtgAnalyze.Rows.Count; i++)
            {
                try
                {
                    totalFiles += (int)DtgAnalyze.Rows[i].Cells[2].Value;
                }
                catch (Exception) { }
            }
            return totalFiles;
        }
    }
}
