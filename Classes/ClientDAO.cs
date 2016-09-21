using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes
{
    public class ClientDAO
    {
        SqlConnection connect;

        public ClientDAO(string phrase)
        {
            connect = new SqlConnection(phrase);
        }


    public List<Client> List()
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from client", connect);
            SqlDataReader lecture = requete.ExecuteReader();
            List<Client> liste = new List<Client>();
            while (lecture.Read())
            {
                Client cli = new Client();
                cli.num_client = Convert.ToInt32(lecture["num_client"]);
                cli.nom_client = lecture["nom_client"].ToString();
                cli.Prenom_client = lecture["Prenom_client"].ToString();
                cli.adresse_livraison_client = lecture["adresse_livraison_client"].ToString();
                cli.code_post_liv_client = lecture["code_post_liv_client"].ToString();
                cli.ville_liv_client = lecture["ville_liv_client"].ToString();
                cli.adresse_facturation_client = lecture["adresse_facturation_client"].ToString();
                cli.code_post_facturation_client = lecture["code_post_facturation_client"].ToString();
                cli.ville_facturation_client = lecture["ville_facturation_client"].ToString();
                cli.siret_client = lecture["siret_client"].ToString();
                cli.tel_fix_client = lecture["tel_fix_client"].ToString();
                cli.tel_mobile_client = lecture["tel_mobile_client"].ToString();
                cli.mail_client = lecture["mail_client"].ToString();
                cli.pro_ou_part_client = Convert.ToBoolean(lecture["pro_ou_part_client"]);
                cli.coef_client = Convert.ToDecimal(lecture["coef_client"]);
                cli.Affichage = lecture["prenom_client"].ToString() + " " + lecture["nom_client"].ToString();
                cli.coef_client = Convert.ToDecimal(lecture["coef_client"]);
                liste.Add(cli);
            }

            connect.Close();
            return liste;
        }

        public Client Find(int id)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from client where num_client=@id", connect);
            requete.Parameters.AddWithValue("@id", id);
            SqlDataReader lecture = requete.ExecuteReader();
            Client cli = new Client();
            while (lecture.Read())
            {
                cli.num_client = Convert.ToInt32(lecture["num_client"]);
                cli.nom_client = lecture["nom_client"].ToString();
                cli.Prenom_client = lecture["Prenom_client"].ToString();
                cli.adresse_livraison_client = lecture["adresse_livraison_client"].ToString();
                cli.code_post_liv_client = lecture["code_post_liv_client"].ToString();
                cli.ville_liv_client = lecture["ville_liv_client"].ToString();
                cli.adresse_facturation_client = lecture["adresse_facturation_client"].ToString();
                cli.code_post_facturation_client = lecture["code_post_facturation_client"].ToString();
                cli.ville_facturation_client = lecture["ville_facturation_client"].ToString();
                cli.siret_client = lecture["siret_client"].ToString();
                cli.tel_fix_client = lecture["tel_fix_client"].ToString();
                cli.tel_mobile_client = lecture["tel_mobile_client"].ToString();
                cli.mail_client = lecture["mail_client"].ToString();
                cli.pro_ou_part_client = Convert.ToBoolean(lecture["pro_ou_part_client"]);
                cli.id_commercial = Convert.ToInt32(lecture["id_commercial"]);
                cli.Affichage = lecture["prenom_client"].ToString() + " " + lecture["nom_client"].ToString();
                cli.coef_client = Convert.ToDecimal(lecture["coef_client"]);

            }
            lecture.Close();
            connect.Close();
            return cli;
        }
        public List<Client> List_pro(bool part_pro)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from client where pro_ou_part_client = @part_pro", connect);
            requete.Parameters.AddWithValue("@part_pro", part_pro);
            SqlDataReader lecture = requete.ExecuteReader();
            List<Client> liste = new List<Client>();
            while (lecture.Read())
            {
                Client varclient = new Client();
                varclient.num_client = Convert.ToInt32(lecture["num_client"]);
                varclient.nom_client = lecture["nom_client"].ToString();
                varclient.Prenom_client = lecture["Prenom_client"].ToString();
                varclient.adresse_livraison_client = lecture["adresse_livraison_client"].ToString();
                varclient.code_post_liv_client = lecture["code_post_liv_client"].ToString();
                varclient.ville_liv_client = lecture["ville_liv_client"].ToString();
                varclient.adresse_facturation_client = lecture["adresse_facturation_client"].ToString();
                varclient.code_post_facturation_client= lecture["code_post_facturation_client"].ToString();
                varclient.ville_facturation_client = lecture["ville_facturation_client"].ToString();
                varclient.siret_client = lecture["siret_client"].ToString();
                varclient.tel_fix_client = lecture["tel_fix_client"].ToString();
                varclient.tel_mobile_client = lecture["tel_mobile_client"].ToString();
                varclient.mail_client = lecture["mail_client"].ToString();
                varclient.pro_ou_part_client = Convert.ToBoolean(lecture["pro_ou_part_client"]);
                varclient.coef_client = Convert.ToDecimal(lecture["coef_client"]);
                
                varclient.Affichage = lecture["prenom_client"].ToString() + " " + lecture["nom_client"].ToString();
                liste.Add(varclient);
            }
            lecture.Close();
            connect.Close();
            return liste;
        }

        public void Insert(Client varclient)

        {
            connect.Open();
            SqlCommand requete = new SqlCommand ("insert into client (num_client, nom_client, prenom_client, adresse_livraison_client, code_post_liv_client, ville_liv_client, adresse_facturation_client, code_post_facturation_client, ville_facturation_client, siret_client, tel_fix_client, tel_mobile_client, mail_client, pro_ou_part_client, coef_client, id_commercial) values( @num_client, @nom_client, @Prenom_client, @adresse_livraison_client, @code_post_liv_client, @ville_liv_client, @adresse_facturation_client, @code_post_facturation_client, @ville_facturation_client, @siret_client, @tel_fix_client, @tel_mobile_client, @mail_client, @pro_ou_part_client, @coef_client, @id_commercial)", connect);
            requete.Parameters.AddWithValue("@num_client", varclient.num_client);
            requete.Parameters.AddWithValue("@nom_client", varclient.nom_client);
            requete.Parameters.AddWithValue("@Prenom_client", varclient.Prenom_client);
            requete.Parameters.AddWithValue("@adresse_livraison_client", varclient.adresse_livraison_client);
            requete.Parameters.AddWithValue("@code_post_liv_client", varclient.code_post_liv_client);
            requete.Parameters.AddWithValue("@ville_liv_client", varclient.ville_liv_client);
            requete.Parameters.AddWithValue("@adresse_facturation_client", varclient.adresse_facturation_client);
            requete.Parameters.AddWithValue("@code_post_facturation_client", varclient.code_post_facturation_client);
            requete.Parameters.AddWithValue("@ville_facturation_client", varclient.ville_facturation_client);
            requete.Parameters.AddWithValue("@siret_client", varclient.siret_client);
            requete.Parameters.AddWithValue("@tel_fix_client", varclient.tel_fix_client);
            requete.Parameters.AddWithValue("@tel_mobile_client", varclient.tel_mobile_client);
            requete.Parameters.AddWithValue("@mail_client", varclient.mail_client);
            requete.Parameters.AddWithValue("@pro_ou_part_client", varclient.pro_ou_part_client);
            requete.Parameters.AddWithValue("@coef_client", varclient.coef_client);
            requete.Parameters.AddWithValue("@id_commercial", varclient.id_commercial);
            requete.ExecuteNonQuery();
            connect.Close();
        }
        public int AutoIncrement()
        {
            int id;
            connect.Open();
            SqlCommand requete = new SqlCommand("select max(num_client) from client", connect);
            id = (int)requete.ExecuteScalar() + 1;
            connect.Close();
            return id;
        }
        public void Delete(Client Varclient)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("Delete from client where num_client = @num_client", connect);
            requete.Parameters.AddWithValue("@num_client", Varclient.num_client);
            requete.ExecuteNonQuery();
            connect.Close();
        }
        public void Update(Client varclient)

        {
            connect.Open();
            SqlCommand requete = new SqlCommand("update client set nom_client = @nom, Prenom_client = @Prenom, adresse_livraison_client = @adresse_livraison_client, code_post_liv_client = @code_post_liv_client,ville_liv_client = @ville_liv_client , adresse_facturation_client = @adresse_facturation_client, code_post_facturation_client= @code_post_facturation_client, ville_facturation_client = @ville_facturation_client, siret_client = @siret_client, tel_fix_client=@tel_fix_client, tel_mobile_client = @tel_mobile_client, mail_client = @mail_client, pro_ou_part_client = @pro_ou_part_client, coef_client = @coef_client, id_commercial = @id_commercial where num_client = @num_client", connect);
            requete.Parameters.AddWithValue("@num_client", varclient.num_client);
            requete.Parameters.AddWithValue("@nom", varclient.nom_client);
            requete.Parameters.AddWithValue("@Prenom", varclient.Prenom_client);
            requete.Parameters.AddWithValue("@adresse_livraison_client", varclient.adresse_livraison_client);
            requete.Parameters.AddWithValue("@code_post_liv_client", varclient.code_post_liv_client);
            requete.Parameters.AddWithValue("@ville_liv_client", varclient.ville_liv_client);
            requete.Parameters.AddWithValue("@adresse_facturation_client", varclient.adresse_facturation_client);
            requete.Parameters.AddWithValue("@code_post_facturation_client", varclient.code_post_facturation_client);
            requete.Parameters.AddWithValue("@ville_facturation_client", varclient.ville_facturation_client);
            requete.Parameters.AddWithValue("@siret_client", varclient.siret_client);
            requete.Parameters.AddWithValue("@tel_fix_client", varclient.tel_fix_client);
            requete.Parameters.AddWithValue("@tel_mobile_client", varclient.tel_mobile_client);
            requete.Parameters.AddWithValue("@mail_client", varclient.mail_client);
            requete.Parameters.AddWithValue("@pro_ou_part_client", varclient.pro_ou_part_client);
            requete.Parameters.AddWithValue("@coef_client", varclient.coef_client);
            requete.Parameters.AddWithValue("@id_commercial", varclient.id_commercial);
     
            requete.ExecuteNonQuery();
            connect.Close();
        }




    }
}
