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
    public partial class frmEtapesNormees : Form
    {
        private int index = 0;
        public frmEtapesNormees()
        {
            InitializeComponent();
        }

        private void frmEtapesNormees_Load(object sender, EventArgs e)
        {
            chargementLVetp();
            tbNorme.Enabled = false;
            tbDateNorme.Enabled = false;
            btValider.Enabled = false;
        }
        private void chargementLVetp()
        {
            lvEtp.Items.Clear();
            foreach (etapes uneEtape in globale.lesEtapes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = uneEtape.etp_num.ToString();
                item.SubItems.Add(uneEtape.etp_libelle);
                if(uneEtape.estNormee == 1)
                {
                    item.SubItems.Add(uneEtape.etp_norme);
                    item.SubItems.Add(uneEtape.etp_date_norme);
                }
                lvEtp.Items.Add(item);
            }
        }

        private void btModif_Click(object sender, EventArgs e)
        {
            if (lvEtp.SelectedItems.Count != 0)
            {
                tbDateNorme.Enabled = true;
                tbNorme.Enabled = true;
                btValider.Enabled = true;
                index = int.Parse(lvEtp.SelectedItems[0].Text)-1;
                lbEtp.Text = globale.lesEtapes[index].etp_num.ToString()+" "+globale.lesEtapes[index].etp_libelle;
                tbNorme.Text = globale.lesEtapes[index].etp_norme;
                tbDateNorme.Text = globale.lesEtapes[index].etp_date_norme;
            }
            else { MessageBox.Show("Sélectionne une étape"); }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if(tbDateNorme.Text == "" || tbNorme.Text =="")
            {
                MessageBox.Show("Veuillez remplir les 2 champs");
            }
            else
            {
                if (bd.updateEtape(index+1, tbNorme.Text, tbDateNorme.Text))
                {
                    MessageBox.Show("Etape modifié avec succès");
                    tbNorme.Text = "";
                    tbDateNorme.Text = "";
                    bd.lireLesEtapes();
                    chargementLVetp();
                }
                else { MessageBox.Show("Erreur lors de la modification de l'étape"); }
            }
            
        }
    }
}
