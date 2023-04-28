
namespace P24_TP2_2210116
{
    
    public partial class frmGestionEtud : Form


    {
        string tp1 = "";
        string tp2 = "";
        string intra = "";
        string final = "";
        string nom = "";
        string prenom = "";
        string adresse = "";
        string ville = "";
        string identification = "";
        string codePerm = "";
        string donnes = "";
        char sexe = ' ';
        string partie1 = "";
        string partie2 = "";
        string partie3 = "";
        int pos = 0;
        int totalEtudiant = 0;
        string action = "";
        string dateFete = "";
        string codePostale = "";
        string telephone = "";


        public bool ValiderVider()
        {
            //valider si un text box est vide un a la fois
            bool erreur = false;

            if ((textBoxNom.Text == "") && (erreur == false))
            {
                MessageBox.Show("Entrez un nom.");                
                textBoxNom.Focus();
                erreur = true;
            }

            if ((textBoxPrenom.Text == "") && (erreur == false))
            {
                MessageBox.Show("Entrez un prénom.");
                textBoxPrenom.Focus();
                erreur = true;
            }

            if ((textBoxCodePerm.Text.Length < 12) && (erreur == false))
            {                
                MessageBox.Show("Entrez un code permanent complet.");
                textBoxCodePerm.Focus();
                erreur = true;
            }
            else
            {
                if (erreur == false)
                {
                    string chiffre = textBoxCodePerm.Text.Substring(4);
                    if (((textBoxNom.Text.Substring(0, 3) != textBoxCodePerm.Text.Substring(0, 3)) || (textBoxPrenom.Text.Substring(0, 1) != textBoxCodePerm.Text.Substring(3, 1))) && (System.Text.RegularExpressions.Regex.IsMatch(chiffre, @"^[0-9]") == false) && (erreur == false))
                    {
                        MessageBox.Show("Entrez un code permanent conforme.");
                        textBoxCodePerm.Focus();
                        erreur = true;
                    }
                }
            }
            
            if (rdbFeminim.Checked == true)
            {
                sexe = 'F';
            }

            if (rdbMasculin.Checked == true)
            {
                sexe = 'M';
            }

            if((sexe == ' ')&& (erreur == false))

            {
                MessageBox.Show("Entrez un genre.");
                erreur = true;
            }

            if ((textBoxAdresse.Text == "") && (erreur == false))
            {
                MessageBox.Show("Entrez une adresse.");
                textBoxAdresse.Focus();
                erreur = true;
            }

            if ((textBoxVille.Text == "") && (erreur == false))
            {
                MessageBox.Show("Entrez le nom d'une ville");
                textBoxVille.Focus();
                erreur = true;
            }
            return (erreur);
        }
        public frmGestionEtud()
        {
            InitializeComponent();
        }

        private void frmGestionEtudiants_Load(object sender, EventArgs e)
        {
            RechargerFormEtudiants();            
        }

