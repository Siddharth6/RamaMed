using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RamaMed.Models;

namespace RamaMed.Data
{
    public class GMIDbContext : DbContext
    {
        public GMIDbContext(DbContextOptions<GMIDbContext> options) : base(options)
        {

        }

        //public DbSet<GastroClinicSymp> GastroClinicSymps { get; set; }
        public DbSet<GastroClinicalSymptom> GastroClinicalSymptoms { get; set; }
    }
}
