namespace P24_TP2_2210116
{
    partial class frmAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAccueil = new System.Windows.Forms.Label();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesÉtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeEtStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccueil
            // 
            this.lblAccueil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccueil.AutoSize = true;
            this.lblAccueil.BackColor = System.Drawing.Color.Red;
            this.lblAccueil.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAccueil.Location = new System.Drawing.Point(216, 23);
            this.lblAccueil.Name = "lblAccueil";
            this.lblAccueil.Size = new System.Drawing.Size(838, 82);
            this.lblAccueil.TabIndex = 1;
            this.lblAccueil.Text = "École du Petit Moulin";
            this.lblAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesÉtudiantsToolStripMenuItem,
            this.listeEtStatToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.terminerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(58, 19);
            this.fichierToolStripMenuItem.Text = "Accueil";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // gestionDesÉtudiantsToolStripMenuItem
            // 
            this.gestionDesÉtudiantsToolStripMenuItem.Name = "gestionDesÉtudiantsToolStripMenuItem";
            this.gestionDesÉtudiantsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gestionDesÉtudiantsToolStripMenuItem.Text = "Gestion des étudiants";
            this.gestionDesÉtudiantsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesÉtudiantsToolStripMenuItem_Click);
            // 
            // listeEtStatToolStripMenuItem
            // 
            this.listeEtStatToolStripMenuItem.Name = "listeEtStatToolStripMenuItem";
            this.listeEtStatToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.listeEtStatToolStripMenuItem.Text = "Statistique";
            this.listeEtStatToolStripMenuItem.Click += new System.EventHandler(this.listeEtStatToolStripMenuItem_Click_1);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // terminerToolStripMenuItem
            // 
            this.terminerToolStripMenuItem.Name = "terminerToolStripMenuItem";
            this.terminerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.terminerToolStripMenuItem.Text = "Quitter";
            this.terminerToolStripMenuItem.Click += new System.EventHandler(this.terminerToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1270, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmAccueil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::P24_TP2_2210116.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1270, 612);
            this.Controls.Add(this.lblAccueil);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "École du Petit  Moulin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblAccueil;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem gestionDesÉtudiantsToolStripMenuItem;
        private ToolStripMenuItem listeEtStatToolStripMenuItem;
        private ToolStripMenuItem terminerToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem rechercherToolStripMenuItem;
    }
}