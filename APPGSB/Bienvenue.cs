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
    public partial class Bienvenue : Form
    {
        public Bienvenue()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ouvre l'accueil
            Accueil Accueil = new Accueil();
            Accueil.Show();
            this.Hide();
        }

        private void Bienvenue_Load(object sender, EventArgs e)
        {
            Connexion.cnx = new System.Data.SqlClient.SqlConnection();
            Connexion.cnx.ConnectionString = Connexion.nomServeur;
            Connexion.cnx.Open();
            globale.lesFamilles = new Dictionary<string, famille>();
            globale.lesMedicaments = new Dictionary<string, medicament>();
            bd.lireLesMedicaments();
            globale.lesEtapes = new List<etapes>();
            bd.lireLesEtapes();
            globale.lesDecisions = new List<decisions>();
            bd.lireLesDecisions();
        }
    }
}
