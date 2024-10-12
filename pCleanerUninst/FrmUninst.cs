using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pCleanerUninst
{
    public partial class FrmUninst : Form
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string appTempPath = Path.Combine(Path.GetTempPath(), "Powered Cleaner");
        public FrmUninst()
        {
            InitializeComponent();
        }

        private void FrmUninst_Load(object sender, EventArgs e)
        {
            CbxLanguage.SelectedIndex = 0;
        }

        private void BtnInstaller_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir désinstaller Powered Cleaner ?", "Powered Cleaner", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Registry.LocalMachine.DeleteSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\PoweredCleaner");

                if (!Directory.Exists(Path.Combine(Path.GetTempPath(), @"Powered Cleaner")))
                    Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), @"Powered Cleaner"));

                if (File.Exists(Path.Combine(desktopPath, "Powered Cleaner.lnk")))
                    File.Delete(Path.Combine(desktopPath, "Powered Cleaner.lnk"));
                using (StreamWriter sw = new StreamWriter(Path.Combine(appTempPath, "uninst.bat")))
                {
                    sw.WriteLine("@RD /S /Q \"" + Application.StartupPath + "");
                    sw.Flush();
                    sw.Close();
                }

                ProcessStartInfo process = new ProcessStartInfo();
                process.Verb = "runas";
                process.FileName = Path.Combine(appTempPath, "uninst.bat");
                Process.Start(process);
                Application.Exit();
            }
            else
                Application.Exit();
            }
        }
    }
