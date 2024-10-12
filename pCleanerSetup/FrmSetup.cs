using pCleanerSetup.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using File = System.IO.File;
using System.Diagnostics;
using Microsoft.Win32;

namespace pCleanerSetup
{
    public partial class FrmSetup : Form
    {
        string appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Powered Cleaner");
        string startMenu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), @"Microsoft\Windows\Start Menu\Programs");

        public FrmSetup()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            /* BtnInstaller.Left = (this.ClientSize.Width - BtnInstaller.Width) / 2;
             BtnInstaller.Top = (this.ClientSize.Height - BtnInstaller.Height) / 2; */
            CbxLanguage.SelectedIndex = 0;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BtnInstaller.Text != "Lancer Powered Cleaner")
            {
                DialogResult dr = MessageBox.Show("Êtes vous sûr de vouloir annuler l'installation ?", "Powered Cleaner", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void BtnInstaller_Click(object sender, EventArgs e)
        {
            #region Copie des fichiers & Raccourci
            appPath = TbxPath.Text;

            if (!Directory.Exists(appPath))
                Directory.CreateDirectory(appPath);
            try
            {
                byte[] buffer = Resources.Powered_Cleaner;
                string base64Encoded = Convert.ToBase64String(buffer);

                buffer = Convert.FromBase64String(base64Encoded);
                File.WriteAllBytes(Path.Combine(appPath, @"Powered Cleaner.exe"), buffer);

                buffer = Resources.CircularProgressBar;
                base64Encoded = Convert.ToBase64String(buffer);
                File.WriteAllBytes(Path.Combine(appPath, @"CircularProgressBar.dll"), buffer);

                buffer = Resources.WinFormAnimation;
                base64Encoded = Convert.ToBase64String(buffer);
                File.WriteAllBytes(Path.Combine(appPath, @"WinFormAnimation.dll"), buffer);

                buffer = Resources.uninst;
                base64Encoded = Convert.ToBase64String(buffer);
                File.WriteAllBytes(Path.Combine(appPath, @"uninst.exe"), buffer);

                buffer = Resources.Powered_Cleaner_resources;
                base64Encoded = Convert.ToBase64String(buffer);

                if (!Directory.Exists(Path.Combine(appPath, "fr")))
                    Directory.CreateDirectory(Path.Combine(appPath, "fr"));
                File.WriteAllBytes(Path.Combine(appPath, @"fr\Powered Cleaner.resources.dll"), buffer);


                if (BtnInstaller.Text == "Lancer Powered Cleaner")
                {
                    Process.Start(Path.Combine(appPath, "Powered Cleaner.exe"));
                    Application.Exit();
                }
                if (ChkDesktop.Checked)
                    CreateShortcut(@"Powered Cleaner", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Path.Combine(appPath, "Powered Cleaner.exe"));
                if (ChkMenuDemarrer.Checked)
                    CreateShortcut(@"Powered Cleaner", startMenu, Path.Combine(appPath, "Powered Cleaner.exe"));
                GuiCenter.Text = "L'installation de Powered Cleaner est terminée";
                BtnInstaller.Text = "Lancer Powered Cleaner";
            }
            catch (IOException)
            {
                MessageBox.Show("Veuillez fermer Powered Cleaner pour continuer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion

            #region Registre
            RegistryKey key;
            key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\PoweredCleaner");
            key.SetValue("", "");
            key.SetValue("DisplayIcon", Path.Combine(appPath + @"\Powered Cleaner.exe"));
            key.SetValue("DisplayName", "Powered Cleaner");
            key.SetValue("DisplayVersion", "0.4");
            key.SetValue("InstallLocation", appPath);
            key.SetValue("Publisher", "Tanguy Lemarié");
            key.SetValue("EstimatedSize", "1024", RegistryValueKind.DWord);
            key.SetValue("UninstallString", Path.Combine(appPath + @"\uninst.exe"));
            key.SetValue("VersionMajor", "0");
            key.SetValue("VersionMinor", "4");
            #endregion
        }

        public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "Nettoyez votre ordinateur";   // The description of the shortcut
            //shortcut.IconLocation = @"c:\myicon.ico";           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;                 // The path of the file that will launch when the shortcut is run
            shortcut.Save();
        }

        private void BtnChoosePath_Click(object sender, EventArgs e)
        {
            DialogResult dr = Fdb.ShowDialog();
            if (dr == DialogResult.OK)
                TbxPath.Text = Fdb.SelectedPath;
        }
    }
}