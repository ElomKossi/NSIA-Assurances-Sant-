﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AssBdEntities : DbContext
    {
        public AssBdEntities()
            : base("name=AssBdEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adherent> Adherent { get; set; }
        public virtual DbSet<Affilie> Affilie { get; set; }
        public virtual DbSet<CompteUtilisateur> CompteUtilisateur { get; set; }
        public virtual DbSet<Connexion> Connexion { get; set; }
        public virtual DbSet<Facture> Facture { get; set; }
        public virtual DbSet<Ligne_PolicePlafond> Ligne_PolicePlafond { get; set; }
        public virtual DbSet<Plafond> Plafond { get; set; }
        public virtual DbSet<Police> Police { get; set; }
        public virtual DbSet<Prestataire> Prestataire { get; set; }
        public virtual DbSet<Profil> Profil { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
