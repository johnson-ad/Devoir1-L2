//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Devoir1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produit
    {
        public string C_ { get; set; }
        public int idProduit { get; set; }
        public Nullable<double> CodeProduit { get; set; }
        public string LibelleProduit { get; set; }
        public Nullable<double> PUProduit { get; set; }
        public Nullable<double> QteProduit { get; set; }
        public Nullable<double> QteMinimale { get; set; }
        public Nullable<double> QteCritque { get; set; }
        public int idCategorie { get; set; }
    
        public virtual Categorie Categorie { get; set; }
    }
}
