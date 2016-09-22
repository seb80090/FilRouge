using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Commandes
    {


        public int num_commande { get; set; }
        public int num_facture { get; set; }
        public bool paiement_a_la_commande { get; set; }
        public decimal prix_vente_ht { get; set; }
        public decimal remise_supp_commande { get; set; }
        public string date_commande { get; set; }
        public string date_de_reglem_commande { get; set; }
        public string statut_commande { get; set; }
        public int num_client { get; set; }
        public string Affichage { get; set; }
    }
}