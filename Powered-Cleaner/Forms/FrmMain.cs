using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using Powered_Cleaner.Classes.Analysis;
using Powered_Cleaner.Classes.Cleaner;
using Powered_Cleaner.Classes.Utils;
using Powered_Cleaner.Properties;
using System.Globalization;
using Powered_Cleaner.Classes.Analysis.Development;
using Powered_Cleaner.Classes.Analysis.Games;
using Powered_Cleaner.Classes.Analysis.Applications;
using System.Net;
using System.Reflection;
using System.Windows.Shell;

namespace Powered_Cleaner
{
    public partial class FrmMain : Form
    {
        #region Variables
        double clientVersion = 0.5;
        int totalRAM;
        int currentMouseOverRow;
        int sizeCleaned;
        bool chrome = false;
        bool firefox = false;
        bool opera = false;
        bool startup = false;
        string myArgument;
        string tabPage;
        string strWebVersion;
        string RepApp = Path.GetDirectoryName(Application.ExecutablePath);
        string cellValue;
        List<string> liste = new List<string>();
        string mySender;
        int rowPos;
        #endregion

        #region Objects
        pcAnalysisEngine pcAnalysisEngine = new pcAnalysisEngine();
        pcAnalysisData pcAnalysis = new pcAnalysisData();
        pcSystem pcSystem = new pcSystem();
        pcWinExplorer pcWinExplorer = new pcWinExplorer();
        pcEdge pcEdge = new pcEdge();

        pcChrome pcChrome;
        pcOpera pcOpera;
        pcFirefox pcFirefox;

        pcVisualStudio pcVisualStudio;
        pcSqlServer pcSqlServer;
        pcSteam pcSteam;
        pcDiscord pcDiscord;
        pcOffice pcOffice;
        pcAndroidStudio pcAndroidStudio;
        #endregion

        #region Initialization
        public FrmMain(string arg)
        {
            if(arg != "") myArgument = arg;
            InitializeComponent();
        }
        #endregion
       
        

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            LoadLanguage();
            if (string.IsNullOrEmpty(TbxManufacturer.Text))
                if (!BgWorkGeneral.IsBusy)
                    BgWorkGeneral.RunWorkerAsync("SytemInfo");

            #region Affichage
            GuiLineSeparator1.Height = 2;
            GuiLineSeparator2.Height = 2;

            #endregion

            #region Applications Check
            if (pcVisualStudio.Exists())
            {
                pcVisualStudio = new pcVisualStudio();
            }
            else
            {
                ChkVisualStudio.Checked = false;
                ChkVisualStudio.Dispose();
            }
            if (pcSqlServer.Exists())
            {
                pcSqlServer = new pcSqlServer();
            }
            else
            {
                ChkSqlServer.Checked = false;
                ChkSqlServer.Dispose();
            }
            if (pcOffice.Exists())
            {
                pcOffice = new pcOffice();
            }
            else
            {
                ChkOffice.Checked = false;
                ChkOffice.Dispose();
            }
            if (pcDiscord.Exists())
            {
                pcDiscord = new pcDiscord();
            }
            else
            {
                ChkDiscord.Checked = false;
                ChkDiscord.Dispose();
            }
            if (pcSteam.Exists())
            {
                pcSteam = new pcSteam();
            }
            else
            {
                ChkSteam.Checked = false;
                ChkSteam.Dispose();
            }
            if (pcAndroidStudio.Exists())
            {
                pcAndroidStudio = new pcAndroidStudio();
            }
            else
            {
                ChkAndroidStudio.Checked = false;
                ChkAndroidStudio.Dispose();
            }
            #endregion

           #region Check Web Browser

            if (pcOpera.Exists())
            {
                pcOpera = new pcOpera();
                opera = true;
                try { LblOperaVersion.Text = FileVersionInfo.GetVersionInfo(pcOpera.GetFile()).FileVersion; }
                catch (Exception) { pnlOpera.Dispose(); ChkOpera.Checked = false; ChkOpera.Dispose(); }
            }
            else
            {
                pnlOpera.Dispose();
                ChkOpera.Checked = false;
                ChkOpera.Dispose();
                opera = false;
            }

            #region Check Chrome | Firefox
            if (pcChrome.Exists())
            {
                pcChrome = new pcChrome();
                chrome = true;
                try
                {
                    LblChromeVersion.Text = FileVersionInfo.GetVersionInfo(pcChrome.GetFile()).FileVersion;
                }
                catch (Exception) { pnlChrome.Hide(); ChkChrome.Checked = false; ChkChrome.Hide(); }
            }
            else
            {
                pnlChrome.Dispose();
                ChkChrome.Checked = false;
                ChkChrome.Dispose();
                chrome = false;
            }

            if (pcFirefox.Exists())
            {
                firefox = true;
                pcFirefox = new pcFirefox();
                try
                {
                    LblFirefoxVersion.Text = FileVersionInfo.GetVersionInfo(pcFirefox.GetFirefoxFile()).FileVersion;
                }
                catch (Exception) { pnlFirefox.Hide(); ChkFirefox.Checked = false; ChkFirefox.Dispose(); }
            }
            else
            {
                pnlFirefox.Dispose();
                ChkFirefox.Checked = false;
                ChkFirefox.Dispose();
                firefox = false;
            }
            #endregion

            #region Web Browser 
            if (chrome && !opera && !firefox)
            {
                BtnWebBrowser.Image = Resources.menu_chrome;
                BtnWebBrowser.Text = "GOOGLE CHROME";
            }
            if (!chrome && !opera && firefox)
            {
                BtnWebBrowser.Text = "FIREFOX";
                BtnWebBrowser.Image = Resources.menu_firefox;
                pnlFirefox.Location = pnlChrome.Location;
            }
            if (!chrome && opera && !firefox)
            {
                BtnWebBrowser.Text = "OPERA";
                BtnWebBrowser.Image = Resources.menu_opera;
                pnlOpera.Location = pnlChrome.Location;
            }
            if (opera && chrome && !firefox)
            {
                ChkOpera.Location = ChkFirefox.Location;
                pnlOpera.Location = pnlFirefox.Location;
            }
            #endregion
            #endregion

            #region Utils
            CpgbDisk.Value = 0;
            CpgbRam.Value = 0;
            myTimer.Start();
            Win32.getDriveSpace(LblFreeSpace, LblTotalSize, CpgbDisk);
            getMemoryInfos();
            #endregion

