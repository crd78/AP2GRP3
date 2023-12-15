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
    public partial class medicEnVerif : Form
    {
        public medicEnVerif()
        {
            InitializeComponent();
        }

        private void medicEnVerif_Load(object sender, EventArgs e)
        {
            // Effacez les éléments précédents de la ListView une seule fois avant la boucle
            listView1.Items.Clear();

            // Lisez les médicaments en vérification
            bd.lireLesMedicEnVerif();

            // Ajoutez chaque médicament à la ListView
            foreach (medicament leMedic in globale.lesMedicaments.Values)
            {
                // Récupère le libellé de la famille du médicament actuel
                string libelleFamille = globale.lesFamilles[leMedic.codeFamille].getLibelle();

                // Crée une nouvelle ligne pour le contrôle ListView 
                ListViewItem uneLigne = new ListViewItem();

                // Définit le texte de la première colonne avec la propriété depotLegal du médicament
                uneLigne.Text = leMedic.depotLegal;

                // Ajoute un sous-élément à la deuxième colonne avec la propriété nomCommercial du médicament
                uneLigne.SubItems.Add(leMedic.nomCommercial);
                // Ajoute un sous-élément à la troisième colonne avec le libellé de la famille de médicaments 
                uneLigne.SubItems.Add(libelleFamille);

                // Ajoute la ligne au contrôle ListView 
                listView1.Items.Add(uneLigne);
            }
        }
    }
}
