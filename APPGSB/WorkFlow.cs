using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Server_Test;

namespace APPGSB
{
    public partial class WorkFlow : Form
    {
        public WorkFlow()
        {
            InitializeComponent();
        }

        private void WorkFlow_Load(object sender, EventArgs e)
        {
            // Effacez les éléments précédents de la ListView une seule fois avant la boucle
            lv_medicament.Items.Clear();

            bd.lireLesMedic();

            foreach (medicament leMedic in globale.lesMedicaments.Values)
            {
                comboBox1.Items.Add($"{leMedic.getDepotLegal()} {leMedic.getNomCommercial()}");
                ListViewItem uneLigne = new ListViewItem();
            }
            foreach(etapes leEtape in globale.lesEtapes)
            {
                foreach(decisions laDecision in globale.lesDecisions)
                {
                    ListViewItem uneLigne = new ListViewItem();

                    // numéro de l'étape
                    uneLigne.Text = leEtape.etp_num.ToString();

                    // libellé de l'étape
                    uneLigne.SubItems.Add(leEtape.etp_libelle);

                    //  date de la décision
                    uneLigne.SubItems.Add(laDecision.id.ToString());

                    //  libellé de la décision
                    uneLigne.SubItems.Add(laDecision.libelle);

                    // numéro de la norme
                    uneLigne.SubItems.Add(leEtape.etp_norme);

                    // date de la norme
                    uneLigne.SubItems.Add(leEtape.etp_date_norme);
                    // Ajoute la ligne au contrôle ListView 
                    lv_medicament.Items.Add(uneLigne);
                }
            }
        }
    }
}
