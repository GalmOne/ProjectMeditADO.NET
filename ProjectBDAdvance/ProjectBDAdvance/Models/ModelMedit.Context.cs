﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectBDAdvance.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VisiteMedacleEntities : DbContext
    {
        public VisiteMedacleEntities()
            : base("name=VisiteMedacleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Emploi> Emplois { get; set; }
        public virtual DbSet<Examan> Examen { get; set; }
        public virtual DbSet<ExamenPratique> ExamenPratiques { get; set; }
        public virtual DbSet<MedecinResponsable> MedecinResponsables { get; set; }
        public virtual DbSet<NonSoumi> NonSoumis { get; set; }
        public virtual DbSet<Personne> Personnes { get; set; }
        public virtual DbSet<Risque> Risques { get; set; }
        public virtual DbSet<Soumi> Soumis { get; set; }
        public virtual DbSet<Travailleur> Travailleurs { get; set; }
        public virtual DbSet<TypeLieu> TypeLieux { get; set; }
        public virtual DbSet<VisiteMedicale> VisiteMedicales { get; set; }
    }
}
