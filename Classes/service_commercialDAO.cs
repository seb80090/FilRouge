using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes
{
    public class service_commercialDAO
    {
        SqlConnection connect;

        public service_commercialDAO(string phrase)
        {
            connect = new SqlConnection(phrase);
        }


        public List<service_commercial> List()
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("select prenom_commercial, nom_commercial, tel_commercial, mail_commercial from client join service_commercial on client.id_commercial = client.id_commercial where id_commercial=@id",connect);
            SqlDataReader lecture = requete.ExecuteReader();
            List<service_commercial> liste = new List<service_commercial>();
            while (lecture.Read())
            {
                service_commercial commercial = new service_commercial();
                commercial.id_commercial = Convert.ToInt32(lecture["id_commercial"]);
                commercial.prenom_commercial = lecture["prenom_commercial"].ToString();
                commercial.nom_commercial = lecture["nom_commercial"].ToString();
                commercial.tel_commercial = lecture["tel_commercial"].ToString();
                commercial.mail_commercial = lecture["mail_commercial"].ToString();


                liste.Add(commercial);
            }

            connect.Close();
            return liste;
        }

        public service_commercial Find(int id)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from service_commercial where id_commercial=@id", connect);
            requete.Parameters.AddWithValue("@id", id);
            SqlDataReader lecture = requete.ExecuteReader();
            service_commercial commercial = new service_commercial();
            while (lecture.Read())
            {
                commercial.id_commercial = Convert.ToInt32(lecture["id_commercial"]);
                commercial.prenom_commercial = lecture["prenom_commercial"].ToString();
                commercial.nom_commercial = lecture["nom_commercial"].ToString();
                commercial.tel_commercial = lecture["tel_commercial"].ToString();
                commercial.mail_commercial = lecture["mail_commercial"].ToString();
            }

            connect.Close();
            return commercial;
        }

       
    }
}
