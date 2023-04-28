namespace P24_TP2_2210116
{
    partial class frmRecherche
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOu = new System.Windows.Forms.Label();
            this.labelStat = new System.Windows.Forms.Label();
            this.btnFermerRecherche = new System.Windows.Forms.Button();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.TextBoxPrenom = new System.Windows.Forms.TextBox();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.TextBoxCodePerm = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblCodePerm = new System.Windows.Forms.Label();
            this.listViewRechercher = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblOu);
            this.groupBox1.Controls.Add(this.labelStat);
            this.groupBox1.Controls.Add(this.btnFermerRecherche);
            this.groupBox1.Controls.Add(this.BtnRechercher);
            this.groupBox1.Controls.Add(this.TextBoxPrenom);
            this.groupBox1.Controls.Add(this.TextBoxNom);
            this.groupBox1.Controls.Add(this.TextBoxCodePerm);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.lblPrenom);
            this.groupBox1.Controls.Add(this.lblCodePerm);
            this.groupBox1.Controls.Add(this.listViewRechercher);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1363, 562);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logiciel de gestion";
            // 
            // lblOu
            // 
            this.lblOu.AutoSize = true;
            this.lblOu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOu.Location = new System.Drawing.Point(1161, 171);
            this.lblOu.Name = "lblOu";
            this.lblOu.Size = new System.Drawing.Size(36, 28);
            this.lblOu.TabIndex = 44;
            this.lblOu.Text = "ou";
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelStat.Location = new System.Drawing.Point(1030, 35);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(148, 37);
            this.labelStat.TabIndex = 43;
            this.labelStat.Text = "Recherche";
            this.labelStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFermerRecherche
            // 
            this.btnFermerRecherche.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFermerRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermerRecherche.Location = new System.Drawing.Point(1230, 467);
            this.btnFermerRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermerRecherche.Name = "btnFermerRecherche";
            this.btnFermerRecherche.Size = new System.Drawing.Size(78, 32);
            this.btnFermerRecherche.TabIndex = 42;
            this.btnFermerRecherche.Text = "Fermer";
            this.btnFermerRecherche.UseVisualStyleBackColor = false;
            this.btnFermerRecherche.Click += new System.EventHandler(this.BtnFermerRecherche_Click);
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRechercher.Location = new System.Drawing.Point(1140, 297);
            this.BtnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(111, 32);
            this.BtnRechercher.TabIndex = 40;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = false;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click_1);
            // 
            // TextBoxPrenom
            // 
            this.TextBoxPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPrenom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxPrenom.Location = new System.Drawing.Point(1060, 240);
            this.TextBoxPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPrenom.MaxLength = 15;
            this.TextBoxPrenom.Name = "TextBoxPrenom";
            this.TextBoxPrenom.Size = new System.Drawing.Size(248, 29);
            this.TextBoxPrenom.TabIndex = 39;
            this.TextBoxPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPrenom.TextChanged += new System.EventHandler(this.TextBoxPrenom_TextChanged);
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxNom.Location = new System.Drawing.Point(1060, 203);
            this.TextBoxNom.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxNom.MaxLength = 15;
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(248, 29);
            this.TextBoxNom.TabIndex = 38;
            this.TextBoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxNom.Click += new System.EventHandler(this.S);
            this.TextBoxNom.TextChanged += new System.EventHandler(this.TextBoxNom_TextChanged);
            // 
            // TextBoxCodePerm
            // 
            this.TextBoxCodePerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCodePerm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxCodePerm.Location = new System.Drawing.Point(1060, 139);
            this.TextBoxCodePerm.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCodePerm.MaxLength = 12;
            this.TextBoxCodePerm.Name = "TextBoxCodePerm";
            this.TextBoxCodePerm.Size = new System.Drawing.Size(248, 29);
            this.TextBoxCodePerm.TabIndex = 37;
            this.TextBoxCodePerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxCodePerm.TextChanged += new System.EventHandler(this.TextBoxCodePerm_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNom.Location = new System.Drawing.Point(885, 203);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 23);
            this.lblNom.TabIndex = 36;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrenom.Location = new System.Drawing.Point(885, 246);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(74, 23);
            this.lblPrenom.TabIndex = 35;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblCodePerm
            // 
            this.lblCodePerm.AutoSize = true;
            this.lblCodePerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodePerm.Location = new System.Drawing.Point(885, 147);
            this.lblCodePerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodePerm.Name = "lblCodePerm";
            this.lblCodePerm.Size = new System.Drawing.Size(135, 23);
            this.lblCodePerm.TabIndex = 34;
            this.lblCodePerm.Text = "Code permanent :";
            // 
            // listViewRechercher
            // 
            this.listViewRechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewRechercher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewRechercher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewRechercher.FullRowSelect = true;
            this.listViewRechercher.GridLines = true;
            this.listViewRechercher.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRechercher.Location = new System.Drawing.Point(23, 43);
            this.listViewRechercher.Name = "listViewRechercher";
            this.listViewRechercher.Size = new System.Drawing.Size(819, 485);
            this.listViewRechercher.TabIndex = 30;
            this.listViewRechercher.UseCompatibleStateImageBehavior = false;
            this.listViewRechercher.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "ID";
            this.columnHeader1.Text = "";
            // 
            // frmRecherche
            // 
            this.AcceptButton = this.BtnRechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 659);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRecherche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "École du Petit Moulin";
            this.Load += new System.EventHandler(this.frmRecherche_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListView listViewRechercher;
        private ColumnHeader columnHeader1;
        private Button btnFermerRecherche;
        private Button BtnRechercher;
        private TextBox TextBoxPrenom;
        private TextBox TextBoxNom;
        private TextBox TextBoxCodePerm;
        private Label lblNom;
        private Label lblPrenom;
        private Label lblCodePerm;
        private Label labelStat;
        private Label lblOu;
    }
}