        private void RechargerFormEtudiants()
        {
            try
            {
                using FileStream fa = new FileStream(Application.StartupPath + @"\Eleve.Dta", FileMode.Open, FileAccess.Read);
                using BinaryReader ba = new BinaryReader(fa);
                donnes = "";
                totalEtudiant = 0;
                for (; ; )
                {
                    if (ba.PeekChar() == -1) break;
                    donnes = donnes + ba.ReadString();
                }
                btnPremier.Enabled = true;
                btnDernier.Enabled = true;
                btnPrecedent.Enabled = true;
                btnSuivant.Enabled = true;
                ba.Close();
                fa.Close();
                for (int i = 0; i < donnes.Length; i += 137)
                {
                    totalEtudiant++;
                }
                lblInfo.Text = "1/" + totalEtudiant;                
                btnPremier.PerformClick();               
                pos = 0;
            }
            catch
            {
                action = "ajouter";
                btnEnregistrer.Enabled = true;
            }
        }



        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            const string message = "Voulez-vous vraiment supprimer ce dossier étudiants?";            
            var result = MessageBox.Show(message, null,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (textBoxCodePerm.Text != "")
                {
                    // suprimer une inscription
                    try
                    {
                        FileStream fa = new FileStream(Application.StartupPath + @"\Eleve.Dta", FileMode.Open, FileAccess.Read);
                        BinaryReader ba = new BinaryReader(fa);
                        donnes = "";
                        for (; ; )
                        {
                            if (ba.PeekChar() == -1) break;
                            donnes = donnes + ba.ReadString();
                        }
                        ba.Close();
                        fa.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Fichier introuvable.");
                    }
                    for (int i = 0; i < donnes.Length; i += 137)
                    {
                        if (textBoxCodePerm.Text == donnes.Substring(i, 12))
                        {
                            partie1 = donnes.Substring(0, i);
                            partie2 = donnes.Substring(i + 137);
                            i = donnes.Length;
                        }
                    }
                    donnes = partie1 + partie2;
                    FileStream fs = new FileStream(Application.StartupPath + @"\Eleve.Dta", FileMode.Truncate, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(donnes);
                    bw.Close();
                    fs.Close();
                    Viderform();
                    RechargerFormEtudiants();
                }
                else
                {
                    MessageBox.Show("Aucun document à effacer.");
                }
            }

        }



        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            if (ValiderVider() == false)
            {
                if (rdbFeminim.Checked == true)
                {
                    sexe = 'F';
                }

                if (rdbMasculin.Checked == true)
                {
                    sexe = 'M';
                }

                //calcule note du cours
                try
                {
                    int tp1 = Convert.ToInt32(numericUpDownTp1.Text);
                    int tp2 = Int32.Parse(numericUpDownTp2.Text);
                    int intra = Int32.Parse(numericUpDownIntra.Text);
                    int final = Int32.Parse(numericUpDownFinal.Text);
                    textBoxNoteFinale.Text = (tp1 + tp2 + intra + final).ToString();
                }

                catch (FormatException)
                {
                    Console.WriteLine("Input string is invalid.");
                }



                if (action == "ajouter")
                {
                    //generer ID (5 characteres)
                    partie1 = textBoxNom.Text.Substring(0, 3);
                    partie2 = textBoxPrenom.Text.Substring(0, 1);
                    identification = partie1 + partie2 ;
                    int maxPareil = 0;
                    for (int i = 0; i < donnes.Length; i += 137)
                        {
                            if (donnes.Substring(i + 42, 4)== identification)
                            {
                                maxPareil = Int32.Parse(donnes.Substring(i+46,1));                            
                            }
                        }


                    if (maxPareil == 9)
                        {
                            MessageBox.Show("Risque de doublon. Sauvegarde annulée.");
                            
                        }
                    else
                        {
                            identification = identification + (maxPareil+1);
                            // ajustement de la longueur des elements du form              
                            tp1 = numericUpDownTp1.Text.TrimStart(new Char[] { '0' });
                            tp2 = numericUpDownTp2.Text.TrimStart(new Char[] { '0' });
                            intra = numericUpDownIntra.Text.TrimStart(new Char[] { '0' });
                            final = numericUpDownFinal.Text.TrimStart(new Char[] { '0' });
                            tp1 = tp1.PadRight(2);
                            tp2 = tp2.PadRight(2);
                            intra = intra.PadRight(2);
                            final = final.PadRight(2);
                            nom = textBoxNom.Text.PadRight(15);
                            prenom = textBoxPrenom.Text.PadRight(15);
                            adresse = textBoxAdresse.Text.PadRight(30);
                            ville = textBoxVille.Text.PadRight(20);
                            codePerm = textBoxCodePerm.Text.PadRight(12);
                            dateFete = dateTimePickerFete.Text.PadRight(10);
                            codePostale = maskedTextBoxCodePostal.Text.PadRight(7);
                            telephone = maskedTextBoxPhone.Text.PadRight(14);

                            FileStream fs = new FileStream(Application.StartupPath + @"\Eleve.Dta", FileMode.Append, FileAccess.Write);
                            BinaryWriter bw = new BinaryWriter(fs);
                            bw.Write(codePerm + nom + prenom + identification + sexe + dateFete + adresse
                                + ville + codePostale + telephone + tp1 + tp2 + intra + final);
                            bw.Close();
                            fs.Close();
                            RechargerFormEtudiants();
                            btnDernier.PerformClick();
                            btnEnregistrer.Enabled = false;
                            btnCreer.Enabled = true;
                            btnModifier.Enabled = true;
                            btnSupprimer.Enabled = true;
                        
                    }
                    
                }


                if (action == "modifier")
                {
                    try
                    {
                        donnes = "";
                        FileStream fa = new FileStream(Application.StartupPath + @"\Eleve.Dta", FileMode.Open, FileAccess.Read);
                        BinaryReader ba = new BinaryReader(fa);
                        for (; ; )
                        {
                            if (ba.PeekChar() == -1) break;
                            donnes = donnes + ba.ReadString();
                        }
                        ba.Close();
                        fa.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Fichier introuvable.: " + Application.StartupPath + @"\Eleve.Dta");
                    }
                    
                    tp1 = numericUpDownTp1.Text.TrimStart(new Char[] { '0' });
                    if(tp1.Length == 0)
                        tp1 = "0";
                    tp2 = numericUpDownTp2.Text.TrimStart(new Char[] { '0' });
                    if(tp2.Length == 0)
                        tp2 ="0";
                    intra = numericUpDownIntra.Text.TrimStart(new Char[] { '0' });
                    if(intra.Length == 0)       
                        intra = "0";
                    final = numericUpDownFinal.Text.TrimStart(new Char[] { '0' });
                    if(final.Length == 0)   
                        final = "0";
                    tp1 = tp1.PadRight(2);
                    tp2 = tp2.PadRight(2);
                    intra = intra.PadRight(2);
                    final = final.PadRight(2);
                    nom = textBoxNom.Text.PadRight(15);
                    prenom = textBoxPrenom.Text.PadRight(15);
                    adresse = textBoxAdresse.Text.PadRight(30);
                    ville = textBoxVille.Text.PadRight(20);
                    codePerm = textBoxCodePerm.Text.PadRight(12);
                    dateFete = dateTimePickerFete.Text.PadRight(10);
                    codePostale = maskedTextBoxCodePostal.Text.PadRight(7);
                    telephone = maskedTextBoxPhone.Text.PadRight(14);
                    identification = textBoxIdentification.Text.PadRight(5);

                    for (int i = 0; i < donnes.Length; i += 137)
                    {
                        if (textBoxCodePerm.Text == donnes.Substring(i, 12))
                        {
                            partie1 = donnes.Substring(0, i);
                            partie2 = codePerm + nom + prenom + identification + sexe + dateFete + adresse
                            + ville + codePostale + telephone + tp1 + tp2 + intra + final;
                            partie3 = donnes.Substring(i+137);
                            donnes = partie1 + partie2 + partie3;
                        }
                    }
                    FileStream fs = new FileStream(Application.StartupPath + @"\Eleve.Dta", FileMode.Truncate, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(donnes);
                    bw.Close();
                    fs.Close();
                    
                    RechargerFormEtudiants();
                    activerChamps(true);
                }
            }            
        }      

