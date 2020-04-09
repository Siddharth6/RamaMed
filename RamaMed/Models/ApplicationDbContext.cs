using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RamaMed.Models
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UserData>()
        //        .HasIndex(p => new { p.OPDNo })
        //        .IsUnique(true);
        //}

        public DbSet<BasicClinic> BasicClinics { get; set; }
        public DbSet<CardioClinic> CardioClinics { get; set; }
        public DbSet<DiabetesClinic> DiabetesClinics { get; set; }
        public DbSet<EndocrinoClinic> EndocrinoClinics { get; set; }
        public DbSet<GastroClinic> GastroClinics { get; set; }

        public DbSet<UserData> UserDatas { get; set; }


    }
}
