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
    
    public partial class Plafond
    {
        public Plafond()
        {
            this.Facture = new HashSet<Facture>();
            this.Ligne_PolicePlafond = new HashSet<Ligne_PolicePlafond>();
            this.Prestataire = new HashSet<Prestataire>();
        }
    
        public int IdPlafond { get; set; }
        public string LibellePlafond { get; set; }
    
        public virtual ICollection<Facture> Facture { get; set; }
        public virtual ICollection<Ligne_PolicePlafond> Ligne_PolicePlafond { get; set; }
        public virtual ICollection<Prestataire> Prestataire { get; set; }
    }
}
