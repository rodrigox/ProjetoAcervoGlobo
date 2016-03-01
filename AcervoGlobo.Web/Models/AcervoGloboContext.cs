using AcervoGlobo.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AcervoGlobo.Web.Models
{
    public class AcervoGloboContext : DbContext 
    {
        public DbSet<Ator> Ator;
        public DbSet<Teledramaturgia> Teledramaturgia;
       
        public DbSet<Diretor> Diretor;

        public AcervoGloboContext() : base("AcervoGlobo") {


          
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Teledramaturgia>().HasMany(t => t.Ator);
            modelBuilder.Entity<Diretor>().HasMany(d => d.Teledramaturgia);
            modelBuilder.Entity<Ator>().HasOptional(a => a.Teledramaturgia);
            modelBuilder.Entity<Diretor>();



        }

        public System.Data.Entity.DbSet<AcervoGlobo.Dominio.Teledramaturgia> Teledramaturgias { get; set; }

        public System.Data.Entity.DbSet<AcervoGlobo.Dominio.Ator> Ators { get; set; }

        public System.Data.Entity.DbSet<AcervoGlobo.Dominio.Diretor> Diretors { get; set; }
    }
}