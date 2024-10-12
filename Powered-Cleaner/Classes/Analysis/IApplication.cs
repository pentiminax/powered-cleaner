using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powered_Cleaner.Classes.Analysis
{
    interface IApplication
    {
        void Analysis();

        void FillData(DataGridView DtgData);
        
        bool ShowData(DataGridView DtgAnalyze, int rowPos);

    }
}
