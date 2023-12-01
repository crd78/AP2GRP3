using APPGSB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Server_Test
{
    public static class bd
    {
        public static void lireLesFamilles()
        {
            globale.listFamille.Clear();

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

                globale.listFamille.Add(laFamille);
            }
        }
        //fonction qui recuperer les medicament en verif de la base de données
        public static void lireLesMedicaments()
        {
            // Vérifiez si globale.listMedicament est null et initialisez-le si nécessaire
            if (globale.listMedicament == null)
            {
                globale.listMedicament = new List<medicament>();
            }
            else
            {
                // Si la liste existe déjà, effacez son contenu
                globale.listMedicament.Clear();
            }
           

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_medicament", Connexion.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string depotLegal = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomCommercial = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string famille = SqlExec["FAM_LIBELLE"].ToString();
                string composition = SqlExec["MED_COMPOSITION"].ToString();
                string effets = SqlExec["MED_EFFETS"].ToString();
                string contreindic = SqlExec["MED_CONTREINDIC"].ToString();


                medicament leMedicament = new medicament(depotLegal, nomCommercial, famille, composition, effets, contreindic);

                globale.listMedicament.Add(leMedicament);
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
