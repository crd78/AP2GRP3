using SQL_Server_Test;
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
    public partial class AjoutMedic : Form
    {
        public AjoutMedic()
        {
            InitializeComponent();
        }

        private void AjoutMedic_Load(object sender, EventArgs e)
        {
            
            bd.lireLesFamilles();

            foreach(famille uneFamille in globale.lesFamilles.Values)
            {
                lbFamille.Items.Add(uneFamille.getId() + " : " + uneFamille.getLibelle());
            }
        }

        private void btAjouterMedicament_Click(object sender, EventArgs e)
        {
            string leCode = "";
            if(tbDepotLegal.Text == "" || tbNomCommercial.Text == "" || tbComposition.Text == "" || tbEffets.Text == "" || tbContreIndication.Text == "" || lbFamille.SelectedItem == "")
            {
                MessageBox.Show("Veuillez sélectionner une valeurs pour chaque paramètres");
            }
            else
            {
                string laFamille = lbFamille.SelectedItem.ToString();
                if (laFamille.Substring(0,3).Contains(" "))
                {
                    leCode = laFamille.Substring(0,2);
                }
                else
                {
                    leCode = laFamille.Substring(0, 3);
                }
                if(bd.ajouterMedicament(tbDepotLegal.Text, tbNomCommercial.Text, leCode, tbComposition.Text, tbEffets.Text,tbContreIndication.Text))
                {
                    MessageBox.Show("Le médicament à bien été ajouter à la base de données");
                    tbDepotLegal.Text = "";
                    tbNomCommercial.Text = "";
                    tbEffets.Text = "";
                    tbContreIndication.Text = "";
                    tbComposition.Text = "";
                }
                else { MessageBox.Show("Erreur lors de l'ajout du médicament"); }
            }
        }
    }
}
