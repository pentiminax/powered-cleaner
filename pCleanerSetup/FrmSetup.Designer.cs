namespace pCleanerSetup
{
    partial class FrmSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetup));
            this.GuiCenter = new System.Windows.Forms.Label();
            this.CbxLanguage = new System.Windows.Forms.ComboBox();
            this.BtnInstaller = new System.Windows.Forms.Button();
            this.ChkDesktop = new System.Windows.Forms.CheckBox();
            this.ChkMenuDemarrer = new System.Windows.Forms.CheckBox();
            this.Copyright = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbxPath = new System.Windows.Forms.TextBox();
            this.BtnChoosePath = new System.Windows.Forms.Button();
            this.Fdb = new System.Windows.Forms.FolderBrowserDialog();
            this.pBoxIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // GuiCenter
            // 
            this.GuiCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GuiCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiCenter.Location = new System.Drawing.Point(0, 0);
            this.GuiCenter.Name = "GuiCenter";
            this.GuiCenter.Size = new System.Drawing.Size(824, 461);
            this.GuiCenter.TabIndex = 2;
            this.GuiCenter.Text = "Bienvenue dans l\'installateur de Powered Cleaner v0.4";
            this.GuiCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxLanguage
            // 
            this.CbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxLanguage.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxLanguage.FormattingEnabled = true;
            this.CbxLanguage.Items.AddRange(new object[] {
            "Français",
            "English"});
            this.CbxLanguage.Location = new System.Drawing.Point(694, 13);
            this.CbxLanguage.Name = "CbxLanguage";
            this.CbxLanguage.Size = new System.Drawing.Size(119, 24);
            this.CbxLanguage.TabIndex = 4;
            // 
            // BtnInstaller
            // 
            this.BtnInstaller.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnInstaller.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnInstaller.FlatAppearance.BorderSize = 0;
            this.BtnInstaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstaller.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstaller.ForeColor = System.Drawing.Color.White;
            this.BtnInstaller.Location = new System.Drawing.Point(328, 267);
            this.BtnInstaller.Name = "BtnInstaller";
            this.BtnInstaller.Size = new System.Drawing.Size(202, 42);
            this.BtnInstaller.TabIndex = 5;
            this.BtnInstaller.Text = "Installer";
            this.BtnInstaller.UseVisualStyleBackColor = false;
            this.BtnInstaller.Click += new System.EventHandler(this.BtnInstaller_Click);
            // 
            // ChkDesktop
            // 
            this.ChkDesktop.AutoSize = true;
            this.ChkDesktop.Checked = true;
            this.ChkDesktop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDesktop.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkDesktop.Location = new System.Drawing.Point(318, 355);
            this.ChkDesktop.Name = "ChkDesktop";
            this.ChkDesktop.Size = new System.Drawing.Size(229, 20);
            this.ChkDesktop.TabIndex = 6;
            this.ChkDesktop.Text = "Créer un raccourci sur le bureau";
            this.ChkDesktop.UseVisualStyleBackColor = true;
            // 
            // ChkMenuDemarrer
            // 
            this.ChkMenuDemarrer.AutoSize = true;
            this.ChkMenuDemarrer.Checked = true;
            this.ChkMenuDemarrer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkMenuDemarrer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMenuDemarrer.Location = new System.Drawing.Point(318, 382);
            this.ChkMenuDemarrer.Name = "ChkMenuDemarrer";
            this.ChkMenuDemarrer.Size = new System.Drawing.Size(292, 20);
            this.ChkMenuDemarrer.TabIndex = 7;
            this.ChkMenuDemarrer.Text = "Créer un raccourci dans le Menu Démarrer";
            this.ChkMenuDemarrer.UseVisualStyleBackColor = true;
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.ForeColor = System.Drawing.Color.White;
            this.Copyright.Location = new System.Drawing.Point(658, 4);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(160, 16);
            this.Copyright.TabIndex = 8;
            this.Copyright.Text = "© Tanguy Lemarié 2018";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.Copyright);
            this.panel1.Location = new System.Drawing.Point(-1, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 25);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 5);
            this.panel2.TabIndex = 10;
            // 
            // TbxPath
            // 
            this.TbxPath.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPath.Location = new System.Drawing.Point(221, 319);
            this.TbxPath.Name = "TbxPath";
            this.TbxPath.Size = new System.Drawing.Size(381, 26);
            this.TbxPath.TabIndex = 11;
            this.TbxPath.Text = "C:\\Program Files\\Powered Cleaner";
            // 
            // BtnChoosePath
            // 
            this.BtnChoosePath.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnChoosePath.FlatAppearance.BorderSize = 0;
            this.BtnChoosePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChoosePath.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnChoosePath.ForeColor = System.Drawing.Color.White;
            this.BtnChoosePath.Location = new System.Drawing.Point(610, 319);
            this.BtnChoosePath.Name = "BtnChoosePath";
            this.BtnChoosePath.Size = new System.Drawing.Size(86, 26);
            this.BtnChoosePath.TabIndex = 12;
            this.BtnChoosePath.Text = "Parcourir";
            this.BtnChoosePath.UseVisualStyleBackColor = false;
            this.BtnChoosePath.Click += new System.EventHandler(this.BtnChoosePath_Click);
            // 
            // pBoxIcon
            // 
            this.pBoxIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxIcon.Image = global::pCleanerSetup.Properties.Resources.pc_logo256x256;
            this.pBoxIcon.Location = new System.Drawing.Point(14, 13);
            this.pBoxIcon.Name = "pBoxIcon";
            this.pBoxIcon.Size = new System.Drawing.Size(146, 136);
            this.pBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxIcon.TabIndex = 3;
            this.pBoxIcon.TabStop = false;
            // 
            // FrmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.BtnChoosePath);
            this.Controls.Add(this.TbxPath);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChkMenuDemarrer);
            this.Controls.Add(this.ChkDesktop);
            this.Controls.Add(this.BtnInstaller);
            this.Controls.Add(this.CbxLanguage);
            this.Controls.Add(this.pBoxIcon);
            this.Controls.Add(this.GuiCenter);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(840, 500);
            this.Name = "FrmSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Powered Cleaner Installer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GuiCenter;
        private System.Windows.Forms.PictureBox pBoxIcon;
        private System.Windows.Forms.ComboBox CbxLanguage;
        private System.Windows.Forms.Button BtnInstaller;
        private System.Windows.Forms.CheckBox ChkDesktop;
        private System.Windows.Forms.CheckBox ChkMenuDemarrer;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TbxPath;
        private System.Windows.Forms.Button BtnChoosePath;
        private System.Windows.Forms.FolderBrowserDialog Fdb;
    }
}

