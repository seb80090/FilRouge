//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class compose
    {
        public Nullable<int> qte_commande { get; set; }
        public Nullable<decimal> prix_vente_commande { get; set; }
        public Nullable<decimal> taux_tva_commande { get; set; }
        public int num_commande { get; set; }
        public string nom_court_article { get; set; }
    
        public virtual article article { get; set; }
        public virtual commande commande { get; set; }
    }
}