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
                ListViewItem uneLigne = new ListViewItem();
                uneLigne.Text = leMedic.depotLegal;
                uneLigne.SubItems.Add(leMedic.nomCommercial);
                uneLigne.SubItems.Add(leMedic.codeFamille);

                listView1.Items.Add(uneLigne);
            }
        }
    }
}
