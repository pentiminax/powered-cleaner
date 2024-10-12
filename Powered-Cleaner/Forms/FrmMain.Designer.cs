using System.Windows.Forms;

namespace Powered_Cleaner
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAnalyser = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.myTabCtrllMain = new System.Windows.Forms.TabControl();
            this.tPDashboard = new System.Windows.Forms.TabPage();
            this.pnlRam = new System.Windows.Forms.Panel();
            this.LblTotalRAM = new System.Windows.Forms.Label();
            this.LblUsedRam = new System.Windows.Forms.Label();
            this.GuiRAM = new System.Windows.Forms.Label();
            this.CpgbRam = new CircularProgressBar.CircularProgressBar();
            this.LblPercPgb = new System.Windows.Forms.Label();
            this.BtnCleanRecycleBin = new System.Windows.Forms.Button();
            this.pBoxProgress = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblSlash = new System.Windows.Forms.Label();
            this.LblFreeSpace = new System.Windows.Forms.Label();
            this.LblTotalSize = new System.Windows.Forms.Label();
            this.PgbAnalyze = new System.Windows.Forms.ProgressBar();
            this.GbxAnalyze = new System.Windows.Forms.GroupBox();
            this.ChkApplications = new System.Windows.Forms.CheckBox();
            this.ChkOpera = new System.Windows.Forms.CheckBox();
            this.CmsAnalyze = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.anaylzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChkEdge = new System.Windows.Forms.CheckBox();
            this.ChkFirefox = new System.Windows.Forms.CheckBox();
            this.ChkSystem = new System.Windows.Forms.CheckBox();
            this.ChkWinExplorer = new System.Windows.Forms.CheckBox();
            this.ChkChrome = new System.Windows.Forms.CheckBox();
            this.GuiStockage = new System.Windows.Forms.Label();
            this.LblSizeToBeRemoved = new System.Windows.Forms.Label();
            this.LblAnalysisProgress = new System.Windows.Forms.Label();
            this.GbxDetailsFiles = new System.Windows.Forms.GroupBox();
            this.DtgAnalyze = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpgbDisk = new CircularProgressBar.CircularProgressBar();
            this.tabPSystem = new System.Windows.Forms.TabPage();
            this.BtnAnalyzeEdge = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChkEdgeSession = new System.Windows.Forms.CheckBox();
            this.ChkEdgeDLHist = new System.Windows.Forms.CheckBox();
            this.ChkEdgeWebHist = new System.Windows.Forms.CheckBox();
            this.ChkEdgeWebCache = new System.Windows.Forms.CheckBox();
            this.GuiEdge = new System.Windows.Forms.Label();
            this.GbxSystemInformation = new System.Windows.Forms.GroupBox();
            this.BtnViewMore = new System.Windows.Forms.Button();
            this.tlpSystemInfo = new System.Windows.Forms.TableLayoutPanel();
            this.TbxAudioDevice = new System.Windows.Forms.TextBox();
            this.GUISystemName = new System.Windows.Forms.Label();
            this.GUIAudioDevice = new System.Windows.Forms.Label();
            this.TbxDesktopName = new System.Windows.Forms.TextBox();
            this.GUIManufacturer = new System.Windows.Forms.Label();
            this.TbxManufacturer = new System.Windows.Forms.TextBox();
            this.GUIProcessor = new System.Windows.Forms.Label();
            this.TbxProcesseur = new System.Windows.Forms.TextBox();
            this.GUIVideoController = new System.Windows.Forms.Label();
            this.TbxVideoController = new System.Windows.Forms.TextBox();
            this.GuiMemory = new System.Windows.Forms.Label();
            this.TbxRAM = new System.Windows.Forms.TextBox();
            this.GUIHDD = new System.Windows.Forms.Label();
            this.TbxHDD = new System.Windows.Forms.TextBox();
            this.GUIOSVersion = new System.Windows.Forms.Label();
            this.TbxOSVersion = new System.Windows.Forms.TextBox();
            this.GUIOSType = new System.Windows.Forms.Label();
            this.TbxOSType = new System.Windows.Forms.TextBox();
            this.GUIBIOS = new System.Windows.Forms.Label();
            this.GUIModel = new System.Windows.Forms.Label();
            this.TbxBIOS = new System.Windows.Forms.TextBox();
            this.TbxModel = new System.Windows.Forms.TextBox();
            this.GbxAnalyzeSystem = new System.Windows.Forms.GroupBox();
            this.ChkWinErrorReporting = new System.Windows.Forms.CheckBox();
            this.ChkMemDumps = new System.Windows.Forms.CheckBox();
            this.ChkClipboard = new System.Windows.Forms.CheckBox();
            this.ChkTempFiles = new System.Windows.Forms.CheckBox();
            this.BtnAnalyseSystem = new System.Windows.Forms.Button();
            this.GuiSystem = new System.Windows.Forms.Label();
            this.PboxEdge = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPWinExplorer = new System.Windows.Forms.TabPage();
            this.BtnAnalyzeWinExplorer = new System.Windows.Forms.Button();
            this.GbxAnalyzeWinExplorer = new System.Windows.Forms.GroupBox();
            this.ChkThumbnailCache = new System.Windows.Forms.CheckBox();
            this.ChkRecentDocuments = new System.Windows.Forms.CheckBox();
            this.GuiWinExplorer = new System.Windows.Forms.Label();
            this.PBoxWinExplorer = new System.Windows.Forms.PictureBox();
            this.tabPWebBrowser = new System.Windows.Forms.TabPage();
            this.pnlOpera = new System.Windows.Forms.Panel();
            this.PboxOpera = new System.Windows.Forms.PictureBox();
            this.GuiOpera = new System.Windows.Forms.Label();
            this.LblOperaVersion = new System.Windows.Forms.Label();
            this.BtnAnalyzeOpera = new System.Windows.Forms.Button();
            this.GbxAnalyzeOpera = new System.Windows.Forms.GroupBox();
            this.ChkOperaSession = new System.Windows.Forms.CheckBox();
            this.ChkOperaDLHist = new System.Windows.Forms.CheckBox();
            this.ChkOperaHist = new System.Windows.Forms.CheckBox();
            this.ChkOperaCache = new System.Windows.Forms.CheckBox();
            this.pnlFirefox = new System.Windows.Forms.Panel();
            this.PboxFirefox = new System.Windows.Forms.PictureBox();
            this.GuiFirefox = new System.Windows.Forms.Label();
            this.LblFirefoxVersion = new System.Windows.Forms.Label();
            this.GbxAnalyzeFirefox = new System.Windows.Forms.GroupBox();
            this.ChkFirefoxHTML5Storage = new System.Windows.Forms.CheckBox();
            this.ChkFirefoxStartupCache = new System.Windows.Forms.CheckBox();
            this.ChkFirefoxDLHist = new System.Windows.Forms.CheckBox();
            this.ChkFirefoxHist = new System.Windows.Forms.CheckBox();
            this.ChkFirefoxCache = new System.Windows.Forms.CheckBox();
            this.BtnAnalyzeFirefox = new System.Windows.Forms.Button();
            this.pnlChrome = new System.Windows.Forms.Panel();
            this.PboxChrome = new System.Windows.Forms.PictureBox();
            this.pBoxAnalysisChrome = new System.Windows.Forms.PictureBox();
            this.GuiChrome = new System.Windows.Forms.Label();
            this.BtnAnalyzeChrome = new System.Windows.Forms.Button();
            this.LblChromeVersion = new System.Windows.Forms.Label();
            this.GbxAnalyzeChrome = new System.Windows.Forms.GroupBox();
            this.ChkChromeExtDb = new System.Windows.Forms.CheckBox();
            this.ChkChromeCrashReports = new System.Windows.Forms.CheckBox();
            this.ChkChromeUpdates = new System.Windows.Forms.CheckBox();
            this.ChkChromeDLHist = new System.Windows.Forms.CheckBox();
            this.ChkChromeHist = new System.Windows.Forms.CheckBox();
            this.ChkChromeCache = new System.Windows.Forms.CheckBox();
            this.tabPAdvanced = new System.Windows.Forms.TabPage();
            this.pBoxLoadingAnalysis = new System.Windows.Forms.PictureBox();
            this.GbxWinUpdate = new System.Windows.Forms.GroupBox();
            this.ChkJumpLists = new System.Windows.Forms.CheckBox();
            this.ChkWinInstaller = new System.Windows.Forms.CheckBox();
            this.ChkDownloadedInstall = new System.Windows.Forms.CheckBox();
            this.ChkWinLogs = new System.Windows.Forms.CheckBox();
            this.ChkWinUpdate = new System.Windows.Forms.CheckBox();
            this.BtnAnalyzeWindows = new System.Windows.Forms.Button();
            this.GuiWinUpdate = new System.Windows.Forms.Label();
            this.PBoxWinUpdate = new System.Windows.Forms.PictureBox();
            this.tabPApplications = new System.Windows.Forms.TabPage();
            this.PbxDevelopment = new System.Windows.Forms.PictureBox();
            this.tCtrlApplications = new System.Windows.Forms.TabControl();
            this.tPageBureautique = new System.Windows.Forms.TabPage();
            this.BtnAnalyzeOffice = new System.Windows.Forms.Button();
            this.GbxOffice = new System.Windows.Forms.GroupBox();
            this.ChkDropbox = new System.Windows.Forms.CheckBox();
            this.ChkOffice = new System.Windows.Forms.CheckBox();
            this.ChkVlcMediaPlayer = new System.Windows.Forms.CheckBox();
            this.ChkAdobeReader = new System.Windows.Forms.CheckBox();
            this.tPageGames = new System.Windows.Forms.TabPage();
            this.BtnAnalyzeGames = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ChkDiscord = new System.Windows.Forms.CheckBox();
            this.ChkBattleNet = new System.Windows.Forms.CheckBox();
            this.ChkSteam = new System.Windows.Forms.CheckBox();
            this.tPageDevelopment = new System.Windows.Forms.TabPage();
            this.BtnAnalyzeDevelopment = new System.Windows.Forms.Button();
            this.GbxDevelopment = new System.Windows.Forms.GroupBox();
            this.ChkAndroidStudio = new System.Windows.Forms.CheckBox();
            this.ChkSqlServer = new System.Windows.Forms.CheckBox();
            this.ChkVisualStudio = new System.Windows.Forms.CheckBox();
            this.tPageOthers = new System.Windows.Forms.TabPage();
            this.PbxGames = new System.Windows.Forms.PictureBox();
            this.PbxOffice = new System.Windows.Forms.PictureBox();
            this.tabPOptions = new System.Windows.Forms.TabPage();
            this.GbxSettings = new System.Windows.Forms.GroupBox();
            this.ChkDelOnlyWinTemp24 = new System.Windows.Forms.CheckBox();
            this.ChkRunPcStart = new System.Windows.Forms.CheckBox();
            this.ChkClosePcClean = new System.Windows.Forms.CheckBox();
            this.ChkMinSysTray = new System.Windows.Forms.CheckBox();
            this.tabPAbout = new System.Windows.Forms.TabPage();
            this.LblOtherProject = new System.Windows.Forms.Label();
            this.GuiLineSeparator2 = new System.Windows.Forms.Label();
            this.GuiLineSeparator1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LinkLblWebSite = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PboxAttributeEditor = new System.Windows.Forms.PictureBox();
            this.pBoxIcon = new System.Windows.Forms.PictureBox();
            this.tabPData = new System.Windows.Forms.TabPage();
            this.DtgData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.pRam = new System.Diagnostics.PerformanceCounter();
            this.BgWorkCleaner = new System.ComponentModel.BackgroundWorker();
            this.GuiTitle = new System.Windows.Forms.Label();
            this.GuiVersion = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.pBoxEnglish = new System.Windows.Forms.PictureBox();
            this.pBoxFrench = new System.Windows.Forms.PictureBox();
            this.pBoxUpdate = new System.Windows.Forms.PictureBox();
            this.GuiTitle2 = new System.Windows.Forms.Label();
            this.LblCheckUpdates = new System.Windows.Forms.LinkLabel();
            this.PboxLogo = new System.Windows.Forms.PictureBox();
            this.BgWorkGeneral = new System.ComponentModel.BackgroundWorker();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnAdvanced = new System.Windows.Forms.Button();
            this.BtnOptions = new System.Windows.Forms.Button();
            this.BtnTools = new System.Windows.Forms.Button();
            this.BtnWebBrowser = new System.Windows.Forms.Button();
            this.BtnWinExplorer = new System.Windows.Forms.Button();
            this.BtnSystem = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BgWorkAnalysis = new System.ComponentModel.BackgroundWorker();
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.CmsNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPoweredCleanerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.AnalyzeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunCleanerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BgWorkAnalyze = new System.ComponentModel.BackgroundWorker();
            this.myTabCtrllMain.SuspendLayout();
            this.tPDashboard.SuspendLayout();
            this.pnlRam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgress)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.GbxAnalyze.SuspendLayout();
            this.CmsAnalyze.SuspendLayout();
            this.GbxDetailsFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAnalyze)).BeginInit();
            this.tabPSystem.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GbxSystemInformation.SuspendLayout();
            this.tlpSystemInfo.SuspendLayout();
            this.GbxAnalyzeSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPWinExplorer.SuspendLayout();
            this.GbxAnalyzeWinExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWinExplorer)).BeginInit();
            this.tabPWebBrowser.SuspendLayout();
            this.pnlOpera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxOpera)).BeginInit();
            this.GbxAnalyzeOpera.SuspendLayout();
            this.pnlFirefox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxFirefox)).BeginInit();
            this.GbxAnalyzeFirefox.SuspendLayout();
            this.pnlChrome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxChrome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAnalysisChrome)).BeginInit();
            this.GbxAnalyzeChrome.SuspendLayout();
            this.tabPAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLoadingAnalysis)).BeginInit();
            this.GbxWinUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWinUpdate)).BeginInit();
            this.tabPApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDevelopment)).BeginInit();
            this.tCtrlApplications.SuspendLayout();
            this.tPageBureautique.SuspendLayout();
            this.GbxOffice.SuspendLayout();
            this.tPageGames.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tPageDevelopment.SuspendLayout();
            this.GbxDevelopment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxOffice)).BeginInit();
            this.tabPOptions.SuspendLayout();
            this.GbxSettings.SuspendLayout();
            this.tabPAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxAttributeEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).BeginInit();
            this.tabPData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).BeginInit();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFrench)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.CmsNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAnalyser
            // 
            this.BtnAnalyser.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAnalyser.FlatAppearance.BorderSize = 0;
            this.BtnAnalyser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyser.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnAnalyser.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnalyser.Location = new System.Drawing.Point(6, 515);
            this.BtnAnalyser.Name = "BtnAnalyser";
            this.BtnAnalyser.Size = new System.Drawing.Size(111, 36);
            this.BtnAnalyser.TabIndex = 0;
            this.BtnAnalyser.Text = "Analyze";
            this.BtnAnalyser.UseVisualStyleBackColor = false;
            this.BtnAnalyser.Click += new System.EventHandler(this.BtnAnalyser_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnClean.Enabled = false;
            this.BtnClean.FlatAppearance.BorderSize = 0;
            this.BtnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClean.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnClean.ForeColor = System.Drawing.Color.White;
            this.BtnClean.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnClean.Location = new System.Drawing.Point(645, 515);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(130, 36);
            this.BtnClean.TabIndex = 3;
            this.BtnClean.Text = "Run Cleaner";
            this.BtnClean.UseVisualStyleBackColor = false;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // myTabCtrllMain
            // 
            this.myTabCtrllMain.Controls.Add(this.tPDashboard);
            this.myTabCtrllMain.Controls.Add(this.tabPSystem);
            this.myTabCtrllMain.Controls.Add(this.tabPWinExplorer);
            this.myTabCtrllMain.Controls.Add(this.tabPWebBrowser);
            this.myTabCtrllMain.Controls.Add(this.tabPAdvanced);
            this.myTabCtrllMain.Controls.Add(this.tabPApplications);
            this.myTabCtrllMain.Controls.Add(this.tabPOptions);
            this.myTabCtrllMain.Controls.Add(this.tabPAbout);
            this.myTabCtrllMain.Controls.Add(this.tabPData);
            this.myTabCtrllMain.ItemSize = new System.Drawing.Size(0, 1);
            this.myTabCtrllMain.Location = new System.Drawing.Point(157, 64);
            this.myTabCtrllMain.Name = "myTabCtrllMain";
            this.myTabCtrllMain.SelectedIndex = 0;
            this.myTabCtrllMain.Size = new System.Drawing.Size(795, 585);
            this.myTabCtrllMain.TabIndex = 4;
            this.myTabCtrllMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tPDashboard
            // 
            this.tPDashboard.Controls.Add(this.pnlRam);
            this.tPDashboard.Controls.Add(this.LblPercPgb);
            this.tPDashboard.Controls.Add(this.BtnCleanRecycleBin);
            this.tPDashboard.Controls.Add(this.pBoxProgress);
            this.tPDashboard.Controls.Add(this.tableLayoutPanel1);
            this.tPDashboard.Controls.Add(this.PgbAnalyze);
            this.tPDashboard.Controls.Add(this.GbxAnalyze);
            this.tPDashboard.Controls.Add(this.BtnClean);
            this.tPDashboard.Controls.Add(this.BtnAnalyser);
            this.tPDashboard.Controls.Add(this.GuiStockage);
            this.tPDashboard.Controls.Add(this.LblSizeToBeRemoved);
            this.tPDashboard.Controls.Add(this.LblAnalysisProgress);
            this.tPDashboard.Controls.Add(this.GbxDetailsFiles);
            this.tPDashboard.Controls.Add(this.CpgbDisk);
            this.tPDashboard.Location = new System.Drawing.Point(4, 5);
            this.tPDashboard.Name = "tPDashboard";
            this.tPDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tPDashboard.Size = new System.Drawing.Size(787, 576);
            this.tPDashboard.TabIndex = 0;
            this.tPDashboard.Text = "Dashboard";
            this.tPDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlRam
            // 
            this.pnlRam.Controls.Add(this.LblTotalRAM);
            this.pnlRam.Controls.Add(this.LblUsedRam);
            this.pnlRam.Controls.Add(this.GuiRAM);
            this.pnlRam.Controls.Add(this.CpgbRam);
            this.pnlRam.Location = new System.Drawing.Point(556, 227);
            this.pnlRam.Name = "pnlRam";
            this.pnlRam.Size = new System.Drawing.Size(186, 150);
            this.pnlRam.TabIndex = 29;
            // 
            // LblTotalRAM
            // 
            this.LblTotalRAM.AutoSize = true;
            this.LblTotalRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblTotalRAM.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.LblTotalRAM.ForeColor = System.Drawing.Color.Gray;
            this.LblTotalRAM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblTotalRAM.Location = new System.Drawing.Point(95, 87);
            this.LblTotalRAM.Name = "LblTotalRAM";
            this.LblTotalRAM.Size = new System.Drawing.Size(42, 16);
            this.LblTotalRAM.TabIndex = 16;
            this.LblTotalRAM.Text = "Total";
            // 
            // LblUsedRam
            // 
            this.LblUsedRam.AutoSize = true;
            this.LblUsedRam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblUsedRam.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.LblUsedRam.ForeColor = System.Drawing.Color.Gray;
            this.LblUsedRam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblUsedRam.Location = new System.Drawing.Point(38, 87);
            this.LblUsedRam.Name = "LblUsedRam";
            this.LblUsedRam.Size = new System.Drawing.Size(37, 16);
            this.LblUsedRam.TabIndex = 17;
            this.LblUsedRam.Text = "Free";
            // 
            // GuiRAM
            // 
            this.GuiRAM.AutoSize = true;
            this.GuiRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GuiRAM.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.GuiRAM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiRAM.Location = new System.Drawing.Point(70, 110);
            this.GuiRAM.Name = "GuiRAM";
            this.GuiRAM.Size = new System.Drawing.Size(36, 16);
            this.GuiRAM.TabIndex = 18;
            this.GuiRAM.Text = "RAM";
            // 
            // CpgbRam
            // 
            this.CpgbRam.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CpgbRam.AnimationSpeed = 500;
            this.CpgbRam.BackColor = System.Drawing.Color.Transparent;
            this.CpgbRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.CpgbRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CpgbRam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CpgbRam.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CpgbRam.InnerMargin = 2;
            this.CpgbRam.InnerWidth = -1;
            this.CpgbRam.Location = new System.Drawing.Point(13, 3);
            this.CpgbRam.MarqueeAnimationSpeed = 2000;
            this.CpgbRam.Name = "CpgbRam";
            this.CpgbRam.OuterColor = System.Drawing.Color.Gray;
            this.CpgbRam.OuterMargin = -25;
            this.CpgbRam.OuterWidth = 26;
            this.CpgbRam.ProgressColor = System.Drawing.Color.Green;
            this.CpgbRam.ProgressWidth = 5;
            this.CpgbRam.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CpgbRam.Size = new System.Drawing.Size(153, 144);
            this.CpgbRam.StartAngle = 270;
            this.CpgbRam.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CpgbRam.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CpgbRam.SubscriptText = "";
            this.CpgbRam.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CpgbRam.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CpgbRam.SuperscriptText = "";
            this.CpgbRam.TabIndex = 14;
            this.CpgbRam.Text = "55 %";
            this.CpgbRam.TextMargin = new System.Windows.Forms.Padding(1, -8, 1, 1);
            this.CpgbRam.Value = 55;
            // 
            // LblPercPgb
            // 
            this.LblPercPgb.AutoSize = true;
            this.LblPercPgb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPercPgb.Location = new System.Drawing.Point(742, 0);
            this.LblPercPgb.Name = "LblPercPgb";
            this.LblPercPgb.Size = new System.Drawing.Size(27, 15);
            this.LblPercPgb.TabIndex = 28;
            this.LblPercPgb.Text = "0%";
            this.LblPercPgb.Visible = false;
            // 
            // BtnCleanRecycleBin
            // 
            this.BtnCleanRecycleBin.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnCleanRecycleBin.FlatAppearance.BorderSize = 0;
            this.BtnCleanRecycleBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCleanRecycleBin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnCleanRecycleBin.ForeColor = System.Drawing.Color.White;
            this.BtnCleanRecycleBin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCleanRecycleBin.Location = new System.Drawing.Point(645, 467);
            this.BtnCleanRecycleBin.Name = "BtnCleanRecycleBin";
            this.BtnCleanRecycleBin.Size = new System.Drawing.Size(130, 36);
            this.BtnCleanRecycleBin.TabIndex = 19;
            this.BtnCleanRecycleBin.Text = "Clean Recycle bin";
            this.BtnCleanRecycleBin.UseVisualStyleBackColor = false;
            this.BtnCleanRecycleBin.Click += new System.EventHandler(this.BtnCleanRecycleBin_Click);
            // 
            // pBoxProgress
            // 
            this.pBoxProgress.Image = ((System.Drawing.Image)(resources.GetObject("pBoxProgress.Image")));
            this.pBoxProgress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pBoxProgress.Location = new System.Drawing.Point(759, 32);
            this.pBoxProgress.Name = "pBoxProgress";
            this.pBoxProgress.Size = new System.Drawing.Size(16, 16);
            this.pBoxProgress.TabIndex = 27;
            this.pBoxProgress.TabStop = false;
            this.pBoxProgress.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.23529F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel1.Controls.Add(this.LblSlash, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblFreeSpace, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblTotalSize, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(504, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(136, 19);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // LblSlash
            // 
            this.LblSlash.AutoSize = true;
            this.LblSlash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LblSlash.ForeColor = System.Drawing.Color.Gray;
            this.LblSlash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblSlash.Location = new System.Drawing.Point(57, 0);
            this.LblSlash.Name = "LblSlash";
            this.LblSlash.Size = new System.Drawing.Size(11, 16);
            this.LblSlash.TabIndex = 11;
            this.LblSlash.Text = "/";
            // 
            // LblFreeSpace
            // 
            this.LblFreeSpace.AutoSize = true;
            this.LblFreeSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblFreeSpace.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.LblFreeSpace.ForeColor = System.Drawing.Color.Gray;
            this.LblFreeSpace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFreeSpace.Location = new System.Drawing.Point(3, 0);
            this.LblFreeSpace.Name = "LblFreeSpace";
            this.LblFreeSpace.Size = new System.Drawing.Size(37, 16);
            this.LblFreeSpace.TabIndex = 10;
            this.LblFreeSpace.Text = "Free";
            this.LblFreeSpace.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblTotalSize
            // 
            this.LblTotalSize.AutoSize = true;
            this.LblTotalSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblTotalSize.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.LblTotalSize.ForeColor = System.Drawing.Color.Gray;
            this.LblTotalSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblTotalSize.Location = new System.Drawing.Point(74, 0);
            this.LblTotalSize.Name = "LblTotalSize";
            this.LblTotalSize.Size = new System.Drawing.Size(42, 16);
            this.LblTotalSize.TabIndex = 9;
            this.LblTotalSize.Text = "Total";
            // 
            // PgbAnalyze
            // 
            this.PgbAnalyze.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PgbAnalyze.Location = new System.Drawing.Point(2, 3);
            this.PgbAnalyze.Name = "PgbAnalyze";
            this.PgbAnalyze.Size = new System.Drawing.Size(740, 10);
            this.PgbAnalyze.TabIndex = 24;
            this.PgbAnalyze.Visible = false;
            // 
            // GbxAnalyze
            // 
            this.GbxAnalyze.Controls.Add(this.ChkApplications);
            this.GbxAnalyze.Controls.Add(this.ChkOpera);
            this.GbxAnalyze.Controls.Add(this.ChkEdge);
            this.GbxAnalyze.Controls.Add(this.ChkFirefox);
            this.GbxAnalyze.Controls.Add(this.ChkSystem);
            this.GbxAnalyze.Controls.Add(this.ChkWinExplorer);
            this.GbxAnalyze.Controls.Add(this.ChkChrome);
            this.GbxAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.GbxAnalyze.Location = new System.Drawing.Point(6, 398);
            this.GbxAnalyze.Name = "GbxAnalyze";
            this.GbxAnalyze.Size = new System.Drawing.Size(419, 110);
            this.GbxAnalyze.TabIndex = 23;
            this.GbxAnalyze.TabStop = false;
            this.GbxAnalyze.Text = "Analyze";
            // 
            // ChkApplications
            // 
            this.ChkApplications.AutoSize = true;
            this.ChkApplications.Checked = true;
            this.ChkApplications.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkApplications.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.ChkApplications.Location = new System.Drawing.Point(171, 47);
            this.ChkApplications.Name = "ChkApplications";
            this.ChkApplications.Size = new System.Drawing.Size(102, 20);
            this.ChkApplications.TabIndex = 26;
            this.ChkApplications.Text = "Applications";
            this.ChkApplications.UseVisualStyleBackColor = true;
            this.ChkApplications.CheckedChanged += new System.EventHandler(this.ChkDashboardAnalyze_CheckedChanged);
            // 
            // ChkOpera
            // 
            this.ChkOpera.AutoSize = true;
            this.ChkOpera.Checked = true;
            this.ChkOpera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkOpera.ContextMenuStrip = this.CmsAnalyze;
            this.ChkOpera.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkOpera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkOpera.Location = new System.Drawing.Point(298, 73);
            this.ChkOpera.Name = "ChkOpera";
            this.ChkOpera.Size = new System.Drawing.Size(66, 20);
            this.ChkOpera.TabIndex = 25;
            this.ChkOpera.Text = "Opera";
            this.ChkOpera.UseVisualStyleBackColor = true;
            this.ChkOpera.CheckedChanged += new System.EventHandler(this.ChkDashboardAnalyze_CheckedChanged);
            // 
            // CmsAnalyze
            // 
            this.CmsAnalyze.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaylzeToolStripMenuItem});
            this.CmsAnalyze.Name = "Cms";
            this.CmsAnalyze.Size = new System.Drawing.Size(116, 26);
            this.CmsAnalyze.Opening += new System.ComponentModel.CancelEventHandler(this.Cms_Opening);
            // 
            // anaylzeToolStripMenuItem
            // 
            this.anaylzeToolStripMenuItem.Name = "anaylzeToolStripMenuItem";
            this.anaylzeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.anaylzeToolStripMenuItem.Text = "Analyze";
            this.anaylzeToolStripMenuItem.Click += new System.EventHandler(this.anaylzeToolStripMenuItem_Click);
            // 
            // ChkEdge
            // 
            this.ChkEdge.AutoSize = true;
            this.ChkEdge.Checked = true;
            this.ChkEdge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkEdge.ContextMenuStrip = this.CmsAnalyze;
            this.ChkEdge.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkEdge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkEdge.Location = new System.Drawing.Point(171, 20);
            this.ChkEdge.Name = "ChkEdge";
            this.ChkEdge.Size = new System.Drawing.Size(119, 20);
            this.ChkEdge.TabIndex = 24;
            this.ChkEdge.Text = "Microsoft Edge";
            this.ChkEdge.UseVisualStyleBackColor = true;
            this.ChkEdge.CheckedChanged += new System.EventHandler(this.ChkDashboardAnalyze_CheckedChanged);
            // 
            // ChkFirefox
            // 
            this.ChkFirefox.AutoSize = true;
            this.ChkFirefox.Checked = true;
            this.ChkFirefox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFirefox.ContextMenuStrip = this.CmsAnalyze;
            this.ChkFirefox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkFirefox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkFirefox.Location = new System.Drawing.Point(298, 47);
            this.ChkFirefox.Name = "ChkFirefox";
            this.ChkFirefox.Size = new System.Drawing.Size(115, 20);
            this.ChkFirefox.TabIndex = 23;
            this.ChkFirefox.Text = "Mozilla Firefox";
            this.ChkFirefox.UseVisualStyleBackColor = true;
            this.ChkFirefox.CheckedChanged += new System.EventHandler(this.ChkDashboardAnalyze_CheckedChanged);
            // 
            // ChkSystem
            // 
            this.ChkSystem.AutoSize = true;
            this.ChkSystem.Checked = true;
            this.ChkSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSystem.ContextMenuStrip = this.CmsAnalyze;
            this.ChkSystem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSystem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkSystem.Location = new System.Drawing.Point(5, 22);
            this.ChkSystem.Name = "ChkSystem";
            this.ChkSystem.Size = new System.Drawing.Size(73, 20);
            this.ChkSystem.TabIndex = 20;
            this.ChkSystem.Text = "System";
            this.ChkSystem.UseVisualStyleBackColor = true;
            this.ChkSystem.CheckedChanged += new System.EventHandler(this.ChkDashboardAnalyze_CheckedChanged);
            // 
            // ChkWinExplorer
            // 
            this.ChkWinExplorer.AutoSize = true;
            this.ChkWinExplorer.Checked = true;
            this.ChkWinExplorer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkWinExplorer.ContextMenuStrip = this.CmsAnalyze;
            this.ChkWinExplorer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkWinExplorer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkWinExplorer.Location = new System.Drawing.Point(5, 47);
            this.ChkWinExplorer.Name = "ChkWinExplorer";
            this.ChkWinExplorer.Size = new System.Drawing.Size(141, 20);
            this.ChkWinExplorer.TabIndex = 22;
            this.ChkWinExplorer.Text = "Windows Explorer";
            this.ChkWinExplorer.UseVisualStyleBackColor = true;
            this.ChkWinExplorer.CheckedChanged += new System.EventHandler(this.ChkDashboardAnalyze_CheckedChanged);
            // 
            // ChkChrome
            // 
            this.ChkChrome.AutoSize = true;
            this.ChkChrome.Checked = true;
            this.ChkChrome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChrome.ContextMenuStrip = this.CmsAnalyze;
            this.ChkChrome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkChrome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkChrome.Location = new System.Drawing.Point(298, 21);
            this.ChkChrome.Name = "ChkChrome";
            this.ChkChrome.Size = new System.Drawing.Size(124, 20);
            this.ChkChrome.TabIndex = 21;
            this.ChkChrome.Text = "Google Chrome";
            this.ChkChrome.UseVisualStyleBackColor = true;
            this.ChkChrome.CheckedChanged += new System.EventHandler(this.ChkDashboardAnalyze_CheckedChanged);
            // 
            // GuiStockage
            // 
            this.GuiStockage.AutoSize = true;
            this.GuiStockage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GuiStockage.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.GuiStockage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiStockage.Location = new System.Drawing.Point(536, 142);
            this.GuiStockage.Name = "GuiStockage";
            this.GuiStockage.Size = new System.Drawing.Size(70, 16);
            this.GuiStockage.TabIndex = 13;
            this.GuiStockage.Text = "STORAGE";
            // 
            // LblSizeToBeRemoved
            // 
            this.LblSizeToBeRemoved.AutoSize = true;
            this.LblSizeToBeRemoved.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSizeToBeRemoved.ForeColor = System.Drawing.Color.Red;
            this.LblSizeToBeRemoved.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblSizeToBeRemoved.Location = new System.Drawing.Point(9, 56);
            this.LblSizeToBeRemoved.Name = "LblSizeToBeRemoved";
            this.LblSizeToBeRemoved.Size = new System.Drawing.Size(139, 16);
            this.LblSizeToBeRemoved.TabIndex = 6;
            this.LblSizeToBeRemoved.Text = "Size To Be Removed.";
            this.LblSizeToBeRemoved.Visible = false;
            // 
            // LblAnalysisProgress
            // 
            this.LblAnalysisProgress.AutoSize = true;
            this.LblAnalysisProgress.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnalysisProgress.Image = ((System.Drawing.Image)(resources.GetObject("LblAnalysisProgress.Image")));
            this.LblAnalysisProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblAnalysisProgress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblAnalysisProgress.Location = new System.Drawing.Point(9, 36);
            this.LblAnalysisProgress.Name = "LblAnalysisProgress";
            this.LblAnalysisProgress.Size = new System.Drawing.Size(177, 16);
            this.LblAnalysisProgress.TabIndex = 5;
            this.LblAnalysisProgress.Text = "    Analysis Completed";
            this.LblAnalysisProgress.Visible = false;
            // 
            // GbxDetailsFiles
            // 
            this.GbxDetailsFiles.Controls.Add(this.DtgAnalyze);
            this.GbxDetailsFiles.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.GbxDetailsFiles.Location = new System.Drawing.Point(6, 74);
            this.GbxDetailsFiles.Name = "GbxDetailsFiles";
            this.GbxDetailsFiles.Size = new System.Drawing.Size(419, 311);
            this.GbxDetailsFiles.TabIndex = 1;
            this.GbxDetailsFiles.TabStop = false;
            this.GbxDetailsFiles.Text = "Details of files to be deleted";
            this.GbxDetailsFiles.Visible = false;
            // 
            // DtgAnalyze
            // 
            this.DtgAnalyze.AllowUserToAddRows = false;
            this.DtgAnalyze.AllowUserToDeleteRows = false;
            this.DtgAnalyze.AllowUserToResizeColumns = false;
            this.DtgAnalyze.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DtgAnalyze.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DtgAnalyze.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgAnalyze.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgAnalyze.BackgroundColor = System.Drawing.Color.White;
            this.DtgAnalyze.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgAnalyze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAnalyze.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.Files});
            this.DtgAnalyze.EnableHeadersVisualStyles = false;
            this.DtgAnalyze.Location = new System.Drawing.Point(6, 20);
            this.DtgAnalyze.MultiSelect = false;
            this.DtgAnalyze.Name = "DtgAnalyze";
            this.DtgAnalyze.ReadOnly = true;
            this.DtgAnalyze.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtgAnalyze.ShowEditingIcon = false;
            this.DtgAnalyze.Size = new System.Drawing.Size(407, 279);
            this.DtgAnalyze.TabIndex = 3;
            this.DtgAnalyze.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DtgAnalyze_MouseClick);
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.FillWeight = 60F;
            this.dataGridViewTextBoxColumn15.HeaderText = "Description";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.FillWeight = 20F;
            this.dataGridViewTextBoxColumn16.HeaderText = "Size (KB)";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Files
            // 
            this.Files.FillWeight = 20F;
            this.Files.HeaderText = "Files";
            this.Files.Name = "Files";
            this.Files.ReadOnly = true;
            this.Files.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Files.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CpgbDisk
            // 
            this.CpgbDisk.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CpgbDisk.AnimationSpeed = 500;
            this.CpgbDisk.BackColor = System.Drawing.Color.Transparent;
            this.CpgbDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.CpgbDisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CpgbDisk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CpgbDisk.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CpgbDisk.InnerMargin = 2;
            this.CpgbDisk.InnerWidth = -1;
            this.CpgbDisk.Location = new System.Drawing.Point(482, 35);
            this.CpgbDisk.MarqueeAnimationSpeed = 2000;
            this.CpgbDisk.Name = "CpgbDisk";
            this.CpgbDisk.OuterColor = System.Drawing.Color.Gray;
            this.CpgbDisk.OuterMargin = -25;
            this.CpgbDisk.OuterWidth = 26;
            this.CpgbDisk.ProgressColor = System.Drawing.Color.Green;
            this.CpgbDisk.ProgressWidth = 5;
            this.CpgbDisk.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CpgbDisk.Size = new System.Drawing.Size(173, 162);
            this.CpgbDisk.StartAngle = 270;
            this.CpgbDisk.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CpgbDisk.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CpgbDisk.SubscriptText = "";
            this.CpgbDisk.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CpgbDisk.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CpgbDisk.SuperscriptText = "";
            this.CpgbDisk.TabIndex = 12;
            this.CpgbDisk.Text = "55 %";
            this.CpgbDisk.TextMargin = new System.Windows.Forms.Padding(1, -8, 1, 1);
            this.CpgbDisk.Value = 55;
            // 
            // tabPSystem
            // 
            this.tabPSystem.Controls.Add(this.BtnAnalyzeEdge);
            this.tabPSystem.Controls.Add(this.groupBox3);
            this.tabPSystem.Controls.Add(this.GuiEdge);
            this.tabPSystem.Controls.Add(this.GbxSystemInformation);
            this.tabPSystem.Controls.Add(this.GbxAnalyzeSystem);
            this.tabPSystem.Controls.Add(this.BtnAnalyseSystem);
            this.tabPSystem.Controls.Add(this.GuiSystem);
            this.tabPSystem.Controls.Add(this.PboxEdge);
            this.tabPSystem.Controls.Add(this.pictureBox2);
            this.tabPSystem.Location = new System.Drawing.Point(4, 5);
            this.tabPSystem.Name = "tabPSystem";
            this.tabPSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPSystem.Size = new System.Drawing.Size(787, 576);
            this.tabPSystem.TabIndex = 6;
            this.tabPSystem.Text = "System";
            this.tabPSystem.UseVisualStyleBackColor = true;
            // 
            // BtnAnalyzeEdge
            // 
            this.BtnAnalyzeEdge.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAnalyzeEdge.FlatAppearance.BorderSize = 0;
            this.BtnAnalyzeEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyzeEdge.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnAnalyzeEdge.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyzeEdge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnalyzeEdge.Location = new System.Drawing.Point(37, 491);
            this.BtnAnalyzeEdge.Name = "BtnAnalyzeEdge";
            this.BtnAnalyzeEdge.Size = new System.Drawing.Size(170, 36);
            this.BtnAnalyzeEdge.TabIndex = 14;
            this.BtnAnalyzeEdge.Text = "Analyze Microsoft Edge";
            this.BtnAnalyzeEdge.UseVisualStyleBackColor = false;
            this.BtnAnalyzeEdge.Click += new System.EventHandler(this.BtnAnalyzeEdge_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChkEdgeSession);
            this.groupBox3.Controls.Add(this.ChkEdgeDLHist);
            this.groupBox3.Controls.Add(this.ChkEdgeWebHist);
            this.groupBox3.Controls.Add(this.ChkEdgeWebCache);
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(15, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 129);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Analyze";
            // 
            // ChkEdgeSession
            // 
            this.ChkEdgeSession.AutoSize = true;
            this.ChkEdgeSession.Checked = true;
            this.ChkEdgeSession.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkEdgeSession.ContextMenuStrip = this.CmsAnalyze;
            this.ChkEdgeSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkEdgeSession.Location = new System.Drawing.Point(6, 100);
            this.ChkEdgeSession.Name = "ChkEdgeSession";
            this.ChkEdgeSession.Size = new System.Drawing.Size(76, 20);
            this.ChkEdgeSession.TabIndex = 3;
            this.ChkEdgeSession.Text = "Session";
            this.ChkEdgeSession.UseVisualStyleBackColor = true;
            this.ChkEdgeSession.CheckedChanged += new System.EventHandler(this.ChkEdgeAnalyze_CheckedChanged);
            // 
            // ChkEdgeDLHist
            // 
            this.ChkEdgeDLHist.AutoSize = true;
            this.ChkEdgeDLHist.Checked = true;
            this.ChkEdgeDLHist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkEdgeDLHist.ContextMenuStrip = this.CmsAnalyze;
            this.ChkEdgeDLHist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkEdgeDLHist.Location = new System.Drawing.Point(6, 75);
            this.ChkEdgeDLHist.Name = "ChkEdgeDLHist";
            this.ChkEdgeDLHist.Size = new System.Drawing.Size(138, 20);
            this.ChkEdgeDLHist.TabIndex = 2;
            this.ChkEdgeDLHist.Text = "Download History";
            this.ChkEdgeDLHist.UseVisualStyleBackColor = true;
            this.ChkEdgeDLHist.CheckedChanged += new System.EventHandler(this.ChkEdgeAnalyze_CheckedChanged);
            // 
            // ChkEdgeWebHist
            // 
            this.ChkEdgeWebHist.AutoSize = true;
            this.ChkEdgeWebHist.Checked = true;
            this.ChkEdgeWebHist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkEdgeWebHist.ContextMenuStrip = this.CmsAnalyze;
            this.ChkEdgeWebHist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkEdgeWebHist.Location = new System.Drawing.Point(6, 50);
            this.ChkEdgeWebHist.Name = "ChkEdgeWebHist";
            this.ChkEdgeWebHist.Size = new System.Drawing.Size(127, 20);
            this.ChkEdgeWebHist.TabIndex = 1;
            this.ChkEdgeWebHist.Text = "Internet History";
            this.ChkEdgeWebHist.UseVisualStyleBackColor = true;
            this.ChkEdgeWebHist.CheckedChanged += new System.EventHandler(this.ChkEdgeAnalyze_CheckedChanged);
            // 
            // ChkEdgeWebCache
            // 
            this.ChkEdgeWebCache.AutoSize = true;
            this.ChkEdgeWebCache.Checked = true;
            this.ChkEdgeWebCache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkEdgeWebCache.ContextMenuStrip = this.CmsAnalyze;
            this.ChkEdgeWebCache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkEdgeWebCache.Location = new System.Drawing.Point(6, 25);
            this.ChkEdgeWebCache.Name = "ChkEdgeWebCache";
            this.ChkEdgeWebCache.Size = new System.Drawing.Size(122, 20);
            this.ChkEdgeWebCache.TabIndex = 0;
            this.ChkEdgeWebCache.Text = "Internet Cache";
            this.ChkEdgeWebCache.UseVisualStyleBackColor = true;
            this.ChkEdgeWebCache.CheckedChanged += new System.EventHandler(this.ChkEdgeAnalyze_CheckedChanged);
            // 
            // GuiEdge
            // 
            this.GuiEdge.AutoSize = true;
            this.GuiEdge.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiEdge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiEdge.Location = new System.Drawing.Point(86, 309);
            this.GuiEdge.Name = "GuiEdge";
            this.GuiEdge.Size = new System.Drawing.Size(120, 16);
            this.GuiEdge.TabIndex = 11;
            this.GuiEdge.Text = "Microsoft Edge";
            // 
            // GbxSystemInformation
            // 
            this.GbxSystemInformation.Controls.Add(this.BtnViewMore);
            this.GbxSystemInformation.Controls.Add(this.tlpSystemInfo);
            this.GbxSystemInformation.Location = new System.Drawing.Point(287, 6);
            this.GbxSystemInformation.Name = "GbxSystemInformation";
            this.GbxSystemInformation.Size = new System.Drawing.Size(488, 376);
            this.GbxSystemInformation.TabIndex = 6;
            this.GbxSystemInformation.TabStop = false;
            this.GbxSystemInformation.Text = "System Information";
            // 
            // BtnViewMore
            // 
            this.BtnViewMore.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnViewMore.FlatAppearance.BorderSize = 0;
            this.BtnViewMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewMore.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnViewMore.ForeColor = System.Drawing.Color.White;
            this.BtnViewMore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnViewMore.Location = new System.Drawing.Point(316, 334);
            this.BtnViewMore.Name = "BtnViewMore";
            this.BtnViewMore.Size = new System.Drawing.Size(163, 33);
            this.BtnViewMore.TabIndex = 7;
            this.BtnViewMore.Text = "View more...";
            this.BtnViewMore.UseVisualStyleBackColor = false;
            this.BtnViewMore.Click += new System.EventHandler(this.BtnViewMore_Click);
            // 
            // tlpSystemInfo
            // 
            this.tlpSystemInfo.ColumnCount = 2;
            this.tlpSystemInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.35294F));
            this.tlpSystemInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.64706F));
            this.tlpSystemInfo.Controls.Add(this.TbxAudioDevice, 1, 10);
            this.tlpSystemInfo.Controls.Add(this.GUISystemName, 0, 0);
            this.tlpSystemInfo.Controls.Add(this.GUIAudioDevice, 0, 10);
            this.tlpSystemInfo.Controls.Add(this.TbxDesktopName, 1, 0);
            this.tlpSystemInfo.Controls.Add(this.GUIManufacturer, 0, 1);
            this.tlpSystemInfo.Controls.Add(this.TbxManufacturer, 1, 1);
            this.tlpSystemInfo.Controls.Add(this.GUIProcessor, 0, 2);
            this.tlpSystemInfo.Controls.Add(this.TbxProcesseur, 1, 2);
            this.tlpSystemInfo.Controls.Add(this.GUIVideoController, 0, 3);
            this.tlpSystemInfo.Controls.Add(this.TbxVideoController, 1, 3);
            this.tlpSystemInfo.Controls.Add(this.GuiMemory, 0, 4);
            this.tlpSystemInfo.Controls.Add(this.TbxRAM, 1, 4);
            this.tlpSystemInfo.Controls.Add(this.GUIHDD, 0, 5);
            this.tlpSystemInfo.Controls.Add(this.TbxHDD, 1, 5);
            this.tlpSystemInfo.Controls.Add(this.GUIOSVersion, 0, 6);
            this.tlpSystemInfo.Controls.Add(this.TbxOSVersion, 1, 6);
            this.tlpSystemInfo.Controls.Add(this.GUIOSType, 0, 7);
            this.tlpSystemInfo.Controls.Add(this.TbxOSType, 1, 7);
            this.tlpSystemInfo.Controls.Add(this.GUIBIOS, 0, 9);
            this.tlpSystemInfo.Controls.Add(this.GUIModel, 0, 8);
            this.tlpSystemInfo.Controls.Add(this.TbxBIOS, 1, 9);
            this.tlpSystemInfo.Controls.Add(this.TbxModel, 1, 8);
            this.tlpSystemInfo.Location = new System.Drawing.Point(6, 24);
            this.tlpSystemInfo.Name = "tlpSystemInfo";
            this.tlpSystemInfo.RowCount = 11;
            this.tlpSystemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01001F));
            this.tlpSystemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01001F));
            this.tlpSystemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01001F));
            this.tlpSystemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01001F));
            this.tlpSystemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01001F));
            this.tlpSystemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01001F));
            this.tlpSystemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01001F));
            this.tlpSystemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01001F));
            this.tlpSystemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01001F));
            this.tlpSystemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.909912F));
            this.tlpSystemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSystemInfo.Size = new System.Drawing.Size(476, 307);
            this.tlpSystemInfo.TabIndex = 3;
            // 
            // TbxAudioDevice
            // 
            this.TbxAudioDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxAudioDevice.Location = new System.Drawing.Point(156, 283);
            this.TbxAudioDevice.Name = "TbxAudioDevice";
            this.TbxAudioDevice.ReadOnly = true;
            this.TbxAudioDevice.Size = new System.Drawing.Size(317, 21);
            this.TbxAudioDevice.TabIndex = 13;
            // 
            // GUISystemName
            // 
            this.GUISystemName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GUISystemName.AutoSize = true;
            this.GUISystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold);
            this.GUISystemName.ForeColor = System.Drawing.Color.OrangeRed;
            this.GUISystemName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GUISystemName.Location = new System.Drawing.Point(47, 6);
            this.GUISystemName.Name = "GUISystemName";
            this.GUISystemName.Size = new System.Drawing.Size(103, 15);
            this.GUISystemName.TabIndex = 1;
            this.GUISystemName.Text = "System Name :";
            // 
            // GUIAudioDevice
            // 
            this.GUIAudioDevice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GUIAudioDevice.AutoSize = true;
            this.GUIAudioDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold);
            this.GUIAudioDevice.ForeColor = System.Drawing.Color.OrangeRed;
            this.GUIAudioDevice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GUIAudioDevice.Location = new System.Drawing.Point(52, 286);
            this.GUIAudioDevice.Name = "GUIAudioDevice";
            this.GUIAudioDevice.Size = new System.Drawing.Size(98, 15);
            this.GUIAudioDevice.TabIndex = 6;
            this.GUIAudioDevice.Text = "Audio Device :";
            // 
            // TbxDesktopName
            // 
            this.TbxDesktopName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxDesktopName.Location = new System.Drawing.Point(156, 3);
            this.TbxDesktopName.Name = "TbxDesktopName";
            this.TbxDesktopName.ReadOnly = true;
            this.TbxDesktopName.Size = new System.Drawing.Size(317, 21);
            this.TbxDesktopName.TabIndex = 4;
            // 
            // GUIManufacturer
            // 
            this.GUIManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GUIManufacturer.AutoSize = true;
            this.GUIManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold);
            this.GUIManufacturer.ForeColor = System.Drawing.Color.OrangeRed;
            this.GUIManufacturer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GUIManufacturer.Location = new System.Drawing.Point(50, 34);
            this.GUIManufacturer.Name = "GUIManufacturer";
            this.GUIManufacturer.Size = new System.Drawing.Size(100, 15);
            this.GUIManufacturer.TabIndex = 7;
            this.GUIManufacturer.Text = "Manufacturer :";
            // 
            // TbxManufacturer
            // 
            this.TbxManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxManufacturer.Location = new System.Drawing.Point(156, 31);
            this.TbxManufacturer.Name = "TbxManufacturer";
            this.TbxManufacturer.ReadOnly = true;
            this.TbxManufacturer.Size = new System.Drawing.Size(317, 21);
            this.TbxManufacturer.TabIndex = 12;
            // 
            // GUIProcessor
            // 
            this.GUIProcessor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GUIProcessor.AutoSize = true;
            this.GUIProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold);
            this.GUIProcessor.ForeColor = System.Drawing.Color.OrangeRed;
            this.GUIProcessor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GUIProcessor.Location = new System.Drawing.Point(71, 62);
            this.GUIProcessor.Name = "GUIProcessor";
            this.GUIProcessor.Size = new System.Drawing.Size(79, 15);
            this.GUIProcessor.TabIndex = 0;
            this.GUIProcessor.Text = "Processor :";
            // 
            // TbxProcesseur
            // 
            this.TbxProcesseur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxProcesseur.Location = new System.Drawing.Point(156, 59);
            this.TbxProcesseur.Name = "TbxProcesseur";
            this.TbxProcesseur.ReadOnly = true;
            this.TbxProcesseur.Size = new System.Drawing.Size(317, 21);
            this.TbxProcesseur.TabIndex = 5;
            // 
            // GUIVideoController
            // 
            this.GUIVideoController.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GUIVideoController.AutoSize = true;
            this.GUIVideoController.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold);
            this.GUIVideoController.ForeColor = System.Drawing.Color.OrangeRed;
            this.GUIVideoController.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GUIVideoController.Location = new System.Drawing.Point(32, 90);
            this.GUIVideoController.Name = "GUIVideoController";
            this.GUIVideoController.Size = new System.Drawing.Size(118, 15);
            this.GUIVideoController.TabIndex = 8;
            this.GUIVideoController.Text = "Video Controller :";
            // 
            // TbxVideoController
            // 
            this.TbxVideoController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxVideoController.Location = new System.Drawing.Point(156, 87);
            this.TbxVideoController.Name = "TbxVideoController";
            this.TbxVideoController.ReadOnly = true;
            this.TbxVideoController.Size = new System.Drawing.Size(317, 21);
            this.TbxVideoController.TabIndex = 6;
            // 
            // GuiMemory
            // 
            this.GuiMemory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GuiMemory.AutoSize = true;
            this.GuiMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold);
            this.GuiMemory.ForeColor = System.Drawing.Color.OrangeRed;
            this.GuiMemory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiMemory.Location = new System.Drawing.Point(36, 118);
            this.GuiMemory.Name = "GuiMemory";
            this.GuiMemory.Size = new System.Drawing.Size(114, 15);
            this.GuiMemory.TabIndex = 5;
            this.GuiMemory.Text = "Memory (RAM) : ";
            // 
            // TbxRAM
            // 
            this.TbxRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxRAM.Location = new System.Drawing.Point(156, 115);
            this.TbxRAM.Name = "TbxRAM";
            this.TbxRAM.ReadOnly = true;
            this.TbxRAM.Size = new System.Drawing.Size(317, 21);
            this.TbxRAM.TabIndex = 7;
            // 
            // GUIHDD
            // 
            this.GUIHDD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GUIHDD.AutoSize = true;
            this.GUIHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold);
            this.GUIHDD.ForeColor = System.Drawing.Color.OrangeRed;
            this.GUIHDD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GUIHDD.Location = new System.Drawing.Point(35, 146);
            this.GUIHDD.Name = "GUIHDD";
            this.GUIHDD.Size = new System.Drawing.Size(115, 15);
            this.GUIHDD.TabIndex = 2;
            this.GUIHDD.Text = "Hard Drive Disk :";
            // 
            // TbxHDD
            // 
            this.TbxHDD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxHDD.Location = new System.Drawing.Point(156, 143);
            this.TbxHDD.Name = "TbxHDD";
            this.TbxHDD.ReadOnly = true;
            this.TbxHDD.Size = new System.Drawing.Size(317, 21);
            this.TbxHDD.TabIndex = 8;
            // 
            // GUIOSVersion
            // 
            this.GUIOSVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GUIOSVersion.AutoSize = true;
            this.GUIOSVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold);
            this.GUIOSVersion.ForeColor = System.Drawing.Color.OrangeRed;
            this.GUIOSVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GUIOSVersion.Location = new System.Drawing.Point(26, 174);
            this.GUIOSVersion.Name = "GUIOSVersion";
            this.GUIOSVersion.Size = new System.Drawing.Size(124, 15);
            this.GUIOSVersion.TabIndex = 2;
            this.GUIOSVersion.Text = "Windows Version :";
            // 
            // TbxOSVersion
            // 
            this.TbxOSVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxOSVersion.Location = new System.Drawing.Point(156, 171);
            this.TbxOSVersion.Name = "TbxOSVersion";
            this.TbxOSVersion.ReadOnly = true;
            this.TbxOSVersion.Size = new System.Drawing.Size(317, 21);
            this.TbxOSVersion.TabIndex = 9;
            // 
            // GUIOSType
            // 
            this.GUIOSType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GUIOSType.AutoSize = true;
            this.GUIOSType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold);
            this.GUIOSType.ForeColor = System.Drawing.Color.OrangeRed;
            this.GUIOSType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GUIOSType.Location = new System.Drawing.Point(55, 202);
            this.GUIOSType.Name = "GUIOSType";
            this.GUIOSType.Size = new System.Drawing.Size(95, 15);
            this.GUIOSType.TabIndex = 19;
            this.GUIOSType.Text = "System Type :";
            // 
            // TbxOSType
            // 
            this.TbxOSType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxOSType.Location = new System.Drawing.Point(156, 199);
            this.TbxOSType.Name = "TbxOSType";
            this.TbxOSType.ReadOnly = true;
            this.TbxOSType.Size = new System.Drawing.Size(317, 21);
            this.TbxOSType.TabIndex = 14;
            // 
            // GUIBIOS
            // 
            this.GUIBIOS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GUIBIOS.AutoSize = true;
            this.GUIBIOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold);
            this.GUIBIOS.ForeColor = System.Drawing.Color.OrangeRed;
            this.GUIBIOS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GUIBIOS.Location = new System.Drawing.Point(51, 258);
            this.GUIBIOS.Name = "GUIBIOS";
            this.GUIBIOS.Size = new System.Drawing.Size(99, 15);
            this.GUIBIOS.TabIndex = 3;
            this.GUIBIOS.Text = "BIOS Version :";
            // 
            // GUIModel
            // 
            this.GUIModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GUIModel.AutoSize = true;
            this.GUIModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold);
            this.GUIModel.ForeColor = System.Drawing.Color.OrangeRed;
            this.GUIModel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GUIModel.Location = new System.Drawing.Point(95, 230);
            this.GUIModel.Name = "GUIModel";
            this.GUIModel.Size = new System.Drawing.Size(55, 15);
            this.GUIModel.TabIndex = 4;
            this.GUIModel.Text = "Model :";
            // 
            // TbxBIOS
            // 
            this.TbxBIOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxBIOS.Location = new System.Drawing.Point(156, 255);
            this.TbxBIOS.Name = "TbxBIOS";
            this.TbxBIOS.ReadOnly = true;
            this.TbxBIOS.Size = new System.Drawing.Size(317, 21);
            this.TbxBIOS.TabIndex = 11;
            // 
            // TbxModel
            // 
            this.TbxModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxModel.Location = new System.Drawing.Point(156, 227);
            this.TbxModel.Name = "TbxModel";
            this.TbxModel.ReadOnly = true;
            this.TbxModel.Size = new System.Drawing.Size(317, 21);
            this.TbxModel.TabIndex = 10;
            // 
            // GbxAnalyzeSystem
            // 
            this.GbxAnalyzeSystem.Controls.Add(this.ChkWinErrorReporting);
            this.GbxAnalyzeSystem.Controls.Add(this.ChkMemDumps);
            this.GbxAnalyzeSystem.Controls.Add(this.ChkClipboard);
            this.GbxAnalyzeSystem.Controls.Add(this.ChkTempFiles);
            this.GbxAnalyzeSystem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.GbxAnalyzeSystem.Location = new System.Drawing.Point(16, 76);
            this.GbxAnalyzeSystem.Name = "GbxAnalyzeSystem";
            this.GbxAnalyzeSystem.Size = new System.Drawing.Size(233, 132);
            this.GbxAnalyzeSystem.TabIndex = 5;
            this.GbxAnalyzeSystem.TabStop = false;
            this.GbxAnalyzeSystem.Text = "Analyze";
            // 
            // ChkWinErrorReporting
            // 
            this.ChkWinErrorReporting.AutoSize = true;
            this.ChkWinErrorReporting.Checked = true;
            this.ChkWinErrorReporting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkWinErrorReporting.ContextMenuStrip = this.CmsAnalyze;
            this.ChkWinErrorReporting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkWinErrorReporting.Location = new System.Drawing.Point(6, 99);
            this.ChkWinErrorReporting.Name = "ChkWinErrorReporting";
            this.ChkWinErrorReporting.Size = new System.Drawing.Size(185, 20);
            this.ChkWinErrorReporting.TabIndex = 5;
            this.ChkWinErrorReporting.Text = "Windows Error Reporting";
            this.ChkWinErrorReporting.UseVisualStyleBackColor = true;
            this.ChkWinErrorReporting.CheckedChanged += new System.EventHandler(this.ChkAnalyzeSystem_CheckedChanged);
            // 
            // ChkMemDumps
            // 
            this.ChkMemDumps.AutoSize = true;
            this.ChkMemDumps.Checked = true;
            this.ChkMemDumps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkMemDumps.ContextMenuStrip = this.CmsAnalyze;
            this.ChkMemDumps.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkMemDumps.Location = new System.Drawing.Point(6, 76);
            this.ChkMemDumps.Name = "ChkMemDumps";
            this.ChkMemDumps.Size = new System.Drawing.Size(123, 20);
            this.ChkMemDumps.TabIndex = 2;
            this.ChkMemDumps.Text = "Memory Dumps";
            this.ChkMemDumps.UseVisualStyleBackColor = true;
            this.ChkMemDumps.CheckedChanged += new System.EventHandler(this.ChkAnalyzeSystem_CheckedChanged);
            // 
            // ChkClipboard
            // 
            this.ChkClipboard.AutoSize = true;
            this.ChkClipboard.Checked = true;
            this.ChkClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkClipboard.ContextMenuStrip = this.CmsAnalyze;
            this.ChkClipboard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkClipboard.Location = new System.Drawing.Point(6, 51);
            this.ChkClipboard.Name = "ChkClipboard";
            this.ChkClipboard.Size = new System.Drawing.Size(87, 20);
            this.ChkClipboard.TabIndex = 1;
            this.ChkClipboard.Text = "Clipboard";
            this.ChkClipboard.UseVisualStyleBackColor = true;
            this.ChkClipboard.CheckedChanged += new System.EventHandler(this.ChkAnalyzeSystem_CheckedChanged);
            // 
            // ChkTempFiles
            // 
            this.ChkTempFiles.AutoSize = true;
            this.ChkTempFiles.Checked = true;
            this.ChkTempFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkTempFiles.ContextMenuStrip = this.CmsAnalyze;
            this.ChkTempFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkTempFiles.Location = new System.Drawing.Point(6, 26);
            this.ChkTempFiles.Name = "ChkTempFiles";
            this.ChkTempFiles.Size = new System.Drawing.Size(126, 20);
            this.ChkTempFiles.TabIndex = 0;
            this.ChkTempFiles.Text = "Temporary Files";
            this.ChkTempFiles.UseVisualStyleBackColor = true;
            this.ChkTempFiles.CheckedChanged += new System.EventHandler(this.ChkAnalyzeSystem_CheckedChanged);
            // 
            // BtnAnalyseSystem
            // 
            this.BtnAnalyseSystem.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAnalyseSystem.FlatAppearance.BorderSize = 0;
            this.BtnAnalyseSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyseSystem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnAnalyseSystem.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyseSystem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnalyseSystem.Location = new System.Drawing.Point(37, 222);
            this.BtnAnalyseSystem.Name = "BtnAnalyseSystem";
            this.BtnAnalyseSystem.Size = new System.Drawing.Size(170, 36);
            this.BtnAnalyseSystem.TabIndex = 4;
            this.BtnAnalyseSystem.Text = "Analyze System";
            this.BtnAnalyseSystem.UseVisualStyleBackColor = false;
            this.BtnAnalyseSystem.Click += new System.EventHandler(this.BtnAnalyseSystem_Click);
            // 
            // GuiSystem
            // 
            this.GuiSystem.AutoSize = true;
            this.GuiSystem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiSystem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiSystem.Location = new System.Drawing.Point(86, 31);
            this.GuiSystem.Name = "GuiSystem";
            this.GuiSystem.Size = new System.Drawing.Size(63, 16);
            this.GuiSystem.TabIndex = 3;
            this.GuiSystem.Text = "System";
            // 
            // PboxEdge
            // 
            this.PboxEdge.Image = global::Powered_Cleaner.Properties.Resources.icon_edge;
            this.PboxEdge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PboxEdge.Location = new System.Drawing.Point(16, 284);
            this.PboxEdge.Name = "PboxEdge";
            this.PboxEdge.Size = new System.Drawing.Size(64, 64);
            this.PboxEdge.TabIndex = 10;
            this.PboxEdge.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Powered_Cleaner.Properties.Resources.icon_system;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(16, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tabPWinExplorer
            // 
            this.tabPWinExplorer.Controls.Add(this.BtnAnalyzeWinExplorer);
            this.tabPWinExplorer.Controls.Add(this.GbxAnalyzeWinExplorer);
            this.tabPWinExplorer.Controls.Add(this.GuiWinExplorer);
            this.tabPWinExplorer.Controls.Add(this.PBoxWinExplorer);
            this.tabPWinExplorer.Location = new System.Drawing.Point(4, 5);
            this.tabPWinExplorer.Name = "tabPWinExplorer";
            this.tabPWinExplorer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPWinExplorer.Size = new System.Drawing.Size(787, 576);
            this.tabPWinExplorer.TabIndex = 7;
            this.tabPWinExplorer.Text = "Windows Explorer";
            this.tabPWinExplorer.UseVisualStyleBackColor = true;
            // 
            // BtnAnalyzeWinExplorer
            // 
            this.BtnAnalyzeWinExplorer.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAnalyzeWinExplorer.FlatAppearance.BorderSize = 0;
            this.BtnAnalyzeWinExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyzeWinExplorer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnAnalyzeWinExplorer.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyzeWinExplorer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnalyzeWinExplorer.Location = new System.Drawing.Point(13, 166);
            this.BtnAnalyzeWinExplorer.Name = "BtnAnalyzeWinExplorer";
            this.BtnAnalyzeWinExplorer.Size = new System.Drawing.Size(209, 36);
            this.BtnAnalyzeWinExplorer.TabIndex = 7;
            this.BtnAnalyzeWinExplorer.Text = "Analyze Windows Explorer";
            this.BtnAnalyzeWinExplorer.UseVisualStyleBackColor = false;
            this.BtnAnalyzeWinExplorer.Click += new System.EventHandler(this.BtnAnalyzeWinExplorer_Click);
            // 
            // GbxAnalyzeWinExplorer
            // 
            this.GbxAnalyzeWinExplorer.Controls.Add(this.ChkThumbnailCache);
            this.GbxAnalyzeWinExplorer.Controls.Add(this.ChkRecentDocuments);
            this.GbxAnalyzeWinExplorer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxAnalyzeWinExplorer.Location = new System.Drawing.Point(13, 81);
            this.GbxAnalyzeWinExplorer.Name = "GbxAnalyzeWinExplorer";
            this.GbxAnalyzeWinExplorer.Size = new System.Drawing.Size(209, 79);
            this.GbxAnalyzeWinExplorer.TabIndex = 6;
            this.GbxAnalyzeWinExplorer.TabStop = false;
            this.GbxAnalyzeWinExplorer.Text = "Analyze";
            // 
            // ChkThumbnailCache
            // 
            this.ChkThumbnailCache.AutoSize = true;
            this.ChkThumbnailCache.Checked = true;
            this.ChkThumbnailCache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkThumbnailCache.ContextMenuStrip = this.CmsAnalyze;
            this.ChkThumbnailCache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkThumbnailCache.Location = new System.Drawing.Point(6, 45);
            this.ChkThumbnailCache.Name = "ChkThumbnailCache";
            this.ChkThumbnailCache.Size = new System.Drawing.Size(134, 20);
            this.ChkThumbnailCache.TabIndex = 1;
            this.ChkThumbnailCache.Text = "Thumbnail Cache";
            this.ChkThumbnailCache.UseVisualStyleBackColor = true;
            this.ChkThumbnailCache.CheckedChanged += new System.EventHandler(this.ChkWinExplorerAnalyze_CheckedChanged);
            // 
            // ChkRecentDocuments
            // 
            this.ChkRecentDocuments.AutoSize = true;
            this.ChkRecentDocuments.Checked = true;
            this.ChkRecentDocuments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRecentDocuments.ContextMenuStrip = this.CmsAnalyze;
            this.ChkRecentDocuments.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkRecentDocuments.Location = new System.Drawing.Point(6, 20);
            this.ChkRecentDocuments.Name = "ChkRecentDocuments";
            this.ChkRecentDocuments.Size = new System.Drawing.Size(144, 20);
            this.ChkRecentDocuments.TabIndex = 0;
            this.ChkRecentDocuments.Text = "Recent Documents";
            this.ChkRecentDocuments.UseVisualStyleBackColor = true;
            this.ChkRecentDocuments.CheckedChanged += new System.EventHandler(this.ChkWinExplorerAnalyze_CheckedChanged);
            // 
            // GuiWinExplorer
            // 
            this.GuiWinExplorer.AutoSize = true;
            this.GuiWinExplorer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiWinExplorer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiWinExplorer.Location = new System.Drawing.Point(83, 36);
            this.GuiWinExplorer.Name = "GuiWinExplorer";
            this.GuiWinExplorer.Size = new System.Drawing.Size(139, 16);
            this.GuiWinExplorer.TabIndex = 5;
            this.GuiWinExplorer.Text = "Windows Explorer";
            // 
            // PBoxWinExplorer
            // 
            this.PBoxWinExplorer.BackgroundImage = global::Powered_Cleaner.Properties.Resources.icon_explorer;
            this.PBoxWinExplorer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PBoxWinExplorer.Location = new System.Drawing.Point(13, 11);
            this.PBoxWinExplorer.Name = "PBoxWinExplorer";
            this.PBoxWinExplorer.Size = new System.Drawing.Size(64, 64);
            this.PBoxWinExplorer.TabIndex = 4;
            this.PBoxWinExplorer.TabStop = false;
            // 
            // tabPWebBrowser
            // 
            this.tabPWebBrowser.Controls.Add(this.pnlOpera);
            this.tabPWebBrowser.Controls.Add(this.pnlFirefox);
            this.tabPWebBrowser.Controls.Add(this.pnlChrome);
            this.tabPWebBrowser.Location = new System.Drawing.Point(4, 5);
            this.tabPWebBrowser.Name = "tabPWebBrowser";
            this.tabPWebBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPWebBrowser.Size = new System.Drawing.Size(787, 576);
            this.tabPWebBrowser.TabIndex = 5;
            this.tabPWebBrowser.Text = "Web Browser";
            this.tabPWebBrowser.UseVisualStyleBackColor = true;
            // 
            // pnlOpera
            // 
            this.pnlOpera.Controls.Add(this.PboxOpera);
            this.pnlOpera.Controls.Add(this.GuiOpera);
            this.pnlOpera.Controls.Add(this.LblOperaVersion);
            this.pnlOpera.Controls.Add(this.BtnAnalyzeOpera);
            this.pnlOpera.Controls.Add(this.GbxAnalyzeOpera);
            this.pnlOpera.Location = new System.Drawing.Point(526, 6);
            this.pnlOpera.Name = "pnlOpera";
            this.pnlOpera.Size = new System.Drawing.Size(255, 315);
            this.pnlOpera.TabIndex = 18;
            // 
            // PboxOpera
            // 
            this.PboxOpera.Image = global::Powered_Cleaner.Properties.Resources.icon_opera;
            this.PboxOpera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PboxOpera.Location = new System.Drawing.Point(10, 3);
            this.PboxOpera.Name = "PboxOpera";
            this.PboxOpera.Size = new System.Drawing.Size(64, 64);
            this.PboxOpera.TabIndex = 10;
            this.PboxOpera.TabStop = false;
            // 
            // GuiOpera
            // 
            this.GuiOpera.AutoSize = true;
            this.GuiOpera.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiOpera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiOpera.Location = new System.Drawing.Point(80, 28);
            this.GuiOpera.Name = "GuiOpera";
            this.GuiOpera.Size = new System.Drawing.Size(52, 16);
            this.GuiOpera.TabIndex = 11;
            this.GuiOpera.Text = "Opera";
            // 
            // LblOperaVersion
            // 
            this.LblOperaVersion.AutoSize = true;
            this.LblOperaVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOperaVersion.ForeColor = System.Drawing.Color.Gray;
            this.LblOperaVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblOperaVersion.Location = new System.Drawing.Point(80, 52);
            this.LblOperaVersion.Name = "LblOperaVersion";
            this.LblOperaVersion.Size = new System.Drawing.Size(55, 16);
            this.LblOperaVersion.TabIndex = 12;
            this.LblOperaVersion.Text = "Version";
            // 
            // BtnAnalyzeOpera
            // 
            this.BtnAnalyzeOpera.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAnalyzeOpera.FlatAppearance.BorderSize = 0;
            this.BtnAnalyzeOpera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyzeOpera.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnAnalyzeOpera.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyzeOpera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnalyzeOpera.Location = new System.Drawing.Point(34, 260);
            this.BtnAnalyzeOpera.Name = "BtnAnalyzeOpera";
            this.BtnAnalyzeOpera.Size = new System.Drawing.Size(185, 36);
            this.BtnAnalyzeOpera.TabIndex = 14;
            this.BtnAnalyzeOpera.Text = "Analyze Opera";
            this.BtnAnalyzeOpera.UseVisualStyleBackColor = false;
            this.BtnAnalyzeOpera.Click += new System.EventHandler(this.BtnAnalyzeOpera_Click);
            // 
            // GbxAnalyzeOpera
            // 
            this.GbxAnalyzeOpera.Controls.Add(this.ChkOperaSession);
            this.GbxAnalyzeOpera.Controls.Add(this.ChkOperaDLHist);
            this.GbxAnalyzeOpera.Controls.Add(this.ChkOperaHist);
            this.GbxAnalyzeOpera.Controls.Add(this.ChkOperaCache);
            this.GbxAnalyzeOpera.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.GbxAnalyzeOpera.Location = new System.Drawing.Point(10, 73);
            this.GbxAnalyzeOpera.Name = "GbxAnalyzeOpera";
            this.GbxAnalyzeOpera.Size = new System.Drawing.Size(228, 181);
            this.GbxAnalyzeOpera.TabIndex = 13;
            this.GbxAnalyzeOpera.TabStop = false;
            this.GbxAnalyzeOpera.Text = "Analyze";
            // 
            // ChkOperaSession
            // 
            this.ChkOperaSession.AutoSize = true;
            this.ChkOperaSession.Checked = true;
            this.ChkOperaSession.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkOperaSession.ContextMenuStrip = this.CmsAnalyze;
            this.ChkOperaSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkOperaSession.Location = new System.Drawing.Point(6, 96);
            this.ChkOperaSession.Name = "ChkOperaSession";
            this.ChkOperaSession.Size = new System.Drawing.Size(76, 20);
            this.ChkOperaSession.TabIndex = 3;
            this.ChkOperaSession.Text = "Session";
            this.ChkOperaSession.UseVisualStyleBackColor = true;
            this.ChkOperaSession.CheckedChanged += new System.EventHandler(this.ChkOperaAnalyze_Checked);
            // 
            // ChkOperaDLHist
            // 
            this.ChkOperaDLHist.AutoSize = true;
            this.ChkOperaDLHist.Checked = true;
            this.ChkOperaDLHist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkOperaDLHist.ContextMenuStrip = this.CmsAnalyze;
            this.ChkOperaDLHist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkOperaDLHist.Location = new System.Drawing.Point(6, 71);
            this.ChkOperaDLHist.Name = "ChkOperaDLHist";
            this.ChkOperaDLHist.Size = new System.Drawing.Size(138, 20);
            this.ChkOperaDLHist.TabIndex = 2;
            this.ChkOperaDLHist.Text = "Download History";
            this.ChkOperaDLHist.UseVisualStyleBackColor = true;
            this.ChkOperaDLHist.CheckedChanged += new System.EventHandler(this.ChkOperaAnalyze_Checked);
            // 
            // ChkOperaHist
            // 
            this.ChkOperaHist.AutoSize = true;
            this.ChkOperaHist.Checked = true;
            this.ChkOperaHist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkOperaHist.ContextMenuStrip = this.CmsAnalyze;
            this.ChkOperaHist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkOperaHist.Location = new System.Drawing.Point(6, 46);
            this.ChkOperaHist.Name = "ChkOperaHist";
            this.ChkOperaHist.Size = new System.Drawing.Size(127, 20);
            this.ChkOperaHist.TabIndex = 1;
            this.ChkOperaHist.Text = "Internet History";
            this.ChkOperaHist.UseVisualStyleBackColor = true;
            this.ChkOperaHist.CheckedChanged += new System.EventHandler(this.ChkOperaAnalyze_Checked);
            // 
            // ChkOperaCache
            // 
            this.ChkOperaCache.AutoSize = true;
            this.ChkOperaCache.Checked = true;
            this.ChkOperaCache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkOperaCache.ContextMenuStrip = this.CmsAnalyze;
            this.ChkOperaCache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkOperaCache.Location = new System.Drawing.Point(6, 21);
            this.ChkOperaCache.Name = "ChkOperaCache";
            this.ChkOperaCache.Size = new System.Drawing.Size(122, 20);
            this.ChkOperaCache.TabIndex = 0;
            this.ChkOperaCache.Text = "Internet Cache";
            this.ChkOperaCache.UseVisualStyleBackColor = true;
            this.ChkOperaCache.CheckedChanged += new System.EventHandler(this.ChkOperaAnalyze_Checked);
            // 
            // pnlFirefox
            // 
            this.pnlFirefox.Controls.Add(this.PboxFirefox);
            this.pnlFirefox.Controls.Add(this.GuiFirefox);
            this.pnlFirefox.Controls.Add(this.LblFirefoxVersion);
            this.pnlFirefox.Controls.Add(this.GbxAnalyzeFirefox);
            this.pnlFirefox.Controls.Add(this.BtnAnalyzeFirefox);
            this.pnlFirefox.Location = new System.Drawing.Point(267, 6);
            this.pnlFirefox.Name = "pnlFirefox";
            this.pnlFirefox.Size = new System.Drawing.Size(255, 315);
            this.pnlFirefox.TabIndex = 17;
            // 
            // PboxFirefox
            // 
            this.PboxFirefox.Image = global::Powered_Cleaner.Properties.Resources.icon_firefox;
            this.PboxFirefox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PboxFirefox.Location = new System.Drawing.Point(15, 3);
            this.PboxFirefox.Name = "PboxFirefox";
            this.PboxFirefox.Size = new System.Drawing.Size(64, 64);
            this.PboxFirefox.TabIndex = 5;
            this.PboxFirefox.TabStop = false;
            // 
            // GuiFirefox
            // 
            this.GuiFirefox.AutoSize = true;
            this.GuiFirefox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiFirefox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiFirefox.Location = new System.Drawing.Point(85, 28);
            this.GuiFirefox.Name = "GuiFirefox";
            this.GuiFirefox.Size = new System.Drawing.Size(111, 16);
            this.GuiFirefox.TabIndex = 6;
            this.GuiFirefox.Text = "Mozilla Firefox";
            // 
            // LblFirefoxVersion
            // 
            this.LblFirefoxVersion.AutoSize = true;
            this.LblFirefoxVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirefoxVersion.ForeColor = System.Drawing.Color.Gray;
            this.LblFirefoxVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFirefoxVersion.Location = new System.Drawing.Point(85, 52);
            this.LblFirefoxVersion.Name = "LblFirefoxVersion";
            this.LblFirefoxVersion.Size = new System.Drawing.Size(55, 16);
            this.LblFirefoxVersion.TabIndex = 7;
            this.LblFirefoxVersion.Text = "Version";
            // 
            // GbxAnalyzeFirefox
            // 
            this.GbxAnalyzeFirefox.Controls.Add(this.ChkFirefoxHTML5Storage);
            this.GbxAnalyzeFirefox.Controls.Add(this.ChkFirefoxStartupCache);
            this.GbxAnalyzeFirefox.Controls.Add(this.ChkFirefoxDLHist);
            this.GbxAnalyzeFirefox.Controls.Add(this.ChkFirefoxHist);
            this.GbxAnalyzeFirefox.Controls.Add(this.ChkFirefoxCache);
            this.GbxAnalyzeFirefox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.GbxAnalyzeFirefox.Location = new System.Drawing.Point(15, 73);
            this.GbxAnalyzeFirefox.Name = "GbxAnalyzeFirefox";
            this.GbxAnalyzeFirefox.Size = new System.Drawing.Size(228, 181);
            this.GbxAnalyzeFirefox.TabIndex = 8;
            this.GbxAnalyzeFirefox.TabStop = false;
            this.GbxAnalyzeFirefox.Text = "Analyze";
            // 
            // ChkFirefoxHTML5Storage
            // 
            this.ChkFirefoxHTML5Storage.AutoSize = true;
            this.ChkFirefoxHTML5Storage.Checked = true;
            this.ChkFirefoxHTML5Storage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFirefoxHTML5Storage.ContextMenuStrip = this.CmsAnalyze;
            this.ChkFirefoxHTML5Storage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkFirefoxHTML5Storage.Location = new System.Drawing.Point(6, 122);
            this.ChkFirefoxHTML5Storage.Name = "ChkFirefoxHTML5Storage";
            this.ChkFirefoxHTML5Storage.Size = new System.Drawing.Size(122, 20);
            this.ChkFirefoxHTML5Storage.TabIndex = 5;
            this.ChkFirefoxHTML5Storage.Text = "HTML5 Storage";
            this.ChkFirefoxHTML5Storage.UseVisualStyleBackColor = true;
            // 
            // ChkFirefoxStartupCache
            // 
            this.ChkFirefoxStartupCache.AutoSize = true;
            this.ChkFirefoxStartupCache.Checked = true;
            this.ChkFirefoxStartupCache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFirefoxStartupCache.ContextMenuStrip = this.CmsAnalyze;
            this.ChkFirefoxStartupCache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkFirefoxStartupCache.Location = new System.Drawing.Point(6, 96);
            this.ChkFirefoxStartupCache.Name = "ChkFirefoxStartupCache";
            this.ChkFirefoxStartupCache.Size = new System.Drawing.Size(117, 20);
            this.ChkFirefoxStartupCache.TabIndex = 4;
            this.ChkFirefoxStartupCache.Text = "Startup Cache";
            this.ChkFirefoxStartupCache.UseVisualStyleBackColor = true;
            // 
            // ChkFirefoxDLHist
            // 
            this.ChkFirefoxDLHist.AutoSize = true;
            this.ChkFirefoxDLHist.Checked = true;
            this.ChkFirefoxDLHist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFirefoxDLHist.ContextMenuStrip = this.CmsAnalyze;
            this.ChkFirefoxDLHist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkFirefoxDLHist.Location = new System.Drawing.Point(6, 71);
            this.ChkFirefoxDLHist.Name = "ChkFirefoxDLHist";
            this.ChkFirefoxDLHist.Size = new System.Drawing.Size(138, 20);
            this.ChkFirefoxDLHist.TabIndex = 2;
            this.ChkFirefoxDLHist.Text = "Download History";
            this.ChkFirefoxDLHist.UseVisualStyleBackColor = true;
            this.ChkFirefoxDLHist.CheckedChanged += new System.EventHandler(this.ChkFirefoxAnalyze_Checked);
            // 
            // ChkFirefoxHist
            // 
            this.ChkFirefoxHist.AutoSize = true;
            this.ChkFirefoxHist.Checked = true;
            this.ChkFirefoxHist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFirefoxHist.ContextMenuStrip = this.CmsAnalyze;
            this.ChkFirefoxHist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkFirefoxHist.Location = new System.Drawing.Point(6, 46);
            this.ChkFirefoxHist.Name = "ChkFirefoxHist";
            this.ChkFirefoxHist.Size = new System.Drawing.Size(127, 20);
            this.ChkFirefoxHist.TabIndex = 1;
            this.ChkFirefoxHist.Text = "Internet History";
            this.ChkFirefoxHist.UseVisualStyleBackColor = true;
            this.ChkFirefoxHist.CheckedChanged += new System.EventHandler(this.ChkFirefoxAnalyze_Checked);
            // 
            // ChkFirefoxCache
            // 
            this.ChkFirefoxCache.AutoSize = true;
            this.ChkFirefoxCache.Checked = true;
            this.ChkFirefoxCache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFirefoxCache.ContextMenuStrip = this.CmsAnalyze;
            this.ChkFirefoxCache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkFirefoxCache.Location = new System.Drawing.Point(6, 21);
            this.ChkFirefoxCache.Name = "ChkFirefoxCache";
            this.ChkFirefoxCache.Size = new System.Drawing.Size(122, 20);
            this.ChkFirefoxCache.TabIndex = 0;
            this.ChkFirefoxCache.Text = "Internet Cache";
            this.ChkFirefoxCache.UseVisualStyleBackColor = true;
            this.ChkFirefoxCache.CheckedChanged += new System.EventHandler(this.ChkFirefoxAnalyze_Checked);
            // 
            // BtnAnalyzeFirefox
            // 
            this.BtnAnalyzeFirefox.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAnalyzeFirefox.FlatAppearance.BorderSize = 0;
            this.BtnAnalyzeFirefox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyzeFirefox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnAnalyzeFirefox.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyzeFirefox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnalyzeFirefox.Location = new System.Drawing.Point(40, 260);
            this.BtnAnalyzeFirefox.Name = "BtnAnalyzeFirefox";
            this.BtnAnalyzeFirefox.Size = new System.Drawing.Size(183, 36);
            this.BtnAnalyzeFirefox.TabIndex = 9;
            this.BtnAnalyzeFirefox.Text = "Analyze Mozilla Firefox";
            this.BtnAnalyzeFirefox.UseVisualStyleBackColor = false;
            this.BtnAnalyzeFirefox.Click += new System.EventHandler(this.BtnAnalyzeFirefox_Click);
            // 
            // pnlChrome
            // 
            this.pnlChrome.Controls.Add(this.PboxChrome);
            this.pnlChrome.Controls.Add(this.pBoxAnalysisChrome);
            this.pnlChrome.Controls.Add(this.GuiChrome);
            this.pnlChrome.Controls.Add(this.BtnAnalyzeChrome);
            this.pnlChrome.Controls.Add(this.LblChromeVersion);
            this.pnlChrome.Controls.Add(this.GbxAnalyzeChrome);
            this.pnlChrome.Location = new System.Drawing.Point(6, 6);
            this.pnlChrome.Name = "pnlChrome";
            this.pnlChrome.Size = new System.Drawing.Size(255, 315);
            this.pnlChrome.TabIndex = 16;
            // 
            // PboxChrome
            // 
            this.PboxChrome.Image = global::Powered_Cleaner.Properties.Resources.icon_chrome;
            this.PboxChrome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PboxChrome.Location = new System.Drawing.Point(17, 3);
            this.PboxChrome.Name = "PboxChrome";
            this.PboxChrome.Size = new System.Drawing.Size(64, 64);
            this.PboxChrome.TabIndex = 0;
            this.PboxChrome.TabStop = false;
            // 
            // pBoxAnalysisChrome
            // 
            this.pBoxAnalysisChrome.Image = ((System.Drawing.Image)(resources.GetObject("pBoxAnalysisChrome.Image")));
            this.pBoxAnalysisChrome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pBoxAnalysisChrome.Location = new System.Drawing.Point(226, 270);
            this.pBoxAnalysisChrome.Name = "pBoxAnalysisChrome";
            this.pBoxAnalysisChrome.Size = new System.Drawing.Size(16, 16);
            this.pBoxAnalysisChrome.TabIndex = 15;
            this.pBoxAnalysisChrome.TabStop = false;
            this.pBoxAnalysisChrome.Visible = false;
            // 
            // GuiChrome
            // 
            this.GuiChrome.AutoSize = true;
            this.GuiChrome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiChrome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiChrome.Location = new System.Drawing.Point(87, 28);
            this.GuiChrome.Name = "GuiChrome";
            this.GuiChrome.Size = new System.Drawing.Size(118, 16);
            this.GuiChrome.TabIndex = 1;
            this.GuiChrome.Text = "Google Chrome";
            // 
            // BtnAnalyzeChrome
            // 
            this.BtnAnalyzeChrome.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAnalyzeChrome.FlatAppearance.BorderSize = 0;
            this.BtnAnalyzeChrome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyzeChrome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnAnalyzeChrome.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyzeChrome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnalyzeChrome.Location = new System.Drawing.Point(23, 260);
            this.BtnAnalyzeChrome.Name = "BtnAnalyzeChrome";
            this.BtnAnalyzeChrome.Size = new System.Drawing.Size(197, 36);
            this.BtnAnalyzeChrome.TabIndex = 2;
            this.BtnAnalyzeChrome.Text = "Analyze Google Chrome";
            this.BtnAnalyzeChrome.UseVisualStyleBackColor = false;
            this.BtnAnalyzeChrome.Click += new System.EventHandler(this.BtnChrome_Click);
            // 
            // LblChromeVersion
            // 
            this.LblChromeVersion.AutoSize = true;
            this.LblChromeVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChromeVersion.ForeColor = System.Drawing.Color.Gray;
            this.LblChromeVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblChromeVersion.Location = new System.Drawing.Point(87, 52);
            this.LblChromeVersion.Name = "LblChromeVersion";
            this.LblChromeVersion.Size = new System.Drawing.Size(55, 16);
            this.LblChromeVersion.TabIndex = 3;
            this.LblChromeVersion.Text = "Version";
            // 
            // GbxAnalyzeChrome
            // 
            this.GbxAnalyzeChrome.Controls.Add(this.ChkChromeExtDb);
            this.GbxAnalyzeChrome.Controls.Add(this.ChkChromeCrashReports);
            this.GbxAnalyzeChrome.Controls.Add(this.ChkChromeUpdates);
            this.GbxAnalyzeChrome.Controls.Add(this.ChkChromeDLHist);
            this.GbxAnalyzeChrome.Controls.Add(this.ChkChromeHist);
            this.GbxAnalyzeChrome.Controls.Add(this.ChkChromeCache);
            this.GbxAnalyzeChrome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.GbxAnalyzeChrome.Location = new System.Drawing.Point(17, 73);
            this.GbxAnalyzeChrome.Name = "GbxAnalyzeChrome";
            this.GbxAnalyzeChrome.Size = new System.Drawing.Size(228, 181);
            this.GbxAnalyzeChrome.TabIndex = 4;
            this.GbxAnalyzeChrome.TabStop = false;
            this.GbxAnalyzeChrome.Text = "Analyze";
            // 
            // ChkChromeExtDb
            // 
            this.ChkChromeExtDb.AutoSize = true;
            this.ChkChromeExtDb.Checked = true;
            this.ChkChromeExtDb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChromeExtDb.ContextMenuStrip = this.CmsAnalyze;
            this.ChkChromeExtDb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkChromeExtDb.Location = new System.Drawing.Point(6, 125);
            this.ChkChromeExtDb.Name = "ChkChromeExtDb";
            this.ChkChromeExtDb.Size = new System.Drawing.Size(161, 20);
            this.ChkChromeExtDb.TabIndex = 5;
            this.ChkChromeExtDb.Text = "Extension Databases";
            this.ChkChromeExtDb.UseVisualStyleBackColor = true;
            // 
            // ChkChromeCrashReports
            // 
            this.ChkChromeCrashReports.AutoSize = true;
            this.ChkChromeCrashReports.Checked = true;
            this.ChkChromeCrashReports.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChromeCrashReports.ContextMenuStrip = this.CmsAnalyze;
            this.ChkChromeCrashReports.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkChromeCrashReports.Location = new System.Drawing.Point(6, 99);
            this.ChkChromeCrashReports.Name = "ChkChromeCrashReports";
            this.ChkChromeCrashReports.Size = new System.Drawing.Size(117, 20);
            this.ChkChromeCrashReports.TabIndex = 4;
            this.ChkChromeCrashReports.Text = "Crash Reports";
            this.ChkChromeCrashReports.UseVisualStyleBackColor = true;
            // 
            // ChkChromeUpdates
            // 
            this.ChkChromeUpdates.AutoSize = true;
            this.ChkChromeUpdates.Checked = true;
            this.ChkChromeUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChromeUpdates.ContextMenuStrip = this.CmsAnalyze;
            this.ChkChromeUpdates.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkChromeUpdates.Location = new System.Drawing.Point(6, 151);
            this.ChkChromeUpdates.Name = "ChkChromeUpdates";
            this.ChkChromeUpdates.Size = new System.Drawing.Size(80, 20);
            this.ChkChromeUpdates.TabIndex = 3;
            this.ChkChromeUpdates.Text = "Updates";
            this.ChkChromeUpdates.UseVisualStyleBackColor = true;
            this.ChkChromeUpdates.CheckedChanged += new System.EventHandler(this.ChkChromeAnalyze_CheckedChanged);
            // 
            // ChkChromeDLHist
            // 
            this.ChkChromeDLHist.AutoSize = true;
            this.ChkChromeDLHist.Checked = true;
            this.ChkChromeDLHist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChromeDLHist.ContextMenuStrip = this.CmsAnalyze;
            this.ChkChromeDLHist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkChromeDLHist.Location = new System.Drawing.Point(6, 71);
            this.ChkChromeDLHist.Name = "ChkChromeDLHist";
            this.ChkChromeDLHist.Size = new System.Drawing.Size(138, 20);
            this.ChkChromeDLHist.TabIndex = 2;
            this.ChkChromeDLHist.Text = "Download History";
            this.ChkChromeDLHist.UseVisualStyleBackColor = true;
            this.ChkChromeDLHist.CheckedChanged += new System.EventHandler(this.ChkChromeAnalyze_CheckedChanged);
            // 
            // ChkChromeHist
            // 
            this.ChkChromeHist.AutoSize = true;
            this.ChkChromeHist.Checked = true;
            this.ChkChromeHist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChromeHist.ContextMenuStrip = this.CmsAnalyze;
            this.ChkChromeHist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkChromeHist.Location = new System.Drawing.Point(6, 46);
            this.ChkChromeHist.Name = "ChkChromeHist";
            this.ChkChromeHist.Size = new System.Drawing.Size(127, 20);
            this.ChkChromeHist.TabIndex = 1;
            this.ChkChromeHist.Text = "Internet History";
            this.ChkChromeHist.UseVisualStyleBackColor = true;
            this.ChkChromeHist.CheckedChanged += new System.EventHandler(this.ChkChromeAnalyze_CheckedChanged);
            // 
            // ChkChromeCache
            // 
            this.ChkChromeCache.AutoSize = true;
            this.ChkChromeCache.Checked = true;
            this.ChkChromeCache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChromeCache.ContextMenuStrip = this.CmsAnalyze;
            this.ChkChromeCache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkChromeCache.Location = new System.Drawing.Point(6, 21);
            this.ChkChromeCache.Name = "ChkChromeCache";
            this.ChkChromeCache.Size = new System.Drawing.Size(122, 20);
            this.ChkChromeCache.TabIndex = 0;
            this.ChkChromeCache.Text = "Internet Cache";
            this.ChkChromeCache.UseVisualStyleBackColor = true;
            this.ChkChromeCache.CheckedChanged += new System.EventHandler(this.ChkChromeAnalyze_CheckedChanged);
            // 
            // tabPAdvanced
            // 
            this.tabPAdvanced.Controls.Add(this.pBoxLoadingAnalysis);
            this.tabPAdvanced.Controls.Add(this.GbxWinUpdate);
            this.tabPAdvanced.Controls.Add(this.BtnAnalyzeWindows);
            this.tabPAdvanced.Controls.Add(this.GuiWinUpdate);
            this.tabPAdvanced.Controls.Add(this.PBoxWinUpdate);
            this.tabPAdvanced.Location = new System.Drawing.Point(4, 5);
            this.tabPAdvanced.Name = "tabPAdvanced";
            this.tabPAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPAdvanced.Size = new System.Drawing.Size(787, 576);
            this.tabPAdvanced.TabIndex = 19;
            this.tabPAdvanced.Text = "Advanced";
            this.tabPAdvanced.UseVisualStyleBackColor = true;
            // 
            // pBoxLoadingAnalysis
            // 
            this.pBoxLoadingAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLoadingAnalysis.Image")));
            this.pBoxLoadingAnalysis.Location = new System.Drawing.Point(211, 265);
            this.pBoxLoadingAnalysis.Name = "pBoxLoadingAnalysis";
            this.pBoxLoadingAnalysis.Size = new System.Drawing.Size(16, 16);
            this.pBoxLoadingAnalysis.TabIndex = 9;
            this.pBoxLoadingAnalysis.TabStop = false;
            this.pBoxLoadingAnalysis.Visible = false;
            // 
            // GbxWinUpdate
            // 
            this.GbxWinUpdate.Controls.Add(this.ChkJumpLists);
            this.GbxWinUpdate.Controls.Add(this.ChkWinInstaller);
            this.GbxWinUpdate.Controls.Add(this.ChkDownloadedInstall);
            this.GbxWinUpdate.Controls.Add(this.ChkWinLogs);
            this.GbxWinUpdate.Controls.Add(this.ChkWinUpdate);
            this.GbxWinUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxWinUpdate.Location = new System.Drawing.Point(10, 86);
            this.GbxWinUpdate.Name = "GbxWinUpdate";
            this.GbxWinUpdate.Size = new System.Drawing.Size(216, 162);
            this.GbxWinUpdate.TabIndex = 8;
            this.GbxWinUpdate.TabStop = false;
            this.GbxWinUpdate.Text = "Windows";
            // 
            // ChkJumpLists
            // 
            this.ChkJumpLists.AutoSize = true;
            this.ChkJumpLists.Checked = true;
            this.ChkJumpLists.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkJumpLists.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkJumpLists.Location = new System.Drawing.Point(6, 47);
            this.ChkJumpLists.Name = "ChkJumpLists";
            this.ChkJumpLists.Size = new System.Drawing.Size(92, 20);
            this.ChkJumpLists.TabIndex = 5;
            this.ChkJumpLists.Text = "Jump Lists";
            this.ChkJumpLists.UseVisualStyleBackColor = true;
            // 
            // ChkWinInstaller
            // 
            this.ChkWinInstaller.AutoSize = true;
            this.ChkWinInstaller.Checked = true;
            this.ChkWinInstaller.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkWinInstaller.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkWinInstaller.Location = new System.Drawing.Point(6, 73);
            this.ChkWinInstaller.Name = "ChkWinInstaller";
            this.ChkWinInstaller.Size = new System.Drawing.Size(141, 20);
            this.ChkWinInstaller.TabIndex = 4;
            this.ChkWinInstaller.Text = "Windows Installer";
            this.ChkWinInstaller.UseVisualStyleBackColor = true;
            // 
            // ChkDownloadedInstall
            // 
            this.ChkDownloadedInstall.AutoSize = true;
            this.ChkDownloadedInstall.Checked = true;
            this.ChkDownloadedInstall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDownloadedInstall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkDownloadedInstall.Location = new System.Drawing.Point(6, 21);
            this.ChkDownloadedInstall.Name = "ChkDownloadedInstall";
            this.ChkDownloadedInstall.Size = new System.Drawing.Size(188, 20);
            this.ChkDownloadedInstall.TabIndex = 3;
            this.ChkDownloadedInstall.Text = "Downloaded Installations";
            this.ChkDownloadedInstall.UseVisualStyleBackColor = true;
            // 
            // ChkWinLogs
            // 
            this.ChkWinLogs.AutoSize = true;
            this.ChkWinLogs.Checked = true;
            this.ChkWinLogs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkWinLogs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkWinLogs.Location = new System.Drawing.Point(6, 100);
            this.ChkWinLogs.Name = "ChkWinLogs";
            this.ChkWinLogs.Size = new System.Drawing.Size(119, 20);
            this.ChkWinLogs.TabIndex = 2;
            this.ChkWinLogs.Text = "Windows Logs";
            this.ChkWinLogs.UseVisualStyleBackColor = true;
            // 
            // ChkWinUpdate
            // 
            this.ChkWinUpdate.AutoSize = true;
            this.ChkWinUpdate.Checked = true;
            this.ChkWinUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkWinUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkWinUpdate.Location = new System.Drawing.Point(6, 126);
            this.ChkWinUpdate.Name = "ChkWinUpdate";
            this.ChkWinUpdate.Size = new System.Drawing.Size(135, 20);
            this.ChkWinUpdate.TabIndex = 0;
            this.ChkWinUpdate.Text = "Windows Update";
            this.ChkWinUpdate.UseVisualStyleBackColor = true;
            this.ChkWinUpdate.CheckedChanged += new System.EventHandler(this.ChkWinUpdate_CheckedChanged);
            // 
            // BtnAnalyzeWindows
            // 
            this.BtnAnalyzeWindows.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAnalyzeWindows.FlatAppearance.BorderSize = 0;
            this.BtnAnalyzeWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyzeWindows.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnAnalyzeWindows.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyzeWindows.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnalyzeWindows.Location = new System.Drawing.Point(16, 254);
            this.BtnAnalyzeWindows.Name = "BtnAnalyzeWindows";
            this.BtnAnalyzeWindows.Size = new System.Drawing.Size(188, 36);
            this.BtnAnalyzeWindows.TabIndex = 7;
            this.BtnAnalyzeWindows.Text = "Analyze Windows";
            this.BtnAnalyzeWindows.UseVisualStyleBackColor = false;
            this.BtnAnalyzeWindows.Click += new System.EventHandler(this.BtnAnalyzeWinUpdate_Click);
            // 
            // GuiWinUpdate
            // 
            this.GuiWinUpdate.AutoSize = true;
            this.GuiWinUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiWinUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiWinUpdate.Location = new System.Drawing.Point(80, 36);
            this.GuiWinUpdate.Name = "GuiWinUpdate";
            this.GuiWinUpdate.Size = new System.Drawing.Size(73, 16);
            this.GuiWinUpdate.TabIndex = 6;
            this.GuiWinUpdate.Text = "Windows";
            // 
            // PBoxWinUpdate
            // 
            this.PBoxWinUpdate.Image = ((System.Drawing.Image)(resources.GetObject("PBoxWinUpdate.Image")));
            this.PBoxWinUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PBoxWinUpdate.Location = new System.Drawing.Point(10, 10);
            this.PBoxWinUpdate.Name = "PBoxWinUpdate";
            this.PBoxWinUpdate.Size = new System.Drawing.Size(64, 64);
            this.PBoxWinUpdate.TabIndex = 5;
            this.PBoxWinUpdate.TabStop = false;
            // 
            // tabPApplications
            // 
            this.tabPApplications.Controls.Add(this.PbxDevelopment);
            this.tabPApplications.Controls.Add(this.tCtrlApplications);
            this.tabPApplications.Controls.Add(this.PbxGames);
            this.tabPApplications.Controls.Add(this.PbxOffice);
            this.tabPApplications.Location = new System.Drawing.Point(4, 5);
            this.tabPApplications.Name = "tabPApplications";
            this.tabPApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPApplications.Size = new System.Drawing.Size(787, 576);
            this.tabPApplications.TabIndex = 21;
            this.tabPApplications.Text = "Applications";
            this.tabPApplications.UseVisualStyleBackColor = true;
            // 
            // PbxDevelopment
            // 
            this.PbxDevelopment.Image = ((System.Drawing.Image)(resources.GetObject("PbxDevelopment.Image")));
            this.PbxDevelopment.Location = new System.Drawing.Point(691, 486);
            this.PbxDevelopment.Name = "PbxDevelopment";
            this.PbxDevelopment.Size = new System.Drawing.Size(64, 64);
            this.PbxDevelopment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxDevelopment.TabIndex = 2;
            this.PbxDevelopment.TabStop = false;
            this.PbxDevelopment.Click += new System.EventHandler(this.PbxDevelopment_Click);
            // 
            // tCtrlApplications
            // 
            this.tCtrlApplications.Controls.Add(this.tPageBureautique);
            this.tCtrlApplications.Controls.Add(this.tPageGames);
            this.tCtrlApplications.Controls.Add(this.tPageDevelopment);
            this.tCtrlApplications.Controls.Add(this.tPageOthers);
            this.tCtrlApplications.ItemSize = new System.Drawing.Size(0, 1);
            this.tCtrlApplications.Location = new System.Drawing.Point(6, 8);
            this.tCtrlApplications.Name = "tCtrlApplications";
            this.tCtrlApplications.SelectedIndex = 0;
            this.tCtrlApplications.Size = new System.Drawing.Size(769, 476);
            this.tCtrlApplications.TabIndex = 0;
            // 
            // tPageBureautique
            // 
            this.tPageBureautique.Controls.Add(this.BtnAnalyzeOffice);
            this.tPageBureautique.Controls.Add(this.GbxOffice);
            this.tPageBureautique.Location = new System.Drawing.Point(4, 5);
            this.tPageBureautique.Name = "tPageBureautique";
            this.tPageBureautique.Padding = new System.Windows.Forms.Padding(3);
            this.tPageBureautique.Size = new System.Drawing.Size(761, 467);
            this.tPageBureautique.TabIndex = 1;
            this.tPageBureautique.UseVisualStyleBackColor = true;
            // 
            // BtnAnalyzeOffice
            // 
            this.BtnAnalyzeOffice.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAnalyzeOffice.FlatAppearance.BorderSize = 0;
            this.BtnAnalyzeOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyzeOffice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnAnalyzeOffice.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyzeOffice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnalyzeOffice.Location = new System.Drawing.Point(6, 141);
            this.BtnAnalyzeOffice.Name = "BtnAnalyzeOffice";
            this.BtnAnalyzeOffice.Size = new System.Drawing.Size(215, 36);
            this.BtnAnalyzeOffice.TabIndex = 9;
            this.BtnAnalyzeOffice.Text = "Analyze Applications";
            this.BtnAnalyzeOffice.UseVisualStyleBackColor = false;
            this.BtnAnalyzeOffice.Click += new System.EventHandler(this.BtnAnalyzeOffice_Click);
            // 
            // GbxOffice
            // 
            this.GbxOffice.Controls.Add(this.ChkDropbox);
            this.GbxOffice.Controls.Add(this.ChkOffice);
            this.GbxOffice.Controls.Add(this.ChkVlcMediaPlayer);
            this.GbxOffice.Controls.Add(this.ChkAdobeReader);
            this.GbxOffice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.GbxOffice.Location = new System.Drawing.Point(6, 6);
            this.GbxOffice.Name = "GbxOffice";
            this.GbxOffice.Size = new System.Drawing.Size(215, 129);
            this.GbxOffice.TabIndex = 1;
            this.GbxOffice.TabStop = false;
            this.GbxOffice.Text = "Applications";
            // 
            // ChkDropbox
            // 
            this.ChkDropbox.AutoSize = true;
            this.ChkDropbox.Checked = true;
            this.ChkDropbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDropbox.Location = new System.Drawing.Point(6, 96);
            this.ChkDropbox.Name = "ChkDropbox";
            this.ChkDropbox.Size = new System.Drawing.Size(80, 20);
            this.ChkDropbox.TabIndex = 3;
            this.ChkDropbox.Text = "Dropbox";
            this.ChkDropbox.UseVisualStyleBackColor = true;
            // 
            // ChkOffice
            // 
            this.ChkOffice.AutoSize = true;
            this.ChkOffice.Checked = true;
            this.ChkOffice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkOffice.Location = new System.Drawing.Point(6, 20);
            this.ChkOffice.Name = "ChkOffice";
            this.ChkOffice.Size = new System.Drawing.Size(120, 20);
            this.ChkOffice.TabIndex = 2;
            this.ChkOffice.Text = "MS Office 2016";
            this.ChkOffice.UseVisualStyleBackColor = true;
            // 
            // ChkVlcMediaPlayer
            // 
            this.ChkVlcMediaPlayer.AutoSize = true;
            this.ChkVlcMediaPlayer.Checked = true;
            this.ChkVlcMediaPlayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkVlcMediaPlayer.Location = new System.Drawing.Point(6, 70);
            this.ChkVlcMediaPlayer.Name = "ChkVlcMediaPlayer";
            this.ChkVlcMediaPlayer.Size = new System.Drawing.Size(135, 20);
            this.ChkVlcMediaPlayer.TabIndex = 1;
            this.ChkVlcMediaPlayer.Text = "VLC Media Player";
            this.ChkVlcMediaPlayer.UseVisualStyleBackColor = true;
            // 
            // ChkAdobeReader
            // 
            this.ChkAdobeReader.AutoSize = true;
            this.ChkAdobeReader.Checked = true;
            this.ChkAdobeReader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAdobeReader.Location = new System.Drawing.Point(6, 45);
            this.ChkAdobeReader.Name = "ChkAdobeReader";
            this.ChkAdobeReader.Size = new System.Drawing.Size(138, 20);
            this.ChkAdobeReader.TabIndex = 0;
            this.ChkAdobeReader.Text = "Adobe Reader DC";
            this.ChkAdobeReader.UseVisualStyleBackColor = true;
            // 
            // tPageGames
            // 
            this.tPageGames.Controls.Add(this.BtnAnalyzeGames);
            this.tPageGames.Controls.Add(this.groupBox4);
            this.tPageGames.Location = new System.Drawing.Point(4, 5);
            this.tPageGames.Name = "tPageGames";
            this.tPageGames.Padding = new System.Windows.Forms.Padding(3);
            this.tPageGames.Size = new System.Drawing.Size(761, 467);
            this.tPageGames.TabIndex = 3;
            this.tPageGames.UseVisualStyleBackColor = true;
            // 
            // BtnAnalyzeGames
            // 
            this.BtnAnalyzeGames.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAnalyzeGames.FlatAppearance.BorderSize = 0;
            this.BtnAnalyzeGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyzeGames.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnAnalyzeGames.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyzeGames.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnalyzeGames.Location = new System.Drawing.Point(6, 107);
            this.BtnAnalyzeGames.Name = "BtnAnalyzeGames";
            this.BtnAnalyzeGames.Size = new System.Drawing.Size(215, 36);
            this.BtnAnalyzeGames.TabIndex = 9;
            this.BtnAnalyzeGames.Text = "Analyze Games";
            this.BtnAnalyzeGames.UseVisualStyleBackColor = false;
            this.BtnAnalyzeGames.Click += new System.EventHandler(this.BtnAnalyzeGames_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ChkDiscord);
            this.groupBox4.Controls.Add(this.ChkBattleNet);
            this.groupBox4.Controls.Add(this.ChkSteam);
            this.groupBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 95);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Games";
            // 
            // ChkDiscord
            // 
            this.ChkDiscord.AutoSize = true;
            this.ChkDiscord.Checked = true;
            this.ChkDiscord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDiscord.Location = new System.Drawing.Point(6, 20);
            this.ChkDiscord.Name = "ChkDiscord";
            this.ChkDiscord.Size = new System.Drawing.Size(73, 20);
            this.ChkDiscord.TabIndex = 2;
            this.ChkDiscord.Text = "Discord";
            this.ChkDiscord.UseVisualStyleBackColor = true;
            // 
            // ChkBattleNet
            // 
            this.ChkBattleNet.AutoSize = true;
            this.ChkBattleNet.Checked = true;
            this.ChkBattleNet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBattleNet.Location = new System.Drawing.Point(6, 70);
            this.ChkBattleNet.Name = "ChkBattleNet";
            this.ChkBattleNet.Size = new System.Drawing.Size(89, 20);
            this.ChkBattleNet.TabIndex = 1;
            this.ChkBattleNet.Text = "Battle.net";
            this.ChkBattleNet.UseVisualStyleBackColor = true;
            // 
            // ChkSteam
            // 
            this.ChkSteam.AutoSize = true;
            this.ChkSteam.Checked = true;
            this.ChkSteam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSteam.Location = new System.Drawing.Point(6, 45);
            this.ChkSteam.Name = "ChkSteam";
            this.ChkSteam.Size = new System.Drawing.Size(67, 20);
            this.ChkSteam.TabIndex = 0;
            this.ChkSteam.Text = "Steam";
            this.ChkSteam.UseVisualStyleBackColor = true;
            // 
            // tPageDevelopment
            // 
            this.tPageDevelopment.Controls.Add(this.BtnAnalyzeDevelopment);
            this.tPageDevelopment.Controls.Add(this.GbxDevelopment);
            this.tPageDevelopment.Location = new System.Drawing.Point(4, 5);
            this.tPageDevelopment.Name = "tPageDevelopment";
            this.tPageDevelopment.Padding = new System.Windows.Forms.Padding(3);
            this.tPageDevelopment.Size = new System.Drawing.Size(761, 467);
            this.tPageDevelopment.TabIndex = 0;
            this.tPageDevelopment.UseVisualStyleBackColor = true;
            // 
            // BtnAnalyzeDevelopment
            // 
            this.BtnAnalyzeDevelopment.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAnalyzeDevelopment.FlatAppearance.BorderSize = 0;
            this.BtnAnalyzeDevelopment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyzeDevelopment.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnAnalyzeDevelopment.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyzeDevelopment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnalyzeDevelopment.Location = new System.Drawing.Point(12, 119);
            this.BtnAnalyzeDevelopment.Name = "BtnAnalyzeDevelopment";
            this.BtnAnalyzeDevelopment.Size = new System.Drawing.Size(209, 36);
            this.BtnAnalyzeDevelopment.TabIndex = 8;
            this.BtnAnalyzeDevelopment.Text = "Analyze Development";
            this.BtnAnalyzeDevelopment.UseVisualStyleBackColor = false;
            this.BtnAnalyzeDevelopment.Click += new System.EventHandler(this.BtnAnalyzeDevelopment_Click);
            // 
            // GbxDevelopment
            // 
            this.GbxDevelopment.Controls.Add(this.ChkAndroidStudio);
            this.GbxDevelopment.Controls.Add(this.ChkSqlServer);
            this.GbxDevelopment.Controls.Add(this.ChkVisualStudio);
            this.GbxDevelopment.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.GbxDevelopment.Location = new System.Drawing.Point(6, 6);
            this.GbxDevelopment.Name = "GbxDevelopment";
            this.GbxDevelopment.Size = new System.Drawing.Size(215, 107);
            this.GbxDevelopment.TabIndex = 0;
            this.GbxDevelopment.TabStop = false;
            this.GbxDevelopment.Text = "Development";
            // 
            // ChkAndroidStudio
            // 
            this.ChkAndroidStudio.AutoSize = true;
            this.ChkAndroidStudio.Checked = true;
            this.ChkAndroidStudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAndroidStudio.Location = new System.Drawing.Point(6, 20);
            this.ChkAndroidStudio.Name = "ChkAndroidStudio";
            this.ChkAndroidStudio.Size = new System.Drawing.Size(119, 20);
            this.ChkAndroidStudio.TabIndex = 2;
            this.ChkAndroidStudio.Text = "Android Studio";
            this.ChkAndroidStudio.UseVisualStyleBackColor = true;
            // 
            // ChkSqlServer
            // 
            this.ChkSqlServer.AutoSize = true;
            this.ChkSqlServer.Checked = true;
            this.ChkSqlServer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSqlServer.Location = new System.Drawing.Point(6, 70);
            this.ChkSqlServer.Name = "ChkSqlServer";
            this.ChkSqlServer.Size = new System.Drawing.Size(119, 20);
            this.ChkSqlServer.TabIndex = 1;
            this.ChkSqlServer.Text = "MS SQL Server";
            this.ChkSqlServer.UseVisualStyleBackColor = true;
            // 
            // ChkVisualStudio
            // 
            this.ChkVisualStudio.AutoSize = true;
            this.ChkVisualStudio.Checked = true;
            this.ChkVisualStudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkVisualStudio.Location = new System.Drawing.Point(6, 45);
            this.ChkVisualStudio.Name = "ChkVisualStudio";
            this.ChkVisualStudio.Size = new System.Drawing.Size(130, 20);
            this.ChkVisualStudio.TabIndex = 0;
            this.ChkVisualStudio.Text = "MS Visual Studio";
            this.ChkVisualStudio.UseVisualStyleBackColor = true;
            // 
            // tPageOthers
            // 
            this.tPageOthers.Location = new System.Drawing.Point(4, 5);
            this.tPageOthers.Name = "tPageOthers";
            this.tPageOthers.Size = new System.Drawing.Size(761, 467);
            this.tPageOthers.TabIndex = 2;
            this.tPageOthers.UseVisualStyleBackColor = true;
            // 
            // PbxGames
            // 
            this.PbxGames.Image = ((System.Drawing.Image)(resources.GetObject("PbxGames.Image")));
            this.PbxGames.Location = new System.Drawing.Point(346, 486);
            this.PbxGames.Name = "PbxGames";
            this.PbxGames.Size = new System.Drawing.Size(64, 64);
            this.PbxGames.TabIndex = 1;
            this.PbxGames.TabStop = false;
            this.PbxGames.Click += new System.EventHandler(this.PbxGames_Click);
            // 
            // PbxOffice
            // 
            this.PbxOffice.Image = ((System.Drawing.Image)(resources.GetObject("PbxOffice.Image")));
            this.PbxOffice.Location = new System.Drawing.Point(35, 486);
            this.PbxOffice.Name = "PbxOffice";
            this.PbxOffice.Size = new System.Drawing.Size(64, 64);
            this.PbxOffice.TabIndex = 0;
            this.PbxOffice.TabStop = false;
            this.PbxOffice.Click += new System.EventHandler(this.PbxOffice_Click);
            // 
            // tabPOptions
            // 
            this.tabPOptions.Controls.Add(this.GbxSettings);
            this.tabPOptions.Location = new System.Drawing.Point(4, 5);
            this.tabPOptions.Name = "tabPOptions";
            this.tabPOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPOptions.Size = new System.Drawing.Size(787, 576);
            this.tabPOptions.TabIndex = 20;
            this.tabPOptions.Text = "Options";
            this.tabPOptions.UseVisualStyleBackColor = true;
            // 
            // GbxSettings
            // 
            this.GbxSettings.Controls.Add(this.ChkDelOnlyWinTemp24);
            this.GbxSettings.Controls.Add(this.ChkRunPcStart);
            this.GbxSettings.Controls.Add(this.ChkClosePcClean);
            this.GbxSettings.Controls.Add(this.ChkMinSysTray);
            this.GbxSettings.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.GbxSettings.Location = new System.Drawing.Point(6, 6);
            this.GbxSettings.Name = "GbxSettings";
            this.GbxSettings.Size = new System.Drawing.Size(769, 137);
            this.GbxSettings.TabIndex = 3;
            this.GbxSettings.TabStop = false;
            this.GbxSettings.Text = "Settings";
            // 
            // ChkDelOnlyWinTemp24
            // 
            this.ChkDelOnlyWinTemp24.AutoSize = true;
            this.ChkDelOnlyWinTemp24.Location = new System.Drawing.Point(6, 45);
            this.ChkDelOnlyWinTemp24.Name = "ChkDelOnlyWinTemp24";
            this.ChkDelOnlyWinTemp24.Size = new System.Drawing.Size(419, 20);
            this.ChkDelOnlyWinTemp24.TabIndex = 3;
            this.ChkDelOnlyWinTemp24.Text = "Only delete files in Windows Temp folders older than 24 hours";
            this.ChkDelOnlyWinTemp24.UseVisualStyleBackColor = true;
            // 
            // ChkRunPcStart
            // 
            this.ChkRunPcStart.AutoSize = true;
            this.ChkRunPcStart.Location = new System.Drawing.Point(6, 20);
            this.ChkRunPcStart.Name = "ChkRunPcStart";
            this.ChkRunPcStart.Size = new System.Drawing.Size(332, 20);
            this.ChkRunPcStart.TabIndex = 0;
            this.ChkRunPcStart.Text = "Run Powered Cleaner when the computer starts";
            this.ChkRunPcStart.UseVisualStyleBackColor = true;
            this.ChkRunPcStart.CheckedChanged += new System.EventHandler(this.ChkRunPcStart_CheckedChanged);
            // 
            // ChkClosePcClean
            // 
            this.ChkClosePcClean.AutoSize = true;
            this.ChkClosePcClean.Location = new System.Drawing.Point(6, 95);
            this.ChkClosePcClean.Name = "ChkClosePcClean";
            this.ChkClosePcClean.Size = new System.Drawing.Size(209, 20);
            this.ChkClosePcClean.TabIndex = 2;
            this.ChkClosePcClean.Text = "Close program after cleaning";
            this.ChkClosePcClean.UseVisualStyleBackColor = true;
            // 
            // ChkMinSysTray
            // 
            this.ChkMinSysTray.AutoSize = true;
            this.ChkMinSysTray.Location = new System.Drawing.Point(6, 70);
            this.ChkMinSysTray.Name = "ChkMinSysTray";
            this.ChkMinSysTray.Size = new System.Drawing.Size(178, 20);
            this.ChkMinSysTray.TabIndex = 1;
            this.ChkMinSysTray.Text = "Minimize to System Tray";
            this.ChkMinSysTray.UseVisualStyleBackColor = true;
            // 
            // tabPAbout
            // 
            this.tabPAbout.Controls.Add(this.LblOtherProject);
            this.tabPAbout.Controls.Add(this.GuiLineSeparator2);
            this.tabPAbout.Controls.Add(this.GuiLineSeparator1);
            this.tabPAbout.Controls.Add(this.label9);
            this.tabPAbout.Controls.Add(this.label8);
            this.tabPAbout.Controls.Add(this.LinkLblWebSite);
            this.tabPAbout.Controls.Add(this.label7);
            this.tabPAbout.Controls.Add(this.label6);
            this.tabPAbout.Controls.Add(this.label5);
            this.tabPAbout.Controls.Add(this.PboxAttributeEditor);
            this.tabPAbout.Controls.Add(this.pBoxIcon);
            this.tabPAbout.Location = new System.Drawing.Point(4, 5);
            this.tabPAbout.Name = "tabPAbout";
            this.tabPAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPAbout.Size = new System.Drawing.Size(787, 576);
            this.tabPAbout.TabIndex = 10;
            this.tabPAbout.Text = "About";
            this.tabPAbout.UseVisualStyleBackColor = true;
            // 
            // LblOtherProject
            // 
            this.LblOtherProject.AutoSize = true;
            this.LblOtherProject.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.LblOtherProject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblOtherProject.Location = new System.Drawing.Point(81, 247);
            this.LblOtherProject.Name = "LblOtherProject";
            this.LblOtherProject.Size = new System.Drawing.Size(101, 16);
            this.LblOtherProject.TabIndex = 13;
            this.LblOtherProject.Text = "Other project :";
            // 
            // GuiLineSeparator2
            // 
            this.GuiLineSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GuiLineSeparator2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiLineSeparator2.Location = new System.Drawing.Point(84, 221);
            this.GuiLineSeparator2.Name = "GuiLineSeparator2";
            this.GuiLineSeparator2.Size = new System.Drawing.Size(358, 13);
            this.GuiLineSeparator2.TabIndex = 12;
            // 
            // GuiLineSeparator1
            // 
            this.GuiLineSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GuiLineSeparator1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiLineSeparator1.Location = new System.Drawing.Point(84, 146);
            this.GuiLineSeparator1.Name = "GuiLineSeparator1";
            this.GuiLineSeparator1.Size = new System.Drawing.Size(358, 13);
            this.GuiLineSeparator1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(81, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tanguy Lemarié";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(81, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Author :";
            // 
            // LinkLblWebSite
            // 
            this.LinkLblWebSite.AutoSize = true;
            this.LinkLblWebSite.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.LinkLblWebSite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LinkLblWebSite.Location = new System.Drawing.Point(81, 195);
            this.LinkLblWebSite.Name = "LinkLblWebSite";
            this.LinkLblWebSite.Size = new System.Drawing.Size(190, 16);
            this.LinkLblWebSite.TabIndex = 7;
            this.LinkLblWebSite.TabStop = true;
            this.LinkLblWebSite.Text = "tanguyonline.wordpress.com";
            this.LinkLblWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblWebSite_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(81, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Website :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(81, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "The tool you need";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(81, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Powered Cleaner 0.5\r\n(Build 19.02)";
            // 
            // PboxAttributeEditor
            // 
            this.PboxAttributeEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PboxAttributeEditor.Image = ((System.Drawing.Image)(resources.GetObject("PboxAttributeEditor.Image")));
            this.PboxAttributeEditor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PboxAttributeEditor.Location = new System.Drawing.Point(100, 283);
            this.PboxAttributeEditor.Name = "PboxAttributeEditor";
            this.PboxAttributeEditor.Size = new System.Drawing.Size(64, 64);
            this.PboxAttributeEditor.TabIndex = 10;
            this.PboxAttributeEditor.TabStop = false;
            // 
            // pBoxIcon
            // 
            this.pBoxIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pBoxIcon.Image")));
            this.pBoxIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pBoxIcon.Location = new System.Drawing.Point(6, 6);
            this.pBoxIcon.Name = "pBoxIcon";
            this.pBoxIcon.Size = new System.Drawing.Size(64, 64);
            this.pBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxIcon.TabIndex = 3;
            this.pBoxIcon.TabStop = false;
            // 
            // tabPData
            // 
            this.tabPData.Controls.Add(this.DtgData);
            this.tabPData.Location = new System.Drawing.Point(4, 5);
            this.tabPData.Name = "tabPData";
            this.tabPData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPData.Size = new System.Drawing.Size(787, 576);
            this.tabPData.TabIndex = 18;
            this.tabPData.Text = "Data";
            this.tabPData.UseVisualStyleBackColor = true;
            // 
            // DtgData
            // 
            this.DtgData.AllowUserToAddRows = false;
            this.DtgData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DtgData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DtgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgData.BackgroundColor = System.Drawing.Color.White;
            this.DtgData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn29});
            this.DtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgData.Location = new System.Drawing.Point(3, 3);
            this.DtgData.MultiSelect = false;
            this.DtgData.Name = "DtgData";
            this.DtgData.ReadOnly = true;
            this.DtgData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgData.Size = new System.Drawing.Size(781, 570);
            this.DtgData.TabIndex = 5;
            this.DtgData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DtgData_MouseClick);
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.FillWeight = 87F;
            this.dataGridViewTextBoxColumn19.HeaderText = "Description";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.FillWeight = 13F;
            this.dataGridViewTextBoxColumn29.HeaderText = "Size (KB)";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // pRam
            // 
            this.pRam.CategoryName = "Memory";
            this.pRam.CounterName = "% Committed Bytes In Use";
            // 
            // BgWorkCleaner
            // 
            this.BgWorkCleaner.WorkerReportsProgress = true;
            this.BgWorkCleaner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorkerCleaner_DoWork);
            this.BgWorkCleaner.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgWorkerCleaner_ProgressChanged);
            this.BgWorkCleaner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorkerCleaner_RunWorkerCompleted);
            // 
            // GuiTitle
            // 
            this.GuiTitle.AutoSize = true;
            this.GuiTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiTitle.ForeColor = System.Drawing.Color.White;
            this.GuiTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiTitle.Location = new System.Drawing.Point(95, 12);
            this.GuiTitle.Name = "GuiTitle";
            this.GuiTitle.Size = new System.Drawing.Size(110, 26);
            this.GuiTitle.TabIndex = 1;
            this.GuiTitle.Text = "Powered";
            // 
            // GuiVersion
            // 
            this.GuiVersion.AutoSize = true;
            this.GuiVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.GuiVersion.ForeColor = System.Drawing.Color.DarkGray;
            this.GuiVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiVersion.Location = new System.Drawing.Point(97, 39);
            this.GuiVersion.Name = "GuiVersion";
            this.GuiVersion.Size = new System.Drawing.Size(123, 16);
            this.GuiVersion.TabIndex = 2;
            this.GuiVersion.Text = "v 0.5 (Build 19.02)";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Brown;
            this.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelHeader.Controls.Add(this.pBoxEnglish);
            this.PanelHeader.Controls.Add(this.pBoxFrench);
            this.PanelHeader.Controls.Add(this.pBoxUpdate);
            this.PanelHeader.Controls.Add(this.GuiTitle2);
            this.PanelHeader.Controls.Add(this.LblCheckUpdates);
            this.PanelHeader.Controls.Add(this.GuiVersion);
            this.PanelHeader.Controls.Add(this.GuiTitle);
            this.PanelHeader.Controls.Add(this.PboxLogo);
            this.PanelHeader.Location = new System.Drawing.Point(-6, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(977, 71);
            this.PanelHeader.TabIndex = 5;
            // 
            // pBoxEnglish
            // 
            this.pBoxEnglish.Image = ((System.Drawing.Image)(resources.GetObject("pBoxEnglish.Image")));
            this.pBoxEnglish.Location = new System.Drawing.Point(890, 11);
            this.pBoxEnglish.Name = "pBoxEnglish";
            this.pBoxEnglish.Size = new System.Drawing.Size(32, 32);
            this.pBoxEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxEnglish.TabIndex = 6;
            this.pBoxEnglish.TabStop = false;
            this.pBoxEnglish.Click += new System.EventHandler(this.pBoxEnglish_Click);
            // 
            // pBoxFrench
            // 
            this.pBoxFrench.Image = ((System.Drawing.Image)(resources.GetObject("pBoxFrench.Image")));
            this.pBoxFrench.Location = new System.Drawing.Point(835, 11);
            this.pBoxFrench.Name = "pBoxFrench";
            this.pBoxFrench.Size = new System.Drawing.Size(32, 32);
            this.pBoxFrench.TabIndex = 0;
            this.pBoxFrench.TabStop = false;
            this.pBoxFrench.Click += new System.EventHandler(this.pBoxFrench_Click);
            // 
            // pBoxUpdate
            // 
            this.pBoxUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pBoxUpdate.Image")));
            this.pBoxUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pBoxUpdate.Location = new System.Drawing.Point(949, 46);
            this.pBoxUpdate.Name = "pBoxUpdate";
            this.pBoxUpdate.Size = new System.Drawing.Size(16, 16);
            this.pBoxUpdate.TabIndex = 5;
            this.pBoxUpdate.TabStop = false;
            this.pBoxUpdate.Visible = false;
            // 
            // GuiTitle2
            // 
            this.GuiTitle2.AutoSize = true;
            this.GuiTitle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiTitle2.ForeColor = System.Drawing.Color.DarkOrange;
            this.GuiTitle2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuiTitle2.Location = new System.Drawing.Point(197, 12);
            this.GuiTitle2.Name = "GuiTitle2";
            this.GuiTitle2.Size = new System.Drawing.Size(101, 26);
            this.GuiTitle2.TabIndex = 4;
            this.GuiTitle2.Text = "Cleaner";
            // 
            // LblCheckUpdates
            // 
            this.LblCheckUpdates.AutoSize = true;
            this.LblCheckUpdates.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.LblCheckUpdates.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblCheckUpdates.LinkColor = System.Drawing.Color.Gainsboro;
            this.LblCheckUpdates.Location = new System.Drawing.Point(818, 46);
            this.LblCheckUpdates.Name = "LblCheckUpdates";
            this.LblCheckUpdates.Size = new System.Drawing.Size(123, 16);
            this.LblCheckUpdates.TabIndex = 3;
            this.LblCheckUpdates.TabStop = true;
            this.LblCheckUpdates.Text = "Check for updates";
            this.LblCheckUpdates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblCheckUpdates_LinkClicked);
            // 
            // PboxLogo
            // 
            this.PboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PboxLogo.Image")));
            this.PboxLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PboxLogo.Location = new System.Drawing.Point(21, 2);
            this.PboxLogo.Name = "PboxLogo";
            this.PboxLogo.Size = new System.Drawing.Size(64, 64);
            this.PboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PboxLogo.TabIndex = 0;
            this.PboxLogo.TabStop = false;
            // 
            // BgWorkGeneral
            // 
            this.BgWorkGeneral.WorkerReportsProgress = true;
            this.BgWorkGeneral.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorkerSystemInfo_DoWork);
            this.BgWorkGeneral.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgWorkerSystemInfo_ProgressChanged);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Firebrick;
            this.MenuPanel.Controls.Add(this.BtnAbout);
            this.MenuPanel.Controls.Add(this.BtnAdvanced);
            this.MenuPanel.Controls.Add(this.BtnOptions);
            this.MenuPanel.Controls.Add(this.BtnTools);
            this.MenuPanel.Controls.Add(this.BtnWebBrowser);
            this.MenuPanel.Controls.Add(this.BtnWinExplorer);
            this.MenuPanel.Controls.Add(this.BtnSystem);
            this.MenuPanel.Controls.Add(this.BtnDashboard);
            this.MenuPanel.Location = new System.Drawing.Point(-2, 71);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(153, 590);
            this.MenuPanel.TabIndex = 7;
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.Firebrick;
            this.BtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnAbout.ForeColor = System.Drawing.Color.White;
            this.BtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbout.Image")));
            this.BtnAbout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAbout.Location = new System.Drawing.Point(0, 525);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(153, 67);
            this.BtnAbout.TabIndex = 7;
            this.BtnAbout.Text = "ABOUT";
            this.BtnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnAdvanced
            // 
            this.BtnAdvanced.BackColor = System.Drawing.Color.Firebrick;
            this.BtnAdvanced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAdvanced.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdvanced.FlatAppearance.BorderSize = 0;
            this.BtnAdvanced.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BtnAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdvanced.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnAdvanced.ForeColor = System.Drawing.Color.White;
            this.BtnAdvanced.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdvanced.Image")));
            this.BtnAdvanced.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAdvanced.Location = new System.Drawing.Point(0, 450);
            this.BtnAdvanced.Name = "BtnAdvanced";
            this.BtnAdvanced.Size = new System.Drawing.Size(153, 75);
            this.BtnAdvanced.TabIndex = 6;
            this.BtnAdvanced.Text = "ADVANCED";
            this.BtnAdvanced.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAdvanced.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAdvanced.UseVisualStyleBackColor = false;
            this.BtnAdvanced.Click += new System.EventHandler(this.BtnAdvanced_Click);
            // 
            // BtnOptions
            // 
            this.BtnOptions.BackColor = System.Drawing.Color.Firebrick;
            this.BtnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOptions.FlatAppearance.BorderSize = 0;
            this.BtnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BtnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnOptions.ForeColor = System.Drawing.Color.White;
            this.BtnOptions.Image = global::Powered_Cleaner.Properties.Resources.menu_options;
            this.BtnOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnOptions.Location = new System.Drawing.Point(0, 375);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(153, 75);
            this.BtnOptions.TabIndex = 5;
            this.BtnOptions.Text = "OPTIONS";
            this.BtnOptions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnOptions.UseVisualStyleBackColor = false;
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // BtnTools
            // 
            this.BtnTools.BackColor = System.Drawing.Color.Firebrick;
            this.BtnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTools.FlatAppearance.BorderSize = 0;
            this.BtnTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BtnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTools.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnTools.ForeColor = System.Drawing.Color.White;
            this.BtnTools.Image = ((System.Drawing.Image)(resources.GetObject("BtnTools.Image")));
            this.BtnTools.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnTools.Location = new System.Drawing.Point(0, 300);
            this.BtnTools.Name = "BtnTools";
            this.BtnTools.Size = new System.Drawing.Size(153, 75);
            this.BtnTools.TabIndex = 4;
            this.BtnTools.Text = "APPLICATIONS";
            this.BtnTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTools.UseVisualStyleBackColor = false;
            this.BtnTools.Click += new System.EventHandler(this.BtnTools_Click);
            // 
            // BtnWebBrowser
            // 
            this.BtnWebBrowser.BackColor = System.Drawing.Color.Firebrick;
            this.BtnWebBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnWebBrowser.FlatAppearance.BorderSize = 0;
            this.BtnWebBrowser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BtnWebBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWebBrowser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnWebBrowser.ForeColor = System.Drawing.Color.White;
            this.BtnWebBrowser.Image = global::Powered_Cleaner.Properties.Resources.menu_webBrowser;
            this.BtnWebBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnWebBrowser.Location = new System.Drawing.Point(0, 225);
            this.BtnWebBrowser.Name = "BtnWebBrowser";
            this.BtnWebBrowser.Size = new System.Drawing.Size(153, 75);
            this.BtnWebBrowser.TabIndex = 3;
            this.BtnWebBrowser.Text = "WEB BROWSER";
            this.BtnWebBrowser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnWebBrowser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnWebBrowser.UseVisualStyleBackColor = false;
            this.BtnWebBrowser.Click += new System.EventHandler(this.BtnGoogleChrome_Click);
            // 
            // BtnWinExplorer
            // 
            this.BtnWinExplorer.BackColor = System.Drawing.Color.Firebrick;
            this.BtnWinExplorer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnWinExplorer.FlatAppearance.BorderSize = 0;
            this.BtnWinExplorer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BtnWinExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWinExplorer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnWinExplorer.ForeColor = System.Drawing.Color.White;
            this.BtnWinExplorer.Image = ((System.Drawing.Image)(resources.GetObject("BtnWinExplorer.Image")));
            this.BtnWinExplorer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnWinExplorer.Location = new System.Drawing.Point(0, 150);
            this.BtnWinExplorer.Name = "BtnWinExplorer";
            this.BtnWinExplorer.Size = new System.Drawing.Size(153, 75);
            this.BtnWinExplorer.TabIndex = 2;
            this.BtnWinExplorer.Text = "WINDOWS EXPLORER";
            this.BtnWinExplorer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnWinExplorer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnWinExplorer.UseVisualStyleBackColor = false;
            this.BtnWinExplorer.Click += new System.EventHandler(this.BtnWinExplorer_Click);
            // 
            // BtnSystem
            // 
            this.BtnSystem.BackColor = System.Drawing.Color.Firebrick;
            this.BtnSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSystem.FlatAppearance.BorderSize = 0;
            this.BtnSystem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BtnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSystem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnSystem.ForeColor = System.Drawing.Color.White;
            this.BtnSystem.Image = ((System.Drawing.Image)(resources.GetObject("BtnSystem.Image")));
            this.BtnSystem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSystem.Location = new System.Drawing.Point(0, 75);
            this.BtnSystem.Name = "BtnSystem";
            this.BtnSystem.Size = new System.Drawing.Size(153, 75);
            this.BtnSystem.TabIndex = 1;
            this.BtnSystem.Text = "SYSTEM";
            this.BtnSystem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSystem.UseVisualStyleBackColor = false;
            this.BtnSystem.Click += new System.EventHandler(this.BtnSystem_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 0);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(153, 75);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.Text = "DASHBOARD";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BgWorkAnalysis
            // 
            this.BgWorkAnalysis.WorkerReportsProgress = true;
            this.BgWorkAnalysis.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorkerAnalysis_DoWork);
            this.BgWorkAnalysis.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgWorkerAnalysis_ProgressChanged);
            this.BgWorkAnalysis.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorkerAnalysis_RunWorkerCompleted);
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.ContextMenuStrip = this.CmsNotifyIcon;
            this.myNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotifyIcon.Icon")));
            this.myNotifyIcon.Text = "Powered Cleaner";
            this.myNotifyIcon.DoubleClick += new System.EventHandler(this.myNotifyIcon_DoubleClick);
            // 
            // CmsNotifyIcon
            // 
            this.CmsNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPoweredCleanerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.AnalyzeMenuItem,
            this.RunCleanerMenuItem,
            this.toolStripMenuItem2,
            this.optionsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.CmsNotifyIcon.Name = "CmsNotifyIcon";
            this.CmsNotifyIcon.Size = new System.Drawing.Size(203, 126);
            // 
            // openPoweredCleanerToolStripMenuItem
            // 
            this.openPoweredCleanerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPoweredCleanerToolStripMenuItem.Name = "openPoweredCleanerToolStripMenuItem";
            this.openPoweredCleanerToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openPoweredCleanerToolStripMenuItem.Text = "Open Powered Cleaner...";
            this.openPoweredCleanerToolStripMenuItem.Click += new System.EventHandler(this.openPoweredCleanerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // AnalyzeMenuItem
            // 
            this.AnalyzeMenuItem.Name = "AnalyzeMenuItem";
            this.AnalyzeMenuItem.Size = new System.Drawing.Size(202, 22);
            this.AnalyzeMenuItem.Text = "Analyze";
            this.AnalyzeMenuItem.Click += new System.EventHandler(this.AnalyzeMenuItem_Click);
            // 
            // RunCleanerMenuItem
            // 
            this.RunCleanerMenuItem.Name = "RunCleanerMenuItem";
            this.RunCleanerMenuItem.Size = new System.Drawing.Size(202, 22);
            this.RunCleanerMenuItem.Text = "Run Cleaner";
            this.RunCleanerMenuItem.Visible = false;
            this.RunCleanerMenuItem.Click += new System.EventHandler(this.RunCleanerMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // BgWorkAnalyze
            // 
            this.BgWorkAnalyze.WorkerReportsProgress = true;
            this.BgWorkAnalyze.WorkerSupportsCancellation = true;
            this.BgWorkAnalyze.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorkSystem_DoWork);
            this.BgWorkAnalyze.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgWorkSystem_ProgressChanged);
            this.BgWorkAnalyze.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorkSystem_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 661);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.myTabCtrllMain);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(980, 700);
            this.MinimumSize = new System.Drawing.Size(980, 700);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Powered Cleaner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.myTabCtrllMain.ResumeLayout(false);
            this.tPDashboard.ResumeLayout(false);
            this.tPDashboard.PerformLayout();
            this.pnlRam.ResumeLayout(false);
            this.pnlRam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgress)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.GbxAnalyze.ResumeLayout(false);
            this.GbxAnalyze.PerformLayout();
            this.CmsAnalyze.ResumeLayout(false);
            this.GbxDetailsFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgAnalyze)).EndInit();
            this.tabPSystem.ResumeLayout(false);
            this.tabPSystem.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GbxSystemInformation.ResumeLayout(false);
            this.tlpSystemInfo.ResumeLayout(false);
            this.tlpSystemInfo.PerformLayout();
            this.GbxAnalyzeSystem.ResumeLayout(false);
            this.GbxAnalyzeSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPWinExplorer.ResumeLayout(false);
            this.tabPWinExplorer.PerformLayout();
            this.GbxAnalyzeWinExplorer.ResumeLayout(false);
            this.GbxAnalyzeWinExplorer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWinExplorer)).EndInit();
            this.tabPWebBrowser.ResumeLayout(false);
            this.pnlOpera.ResumeLayout(false);
            this.pnlOpera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxOpera)).EndInit();
            this.GbxAnalyzeOpera.ResumeLayout(false);
            this.GbxAnalyzeOpera.PerformLayout();
            this.pnlFirefox.ResumeLayout(false);
            this.pnlFirefox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxFirefox)).EndInit();
            this.GbxAnalyzeFirefox.ResumeLayout(false);
            this.GbxAnalyzeFirefox.PerformLayout();
            this.pnlChrome.ResumeLayout(false);
            this.pnlChrome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxChrome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAnalysisChrome)).EndInit();
            this.GbxAnalyzeChrome.ResumeLayout(false);
            this.GbxAnalyzeChrome.PerformLayout();
            this.tabPAdvanced.ResumeLayout(false);
            this.tabPAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLoadingAnalysis)).EndInit();
            this.GbxWinUpdate.ResumeLayout(false);
            this.GbxWinUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWinUpdate)).EndInit();
            this.tabPApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxDevelopment)).EndInit();
            this.tCtrlApplications.ResumeLayout(false);
            this.tPageBureautique.ResumeLayout(false);
            this.GbxOffice.ResumeLayout(false);
            this.GbxOffice.PerformLayout();
            this.tPageGames.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tPageDevelopment.ResumeLayout(false);
            this.GbxDevelopment.ResumeLayout(false);
            this.GbxDevelopment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxOffice)).EndInit();
            this.tabPOptions.ResumeLayout(false);
            this.GbxSettings.ResumeLayout(false);
            this.GbxSettings.PerformLayout();
            this.tabPAbout.ResumeLayout(false);
            this.tabPAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxAttributeEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).EndInit();
            this.tabPData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFrench)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.CmsNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnAnalyser;
        private Button BtnClean;
        private TabControl myTabCtrllMain;
        private TabPage tPDashboard;
        private GroupBox GbxDetailsFiles;
        private Label LblAnalysisProgress;
        private Label LblSizeToBeRemoved;
        private Label LblTotalSize;
        private Label LblFreeSpace;
        private CircularProgressBar.CircularProgressBar CpgbDisk;
        private Label GuiStockage;
        private Timer myTimer;
        private CircularProgressBar.CircularProgressBar CpgbRam;
        private System.Diagnostics.PerformanceCounter pRam;
        private Label GuiRAM;
        private Label LblUsedRam;
        private Label LblTotalRAM;
        private Button BtnCleanRecycleBin;
        private TabPage tabPWebBrowser;
        private PictureBox PboxChrome;
        private Label GuiChrome;
        private TabPage tabPSystem;
        private Label GuiSystem;
        private PictureBox pictureBox2;
        private Button BtnAnalyzeChrome;
        private Button BtnAnalyseSystem;
        private Label LblChromeVersion;
        private GroupBox GbxAnalyze;
        private GroupBox GbxAnalyzeChrome;
        private CheckBox ChkChromeUpdates;
        private CheckBox ChkChromeDLHist;
        private CheckBox ChkChromeHist;
        private CheckBox ChkChromeCache;
        private GroupBox GbxAnalyzeSystem;
        private CheckBox ChkMemDumps;
        private CheckBox ChkClipboard;
        private CheckBox ChkTempFiles;
        private TabPage tabPWinExplorer;
        private Label GuiWinExplorer;
        private PictureBox PBoxWinExplorer;
        private GroupBox GbxAnalyzeWinExplorer;
        private CheckBox ChkRecentDocuments;
        private CheckBox ChkWinErrorReporting;
        private ProgressBar PgbAnalyze;
        private System.ComponentModel.BackgroundWorker BgWorkCleaner;
        private Button BtnAnalyzeWinExplorer;
        private ContextMenuStrip CmsAnalyze;
        private ToolStripMenuItem anaylzeToolStripMenuItem;
        private TabPage tabPAbout;
        private PictureBox pBoxIcon;
        private Label label5;
        private Label label6;
        private LinkLabel LinkLblWebSite;
        private Label label7;
        private Label label9;
        private Label label8;
        private CheckBox ChkThumbnailCache;
        private PictureBox PboxLogo;
        private Label GuiTitle;
        private Label GuiVersion;
        private Panel PanelHeader;
        private GroupBox GbxSystemInformation;
        private TableLayoutPanel tlpSystemInfo;
        private TextBox TbxOSType;
        private Label GUIProcessor;
        private TextBox TbxAudioDevice;
        private Label GUISystemName;
        private TextBox TbxManufacturer;
        private Label GUIVideoController;
        private TextBox TbxBIOS;
        private Label GUIHDD;
        private TextBox TbxModel;
        private Label GuiMemory;
        private TextBox TbxOSVersion;
        private Label GUIOSVersion;
        private TextBox TbxHDD;
        private Label GUIOSType;
        private TextBox TbxRAM;
        private Label GUIModel;
        private TextBox TbxVideoController;
        private Label GUIBIOS;
        private TextBox TbxProcesseur;
        private Label GUIAudioDevice;
        private TextBox TbxDesktopName;
        private Label GUIManufacturer;
        private Button BtnViewMore;
        private GroupBox GbxAnalyzeFirefox;
        private CheckBox ChkFirefoxDLHist;
        private CheckBox ChkFirefoxHist;
        private CheckBox ChkFirefoxCache;
        private Label LblFirefoxVersion;
        private Label GuiFirefox;
        private PictureBox PboxFirefox;
        private Button BtnAnalyzeFirefox;
        private Button BtnAnalyzeEdge;
        private GroupBox groupBox3;
        private CheckBox ChkEdgeSession;
        private CheckBox ChkEdgeDLHist;
        private CheckBox ChkEdgeWebHist;
        private CheckBox ChkEdgeWebCache;
        private Label GuiEdge;
        private PictureBox PboxEdge;
        private DataGridView DtgAnalyze;
        private Button BtnAnalyzeOpera;
        private GroupBox GbxAnalyzeOpera;
        private CheckBox ChkOperaSession;
        private CheckBox ChkOperaDLHist;
        private CheckBox ChkOperaHist;
        private CheckBox ChkOperaCache;
        private Label LblOperaVersion;
        private Label GuiOpera;
        private PictureBox PboxOpera;
        private System.ComponentModel.BackgroundWorker BgWorkGeneral;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn Files;
        private Button BtnDashboard;
        private Button BtnWinExplorer;
        private Button BtnWebBrowser;
        private Button BtnTools;
        private Button BtnOptions;
        private Button BtnAdvanced;
        private Button BtnAbout;
        private Panel MenuPanel;
        private LinkLabel LblCheckUpdates;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LblSlash;
        private System.ComponentModel.BackgroundWorker BgWorkAnalysis;
        private TabPage tabPData;
        private Label GuiTitle2;
        private PictureBox PboxAttributeEditor;
        private Label GuiLineSeparator1;
        private Label LblOtherProject;
        private Label GuiLineSeparator2;
        private TabPage tabPAdvanced;
        private PictureBox PBoxWinUpdate;
        private Label GuiWinUpdate;
        private Button BtnAnalyzeWindows;
        private GroupBox GbxWinUpdate;
        private CheckBox ChkWinUpdate;
        private PictureBox pBoxUpdate;
        private PictureBox pBoxLoadingAnalysis;
        private PictureBox pBoxAnalysisChrome;
        private PictureBox pBoxProgress;
        private NotifyIcon myNotifyIcon;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private TabPage tabPOptions;
        private GroupBox GbxSettings;
        private ContextMenuStrip CmsNotifyIcon;
        private ToolStripMenuItem openPoweredCleanerToolStripMenuItem;
        private ToolStripMenuItem RunCleanerMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem AnalyzeMenuItem;
        private PictureBox pBoxFrench;
        private PictureBox pBoxEnglish;
        private TabPage tabPApplications;
        public CheckBox ChkRunPcStart;
        public CheckBox ChkMinSysTray;
        public CheckBox ChkClosePcClean;
        public CheckBox ChkDelOnlyWinTemp24;
        private CheckBox ChkChrome;
        private CheckBox ChkSystem;
        private CheckBox ChkWinExplorer;
        private CheckBox ChkEdge;
        private CheckBox ChkFirefox;
        private CheckBox ChkOpera;
        private Label LblPercPgb;
        private CheckBox ChkApplications;
        private DataGridView DtgData;
        private System.ComponentModel.BackgroundWorker BgWorkAnalyze;
        private CheckBox ChkWinLogs;
        private CheckBox ChkDownloadedInstall;
        private CheckBox ChkWinInstaller;
        private TabControl tCtrlApplications;
        private TabPage tPageDevelopment;
        private TabPage tPageBureautique;
        private TabPage tPageOthers;
        private TabPage tPageGames;
        private CheckBox ChkJumpLists;
        private PictureBox PbxDevelopment;
        private PictureBox PbxGames;
        private PictureBox PbxOffice;
        private Panel pnlChrome;
        private Panel pnlOpera;
        private Panel pnlFirefox;
        private GroupBox GbxDevelopment;
        private CheckBox ChkVisualStudio;
        private CheckBox ChkSqlServer;
        private CheckBox ChkAndroidStudio;
        private Button BtnAnalyzeDevelopment;
        private GroupBox GbxOffice;
        private CheckBox ChkOffice;
        private CheckBox ChkVlcMediaPlayer;
        private CheckBox ChkAdobeReader;
        private CheckBox ChkDropbox;
        private GroupBox groupBox4;
        private CheckBox ChkDiscord;
        private CheckBox ChkBattleNet;
        private CheckBox ChkSteam;
        private Button BtnAnalyzeOffice;
        private Button BtnAnalyzeGames;
        private Panel pnlRam;
        private CheckBox ChkChromeExtDb;
        private CheckBox ChkChromeCrashReports;
        private CheckBox ChkFirefoxStartupCache;
        private CheckBox ChkFirefoxHTML5Storage;
        private Button BtnSystem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
    }
}

