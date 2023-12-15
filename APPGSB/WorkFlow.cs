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

        }
    }
}
