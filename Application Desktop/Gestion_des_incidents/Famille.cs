//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_des_incidents
{
    using System;
    using System.Collections.Generic;
    
    public partial class Famille
    {
        public Famille()
        {
            this.Fichiers = new HashSet<Fichier>();
        }
    
        public string idfamille { get; set; }
        public string famille1 { get; set; }
    
        public virtual ICollection<Fichier> Fichiers { get; set; }
    }
}