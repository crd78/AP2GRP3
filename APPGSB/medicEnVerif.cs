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
            foreach(famille uneFamille in globale.lesFamilles.Values)
            {
               foreach(medicament unMedicament in uneFamille.getLesMedicaments())
                {
                    if(unMedicament.getCodeFamille()== uneFamille.getId())
                    {
                        ListViewItem uneLigne = new ListViewItem();
                        uneLigne.Text = unMedicament.getDepotLegal();
                        uneLigne.SubItems.Add(unMedicament.getNomCommercial());
                        uneLigne.SubItems.Add(uneFamille.getLibelle());


                    }
                }
            }
           
        }
    }
}
