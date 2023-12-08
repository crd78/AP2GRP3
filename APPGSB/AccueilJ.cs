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
        private Button currentButton;
        //private Random random;
        private int tempIndex;
        private Form activeForm;

        public AccueilJ()
        {
            InitializeComponent();
        }
        private Color SelectThemeColor()
        {
            List<string> ColorList = new List<string>();
            ColorList.Add("#0000FF");
            ColorList.Add("#B0C4DE");
            ColorList.Add("#B0E0E6");
            ColorList.Add("#ADD8E6");
            ColorList.Add("#87CEEB");
            ColorList.Add("#1E90FF");
            Random random = new Random();
            int index=random.Next(ColorList.Count);
            while (tempIndex == index)
            {
                index=random.Next(ColorList.Count);
            }
            tempIndex = index;
            string color = ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender!=null)
            {
                if(currentButton !=(Button)btnSender)
                {
                    DisableButton(currentButton);
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);

                }
            }
        }
        private void DisableButton(object sender)
        {
            foreach(Control previousBtn in panel2.Controls)
            {
                if(previousBtn.GetType()== typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void AccueilJ_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //ouvre l'accueil
            AjoutMedic AccueilJ = new AjoutMedic();
            AccueilJ.Show();
            this.Hide();
        }

        private void btn_saisieetape_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_etapenorme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btn_workflow_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btn_nbmedicament_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
