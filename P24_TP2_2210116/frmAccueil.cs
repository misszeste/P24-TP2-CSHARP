
namespace P24_TP2_2210116
{
    public partial class frmAccueil : Form
    {
        public static frmGestionEtud? frmGestionEtud = null;
        public static frmStat? frmStatistique = null;

        public frmAccueil()
        {
            InitializeComponent();
        }
       

        private void gestionDesÉtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionEtud inscription = new frmGestionEtud();
            inscription.ShowDialog(); // Shows Form1
        }

        private void listeEtStatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmStat stat = new frmStat();
            stat.ShowDialog(); // Shows Form2
        }


        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecherche rechercher = new frmRecherche();
            rechercher.ShowDialog(); // Shows Form3
        }
        private void terminerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Voulez-vous vraiment quitter l'application?";
            const string caption = " Merci et à bientôt! ";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the YEs button was pressed ...
            if (result == DialogResult.Yes)
            {
                //  closure of the app.
                MessageBox.Show(caption);
                Application.Exit();
            }
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}