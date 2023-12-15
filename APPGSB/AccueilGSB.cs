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
        
    

        public Accueil_GSB()
        {
            InitializeComponent();
            ActiverDesactiverMenu();
        }
        private bool utilisateurConnecte = false;
        private void ActiverDesactiverMenu()
        {
            btn_ajoutmedicament.Enabled = utilisateurConnecte;
            btn_encoursdevlidation.Enabled = utilisateurConnecte;
            btn_saisieetape.Enabled = utilisateurConnecte;
            btn_majetape.Enabled = utilisateurConnecte;
            btn_worfklow.Enabled = utilisateurConnecte;
            btn_autoriseparfamille.Enabled= utilisateurConnecte;




        }

        private void Accueil_GSB_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(ActiveMdiChild!=null)
            {
                ActiveForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelbureau.Controls.Add(childForm);
            this.panelbureau.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbtitle.Text = childForm.Text;
        }

        private void btn_saisieetape_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSaisieDecision(), sender);
        }

       

        private void btn_ajoutmedicament_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AjoutMedic(), sender);

        }

    
     

        private void btn_encoursdevlidation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new medicEnVerif(), sender);

        }

       
      

        private void btn_connexion_Click(object sender, EventArgs e)
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

        private void panelbureau_Paint(object sender, PaintEventArgs e)
        {

        }
       
    }
}
