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
    
    public partial class Ligne_PolicePlafond
    {
        public int Id { get; set; }
        public int IdPolice { get; set; }
        public int IdPlafond { get; set; }
        public double MontantPlafond { get; set; }
    
        public virtual Plafond Plafond { get; set; }
        public virtual Police Police { get; set; }
    }
}