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
            foreach(famille laFamille in globale.lesFamilles.Values)
            {
               foreach(medicament leMedicament in laFamille.getLesMedicaments())
                {
                    if(leMedicament.getCodeFamille()== laFamille.getId())
                    {
                        ListViewItem uneLigne = new ListViewItem();
                        uneLigne.Text = leMedicament.getDepotLegal();
                        uneLigne.SubItems.Add(leMedicament.getNomCommercial());
                        uneLigne.SubItems.Add(laFamille.getLibelle());


                    }
                }
            }
           
        }
    }
}
