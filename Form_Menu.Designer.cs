namespace TP_GestionCommerciale
{
    partial class Form_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeNomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeParVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreParVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseAJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseAJourToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.articleToolStripMenuItem,
            this.commandeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeNomsToolStripMenuItem,
            this.listeParVilleToolStripMenuItem,
            this.nombreParVilleToolStripMenuItem,
            this.miseAJourToolStripMenuItem,
            this.rapportToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // listeNomsToolStripMenuItem
            // 
            this.listeNomsToolStripMenuItem.Name = "listeNomsToolStripMenuItem";
            this.listeNomsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listeNomsToolStripMenuItem.Text = "Liste Noms";
            this.listeNomsToolStripMenuItem.Click += new System.EventHandler(this.listeNomsToolStripMenuItem_Click);
            // 
            // listeParVilleToolStripMenuItem
            // 
            this.listeParVilleToolStripMenuItem.Name = "listeParVilleToolStripMenuItem";
            this.listeParVilleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listeParVilleToolStripMenuItem.Text = "Liste Par Ville";
            this.listeParVilleToolStripMenuItem.Click += new System.EventHandler(this.listeParVilleToolStripMenuItem_Click);
            // 
            // nombreParVilleToolStripMenuItem
            // 
            this.nombreParVilleToolStripMenuItem.Name = "nombreParVilleToolStripMenuItem";
            this.nombreParVilleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.nombreParVilleToolStripMenuItem.Text = "Nombre Par Ville";
            this.nombreParVilleToolStripMenuItem.Click += new System.EventHandler(this.nombreParVilleToolStripMenuItem_Click);
            // 
            // miseAJourToolStripMenuItem
            // 
            this.miseAJourToolStripMenuItem.Name = "miseAJourToolStripMenuItem";
            this.miseAJourToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.miseAJourToolStripMenuItem.Text = "Mise A Jour";
            this.miseAJourToolStripMenuItem.Click += new System.EventHandler(this.miseAJourToolStripMenuItem_Click);
            // 
            // articleToolStripMenuItem
            // 
            this.articleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseAJourToolStripMenuItem1,
            this.rechercheToolStripMenuItem});
            this.articleToolStripMenuItem.Name = "articleToolStripMenuItem";
            this.articleToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.articleToolStripMenuItem.Text = "Article";
            // 
            // miseAJourToolStripMenuItem1
            // 
            this.miseAJourToolStripMenuItem1.Name = "miseAJourToolStripMenuItem1";
            this.miseAJourToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.miseAJourToolStripMenuItem1.Text = "Mise A Jour";
            this.miseAJourToolStripMenuItem1.Click += new System.EventHandler(this.miseAJourToolStripMenuItem1_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.rechercheToolStripMenuItem.Text = "Recherche";
            this.rechercheToolStripMenuItem.Click += new System.EventHandler(this.rechercheToolStripMenuItem_Click);
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCommandesToolStripMenuItem});
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.commandeToolStripMenuItem.Text = "Commande";
            // 
            // listeCommandesToolStripMenuItem
            // 
            this.listeCommandesToolStripMenuItem.Name = "listeCommandesToolStripMenuItem";
            this.listeCommandesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listeCommandesToolStripMenuItem.Text = "Liste Commandes";
            this.listeCommandesToolStripMenuItem.Click += new System.EventHandler(this.listeCommandesToolStripMenuItem_Click);
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rapportToolStripMenuItem.Text = "Rapport";
            this.rapportToolStripMenuItem.Click += new System.EventHandler(this.rapportToolStripMenuItem_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 467);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeNomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeParVilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreParVilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseAJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseAJourToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
    }
}

