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
    public partial class MedicEnVerif : Form
    {
        public MedicEnVerif()
        {
            InitializeComponent();
        }

        private void MedicEnVerif_Load(object sender, EventArgs e)
        {
            bd.lireLesMedicaments();

            //affiche que les medicamment en cour de verification
            lvMedic.Items.Clear();

            // Vérifie si la liste de médicaments est non nulle avant de l'itérer
            if (globale.listMedicament != null)
            {
                // Affichage des médicaments en attente de validation dans les colonnes de la ListView
                foreach (medicament unMedic in globale.listMedicament)
                {
                    ListViewItem item = new ListViewItem(new string[] { unMedic.getDepotLegal(), unMedic.getNomCommercial(), unMedic.getFamille() });
                    lvMedic.Items.Add(item);
                }
            }
            else
            {
                // Traitez le cas où globale.listMedicament est null
                Console.WriteLine("La liste de médicaments est null. Veuillez vérifier l'initialisation.");
            }
        }
    }
}
