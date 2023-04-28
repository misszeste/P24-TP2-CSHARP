namespace P24_TP2_2210116

{   
    public partial class frmStat : Form
    {
        string donnes = "";
        public frmStat()
        {
            InitializeComponent();

        }

        private void frmStat_Load(object sender, EventArgs e)
        {   //creation du listview
            listViewStat.View = View.Details;
            listViewStat.GridLines = true;
            listViewStat.FullRowSelect = true;
            listViewStat.Columns.Add("Code Permanent", 160);
            listViewStat.Columns.Add("Nom", 150);
            listViewStat.Columns.Add("Prénom", 150);
            listViewStat.Columns.Add("ID", 80);
            listViewStat.Columns.Add("Sexe", 50);
            listViewStat.Columns.Add("Date de naissance", 110);
            listViewStat.Columns.Add("Adresse", 190);
            listViewStat.Columns.Add("Ville", 110);
            listViewStat.Columns.Add("Code postale", 110);
            listViewStat.Columns.Add("telephone", 130);
            listViewStat.Columns.Add("Note TP 1", 80);
            listViewStat.Columns.Add("Note TP 2", 80);
            listViewStat.Columns.Add("Note Intra", 80);
            listViewStat.Columns.Add("Note Finale", 80);
            listViewStat.Columns.Add("Cours Final", 80);

            
            int part1;
            int part2;
            int part3;
            int part4;
            int totalTp1 = 0;
            int totalTp2 = 0;                
            int totalIntra = 0;
            int totalFinale = 0;
            int totalFinaleCours = 0;

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
                    part1 = Int32.Parse(donnes.Substring(i + 129, 2));
                    part2 = Int32.Parse(donnes.Substring(i + 131, 2));
                    part3 = Int32.Parse(donnes.Substring(i + 133, 2));
                    part4 = Int32.Parse(donnes.Substring(i + 135, 2));
                    string[] maliste = {"",donnes.Substring(i,12),donnes.Substring(i+12,15).Trim(), donnes.Substring(i+27,15).Trim(), donnes.Substring(i+42,5), donnes.Substring(i+47,1),
                        donnes.Substring(i+48,10), donnes.Substring(i+58,30).Trim(), donnes.Substring(i+88,20).Trim(), donnes.Substring(i+108,7), donnes.Substring(i+115,14), donnes.Substring(i+129,2),
                        donnes.Substring(i+131,2),donnes.Substring(i+133,2),donnes.Substring(i+135,2),(part1+part2+part3+part4).ToString()};
                    var monItem = new ListViewItem(maliste);
                    listViewStat.Items.Add(monItem);
                    totalTp1 = totalTp1 + part1;
                    totalTp2 = totalTp2 + part2;
                    totalIntra = totalIntra + part3;
                    totalFinale = totalFinale + part4;
                    totalFinaleCours = totalFinaleCours + part1 + part2 + part3 + part4;
                }                
            }
            catch
            {
                MessageBox.Show("Fichier introuvable.");
            }

            int nbrEtudiant = donnes.Length/ 137;
            textBoxMoyenneTP1.Text = (totalTp1/nbrEtudiant).ToString(); 
            textBoxMoyenneTP2.Text = (totalTp2 / nbrEtudiant).ToString();
            textBoxMoyenneIntra.Text = (totalIntra / nbrEtudiant).ToString();
            textBoxMoyenneFinale.Text= (totalFinale / nbrEtudiant).ToString();            
            textBoxMoyenneCours.Text = (totalFinaleCours / nbrEtudiant).ToString(); 
            textBoxNbrEtudiant.Text = (nbrEtudiant).ToString();


        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment fermer cet onglet?";

            var result = MessageBox.Show(message, null,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                //  close
                this.Close();
            }
        }
    }
}
