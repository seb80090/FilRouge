using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes
{
    public class commandesDAO
    {
        SqlConnection connect;

        public commandesDAO(string phrase)
        {
            connect = new SqlConnection(phrase);
        }

        public List<Commandes> List(int id)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from commande where num_client = @id ", connect);
            requete.Parameters.AddWithValue("@id", id);
            SqlDataReader lecture = requete.ExecuteReader();
            List<Commandes> liste = new List<Commandes>();
            while (lecture.Read())
            {
                Commandes com = new Commandes();
                com.num_commande = Convert.ToInt32(lecture["num_commande"]);
                com.num_facture = Convert.ToInt32(lecture["num_facture"]);
                com.paiement_a_la_commande = Convert.ToBoolean(lecture["paiement_a_la_commande"]);
                com.prix_vente_ht = Convert.ToDecimal(lecture["prix_vente_ht"]);
                com.remise_supp_commande = Convert.ToDecimal(lecture["remise_supp_commande"]);
                com.date_commande = Convert.ToString(lecture["date_commande"]);
                com.date_de_reglem_commande = Convert.ToString(lecture["date_reglem_commande"]);
                com.statut_commande = lecture["statut_commande"].ToString();
                com.num_client = Convert.ToInt32(lecture["num_client"]);
                com.Affichage = id.ToString() + " " + lecture["date_commande"].ToString() + " " + lecture["prix_vente_ht"].ToString();
                liste.Add(com);
            }
            connect.Close();
            return liste;
        }
        //public Commandes Find(int id)
        //{
        //    connect.Open();
        //    SqlCommand requete = new SqlCommand("select * from commande where num_commande=@id", connect);
        //    requete.Parameters.AddWithValue("@id", id);
        //    SqlDataReader lecture = requete.ExecuteReader();
        //    Commandes com = new Commandes();
        //    while (lecture.Read())
        //    {
        //        com.num_commande = Convert.ToInt32(lecture["num_commande"]);
        //        com.num_facture = Convert.ToInt32(lecture["num_facture"]);
        //        com.paiement_a_la_commande = Convert.ToBoolean(lecture["paiement_a_la_commade"]);
        //        com.prix_vente_ht = Convert.ToDecimal(lecture["prix_vente_ht"]);
        //        com.remise_supp_commande = Convert.ToDecimal(lecture["remise_supp_commande"]);
        //        com.date_commande = Convert.ToString(lecture["date_commande"]);
        //        com.date_de_reglem_commande = Convert.ToString(lecture["date_reglem_commande"]);
        //        com.statut_commande = lecture["statut_commande"].ToString();
        //        com.num_client = Convert.ToInt32(lecture["num_client"]);
        //    }
        //    lecture.Close();
        //    connect.Close();
        //    return com;

    }
}
