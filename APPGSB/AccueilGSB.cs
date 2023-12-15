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
    public partial class Accueil_GSB : Form
    {
        //Champ
        private Button currentButton;
        private Random random;
        private int tempIndex;

        public Accueil_GSB()
        {
            InitializeComponent();
        }

        private void Accueil_GSB_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            // Vérifie si une fenêtre MDI est active
            if (ActiveMdiChild!=null)
            {
                // Ferme la fenêtre active si elle existe
                ActiveForm.Close();
            }
            // Configure la fenêtre enfant comme non TopLevel, sans bordure, remplissant le panneau :
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //Ajoute la fenêtre enfant au panneau
            this.panelbureau.Controls.Add(childForm);
            // Associe la fenêtre enfant au tag du panneau
            this.panelbureau.Tag = childForm;
            //Place la fenêtre enfant au premier plan
            childForm.BringToFront();
            //Affiche la fenêtre enfant
            childForm.Show();
            // Met à jour le texte du label avec le titre de la fenêtre enfant
            lbtitle.Text = childForm.Text;
        }

        private void btn_saisieetape_Click(object sender, EventArgs e)
        {
        }

        private void btn_majetape_Click(object sender, EventArgs e)
        {

        }

        private void btn_ajoutmedicament_Click(object sender, EventArgs e)
        {
            // Appelle une fonction pour ouvrir une nouvelle fenêtre enfant avec un formulaire spécifique
            OpenChildForm(new AjoutMedic(), sender);

        }

        private void btn_worfklow_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WorkFlow(), sender);
        }

        private void btn_autoriseparfamille_Click(object sender, EventArgs e)
        {
        }

        private void btn_encoursdevlidation_Click(object sender, EventArgs e)
        {

        }

        private void panelbureau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbtitle_Click(object sender, EventArgs e)
        {

        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {

        }
    }
}
