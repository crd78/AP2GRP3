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
    public partial class FrmConnexioncs : Form
    {
        public FrmConnexioncs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Récupérez les valeurs des textbox
            string username = textBox1.Text;
            string password = textBox2.Text;
           
            // Appel à la procédure stockée
            bool credentialsMatch = bd.connexionUser(username, password);

            // Vérifiez le résultat
            if (credentialsMatch)
            {
                MessageBox.Show("Connexion réussie !");
                // Ajoutez ici le code pour passer à la prochaine étape ou effectuer d'autres actions après la connexion réussie.
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Identifiants incorrects. Veuillez réessayer.");
                // Ajoutez ici le code pour gérer le cas où les identifiants ne correspondent pas.
            }
        }

     
    }
}
