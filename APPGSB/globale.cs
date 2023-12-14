using APPGSB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Server_Test
{
    class globale
    {
        public static Dictionary<string, medicament> lesMedicaments;
        public static Dictionary<string,famille> lesFamilles;
        public static List<etapes> lesEtapes;
        public static List<decisions> lesDecisions;
        public static List<Workflow> lesWorkflows;
        public static List<medicament> lesMedicEnVerif;
       
    }
}