        private void Viderform()
        {
            textBoxCodePerm.Text = "";
            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            rdbFeminim.Checked = false;
            rdbMasculin.Checked = false;
            dateTimePickerFete.Text = "";
            textBoxIdentification.Text = "";
            textBoxAdresse.Text = "";
            maskedTextBoxCodePostal.Text = "";
            maskedTextBoxPhone.Text = "";
            textBoxVille.Text = "";
            numericUpDownTp1.Value = 0;
            numericUpDownTp2.Value = 0;
            numericUpDownIntra.Value = 0;
            numericUpDownFinal.Value = 0;
            textBoxNoteFinale.Text = "0";
        }

        private void RemplirForm(string parm1, string parm2, string parm3, string parm4, string parm5, string parm6, string parm7, string parm8
            , string parm9, string parm10, int parm11, int parm12, int parm13, int parm14)
        {
            textBoxCodePerm.Text = parm1;
            textBoxNom.Text = parm2;
            textBoxPrenom.Text = parm3;
            textBoxIdentification.Text = parm4;
            if (parm5 == "F") { rdbFeminim.Checked = true; }
            if (parm5 == "M") { rdbMasculin.Checked = true; }
            dateTimePickerFete.Text = parm6;
            textBoxAdresse.Text = parm7;
            textBoxVille.Text = parm8;
            maskedTextBoxCodePostal.Text = parm9;
            maskedTextBoxPhone.Text = parm10;

            numericUpDownTp1.Value = parm11;
            numericUpDownTp2.Value = parm12;
            numericUpDownIntra.Value = parm13;
            numericUpDownFinal.Value = parm14;
            string resultat = (parm11 + parm12 + parm13 + parm14).ToString();
            textBoxNoteFinale.Text = resultat;
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            action = "ajouter";
            activerChamps(true);                     
         
            Viderform();
            lblInfo.Text = (totalEtudiant + 1) + "/" + (totalEtudiant + 1);
        }

