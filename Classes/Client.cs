using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Client
    {
   

        public int num_client { get; set; }
        public string nom_client { get; set; }
        public string Prenom_client { get; set; }
        public string adresse_livraison_client { get; set; }
        public string code_post_liv_client { get; set; }
        public string ville_liv_client { get; set; }
        public string adresse_facturation_client{ get; set; }
        public string code_post_facturation_client { get; set; }
        public string ville_facturation_client { get; set; }
        public string siret_client { get; set; }
        public string tel_fix_client { get; set; }
        public string tel_mobile_client { get; set; }
        public string mail_client { get; set; }
        public bool pro_ou_part_client { get; set; }
        public decimal coef_client { get; set; }
        public string Affichage { get; set; }
        public int id_commercial { get; set; }
    }
}


