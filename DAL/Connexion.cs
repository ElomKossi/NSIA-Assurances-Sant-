//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Connexion
    {
        public int IdConnexion { get; set; }
        public int IdUtilisateur { get; set; }
        public Nullable<System.DateTime> Debut { get; set; }
        public Nullable<System.DateTime> Fin { get; set; }
        public string adresseIp { get; set; }
    
        public virtual CompteUtilisateur CompteUtilisateur { get; set; }
    }
}