        private void activerChamps(bool active)
        {
            if( active == true)
            {
                if(action == "ajouter")
                {
                    btnModifier.Enabled = false;
                    btnEnregistrer.Enabled = true;
                    btnSupprimer.Enabled = false;
                    textBoxCodePerm.Enabled = true;
                    textBoxNom.Enabled = true;
                    textBoxPrenom.Enabled = true;
                    rdbFeminim.Enabled = true;
                    rdbMasculin.Enabled = true;
                    groupBoxSexe.Enabled = true;
                    dateTimePickerFete.Enabled = true;
                    textBoxAdresse.Enabled = true;
                    textBoxVille.Enabled = true;
                    maskedTextBoxCodePostal.Enabled = true;
                    maskedTextBoxPhone.Enabled = true;
                    numericUpDownTp1.Enabled = true;
                    numericUpDownTp2.Enabled = true;
                    numericUpDownIntra.Enabled = true;
                    numericUpDownFinal.Enabled = true;
                }
                else
                {
                    textBoxAdresse.Enabled = true;
                    textBoxVille.Enabled = true;
                    maskedTextBoxCodePostal.Enabled = true;
                    maskedTextBoxPhone.Enabled = true;
                    numericUpDownTp1.Enabled = true;
                    numericUpDownTp2.Enabled = true;
                    numericUpDownIntra.Enabled = true;
                    numericUpDownFinal.Enabled = true;
                }
                
            }
            else
            {
                btnModifier.Enabled = true;
                btnEnregistrer.Enabled = false;
                btnSupprimer.Enabled = true;
                textBoxCodePerm.Enabled = false;
                textBoxNom.Enabled = false;
                textBoxPrenom.Enabled = false;
                rdbFeminim.Enabled = false;
                rdbMasculin.Enabled = false;
                groupBoxSexe.Enabled = false;
                dateTimePickerFete.Enabled = false;
                textBoxAdresse.Enabled = false;
                textBoxVille.Enabled = false;
                maskedTextBoxCodePostal.Enabled = false;
                maskedTextBoxPhone.Enabled = false;
                numericUpDownTp1.Enabled = false;
                numericUpDownTp2.Enabled = false;
                numericUpDownIntra.Enabled = false;
                numericUpDownFinal.Enabled = false;
            }
               
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            action = "modifier";
            activerChamps(true);
            btnEnregistrer.Enabled = true;
        }



