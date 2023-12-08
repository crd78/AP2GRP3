using APPGSB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Server_Test
{
    public static class bd
    {
        public static void lireLesFamilles()
        {
            globale.lesFamilles.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_famille", Connexion.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string id = SqlExec["FAM_CODE"].ToString();
                string libelle = SqlExec["FAM_LIBELLE"].ToString();

                famille laFamille = new famille(id, libelle);

                globale.lesFamilles.Add(laFamille.getId(),laFamille);
            }
        }
        public static void lireLesDecisions()
        {
            globale.lesDecisions.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_decisions", Connexion.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int id = int.Parse(SqlExec["DCS_ID"].ToString());
                string libelle = SqlExec["DCS_LIBELLE"].ToString();

                decisions uneDecision = new decisions(id, libelle);

                globale.lesDecisions.Add(uneDecision);
            }
        }
        public static void lireLesWorkflows()
        {
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_workflows", Connexion.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string depot = SqlExec["SBR_MED_DEPOTLEGAL"].ToString();
                int numEtp = int.Parse(SqlExec["SBR_ETP_NUM"].ToString());
                int dcsId = int.Parse(SqlExec["SBR_DCS_ID"].ToString());
                DateTime dateDec = DateTime.Parse(SqlExec["SBR_DATEDECISION"].ToString());
                bool trouve = false;
                int i = 0;
                while(!trouve && i < globale.lesEtapes.Count)
                {
                    if (globale.lesEtapes[i].etp_num == numEtp)
                    {
                        trouve = true;
                    }
                    else { i++; }
                }
                etapes letapes = globale.lesEtapes[i];
                i = 0;
                trouve = false;
                while(!trouve && i < globale.lesDecisions.Count)
                {
                    if(globale.lesDecisions[i].id == dcsId)
                    {
                        trouve= true;
                    }
                    else
                    {
                        i++;
                    }
                }
                decisions laDecision = globale.lesDecisions[i];
                Workflow unWorkflow = new Workflow(dateDec, letapes, laDecision);

                globale.lesMedicaments[depot].ajouterWorkflow(unWorkflow);
            }
        }
        public static void lireLesEtapes()
        {
            globale.lesEtapes.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_etapes", Connexion.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int id = int.Parse(SqlExec["ETP_NUM"].ToString());
                string libelle = SqlExec["ETP_LIBELLE"].ToString();
                string norme = SqlExec["ETP_NORME"].ToString();
                string date = SqlExec["ETP_DATE_NORME"].ToString();
                int estNormee = int.Parse(SqlExec["estNormee"].ToString());

                etapes etape = new etapes(id, libelle, norme,date,estNormee) ;

                globale.lesEtapes.Add(etape);
            }
        }
        public static void lireLesMedicaments()
        {
            globale.lesMedicaments.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_medicament", Connexion.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string depotlegal = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomcommercial = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string fam_code = SqlExec["FAM_CODE"].ToString();
                string composition = SqlExec["MED_COMPOSITION"].ToString();
                string effets = SqlExec["MED_EFFETS"].ToString();
                string contreindic = SqlExec["MED_CONTREINDIC"].ToString();
                string amm = SqlExec["MED_AMM"].ToString();
                string etp_num = SqlExec["MED_ETP_NUM"].ToString();

                medicament leMedicament = new medicament(depotlegal, nomcommercial, fam_code, composition, effets,contreindic,amm,etp_num) ;

                globale.lesMedicaments.Add(depotlegal, leMedicament);
            }
        }
        public static Boolean ajouterMedicament(
        string depotLegal,
        string nomCommercial,
        string famCode,
        string composition,
        string effets,
        string contreindic
)
        {
            SqlCommand maRequete = new SqlCommand("prc_ajouterMedicament", Connexion.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les paramètres à la procédure stockée
            SqlParameter paramDepotLegal = new SqlParameter("@p_DEPOTLEGAL", System.Data.SqlDbType.VarChar, 255);
            paramDepotLegal.Value = depotLegal;
            SqlParameter paramNomCommercial = new SqlParameter("@p_NOMCOMMERCIAL", System.Data.SqlDbType.VarChar, 255);
            paramNomCommercial.Value = nomCommercial;
            SqlParameter paramFamCode = new SqlParameter("@p_FAM_CODE", System.Data.SqlDbType.VarChar, 255);
            paramFamCode.Value = famCode;
            SqlParameter paramComposition = new SqlParameter("@p_COMPOSITION", System.Data.SqlDbType.VarChar, 255);
            paramComposition.Value = composition;
            SqlParameter paramEffets = new SqlParameter("@p_EFFETS", System.Data.SqlDbType.VarChar, 255);
            paramEffets.Value = effets;
            SqlParameter paramContreindic = new SqlParameter("@p_CONTREINDIC", System.Data.SqlDbType.VarChar, 255);
            paramContreindic.Value = contreindic;

            maRequete.Parameters.Add(paramDepotLegal);
            maRequete.Parameters.Add(paramNomCommercial);
            maRequete.Parameters.Add(paramFamCode);
            maRequete.Parameters.Add(paramComposition);
            maRequete.Parameters.Add(paramEffets);
            maRequete.Parameters.Add(paramContreindic);

            // exécuter la procédure stockée
            try
            {
                maRequete.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
