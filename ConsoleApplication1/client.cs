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
    
    public partial class client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public client()
        {
            this.commande = new HashSet<commande>();
        }
    
        public int num_client { get; set; }
        public string nom_client { get; set; }
        public string prenom_client { get; set; }
        public string adresse_livraison_client { get; set; }
        public string code_post_liv_client { get; set; }
        public string ville_liv_client { get; set; }
        public string adresse_facturation_client { get; set; }
        public string code_post_facturation_client { get; set; }
        public string ville_facturation_client { get; set; }
        public string siret_client { get; set; }
        public string tel_fix_client { get; set; }
        public string tel_mobile_client { get; set; }
        public string mail_client { get; set; }
        public Nullable<bool> pro_ou_part_client { get; set; }
        public Nullable<double> coef_client { get; set; }
        public Nullable<int> id_commercial { get; set; }
    
        public virtual service_commercial service_commercial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commande> commande { get; set; }
    }
}
