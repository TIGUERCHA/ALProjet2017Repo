﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ALProjet2017AL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CalendrierESGIEntities : DbContext
    {
        public CalendrierESGIEntities()
            : base("name=CalendrierESGIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ETUDIANT> ETUDIANT { get; set; }
        public virtual DbSet<MATIERE> MATIERE { get; set; }
        public virtual DbSet<PROMOTION> PROMOTION { get; set; }
        public virtual DbSet<RESERVATIONs> RESERVATIONs { get; set; }
        public virtual DbSet<SALLE> SALLE { get; set; }
    }
}
