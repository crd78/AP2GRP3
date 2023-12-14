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
    public partial class Accueil_GSB : Form
    {
        public Accueil_GSB()
        {
            InitializeComponent();
        }

        private void Accueil_GSB_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(ActiveMdiChild!=null)
            {
                ActiveForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelbureau.Controls.Add(childForm);
            this.panelbureau.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbtitle.Text = childForm.Text;
        }

        private void btn_saisieetape_Click(object sender, EventArgs e)
        {
            OpenChildForm(new saisieetape(), sender);
        }

        private void btn_majetape_Click(object sender, EventArgs e)
        {
            OpenChildForm(new etapenormee(), sender);

        }

        private void btn_ajoutmedicament_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AjoutMedic(), sender);

        }

        private void btn_worfklow_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WorkFlow(), sender);
        }

        private void btn_autoriseparfamille_Click(object sender, EventArgs e)
        {
            OpenChildForm(new medicautorise(), sender);
        }

        private void btn_encoursdevlidation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new nbmedicament(), sender);

        }

        private void panelbureau_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
