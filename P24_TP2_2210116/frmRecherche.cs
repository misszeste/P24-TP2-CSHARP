namespace P24_TP2_2210116
{
    public partial class frmRecherche : Form
    {
        string donnes = "";
        bool trouve = false;
        public frmRecherche()
        {
            InitializeComponent();
        }

        private void AfficherRechercher(string obj,string chaine)
        {           
            int part1;
            int part2;
            int part3;
            int part4;
            string comparaison = "";
            listViewRechercher.Items.Clear();
            donnes = "";
           
            try
            {           
                FileStream fa = new FileStream(Application.StartupPath + @"\Eleve.Dta", FileMode.Open, FileAccess.Read);
                BinaryReader ba = new BinaryReader(fa);
                for (; ; )
                {
                    if (ba.PeekChar() == -1) break;
                    donnes = donnes + ba.ReadString();
                }
                ba.Close();
                fa.Close();
                for (int i = 0; i < donnes.Length; i += 137)
                {
                    switch (obj)
                    {
                        case "nom":
                            comparaison = donnes.Substring(i + 12, 15).Trim();
                        break;

                        case "prenom":
                                comparaison = donnes.Substring(i + 27, 15).Trim();
                        break;

                        case "code":
                                comparaison = donnes.Substring(i, 12);
                        break;

                        case "nomprenom":
                            comparaison = donnes.Substring(i + 12, 15).Trim() + donnes.Substring(i + 27, 15).Trim();
                        break;
                    }

                    if (chaine == comparaison)
                    {
                        part1 = Int32.Parse(donnes.Substring(i + 129, 2));
                        part2 = Int32.Parse(donnes.Substring(i + 131, 2));
                        part3 = Int32.Parse(donnes.Substring(i + 133, 2));
                        part4 = Int32.Parse(donnes.Substring(i + 135, 2));
                        string[] maliste = {"",donnes.Substring(i,12),donnes.Substring(i+12,15).Trim(), donnes.Substring(i+27,15).Trim(), donnes.Substring(i+42,5), donnes.Substring(i+47,1),
                            donnes.Substring(i+48,10), donnes.Substring(i+58,30).Trim(), donnes.Substring(i+88,20).Trim(), donnes.Substring(i+108,7), donnes.Substring(i+115,14), donnes.Substring(i+129,2),
                            donnes.Substring(i+131,2),donnes.Substring(i+133,2),donnes.Substring(i+135,2),(part1+part2+part3+part4).ToString()};
                        var monItem = new ListViewItem(maliste);
                        listViewRechercher.Items.Add(monItem);
                        trouve = true;
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Fichier introuvable.");
            }

        }


        private void frmRecherche_Load(object sender, EventArgs e)
        {
            listViewRechercher.View = View.Details;
            listViewRechercher.GridLines = true;
            listViewRechercher.FullRowSelect = true;
            listViewRechercher.Columns.Add("Code Permanent", 160);
            listViewRechercher.Columns.Add("Nom", 150);
            listViewRechercher.Columns.Add("Prénom", 150);
            listViewRechercher.Columns.Add("ID", 80);
            listViewRechercher.Columns.Add("Sexe", 50);
            listViewRechercher.Columns.Add("Date de naissance", 110);
            listViewRechercher.Columns.Add("Adresse", 190);
            listViewRechercher.Columns.Add("Ville", 110);
            listViewRechercher.Columns.Add("Code postale", 110);
            listViewRechercher.Columns.Add("telephone", 130);
            listViewRechercher.Columns.Add("Note TP 1", 80);
            listViewRechercher.Columns.Add("Note TP 2", 80);
            listViewRechercher.Columns.Add("Note Intra", 80);
            listViewRechercher.Columns.Add("Note Finale", 80);
            listViewRechercher.Columns.Add("Cours Final", 80);

        }
        
       
        private void TextBoxCodePerm_TextChanged(object sender, EventArgs e)
        {
            TextBoxPrenom.Text = "";
            TextBoxNom.Text = "";
        }

        private void TextBoxNom_TextChanged(object sender, EventArgs e)
        {
            TextBoxCodePerm.Text = "";
        }

        private void TextBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            TextBoxCodePerm.Text = "";
        }

        private void BtnRechercher_Click_1(object sender, EventArgs e)
        {
            bool erreurCodePerm = false;
            bool erreurNomPrenom = false;
            trouve = false;
            if (TextBoxCodePerm.Text.Length > 0)
            {
                AfficherRechercher("code", TextBoxCodePerm.Text);
            }
            else
            {
                erreurCodePerm = true;
            }

            if ((TextBoxNom.Text.Length > 0) || (TextBoxPrenom.Text.Length > 0))
            {
                AfficherRechercher("nomprenom", TextBoxNom.Text + TextBoxPrenom.Text);
            }
            else
            {
                erreurNomPrenom = true;
            }

            if (erreurCodePerm && erreurNomPrenom)
            {
                MessageBox.Show("Vous devez remplir un champ pour faire une recherche.");
                trouve = true;
            }

            if (trouve == false)
            {
                MessageBox.Show("Je n'ai pas trouvé ce que vous rechercher");
            }            
        }

        private void BtnFermerRecherche_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment fermer cet onglet?";

            var result = MessageBox.Show(message, null,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the YEs button was pressed ...
            if (result == DialogResult.Yes)
            {
                //  closure of the app.

                this.Close();
            }
        }

        private void S(object sender, EventArgs e)//Je ne suis pas capable de supprimer cet evenement sans faire disparaitre mon form malgré la tentative daller dans frmR
        {

        }
    }
}