            if (startup)
            {
                WindowState = FormWindowState.Minimized;
                Hide();
            }
        }
        #endregion

        #region Button Analyze
        private void BtnAnalyser_Click(object sender, EventArgs e)
        {
            BeginAnalysis();
            pcAnalysis.SetRowPos(0);
            LblPercPgb.Show();
            LblPercPgb.Text = "0%";

            if (BgWorkAnalyze.IsBusy)
            {
                BgWorkAnalyze.CancelAsync();
                BtnAnalyser.Text = strings.analyze;
            }
            else if (!BgWorkAnalyze.IsBusy)
            {
                BtnAnalyser.Text = "Cancel";
                BgWorkAnalyze.RunWorkerAsync();
            }
            if (ChkFirefox.Checked)
            {
                pcFirefox.InternetCache();
                pcFirefox.InternetHistory();
                pcAnalysis.ShowFirefoxData(DtgAnalyze);
            }
            if (ChkEdge.Checked)
            {
                pcEdge.InternetCache();
                pcEdge.InternetHistory();
                pcAnalysis.ShowEdgeData(DtgAnalyze);
            }
            if (ChkOpera.Checked)
            {
                pcOpera.InternetCache();
                pcOpera.InternetHistory();
                pcAnalysis.ShowOperaData(DtgAnalyze);
            }
            if (ChkApplications.Checked)
            {
                if (pcVisualStudio != null)
                    pcVisualStudio.Analysis();
                if (pcSqlServer!= null)
                    pcSqlServer.Analysis();
                if (pcSteam != null)
                    pcSteam.Analysis();
                if (pcDiscord != null)
                    pcDiscord.Analysis();
                if (pcOffice != null)
                    pcOffice.Analysis();
                pcAnalysis.ShowApplicationsData(DtgAnalyze);
            }
        }
        #endregion

        #region CLEAN
        private void BtnClean_Click(object sender, EventArgs e)
        {
            int totalFiles = pcCleanerEngine.GetTotalFiles(DtgAnalyze);
            if (!BgWorkCleaner.IsBusy)
            {
                LblPercPgb.Show();
                LblPercPgb.Text = "0%";
                PgbAnalyze.Value = 0;
                pBoxProgress.Show();
                BgWorkCleaner.RunWorkerAsync(totalFiles);
                BtnClean.Enabled = false;
                RunCleanerMenuItem.Visible = false;
                AnalyzeMenuItem.Visible = true;
            }
        }

        #region BackgroundWorker Cleaner
        private void BgWorkerCleaner_DoWork(object sender, DoWorkEventArgs e)
        {
            int totalFiles = (int)e.Argument;
            int counter = 0;
            sizeCleaned = 0;
            int onePerc = totalFiles / 100;
            int count = 0;
            string[,] table =  pcCleaner.GetAnalysisDataTable(DtgAnalyze);

            for (int i = 0; i < table.GetLength(0); i++)
            {
                try
                {
                    File.Delete(table[i, 0]);
                    sizeCleaned += int.Parse(table[i, 1]);

                    if (onePerc > 1 && (counter % onePerc) == 0)
                    {
                        BgWorkCleaner.ReportProgress(1, count);
                        count += 1;
                    }
                }
                catch (UnauthorizedAccessException) { }
                catch (IOException) { }
                counter++;
            }
            if (onePerc < 1)
                BgWorkCleaner.ReportProgress(100);
        }