        private void btnPremier_Click(object sender, EventArgs e)
        {
            pos = 0;
            RemplirForm(donnes.Substring(0, 12), donnes.Substring(12, 15).Trim(), donnes.Substring(27, 15).Trim(), donnes.Substring(42, 5), donnes.Substring(47, 1),
                donnes.Substring(48, 10), donnes.Substring(58, 30).Trim(), donnes.Substring(88, 20).Trim(), donnes.Substring(108, 7), donnes.Substring(115, 14),
                Int32.Parse(donnes.Substring(129, 2)), Int32.Parse(donnes.Substring(131, 2)), Int32.Parse(donnes.Substring(133, 2)), Int32.Parse(donnes.Substring(135, 2)));
            lblInfo.Text = "1/" + totalEtudiant;
            activerChamps(false);
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 137;
                RemplirForm(donnes.Substring(pos, 12), donnes.Substring(pos + 12, 15).Trim(), donnes.Substring(pos + 27, 15).Trim(), donnes.Substring(pos + 42, 5), donnes.Substring(pos + 47, 1), donnes.Substring(pos + 48, 10),
                donnes.Substring(pos + 58, 30).Trim(), donnes.Substring(pos + 88, 20).Trim(), donnes.Substring(pos + 108, 7), donnes.Substring(pos + 115, 14), Int32.Parse(donnes.Substring(pos + 129, 2)), Int32.Parse(donnes.Substring(pos + 131, 2))
                , Int32.Parse(donnes.Substring(pos + 133, 2)), Int32.Parse(donnes.Substring(pos + 135, 2)));
                if (pos == 0)
                {
                    lblInfo.Text = "1/" + totalEtudiant;
                }
                else
                {
                    lblInfo.Text = ((pos / 137) + 1) + "/" + totalEtudiant;
                }
            }
            activerChamps(false);
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (pos + 137 < donnes.Length)
            {
                pos = pos + 137;
                RemplirForm(donnes.Substring(pos, 12), donnes.Substring(pos + 12, 15).Trim(), donnes.Substring(pos + 27, 15).Trim(), donnes.Substring(pos + 42, 5), donnes.Substring(pos + 47, 1), donnes.Substring(pos + 48, 10),
                donnes.Substring(pos + 58, 30).Trim(), donnes.Substring(pos + 88, 20).Trim(), donnes.Substring(pos + 108, 7), donnes.Substring(pos + 115, 14), Int32.Parse(donnes.Substring(pos + 129, 2)), Int32.Parse(donnes.Substring(pos + 131, 2))
                , Int32.Parse(donnes.Substring(pos + 133, 2)), Int32.Parse(donnes.Substring(pos + 135, 2)));
                lblInfo.Text = ((pos / 137) + 1) + "/" + totalEtudiant;
            }
            activerChamps(false);
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            pos = donnes.Length - 137;
            RemplirForm(donnes.Substring(pos, 12), donnes.Substring(pos + 12, 15).Trim(), donnes.Substring(pos + 27, 15).Trim(), donnes.Substring(pos + 42, 5), donnes.Substring(pos + 47, 1), donnes.Substring(pos + 48, 10),
                donnes.Substring(pos + 58, 30).Trim(), donnes.Substring(pos + 88, 20).Trim(), donnes.Substring(pos + 108, 7), donnes.Substring(pos + 115, 14), Int32.Parse(donnes.Substring(pos + 129, 2)), Int32.Parse(donnes.Substring(pos + 131, 2))
                , Int32.Parse(donnes.Substring(pos + 133, 2)), Int32.Parse(donnes.Substring(pos + 135, 2)));
            lblInfo.Text = totalEtudiant + "/" + totalEtudiant;
            activerChamps(false);
        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment fermer cet onglet?";
            var result = MessageBox.Show(message, null,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

           
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
