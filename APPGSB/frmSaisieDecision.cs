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
    public partial class frmSaisieDecision : Form
    {
        public frmSaisieDecision()
        {
            InitializeComponent();
        }

        private void frmSaisieDecision_Load(object sender, EventArgs e)
        {
            foreach(medicament unMedoc in globale.lesMedicaments.Values)
            {
                cbMedicament.Items.Add(unMedoc.depotLegal);
            }
            foreach(etapes uneEtape in globale.lesEtapes)
            {
                cbEtapes.Items.Add(uneEtape.etp_libelle);
            }
            foreach(decisions uneDecision in globale.lesDecisions)
            {
                cbDecision.Items.Add(uneDecision.libelle);
            }
        }

        private void cbMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSaisir_Click(object sender, EventArgs e)
        {
            if(cbDecision.SelectedIndex == -1 || cbEtapes.SelectedIndex == -1 || cbEtapes.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner touts les champs");
            }
            else if(dtpDate.Value > DateTime.Now)
            {
                MessageBox.Show("Vous ne pouvez pas sélectionner une date supérieur à la date du jour");
            }
            else
            {
                string depot = cbMedicament.SelectedItem.ToString();
                int etape = 0;
                int decision = 0;
                int i = 0;
                bool trouve = false;
                while(i < globale.lesEtapes.Count && trouve == false)
                {
                    if (globale.lesEtapes[i].etp_libelle == cbEtapes.SelectedItem.ToString())
                    {
                        etape = globale.lesEtapes[i].etp_num;
                        trouve = true;
                    }
                    i++;
                }
                if(cbDecision.SelectedItem.ToString() == "Validée")
                {
                    decision = 1;
                }
                else { decision = 2; }
                string date = dtpDate.Value.ToShortDateString();

                if(bd.saisirEtape(depot,etape,decision,date))
                {
                    MessageBox.Show("Décision ajouté avec succès");
                    cbDecision.SelectedIndex = -1;
                    cbEtapes.SelectedIndex = -1;
                    cbMedicament.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Un problème est survenue lors de l'ajout de la décision");
                }
            }
        }

        private void cbEtapes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
