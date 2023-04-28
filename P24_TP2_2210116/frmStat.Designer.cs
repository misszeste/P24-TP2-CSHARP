namespace P24_TP2_2210116
{
    partial class frmStat
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
            this.groupBoxStat = new System.Windows.Forms.GroupBox();
            this.labelStat = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.textBoxMoyenneCours = new System.Windows.Forms.TextBox();
            this.lblNbrEtudiantStat = new System.Windows.Forms.Label();
            this.listViewStat = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.textBoxMoyenneTP2 = new System.Windows.Forms.TextBox();
            this.textBoxMoyenneIntra = new System.Windows.Forms.TextBox();
            this.textBoxMoyenneFinale = new System.Windows.Forms.TextBox();
            this.textBoxNbrEtudiant = new System.Windows.Forms.TextBox();
            this.textBoxMoyenneTP1 = new System.Windows.Forms.TextBox();
            this.lblFinalStat = new System.Windows.Forms.Label();
            this.lblIntraStat = new System.Windows.Forms.Label();
            this.lblTP2Stat = new System.Windows.Forms.Label();
            this.lblTP1Stat = new System.Windows.Forms.Label();
            this.lblCoursStat = new System.Windows.Forms.Label();
            this.groupBoxStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStat
            // 
            this.groupBoxStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxStat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxStat.Controls.Add(this.labelStat);
            this.groupBoxStat.Controls.Add(this.btnFermer);
            this.groupBoxStat.Controls.Add(this.textBoxMoyenneCours);
            this.groupBoxStat.Controls.Add(this.lblNbrEtudiantStat);
            this.groupBoxStat.Controls.Add(this.listViewStat);
            this.groupBoxStat.Controls.Add(this.textBoxMoyenneTP2);
            this.groupBoxStat.Controls.Add(this.textBoxMoyenneIntra);
            this.groupBoxStat.Controls.Add(this.textBoxMoyenneFinale);
            this.groupBoxStat.Controls.Add(this.textBoxNbrEtudiant);
            this.groupBoxStat.Controls.Add(this.textBoxMoyenneTP1);
            this.groupBoxStat.Controls.Add(this.lblFinalStat);
            this.groupBoxStat.Controls.Add(this.lblIntraStat);
            this.groupBoxStat.Controls.Add(this.lblTP2Stat);
            this.groupBoxStat.Controls.Add(this.lblTP1Stat);
            this.groupBoxStat.Controls.Add(this.lblCoursStat);
            this.groupBoxStat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxStat.Location = new System.Drawing.Point(0, 2);
            this.groupBoxStat.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStat.Name = "groupBoxStat";
            this.groupBoxStat.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStat.Size = new System.Drawing.Size(1858, 955);
            this.groupBoxStat.TabIndex = 17;
            this.groupBoxStat.TabStop = false;
            this.groupBoxStat.Text = "Logiciel de gestion";
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelStat.Location = new System.Drawing.Point(1373, 136);
            this.labelStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(155, 37);
            this.labelStat.TabIndex = 33;
            this.labelStat.Text = "Statistique";
            this.labelStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFermer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.Location = new System.Drawing.Point(1420, 648);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(123, 45);
            this.btnFermer.TabIndex = 32;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
            // 
            // textBoxMoyenneCours
            // 
            this.textBoxMoyenneCours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMoyenneCours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMoyenneCours.Enabled = false;
            this.textBoxMoyenneCours.Location = new System.Drawing.Point(1545, 449);
            this.textBoxMoyenneCours.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoyenneCours.MaxLength = 3;
            this.textBoxMoyenneCours.Name = "textBoxMoyenneCours";
            this.textBoxMoyenneCours.ReadOnly = true;
            this.textBoxMoyenneCours.Size = new System.Drawing.Size(128, 29);
            this.textBoxMoyenneCours.TabIndex = 31;
            this.textBoxMoyenneCours.TabStop = false;
            this.textBoxMoyenneCours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNbrEtudiantStat
            // 
            this.lblNbrEtudiantStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNbrEtudiantStat.AutoSize = true;
            this.lblNbrEtudiantStat.Location = new System.Drawing.Point(1268, 492);
            this.lblNbrEtudiantStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbrEtudiantStat.Name = "lblNbrEtudiantStat";
            this.lblNbrEtudiantStat.Size = new System.Drawing.Size(149, 21);
            this.lblNbrEtudiantStat.TabIndex = 30;
            this.lblNbrEtudiantStat.Text = "Nombre d\'étudiant :";
            // 
            // listViewStat
            // 
            this.listViewStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewStat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewStat.GridLines = true;
            this.listViewStat.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewStat.Location = new System.Drawing.Point(52, 122);
            this.listViewStat.Margin = new System.Windows.Forms.Padding(4);
            this.listViewStat.Name = "listViewStat";
            this.listViewStat.Size = new System.Drawing.Size(1052, 678);
            this.listViewStat.TabIndex = 29;
            this.listViewStat.UseCompatibleStateImageBehavior = false;
            this.listViewStat.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "ID";
            this.columnHeader1.Text = "";
            // 
            // textBoxMoyenneTP2
            // 
            this.textBoxMoyenneTP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMoyenneTP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMoyenneTP2.Enabled = false;
            this.textBoxMoyenneTP2.Location = new System.Drawing.Point(1545, 312);
            this.textBoxMoyenneTP2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoyenneTP2.MaxLength = 2;
            this.textBoxMoyenneTP2.Name = "textBoxMoyenneTP2";
            this.textBoxMoyenneTP2.ReadOnly = true;
            this.textBoxMoyenneTP2.Size = new System.Drawing.Size(128, 29);
            this.textBoxMoyenneTP2.TabIndex = 28;
            this.textBoxMoyenneTP2.TabStop = false;
            this.textBoxMoyenneTP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMoyenneIntra
            // 
            this.textBoxMoyenneIntra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMoyenneIntra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMoyenneIntra.Enabled = false;
            this.textBoxMoyenneIntra.Location = new System.Drawing.Point(1545, 358);
            this.textBoxMoyenneIntra.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoyenneIntra.MaxLength = 2;
            this.textBoxMoyenneIntra.Name = "textBoxMoyenneIntra";
            this.textBoxMoyenneIntra.ReadOnly = true;
            this.textBoxMoyenneIntra.Size = new System.Drawing.Size(128, 29);
            this.textBoxMoyenneIntra.TabIndex = 27;
            this.textBoxMoyenneIntra.TabStop = false;
            this.textBoxMoyenneIntra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMoyenneFinale
            // 
            this.textBoxMoyenneFinale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMoyenneFinale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMoyenneFinale.Enabled = false;
            this.textBoxMoyenneFinale.Location = new System.Drawing.Point(1545, 404);
            this.textBoxMoyenneFinale.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoyenneFinale.MaxLength = 2;
            this.textBoxMoyenneFinale.Name = "textBoxMoyenneFinale";
            this.textBoxMoyenneFinale.ReadOnly = true;
            this.textBoxMoyenneFinale.Size = new System.Drawing.Size(128, 29);
            this.textBoxMoyenneFinale.TabIndex = 26;
            this.textBoxMoyenneFinale.TabStop = false;
            this.textBoxMoyenneFinale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNbrEtudiant
            // 
            this.textBoxNbrEtudiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNbrEtudiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNbrEtudiant.Enabled = false;
            this.textBoxNbrEtudiant.Location = new System.Drawing.Point(1545, 492);
            this.textBoxNbrEtudiant.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNbrEtudiant.MaxLength = 3;
            this.textBoxNbrEtudiant.Name = "textBoxNbrEtudiant";
            this.textBoxNbrEtudiant.ReadOnly = true;
            this.textBoxNbrEtudiant.Size = new System.Drawing.Size(128, 29);
            this.textBoxNbrEtudiant.TabIndex = 25;
            this.textBoxNbrEtudiant.TabStop = false;
            this.textBoxNbrEtudiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMoyenneTP1
            // 
            this.textBoxMoyenneTP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMoyenneTP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMoyenneTP1.Enabled = false;
            this.textBoxMoyenneTP1.Location = new System.Drawing.Point(1545, 271);
            this.textBoxMoyenneTP1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoyenneTP1.MaxLength = 2;
            this.textBoxMoyenneTP1.Name = "textBoxMoyenneTP1";
            this.textBoxMoyenneTP1.ReadOnly = true;
            this.textBoxMoyenneTP1.Size = new System.Drawing.Size(128, 29);
            this.textBoxMoyenneTP1.TabIndex = 24;
            this.textBoxMoyenneTP1.TabStop = false;
            this.textBoxMoyenneTP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFinalStat
            // 
            this.lblFinalStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFinalStat.AutoSize = true;
            this.lblFinalStat.Location = new System.Drawing.Point(1266, 407);
            this.lblFinalStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalStat.Name = "lblFinalStat";
            this.lblFinalStat.Size = new System.Drawing.Size(127, 21);
            this.lblFinalStat.TabIndex = 23;
            this.lblFinalStat.Text = "Moyenne Finale :";
            // 
            // lblIntraStat
            // 
            this.lblIntraStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIntraStat.AutoSize = true;
            this.lblIntraStat.Location = new System.Drawing.Point(1266, 358);
            this.lblIntraStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntraStat.Name = "lblIntraStat";
            this.lblIntraStat.Size = new System.Drawing.Size(118, 21);
            this.lblIntraStat.TabIndex = 22;
            this.lblIntraStat.Text = "Moyenne Intra :";
            // 
            // lblTP2Stat
            // 
            this.lblTP2Stat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTP2Stat.AutoSize = true;
            this.lblTP2Stat.Location = new System.Drawing.Point(1266, 315);
            this.lblTP2Stat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTP2Stat.Name = "lblTP2Stat";
            this.lblTP2Stat.Size = new System.Drawing.Size(116, 21);
            this.lblTP2Stat.TabIndex = 21;
            this.lblTP2Stat.Text = "Moyenne TP 2 :";
            // 
            // lblTP1Stat
            // 
            this.lblTP1Stat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTP1Stat.AutoSize = true;
            this.lblTP1Stat.Location = new System.Drawing.Point(1266, 270);
            this.lblTP1Stat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTP1Stat.Name = "lblTP1Stat";
            this.lblTP1Stat.Size = new System.Drawing.Size(116, 21);
            this.lblTP1Stat.TabIndex = 20;
            this.lblTP1Stat.Text = "Moyenne TP1 : ";
            // 
            // lblCoursStat
            // 
            this.lblCoursStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCoursStat.AutoSize = true;
            this.lblCoursStat.Location = new System.Drawing.Point(1266, 452);
            this.lblCoursStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoursStat.Name = "lblCoursStat";
            this.lblCoursStat.Size = new System.Drawing.Size(146, 21);
            this.lblCoursStat.TabIndex = 19;
            this.lblCoursStat.Text = "Moyenne du cours :";
            // 
            // frmStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1859, 956);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxStat);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "École du Petit Moulin";
            this.Load += new System.EventHandler(this.frmStat_Load);
            this.groupBoxStat.ResumeLayout(false);
            this.groupBoxStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxStat;
        private Button btnFermer;
        private TextBox textBoxMoyenneCours;
        private Label lblNbrEtudiantStat;
        private ListView listViewStat;
        private ColumnHeader columnHeader1;
        private TextBox textBoxMoyenneTP2;
        private TextBox textBoxMoyenneIntra;
        private TextBox textBoxMoyenneFinale;
        private TextBox textBoxNbrEtudiant;
        private TextBox textBoxMoyenneTP1;
        private Label lblFinalStat;
        private Label lblIntraStat;
        private Label lblTP2Stat;
        private Label lblTP1Stat;
        private Label lblCoursStat;
        private Label labelStat;
    }
}