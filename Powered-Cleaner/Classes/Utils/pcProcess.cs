using Powered_Cleaner.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Powered_Cleaner
{
    public partial class pcProcess
    {
        public static bool IsProcessOpenTool(string name)
        {
            bool Ok = false;
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    Ok = true;
                    break;
                }
            }
            return Ok;
        }
        
        public static void KillProcess(string name)
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName(name))
                    proc.Kill();
            }
            catch (Exception){}
        }

        public static string GetProcessName(string name)
        {
            string aName = null;
            try
            {
                foreach (Process proc in Process.GetProcessesByName(name))
                    aName = proc.ProcessName;
            }
            catch (Exception) { }
            return aName;
        }

        public static bool IsProcessSkipped(string name)
        {
            bool isSkipped = false;
            if (IsProcessOpenTool(name))
            {
                DialogResult dr = MessageBox.Show(name + " " + strings.mBoxProcessBefore + "\n" +
                    strings.mBoxProcessQuestion + " " + GetProcessName(name), "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                    KillProcess(name);
                else
                    isSkipped = true;
            }
            return isSkipped;
        }
    }
}
