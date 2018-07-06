namespace NatCrafter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pageInventaire = new System.Windows.Forms.TabPage();
            this.pageMateriaux = new System.Windows.Forms.TabPage();
            this.flpMaterial = new System.Windows.Forms.FlowLayoutPanel();
            this.pageCraft = new System.Windows.Forms.TabPage();
            this.pageForce = new System.Windows.Forms.TabPage();
            this.pageStatistique = new System.Windows.Forms.TabPage();
            this.ImageListPages = new System.Windows.Forms.ImageList(this.components);
            this.picTop = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.pageMateriaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.picTop);
            this.pnlTop.Controls.Add(this.lblTimer);
            this.pnlTop.Location = new System.Drawing.Point(13, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1039, 74);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(785, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(239, 29);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Temps Restant : 5:00";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pageInventaire);
            this.tabMain.Controls.Add(this.pageMateriaux);
            this.tabMain.Controls.Add(this.pageCraft);
            this.tabMain.Controls.Add(this.pageForce);
            this.tabMain.Controls.Add(this.pageStatistique);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.ImageList = this.ImageListPages;
            this.tabMain.Location = new System.Drawing.Point(13, 92);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1039, 507);
            this.tabMain.TabIndex = 0;
            // 
            // pageInventaire
            // 
            this.pageInventaire.Location = new System.Drawing.Point(4, 57);
            this.pageInventaire.Name = "pageInventaire";
            this.pageInventaire.Size = new System.Drawing.Size(1031, 446);
            this.pageInventaire.TabIndex = 2;
            this.pageInventaire.Text = "Inventaire";
            this.pageInventaire.UseVisualStyleBackColor = true;
            // 
            // pageMateriaux
            // 
            this.pageMateriaux.Controls.Add(this.flpMaterial);
            this.pageMateriaux.ImageIndex = 0;
            this.pageMateriaux.Location = new System.Drawing.Point(4, 57);
            this.pageMateriaux.Name = "pageMateriaux";
            this.pageMateriaux.Padding = new System.Windows.Forms.Padding(3);
            this.pageMateriaux.Size = new System.Drawing.Size(1031, 446);
            this.pageMateriaux.TabIndex = 0;
            this.pageMateriaux.Text = "Materiaux";
            this.pageMateriaux.UseVisualStyleBackColor = true;
            // 
            // flpMaterial
            // 
            this.flpMaterial.AutoScroll = true;
            this.flpMaterial.Location = new System.Drawing.Point(0, 0);
            this.flpMaterial.Name = "flpMaterial";
            this.flpMaterial.Size = new System.Drawing.Size(1031, 446);
            this.flpMaterial.TabIndex = 0;
            // 
            // pageCraft
            // 
            this.pageCraft.ImageIndex = 1;
            this.pageCraft.Location = new System.Drawing.Point(4, 57);
            this.pageCraft.Name = "pageCraft";
            this.pageCraft.Padding = new System.Windows.Forms.Padding(3);
            this.pageCraft.Size = new System.Drawing.Size(1031, 446);
            this.pageCraft.TabIndex = 1;
            this.pageCraft.Text = "Craft";
            this.pageCraft.UseVisualStyleBackColor = true;
            // 
            // pageForce
            // 
            this.pageForce.ImageIndex = 2;
            this.pageForce.Location = new System.Drawing.Point(4, 57);
            this.pageForce.Name = "pageForce";
            this.pageForce.Size = new System.Drawing.Size(1031, 446);
            this.pageForce.TabIndex = 3;
            this.pageForce.Text = "Forge";
            this.pageForce.UseVisualStyleBackColor = true;
            // 
            // pageStatistique
            // 
            this.pageStatistique.Location = new System.Drawing.Point(4, 57);
            this.pageStatistique.Name = "pageStatistique";
            this.pageStatistique.Size = new System.Drawing.Size(1031, 446);
            this.pageStatistique.TabIndex = 4;
            this.pageStatistique.Text = "Statistique";
            this.pageStatistique.UseVisualStyleBackColor = true;
            // 
            // ImageListPages
            // 
            this.ImageListPages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListPages.ImageStream")));
            this.ImageListPages.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListPages.Images.SetKeyName(0, "Bois.png");
            this.ImageListPages.Images.SetKeyName(1, "Outil.png");
            this.ImageListPages.Images.SetKeyName(2, "Forge.png");
            // 
            // picTop
            // 
            this.picTop.Location = new System.Drawing.Point(4, 4);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(70, 70);
            this.picTop.TabIndex = 1;
            this.picTop.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "NatCrafter";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.pageMateriaux.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage pageCraft;
        private System.Windows.Forms.ImageList ImageListPages;
        private System.Windows.Forms.TabPage pageInventaire;
        private System.Windows.Forms.TabPage pageForce;
        private System.Windows.Forms.TabPage pageStatistique;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.FlowLayoutPanel flpMaterial;
        protected System.Windows.Forms.TabPage pageMateriaux;
        private System.Windows.Forms.PictureBox picTop;
    }
}

