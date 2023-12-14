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
        public static void lireLesMedicEnVerif()
        {
            globale.lesMedicEnVerif.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_medicamentEnVerif", Connexion.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des medic en verifiaction avec ajout dans la collection
            while(SqlExec.Read())
            { 
                string depotlegal = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomcommercial = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string fam_code = SqlExec["FAM_CODE"].ToString();
                string composition = SqlExec["MED_COMPOSITION"].ToString();
                string effets = SqlExec["MED_EFFETS"].ToString();
                string contreindic = SqlExec["MED_CONTREINDIC"].ToString();
                string amm = SqlExec["MED_AMM"].ToString();
                string etp_num = SqlExec["MED_ETP_NUM"].ToString();  
                string libelleFamille = SqlExec["FAM_LIBELLE"].ToString();

                famille laFamille = new famille(fam_code, libelleFamille);
                medicament leMedicament = new medicament(depotlegal, nomcommercial, fam_code,composition,effets,contreindic,amm,etp_num);
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
        public static Boolean saisirEtape(
        string depotLegal,
        int numEtape,
        int idDcs,
        string date
)
        {
            SqlCommand maRequete = new SqlCommand("prc_saisirDecision", Connexion.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les paramètres à la procédure stockée
            SqlParameter paramDepotLegal = new SqlParameter("@p_DEPOTLEGAL", System.Data.SqlDbType.VarChar, 255);
            paramDepotLegal.Value = depotLegal;
            SqlParameter paramNumEtape = new SqlParameter("@p_NUMETAPE", System.Data.SqlDbType.Int);
            paramNumEtape.Value = numEtape;
            SqlParameter paramDecision = new SqlParameter("@p_DECISION", System.Data.SqlDbType.Int);
            paramDecision.Value = idDcs;
            SqlParameter paramDate = new SqlParameter("@p_DATE", System.Data.SqlDbType.VarChar, 12);
            paramDate.Value = date;

            maRequete.Parameters.Add(paramDepotLegal);
            maRequete.Parameters.Add(paramNumEtape);
            maRequete.Parameters.Add(paramDecision);
            maRequete.Parameters.Add(paramDate);

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
