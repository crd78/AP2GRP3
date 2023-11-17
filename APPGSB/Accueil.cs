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
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            

        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ouvre la fenetre ajout medicament dans la fenetre accueil
            // Créez une nouvelle instance de FormAjoutMedic
            AjoutMedic ajoutMedicForm = new AjoutMedic();

            // Définissez le formulaire parent comme AccueilForm
            ajoutMedicForm.MdiParent = this;

            // Affichez la nouvelle forme
            ajoutMedicForm.Show();



        }
    }
}
