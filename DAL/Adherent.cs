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
    
    public partial class Adherent
    {
        public Adherent()
        {
            this.Affilie = new HashSet<Affilie>();
            this.Facture = new HashSet<Facture>();
        }
    
        public int IdAdherent { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public System.DateTime DateNaissance { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public int IdPolice { get; set; }
    
        public virtual Police Police { get; set; }
        public virtual ICollection<Affilie> Affilie { get; set; }
        public virtual ICollection<Facture> Facture { get; set; }
    }
}
