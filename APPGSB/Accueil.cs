using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPGSB
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            ActiverDesactiverMenu();
        }
        private bool utilisateurConnecte = false;
        private void ActiverDesactiverMenu()
        {
            ajoutToolStripMenuItem.Enabled = utilisateurConnecte;
            quitterToolStripMenuItem.Enabled = utilisateurConnecte;
            saisieDécisionToolStripMenuItem.Enabled = utilisateurConnecte;
            enValidatiionToolStripMenuItem.Enabled = utilisateurConnecte;
          
        }



        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ouvre la fenetre ajout medicament dans la fenetre accueil
            // Créez une nouvelle instance de FormAjoutMedic
            AjoutMedic ajoutMedicForm = new AjoutMedic();

            // Définissez le formulaire parent comme AccueilForm
            ajoutMedicForm.MdiParent = this;
            ajoutMedicForm.WindowState = FormWindowState.Maximized;

            // Affichez la nouvelle forme
            ajoutMedicForm.Show();



        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }

        private void saisieDécisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaisieDecision form = new frmSaisieDecision();
            this.Hide();
            form.Show();
        }

        private void enValidatiionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicEnVerif form = new medicEnVerif();
            this.Hide();
            form.Show();
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConnexioncs form = new FrmConnexioncs();
            this.Hide();

            // Afficher la fenêtre de connexion en tant que dialogue
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Mettez à jour l'état de la connexion si l'utilisateur est connecté
                utilisateurConnecte = true;
                ActiverDesactiverMenu();

                // Ne créez pas une nouvelle instance d'Accueil
                this.Show();  // Montrez la fenêtre actuelle
            }
        }
    }
}