        private void BgWorkerCleaner_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int totalPerc = 0;
            if (e.UserState != null)
            {
                totalPerc = (int)e.UserState;
            }
            if (PgbAnalyze.Value >= 100)
            {
                LblPercPgb.Text = "100%";
                PgbAnalyze.Value = 100;
            }
            else
            {
                LblPercPgb.Text = totalPerc + "%";
                PgbAnalyze.Value += e.ProgressPercentage;
            }
        }

        private void BgWorkerCleaner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LblAnalysisProgress.Text = "    " + strings.cleaningCompleted;
            LblSizeToBeRemoved.ForeColor = Color.Green;
            LblSizeToBeRemoved.Text = (sizeCleaned / 1024) + " " + strings.sizeCleaned;
            pBoxProgress.Hide();
            PgbAnalyze.Value = 100;
            LblPercPgb.Text = "100%";
            Win32.getDriveSpace(LblFreeSpace, LblTotalSize, CpgbDisk);
            BgWorkCleaner.Dispose();
            GbxDetailsFiles.Hide();
            if (ChkClosePcClean.Checked)
                Application.Exit();
            if (myNotifyIcon.Visible)
                myNotifyIcon.ShowBalloonTip(1000, "Powered Cleaner", LblSizeToBeRemoved.Text, ToolTipIcon.Info);
        }
        #endregion
        #endregion

        #region Other Methods
        private void BeginAnalysis()
        {
            myTabCtrllMain.SelectedTab = tPDashboard;
            PgbAnalyze.Value = 0;
            PgbAnalyze.Show();
            DtgAnalyze.Rows.Clear();
            GbxDetailsFiles.Show();
        }
        private void FinishAnalysis()
        {
            BtnClean.Enabled = true;
            PgbAnalyze.Value = 100;
            LblAnalysisProgress.Text = "    " + strings.analysisCompleted;
            LblAnalysisProgress.Show();
            AnalyzeMenuItem.Visible = false;
            RunCleanerMenuItem.Visible = true;
            pcAnalysisEngine.ShowAnalysisSize(DtgAnalyze, ref LblSizeToBeRemoved);
        }

        #endregion

        #region Memory Infos
        private void getMemoryInfos()
        {
            try
            {
                totalRAM = int.Parse(Win32.GetRAMsize());
                LblTotalRAM.Text = totalRAM + ".0 GB";
            }
            catch (Exception)
            {
                pnlRam.Hide();
            }
        }
        #endregion

        #region Timer Memory
        private void myTimer_Tick(object sender, EventArgs e)
        {
            double fRam = Math.Round(pRam.NextValue(), 0) - 5;
            CpgbRam.Value = (int)fRam;
            CpgbRam.Text = Convert.ToString(fRam) + "%";
            CpgbRam.Update();

            double usedMemory = Math.Round(totalRAM * ((double)pRam.NextValue() / 100), 2);
            LblUsedRam.Text = Convert.ToString(usedMemory) + " GB /";
            if (fRam > 50 && fRam < 70)
                CpgbRam.ProgressColor = Color.Orange;
            else if (fRam > 70)
                CpgbRam.ProgressColor = Color.Red;
            else if (fRam < 50)
                CpgbRam.ProgressColor = Color.Green;
        } 
        #endregion

        #region Clean Recycle Bin
        private void BtnCleanRecycleBin_Click(object sender, EventArgs e)
        {
            Win32.EmptyRecycleBin();
        }
        #endregion

        #region Left Menu

        #region Dashboard
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            DtgData.Rows.Clear();
            DtgAnalyze.Refresh();
            myTabCtrllMain.SelectedTab = tPDashboard;
        }
        #endregion

        #region System
        private void BtnSystem_Click(object sender, EventArgs e)
        {
            myTabCtrllMain.SelectedTab = tabPSystem;
        }


        private void BgWorkerSystemInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((string)e.Argument != "WinExplorer")
            {
                Win32.LoadSystemInformations(liste);
                BgWorkGeneral.ReportProgress(0, "SystemInfo");
            }
        }
        private void BgWorkerSystemInfo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState.ToString() == "SystemInfo")
            {
                TbxOSType.Text = liste[0]; TbxDesktopName.Text = liste[1]; TbxProcesseur.Text = liste[2];
                TbxManufacturer.Text = liste[3]; TbxHDD.Text = liste[4]; TbxBIOS.Text = liste[5];
                TbxModel.Text = liste[6]; TbxRAM.Text = liste[7]; TbxAudioDevice.Text = liste[8];
                TbxVideoController.Text = liste[9]; TbxOSVersion.Text = liste[10]; liste.Clear();
            }
        } 
        #endregion

        #region Web Browser
        private void BtnGoogleChrome_Click(object sender, EventArgs e)
        {
            myTabCtrllMain.SelectedTab = tabPWebBrowser;
        }
        #endregion

        #region Windows Explorer
        private void BtnWinExplorer_Click(object sender, EventArgs e)
        {
            myTabCtrllMain.SelectedTab = tabPWinExplorer;
        }
        #endregion

        #region About
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            myTabCtrllMain.SelectedTab = tabPAbout;
        }
        #endregion

        #endregion

        #region ContextMenuStrip : Analyze <SourceControl>
        private void Cms_Opening(object sender, CancelEventArgs e)
        {
            CmsAnalyze.Items[0].Text = strings.analyze + " " + CmsAnalyze.SourceControl.Text;
        }

        private void anaylzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeginAnalysis();
            string myTabPage = CmsAnalyze.SourceControl.Name;
            switch (myTabPage)
            {
                case "ChkSystem":
                    pcSystem.SetRowPos(0);
                    pcSystem.Analysis();
                    pcSystem.ShowSystemData(DtgAnalyze);
                    break;
                case "ChkWinExplorer":
                    pcWinExplorer.SetRowPos(0);
                    pcWinExplorer.Analysis();
                    pcWinExplorer.ShowWinExplorerData(DtgAnalyze);
                    break;
                case "ChkChrome":
                    pcChrome.SetRowPos(0);
                    pcChrome.Analysis();
                    pcChrome.ShowData(DtgAnalyze);
                    break;
                case "ChkChromeCache":
                    pcChrome.SetRowPos(0);
                    pcChrome.InternetCache();
                    pcChrome.ShowInternetCache(DtgAnalyze);
                    break;
                case "ChkChromeHist":
                    pcChrome.SetRowPos(0);
                    pcChrome.InternetHistory();
                    pcChrome.ShowInternetHistory(DtgAnalyze);
                    break;
                case "ChkChromeCrashReports":
                    pcChrome.SetRowPos(0);
                    pcChrome.CrashReports();
                    pcChrome.ShowCrashReports(DtgAnalyze);
                    break;
                case "ChkChromeDLHist":
                    pcChrome.SetRowPos(0);
                    pcChrome.DownloadHistory();
                    pcChrome.ShowDownloadHistory(DtgAnalyze);
                    break;
                case "ChkFirefox":
                    pcFirefox.SetRowPos(0);
                    pcFirefox.Analysis();
                    pcFirefox.ShowData(DtgAnalyze);
                    break;
                case "ChkFirefoxCache":
                    pcFirefox.SetRowPos(0);
                    pcFirefox.InternetCache();
                    pcChrome.ShowInternetCache(DtgAnalyze);
                    break;
                case "ChkFirefoxHist":
                    pcFirefox.SetRowPos(0);
                    pcFirefox.InternetHistory();
                    pcFirefox.ShowInternetHistory(DtgAnalyze);
                    break;
                case "ChkFirefoxDLHist":
                    pcFirefox.SetRowPos(0);
                    //pcChrome.ShowDownloadHistory(DtgAnalyze);
                    break;
                case "ChkEdge":
                    pcEdge.SetRowPos(0);
                    pcEdge.InternetCache();
                    pcEdge.InternetHistory();
                    pcEdge.ShowEdgeData(DtgAnalyze);
                    break;
                case "ChkOpera":
                    pcOpera.InternetCache();
                    pcOpera.ShowInternetCache(DtgAnalyze);
                    break;
                case "ChkOperaCache":
                    pcOpera.SetRowPos(0);
                    pcOpera.InternetCache();
                    pcOpera.ShowInternetCache(DtgAnalyze);
                    break;
                case "ChkOperaHist":
                    pcOpera.SetRowPos(0);
                    pcOpera.InternetHistory();
                    pcOpera.ShowInternetHistory(DtgAnalyze);
                    break;
                case "ChkTempFiles":
                    pcSystem.SetRowPos(0);
                    pcSystem.TemporaryFiles();
                    pcSystem.ShowTemporaryFiles(DtgAnalyze);
                    break;
                case "ChkMemDumps":
                    pcSystem.SetRowPos(0);
                    pcSystem.MemDump();
                    pcSystem.ShowMemoryDumps(DtgAnalyze);
                    break;
                case "ChkWinErrorReporting":
                    pcSystem.SetRowPos(0);
                    pcSystem.WinErrorReporting();
                    pcSystem.ShowWinErrorReporting(DtgAnalyze);
                    break;
                default:
                    break;
            }
            FinishAnalysis();
        }
        #endregion

        #region Controls
        private void BtnSystemConfig_Click(object sender, EventArgs e)
        {
            string msConfig = Path.Combine(Environment.GetEnvironmentVariable("windir"), "System32\\msconfig.EXE");
            Process.Start(msConfig);
        }

        private void LinkLblWebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.LinkData = "https://tanguyonline.wordpress.com/";
            Process.Start(e.Link.LinkData as string);
        }
        private void BtnViewMore_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region MenuItems : View All Files - Open Containing Folder

        #region View All Files
        private void DtgAnalyze_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu myContextMenu = new ContextMenu();
                myContextMenu.MenuItems.Add(new MenuItem(strings.viewAllFiles, MenuItemViewFiles_Click));
                currentMouseOverRow = DtgAnalyze.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    if (DtgAnalyze.Rows[currentMouseOverRow].Cells[1].Value.GetType().Name == "Int64")
                    {
                        DtgAnalyze.ClearSelection();
                       // DtgAnalyze.Rows[currentMouseOverRow].Selected = true;
                        tabPage = (string)DtgAnalyze.Rows[currentMouseOverRow].Cells[0].Value;
                        myContextMenu.Show(DtgAnalyze, new Point(e.X, e.Y));
                    }
                }
            }
        }
        #region SWITCH
        private void MenuItemViewFiles_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tabPage))
            {
                switch (tabPage)
                {
                    case "Temporary Files":
                        pcSystem.FillTemporaryFiles(DtgData);
                        break;
                    case "Memory Dumps":
                        pcSystem.FillMemDump(DtgData);
                        break;
                    case "Windows Error Reporting":
                        pcSystem.FillWinErrorReporting(DtgData);
                        break;
                    case "Thumbnail Cache":
                        pcWinExplorer.FillThumbnailCache(DtgData);
                        break;
                    case "Recent Documents":
                        pcWinExplorer.FillRecentDocuments(DtgData);
                        break;
                    case "Firefox - Internet Cache":
                        pcFirefox.FillInternetCache(DtgData);
                        break;
                    case "Firefox - Internet History":
                        pcFirefox.FillInternetHistory(DtgData);
                        break;
                    case "Chrome - Internet Cache":
                        pcChrome.FillInternetCache(DtgData);
                        break;
                    case "Chrome - Internet History":
                        pcChrome.FillInternetHistory(DtgData);
                        break;
                    case "Chrome - Download History":
                        pcChrome.FillDownloadHistory(DtgData);
                        break;
                    case "Edge - Internet Cache":
                        pcEdge.FillInternetCache(DtgData);
                        break;
                    case "Edge - Internet History":
                        pcEdge.FillInternetHistory(DtgData);
                        break;
                    case "Opera - Internet Cache":
                        pcOpera.FillInternetCache(DtgData);
                        break;
                    case "Opera - Internet History":
                        pcOpera.FillInternetHistory(DtgData);
                        break;
                    case "Windows - Downloaded Files":
                        pcWindows.FillDownloadedFiles(DtgData);
                        break;
                    case "Windows - Windows Update":
                        pcWindows.FillWinUpdate(DtgData);
                        break;
                    case "Windows - Windows Installer":
                        pcWindows.FillWinInstaller(DtgData);
                        break;
                    case "Windows - Windows Logs":
                        pcWindows.FillWinLogs(DtgData);
                        break;
                    case "Windows - Jump Lists":
                        pcWindows.FillJumpLists(DtgData);
                        break;
                    case "MS Visual Studio":
                        pcVisualStudio.FillData(DtgData);
                        break;
                    case "MS SQL Server":
                        pcSqlServer.FillData(DtgData);
                        break;
                    case "Steam":
                        pcSteam.FillData(DtgData);
                        break;
                    case "Discord":
                        pcDiscord.FillData(DtgData);
                        break;
                    case "MS Office 2016":
                        pcOffice.FillData(DtgData);
                        break;
                    case "Android Studio":
                        pcAndroidStudio.FillData(DtgData);
                        break;
                    default:
                        break;
                }
                myTabCtrllMain.SelectedTab = tabPData;
                tabPage = "";
            }
        }
        #endregion
        #endregion

        #region Open Containing Folder

        private void DtgData_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = DtgData.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    DtgData.ClearSelection();
                    DtgData.Rows[currentMouseOverRow].Selected = true;
                    CreateCtxtMenuOpenFolder(DtgData, e);
                    cellValue = DtgData.Rows[currentMouseOverRow].Cells[0].Value.ToString();
                }
            }
        }
        private void MenuItemOpenContainingFolder_Click(object sender, EventArgs e)
        {
            if (currentMouseOverRow >= 0)
                Process.Start("explorer.exe", @"/select," + cellValue + "");
        } 

        private void CreateCtxtMenuOpenFolder(DataGridView Dtg, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu myContextMenu = new ContextMenu();
                myContextMenu.MenuItems.Add(new MenuItem(strings.openContainingFolder, MenuItemOpenContainingFolder_Click));
                currentMouseOverRow = Dtg.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                    myContextMenu.Show(Dtg, new Point(e.X, e.Y));
            }
        }
        #endregion

        #endregion

        #region  Analyze  System - Chrome - Firefox - Edge - Windows Explorer - Windows Update
        
        #region System
        private void BtnAnalyseSystem_Click(object sender, EventArgs e)
        {
            myTabCtrllMain.SelectedTab = tPDashboard;
            BeginAnalysis();
            pcSystem.SetRowPos(0);
            if (ChkTempFiles.Checked)
            {
                pcSystem.TemporaryFiles();
                pcSystem.ShowTemporaryFiles(DtgAnalyze);
            }
            if (ChkMemDumps.Checked)
            {
                pcSystem.MemDump();
                pcSystem.ShowMemoryDumps(DtgAnalyze);
            }
            if (ChkWinErrorReporting.Checked)
            {
                pcSystem.WinErrorReporting();
                pcSystem.ShowWinErrorReporting(DtgAnalyze);
            }
            FinishAnalysis();
        }
        #endregion

        #region Chrome
        private void BtnChrome_Click(object sender, EventArgs e)
        {
                if (!BgWorkAnalysis.IsBusy)
                {
                    DtgAnalyze.Rows.Clear();
                    PgbAnalyze.Value = 0;
                    myTabCtrllMain.SelectedTab = tPDashboard;
                    mySender = (sender as Button).Text;
                    pBoxAnalysisChrome.Show();
                    BgWorkAnalysis.RunWorkerAsync("chrome");
                }
        }

        #region BG Worker Analysis
        private void BgWorkerAnalysis_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (e.Argument)
            {
                case "chrome":
                        pcChrome.SetRowPos(0);
                        // CACHE
                        if (ChkChromeCache.Checked) BgWorkAnalysis.ReportProgress(20, "WebCache");
                        // HISTORY
                        if (ChkChromeHist.Checked) BgWorkAnalysis.ReportProgress(20, "WebHistory");
                        // DOWNLOAD HISTORY
                        if (ChkChromeDLHist.Checked) BgWorkAnalysis.ReportProgress(20, "DlHistory");
                        // CRASH REPORTS
                        if (ChkChromeCrashReports.Checked) BgWorkAnalysis.ReportProgress(20, "CrashReports");
                    BgWorkAnalysis.ReportProgress(20, "Finished");
                    break;
                case "WUpdate":
                    if (ChkWinUpdate.Checked)
                        pcWindows.WinUpdate();
                        
                    BgWorkAnalysis.ReportProgress(0, "WUpdate");
                    break;
                default:
                    break;
            }
        }
        private void BgWorkerAnalysis_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string analyze = e.UserState.ToString();
            PgbAnalyze.Value = 100;
            switch (analyze)
            {
                case "WUpdate":
                    pcWindows.ShowWinUpdate(DtgAnalyze);
                    break;
                case "WebCache":
                    pcChrome.InternetCache();
                    pcChrome.ShowInternetCache(DtgAnalyze);
                    break;
                case "WebHistory":
                    pcChrome.InternetHistory();
                    pcChrome.ShowInternetHistory(DtgAnalyze);
                    break;
                case "DlHistory":
                    pcChrome.DownloadHistory();
                    pcChrome.ShowDownloadHistory(DtgAnalyze);
                    break;
                case "CrashReports":
                    pcChrome.CrashReports();
                    pcChrome.ShowCrashReports(DtgAnalyze);
                    break;
                default:
                    break;
            }
            BtnAnalyser.Enabled = true;
        }

        private void BgWorkerAnalysis_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PgbAnalyze.Show();
            GbxDetailsFiles.Show();
            pBoxLoadingAnalysis.Hide();
            myTabCtrllMain.SelectedTab = tPDashboard;
            LblAnalysisProgress.Show(); pBoxAnalysisChrome.Hide();
            pcAnalysisEngine.ShowAnalysisSize(DtgAnalyze, ref LblSizeToBeRemoved);
            pBoxLoadingAnalysis.Hide();
            BgWorkAnalysis.Dispose();

        } 
        #endregion
        #endregion

        #region Firefox
        private void BtnAnalyzeFirefox_Click(object sender, EventArgs e)
        {
                BeginAnalysis();
                pcFirefox.SetRowPos(0);
                if (ChkFirefoxCache.Checked)
                {
                    pcFirefox.InternetCache();
                    pcFirefox.ShowInternetCache(DtgAnalyze);
                }
                if (ChkFirefoxHist.Checked)
                {
                    pcFirefox.InternetHistory();
                    pcFirefox.ShowInternetHistory(DtgAnalyze);
                }
                FinishAnalysis();
        }
        #endregion

        #region Opera
        private void BtnAnalyzeOpera_Click(object sender, EventArgs e)
        {
            if (!pcProcess.IsProcessSkipped("opera"))
            {
                if (pcOpera == null)
                {
                    pcOpera = new pcOpera();
                }
                pcOpera.SetRowPos(0);
                BeginAnalysis();
                if (ChkOperaCache.Checked)
                {
                    pcOpera.InternetCache();
                    pcOpera.ShowInternetCache(DtgAnalyze);
                }
                if (ChkOperaHist.Checked)
                {
                    pcOpera.InternetHistory();
                    pcOpera.ShowInternetHistory(DtgAnalyze);
                }
                FinishAnalysis();
            }
        }
        #endregion

        #region Edge
        private void BtnAnalyzeEdge_Click(object sender, EventArgs e)
        {
            BeginAnalysis();
            pcEdge.SetRowPos(0);
            if (ChkEdgeWebCache.Checked)
            {
                pcEdge.InternetCache();
                pcEdge.ShowInternetCache(DtgAnalyze);
            }
            if (ChkEdgeWebHist.Checked)
            {
                pcEdge.InternetHistory();
                pcEdge.ShowInternetHistory(DtgAnalyze);
            }
            FinishAnalysis();
        }
        #endregion

        #region Windows Explorer
        private void BtnAnalyzeWinExplorer_Click(object sender, EventArgs e)
        {
            BeginAnalysis();
            pcWinExplorer.SetRowPos(0);
            if (ChkRecentDocuments.Checked)
            {
                pcWinExplorer.RecentDocuments();
                pcWinExplorer.ShowRecentDocuments(DtgAnalyze);
            }
            if (ChkThumbnailCache.Checked)
            {
                pcWinExplorer.ThumbnailCache();
                pcWinExplorer.ShowThumbnail(DtgAnalyze);
            }
            FinishAnalysis();
        }
        #endregion

        #region Windows Update
        private void BtnAnalyzeWinUpdate_Click(object sender, EventArgs e)
        {
            pcWindows.SetRowPos(0);
            PgbAnalyze.Value = 0;
            pBoxLoadingAnalysis.Show();
            PgbAnalyze.Show();
            DtgAnalyze.Rows.Clear();
            GbxDetailsFiles.Show();
            if (ChkWinUpdate.Checked)
            {
                BgWorkAnalysis.RunWorkerAsync("WUpdate");
            }
            if (ChkDownloadedInstall.Checked)
            {
                pcWindows.DownloadedInstall();
            }
            if (ChkWinInstaller.Checked)
            {
                pcWindows.WinInstaller();
                pcWindows.ShowWinInstaller(DtgAnalyze);
            }
            if (ChkWinLogs.Checked)
            {
                pcWindows.WinLogs();
                pcWindows.ShowWinLogs(DtgAnalyze);
            }
            if (ChkJumpLists.Checked)
            {
                pcWindows.JumpLists();
                pcWindows.ShowJumpLists(DtgAnalyze);
            }
            FinishAnalysis();
        } 
        #endregion
        #endregion

        #region Menu Color Event
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Button> myButtons = new List<Button>();
            myButtons.Add(BtnDashboard); myButtons.Add(BtnSystem);
            myButtons.Add(BtnWinExplorer); myButtons.Add(BtnWebBrowser);
            myButtons.Add(BtnTools); myButtons.Add(BtnOptions);
            myButtons.Add(BtnAdvanced); myButtons.Add(BtnAbout);
            myButtons.Add(BtnTools);
            if (myTabCtrllMain.SelectedTab == tPDashboard)
            {
                foreach (Button item in myButtons)
                    item.BackColor = Color.Firebrick;
                BtnDashboard.BackColor = Color.OrangeRed;
            }
            if (myTabCtrllMain.SelectedTab == tabPSystem)
            {
                foreach (Button item in myButtons)
                    item.BackColor = Color.Firebrick;
                BtnSystem.BackColor = Color.OrangeRed;
            }
            if (myTabCtrllMain.SelectedTab == tabPWinExplorer)
            {
                foreach (Button item in myButtons)
                    item.BackColor = Color.Firebrick;
                BtnWinExplorer.BackColor = Color.OrangeRed;
            }
            if (myTabCtrllMain.SelectedTab == tabPWebBrowser)
            {
                foreach (Button item in myButtons)
                    item.BackColor = Color.Firebrick;
                BtnWebBrowser.BackColor = Color.OrangeRed;
            }
            if (myTabCtrllMain.SelectedTab == tabPAdvanced)
            {
                foreach (Button item in myButtons)
                    item.BackColor = Color.Firebrick;
                BtnAdvanced.BackColor = Color.OrangeRed;
            }
            if (myTabCtrllMain.SelectedTab == tabPOptions)
            {
                foreach (Button item in myButtons)
                    item.BackColor = Color.Firebrick;
                BtnOptions.BackColor = Color.OrangeRed;
            }
            if (myTabCtrllMain.SelectedTab == tabPAbout)
            {
                foreach (Button item in myButtons)
                    item.BackColor = Color.Firebrick;
                BtnAbout.BackColor = Color.OrangeRed;
            }
            if (myTabCtrllMain.SelectedTab == tabPApplications)
            {
                foreach (Button item in myButtons)
                    item.BackColor = Color.Firebrick;
                BtnTools.BackColor = Color.OrangeRed;
            }
        }
        #endregion

        #region Checkbox CheckedChanged Event
        private void ChkDashboardAnalyze_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkSystem.Checked && !ChkChrome.Checked && !ChkApplications.Checked && !ChkWinExplorer.Checked && !ChkFirefox.Checked && !ChkEdge.Checked && !ChkOpera.Checked)
                BtnAnalyser.Enabled = false;
            else
                BtnAnalyser.Enabled = true;
        }

        private void ChkWinExplorerAnalyze_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkRecentDocuments.Checked && !ChkThumbnailCache.Checked)
                BtnAnalyzeWinExplorer.Enabled = false;
            else
                BtnAnalyzeWinExplorer.Enabled = true;
        }

        private void ChkAnalyzeSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkTempFiles.Checked && !ChkWinErrorReporting.Checked && !ChkMemDumps.Checked && !ChkClipboard.Checked)
                BtnAnalyseSystem.Enabled = false;
            else
                BtnAnalyseSystem.Enabled = true;
        }

        private void ChkChromeAnalyze_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkChromeCache.Checked && !ChkChromeHist.Checked && !ChkChromeUpdates.Checked && !ChkChromeDLHist.Checked && !ChkChromeCrashReports.Checked && !ChkChromeExtDb.Checked)
                BtnAnalyzeChrome.Enabled = false;
            else
                BtnAnalyzeChrome.Enabled = true;
        }

        private void ChkFirefoxAnalyze_Checked(object sender, EventArgs e)
        {
            if (!ChkFirefoxDLHist.Checked && !ChkFirefoxStartupCache.Checked && !ChkFirefoxCache.Checked && !ChkFirefoxHist.Checked && !ChkFirefoxHTML5Storage.Checked)
                BtnAnalyzeFirefox.Enabled = false;
            else
                BtnAnalyzeFirefox.Enabled = true;
        }

        private void ChkOperaAnalyze_Checked(object sender, EventArgs e)
        {
            if (!ChkOperaDLHist.Checked && !ChkOperaSession.Checked && !ChkOperaCache.Checked && !ChkOperaHist.Checked)
                BtnAnalyzeOpera.Enabled = false;
            else
                BtnAnalyzeOpera.Enabled = true;
        }

        private void ChkEdgeAnalyze_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkEdgeDLHist.Checked && !ChkEdgeSession.Checked && !ChkEdgeWebCache.Checked && !ChkEdgeWebHist.Checked)
                BtnAnalyzeEdge.Enabled = false;
            else
                BtnAnalyzeEdge.Enabled = true;
        }
        #endregion

        #region Check for Updates
        private void LblCheckUpdates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WebClient webclient = new WebClient();

            Uri webVersion = new Uri("https://www.dropbox.com/s/uy8bulci8o9f3q1/version.txt?dl=1"); // PROD
            // Uri webVersion = new Uri("https://www.dropbox.com/s/s6fxbdh4631oet8/dev.txt?dl=1"); // DEV
            try
            {
                webclient.DownloadStringCompleted += DownloadStringCompleted;
                webclient.DownloadStringAsync(webVersion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                    strWebVersion = e.Result;
                    strWebVersion = strWebVersion.Replace(".", ",");
                    WebClient webclient = new WebClient();
                    double serverVersion = double.Parse(strWebVersion);
                    if (clientVersion < serverVersion)
                    {
                        MessageBox.Show("Une nouvelle version est disponible ! Powered Cleaner va procéder à la mise à jour dés maintenant."
                            , "Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        webclient.DownloadFileCompleted += DownloadFileCompleted;
                        Uri uri = new Uri("https://www.dropbox.com/s/jaw1tyl8ahyhxd9/Powered%20Cleaner%20Installer.exe?dl=1");

                        if (!Directory.Exists(Path.Combine(RepApp, @"update\0.4")))
                        {
                            Directory.CreateDirectory(Path.Combine(RepApp, @"update\0.4"));
                            webclient.DownloadFileAsync(uri, Path.Combine(RepApp, @"update\0.4\Powered Cleaner Installer.exe"));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous disposez déjà de la dernière version !", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            catch (TargetInvocationException)
            {
                MessageBox.Show("Please verify your internet connection", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start(Path.Combine(RepApp, @"Update\0.4\Powered Cleaner Installer.exe"));
            Application.Exit();
        }
        
        private void BtnAdvanced_Click(object sender, EventArgs e)
        {
            myTabCtrllMain.SelectedTab = tabPAdvanced;
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            myTabCtrllMain.SelectedTab = tabPOptions;
        }

        private void ChkWinUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkWinUpdate.Checked)
                BtnAnalyzeWindows.Enabled = false;
            else
                BtnAnalyzeWindows.Enabled = true;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && ChkMinSysTray.Checked)
            {
                Hide();
                myNotifyIcon.Visible = true;
            }
            if (myTabCtrllMain.SelectedTab == tabPData)
            {
                DtgData.Rows.Clear();
                myTabCtrllMain.SelectedTab = tPDashboard;
            }
        }

        private void myNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            myNotifyIcon.Visible = false;
        }

        #region Settings
        #region Settings Saving
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            myNotifyIcon.Visible = false;
            Settings.Default.CloseProgramAfterClean = ChkClosePcClean.Checked;
            Settings.Default.MinimizeTray = ChkMinSysTray.Checked;
            Settings.Default.DelOnlyWinTemp24 = ChkDelOnlyWinTemp24.Checked;
            Settings.Default.System = ChkSystem.Checked;
            Settings.Default.WinExplorer = ChkWinExplorer.Checked;
            Settings.Default.Chrome = ChkChrome.Checked;
            Settings.Default.Edge = ChkEdge.Checked;
            Settings.Default.Firefox = ChkFirefox.Checked;
            Settings.Default.Opera = ChkOpera.Checked;
            Settings.Default.Applications = ChkApplications.Checked;
            Settings.Default.Save();
        }
        #endregion

        #region Settings Loading
        private void LoadSettings()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Settings.Default.Language);
            ChkMinSysTray.Checked = Settings.Default.MinimizeTray;
            ChkDelOnlyWinTemp24.Checked = Settings.Default.DelOnlyWinTemp24;
            ChkClosePcClean.Checked = Settings.Default.CloseProgramAfterClean;
            ChkSystem.Checked = Settings.Default.System;
            ChkWinExplorer.Checked = Settings.Default.WinExplorer;
            ChkChrome.Checked = Settings.Default.Chrome;
            ChkEdge.Checked = Settings.Default.Edge;
            ChkFirefox.Checked = Settings.Default.Firefox;
            ChkOpera.Checked = Settings.Default.Opera;
            ChkRunPcStart.Checked = Settings.Default.Startup;
            ChkApplications.Checked = Settings.Default.Applications;
        }
        #endregion 
        #endregion

        #region Notify Icon
        private void openPoweredCleanerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            myNotifyIcon.Visible = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            myTabCtrllMain.SelectedTab = tabPOptions;
            myNotifyIcon.Visible = false;
        }

        private void AnalyzeMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            myTabCtrllMain.SelectedTab = tPDashboard;
            BtnAnalyser.PerformClick();
            myNotifyIcon.Visible = false;
            AnalyzeMenuItem.Visible = false;
            RunCleanerMenuItem.Visible = true;
        }

        private void RunCleanerMenuItem_Click(object sender, EventArgs e)
        {
            int totalFiles = pcCleanerEngine.GetTotalFiles(DtgAnalyze);
            if (!BgWorkCleaner.IsBusy)
            {
                PgbAnalyze.Value = 0;
                pBoxProgress.Show();
                BgWorkCleaner.RunWorkerAsync(totalFiles);
                BtnClean.Enabled = false;
                RunCleanerMenuItem.Visible = false;
                AnalyzeMenuItem.Visible = true;
            }
        }
        #endregion

        #region Language Selection
        private void pBoxFrench_Click(object sender, EventArgs e)
        {
            Settings.Default.Language = "fr-FR";
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Settings.Default.Language);
            LoadLanguage();
        }

        private void pBoxEnglish_Click(object sender, EventArgs e)
        {
            Settings.Default.Language = "en-US";
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Settings.Default.Language);
            LoadLanguage();
        } 
        #endregion

        #region Localization
        private void LoadLanguage()
        {
            BtnDashboard.Text = strings.dashboard;
            BtnSystem.Text = strings.system;
            BtnWinExplorer.Text = strings.winExplorer;
            ChkDownloadedInstall.Text = strings.downloadedInstall;
            ChkWinLogs.Text = strings.winLogFiles;
            ChkSystem.Text = strings.chkSystem;
            ChkWinExplorer.Text = strings.chkWinExplorer;
            BtnWebBrowser.Text = strings.webBrowser;
            BtnAdvanced.Text = strings.advanced;
            BtnAbout.Text = strings.about;
            LblCheckUpdates.Text = strings.checkForUpdates;
            ChkTempFiles.Text = strings.temporaryFiles;
            //LblSizeToBeRemoved.Text = (sizeCleaned / 1024) + " " + strings.sizeCleaned;
            ChkMemDumps.Text = strings.memoryDumps;
            ChkClipboard.Text = strings.clipboard;
            ChkWinErrorReporting.Text = strings.winErrorReporting;
            ChkEdgeWebCache.Text = strings.internetCache;
            ChkEdgeDLHist.Text = strings.downloadHistory;
            ChkEdgeWebHist.Text = strings.history;
            ChkChromeCache.Text = strings.internetCache;
            ChkChromeDLHist.Text = strings.downloadHistory;
            ChkChromeHist.Text = strings.history;
            ChkFirefoxCache.Text = strings.internetCache;
            ChkFirefoxDLHist.Text = strings.downloadHistory;
            ChkFirefoxHist.Text = strings.history;
            ChkOperaCache.Text = strings.internetCache;
            ChkOperaDLHist.Text = strings.downloadHistory;
            ChkOperaHist.Text = strings.history;
            ChkRecentDocuments.Text = strings.recentDocs;
            ChkThumbnailCache.Text = strings.thumbnailCache;
            BtnCleanRecycleBin.Text = strings.cleanRecycleBin;
            BtnAnalyzeChrome.Text = strings.analyze + " Google Chrome";
            BtnAnalyzeFirefox.Text = strings.analyze + " Mozilla Firefox";
            BtnAnalyzeOpera.Text = strings.analyze + " Opera";
            BtnAnalyzeEdge.Text = strings.analyze + " Microsoft Edge";
            BtnAnalyseSystem.Text = strings.analyze + " Système";
            BtnAnalyzeWinExplorer.Text = strings.analyze + " " + strings.chkWinExplorer;
            BtnAnalyzeWindows.Text = strings.analyze + " Windows";
            GbxSystemInformation.Text = strings.systemInfo;
            GUIVideoController.Text = strings.videoController;
            GUIProcessor.Text = strings.processor;
            GUISystemName.Text = strings.systemName;
            GUIBIOS.Text = strings.biosVersion;
            GUIOSType.Text = strings.systemType;
            GUIOSVersion.Text = strings.winVersion;
            GUIManufacturer.Text = strings.manufacturer;
            GUIAudioDevice.Text = strings.audioDevice;
            GUIModel.Text = strings.model;
            GUIHDD.Text = strings.hdd;

            if (Settings.Default.Language == "en-US")
                LblCheckUpdates.Left = 818;

            if (Settings.Default.Language == "fr-FR")
                LblCheckUpdates.Left = 765;

            GuiSystem.Text = strings.chkSystem;
            GuiWinExplorer.Text = strings.chkWinExplorer;
            GuiStockage.Text = strings.storage;
            BtnClean.Text = strings.clean;
            ChkWinUpdate.Text = strings.winUpdate;
            ChkMinSysTray.Text = strings.minSysTray;
            ChkRunPcStart.Text = strings.runPcStart;
            ChkClosePcClean.Text = strings.ClosePcClean;
            ChkDelOnlyWinTemp24.Text = strings.DelOnlyWinTemp24;
            GbxSettings.Text = strings.settings;
            RunCleanerMenuItem.Text = strings.clean;
            BtnAnalyser.Text = strings.analyze;
            AnalyzeMenuItem.Text = strings.analyze;
            openPoweredCleanerToolStripMenuItem.Text = strings.openPc;
            quitToolStripMenuItem.Text = strings.quit;
        } 
        #endregion

        private void ChkRunPcStart_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey key;
            if (ChkRunPcStart.Checked)
            {
                key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                key.SetValue("PoweredCleaner", "\"" + Application.ExecutablePath + "\"");
            }
            else
            {
                key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue("PoweredCleaner") != null)
                    key.DeleteValue("PoweredCleaner");
            }
            Settings.Default.Startup = ChkRunPcStart.Checked;
        }

        private void BtnTools_Click(object sender, EventArgs e)
        {
            myTabCtrllMain.SelectedTab = tabPApplications;
        }

        private void BgWorkSystem_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ChkSystem.Checked)
                pcSystem.Analysis();
            if (ChkWinExplorer.Checked)
                pcWinExplorer.Analysis();
            if (ChkChrome.Checked)
                pcChrome.Analysis();
        }

        private void BgWorkSystem_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void BgWorkSystem_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LblPercPgb.Text = "100%";
            if (ChkSystem.Checked)
                pcAnalysis.ShowSystemData(DtgAnalyze);
            if (ChkWinExplorer.Checked)
                pcAnalysis.ShowWinExplorerData(DtgAnalyze);
            if (ChkChrome.Checked)
                pcAnalysis.ShowChromeData(DtgAnalyze);

            BtnAnalyser.Text = strings.analyze;
            FinishAnalysis();
        }

        private void BtnAnalyzeDevelopment_Click(object sender, EventArgs e)
        {
            BeginAnalysis();
            rowPos = 0;
            bool OK;
            if (ChkAndroidStudio.Checked)
            {
                pcAndroidStudio.Analysis();
                OK = pcAndroidStudio.ShowData(DtgAnalyze, rowPos);
                if (OK)
                    rowPos++;
            }
            if (ChkVisualStudio.Checked)
            {
                pcVisualStudio.Analysis();
                OK = pcVisualStudio.ShowData(DtgAnalyze, rowPos);
                if (OK)
                    rowPos++;
            }
            if (ChkSqlServer.Checked)
            {
                pcSqlServer.Analysis();
                OK = pcSqlServer.ShowData(DtgAnalyze, rowPos);
                if (OK)
                    rowPos++;
            }
            FinishAnalysis();
        }

        private void PbxOffice_Click(object sender, EventArgs e)
        {
            tCtrlApplications.SelectedTab = tPageBureautique;
        }

        private void PbxGames_Click(object sender, EventArgs e)
        {
            tCtrlApplications.SelectedTab = tPageGames;
        }

        private void PbxDevelopment_Click(object sender, EventArgs e)
        {
            tCtrlApplications.SelectedTab = tPageDevelopment;
        }

        private void ChkApplications_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Applications = ChkApplications.Checked;
        }

        private void BtnAnalyzeGames_Click(object sender, EventArgs e)
        {
            BeginAnalysis();
            rowPos = 0;
            if (ChkSteam.Checked)
            {
                pcSteam.Analysis();
                pcSteam.ShowData(DtgAnalyze, rowPos);
                rowPos++;
            }
            if (ChkDiscord.Checked)
            {
                pcDiscord.Analysis();
                pcDiscord.ShowData(DtgAnalyze, rowPos);
                rowPos++;
            }
            FinishAnalysis();
        }

        private void BtnAnalyzeOffice_Click(object sender, EventArgs e)
        {
            BeginAnalysis();
            rowPos = 0;
            if (ChkOffice.Checked)
            {
                pcOffice.Analysis();
                pcOffice.ShowData(DtgAnalyze, rowPos);
            }
            FinishAnalysis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            MyJumpList();
        }

        private void MyJumpList()
        {
            JumpTask task = new JumpTask
            {
                Title = "Options",
                Arguments = "/options",
                Description = "Options",
                CustomCategory = "Tâches",
                IconResourcePath = Assembly.GetEntryAssembly().CodeBase,
                ApplicationPath = Assembly.GetEntryAssembly().CodeBase,
                IconResourceIndex = 6
            };

            JumpList jumpList = new JumpList();
            jumpList.JumpItems.Add(task);
            jumpList.ShowFrequentCategory = false;
            jumpList.ShowRecentCategory = false;
            if (null == System.Windows.Application.Current)
            {
                new System.Windows.Application();
            }
            JumpList.SetJumpList(System.Windows.Application.Current, jumpList);
        }
    }
}