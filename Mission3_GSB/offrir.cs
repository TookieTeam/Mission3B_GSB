//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mission3_GSB
{
    using System;
    using System.Collections.Generic;
    
    public partial class offrir
    {
        public int idRapport { get; set; }
        public string idMedicament { get; set; }
        public Nullable<int> quantite { get; set; }
    
        public virtual medicament medicament { get; set; }
        public virtual rapport rapport { get; set; }
    }
}
