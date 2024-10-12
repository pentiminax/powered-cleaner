namespace pCleanerUninst
{
    partial class FrmUninst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUninst));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pBoxIcon = new System.Windows.Forms.PictureBox();
            this.BtnInstaller = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Copyright = new System.Windows.Forms.Label();
            this.CbxLanguage = new System.Windows.Forms.ComboBox();
            this.GuiCenter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 5);
            this.panel2.TabIndex = 11;
            // 
            // pBoxIcon
            // 
            this.pBoxIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxIcon.Image = global::pCleanerUninst.Properties.Resources.pc_logo256x256;
            this.pBoxIcon.Location = new System.Drawing.Point(14, 13);
            this.pBoxIcon.Name = "pBoxIcon";
            this.pBoxIcon.Size = new System.Drawing.Size(146, 136);
            this.pBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxIcon.TabIndex = 12;
            this.pBoxIcon.TabStop = false;
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
            this.BtnInstaller.MaximumSize = new System.Drawing.Size(202, 42);
            this.BtnInstaller.MinimumSize = new System.Drawing.Size(202, 42);
            this.BtnInstaller.Name = "BtnInstaller";
            this.BtnInstaller.Size = new System.Drawing.Size(202, 42);
            this.BtnInstaller.TabIndex = 13;
            this.BtnInstaller.Text = "Désinstaller";
            this.BtnInstaller.UseVisualStyleBackColor = false;
            this.BtnInstaller.Click += new System.EventHandler(this.BtnInstaller_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.Copyright);
            this.panel1.Location = new System.Drawing.Point(1, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 25);
            this.panel1.TabIndex = 14;
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.Copyright.ForeColor = System.Drawing.Color.White;
            this.Copyright.Location = new System.Drawing.Point(658, 4);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(160, 16);
            this.Copyright.TabIndex = 8;
            this.Copyright.Text = "© Tanguy Lemarié 2018";
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
            this.CbxLanguage.TabIndex = 15;
            // 
            // GuiCenter
            // 
            this.GuiCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GuiCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiCenter.Location = new System.Drawing.Point(0, 0);
            this.GuiCenter.Name = "GuiCenter";
            this.GuiCenter.Size = new System.Drawing.Size(824, 461);
            this.GuiCenter.TabIndex = 16;
            this.GuiCenter.Text = "Nous sommes désolé de vous voir partir";
            this.GuiCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmUninst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.CbxLanguage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnInstaller);
            this.Controls.Add(this.pBoxIcon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GuiCenter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUninst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Powered Cleaner Uninstaller";
            this.Load += new System.EventHandler(this.FrmUninst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pBoxIcon;
        private System.Windows.Forms.Button BtnInstaller;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.ComboBox CbxLanguage;
        private System.Windows.Forms.Label GuiCenter;
    }
}

