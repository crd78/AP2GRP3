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
    public partial class AccueilJ : Form
    {
        public AccueilJ()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ouvre l'accueil
            AccueilJ AccueilJ = new AccueilJ();
            AccueilJ.Show();
            this.Hide();
        }

        private void AccueilJ_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ouvre l'accueil
            AjoutMedic AccueilJ = new AjoutMedic();
            AccueilJ.Show();
            this.Hide();
        }
    }
}
