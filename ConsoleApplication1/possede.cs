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
    
    public partial class possede
    {
        public Nullable<int> qte_livree { get; set; }
        public int num_bon_livraison { get; set; }
        public string nom_court_article { get; set; }
    
        public virtual article article { get; set; }
        public virtual bon_de_livraison bon_de_livraison { get; set; }
    }
}