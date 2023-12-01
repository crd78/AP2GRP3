using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGSB
{
    class Connexion
    {
        public static SqlConnection cnx;
        public static String nomServeur = "Data Source=BTS2022-22\\SQLEXPRESS02;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";
    }
}
