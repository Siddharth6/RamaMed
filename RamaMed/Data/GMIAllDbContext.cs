using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RamaMed.Models;

namespace RamaMed.Data
{
    public class GMIAllDbContext : DbContext
    {
        public GMIAllDbContext(DbContextOptions<GMIAllDbContext> options) : base(options)
        {

        }
        //Gastroclinic
        public DbSet<GastroClinicalSymptom> GastroClinicalSymptoms { get; set; }

        public DbSet<GastroComorbidity> GastroComorbidities { get; set; }

        public DbSet<GastroPersonalHabit> GastroPersonalHabits { get; set; }

        public DbSet<GastroGeneralExamination> GastroGeneralExaminations { get; set; }

        public DbSet<GastroCNS> GastroCNSs { get; set; }

        public DbSet<GastroRespSystem> GastroRespSystems { get; set; }

        public DbSet<GastroAbdExam> GastroAbdExams { get; set; }

        public DbSet<GastroCVS> GastroCVSs { get; set; }

        public DbSet<GastroInvestigation> GastroInvestigations { get; set; }

        public DbSet<GastroOther> GastroOthers { get; set; }


        //CardioClinic

        public DbSet<CardioClinicalSymptom> CardioClinicalSymptoms { get; set; }

        public DbSet<CardioComorbidity> CardioComorbidities { get; set; }

        public DbSet<CardioPersonal> CardioPersonals { get; set; }

        public DbSet<CardioGeneralExamination> CardioGeneralExaminations { get; set; }

        public DbSet<CardioCNS> CardioCNSs { get; set; }

        public DbSet<CardioRespSystem> CardioRespSystems { get; set; }

        public DbSet<CardioAbdExam> CardioAbdExams { get; set; }

        public DbSet<CardioCVS> CardioCVSs { get; set; }

        public DbSet<CardioInvestigation> CardioInvestigations { get; set; }

        public DbSet<CardioOther> CardioOthers { get; set; }


        //DiabetesAbdExam Clinic

        public DbSet<DiabetesClinicalSymptom> DiabetesClinicalSymptoms { get; set; }

        public DbSet<DiabetesComorbidity> DiabetesComorbidities { get; set; }

        public DbSet<DiabetesPersonalHabit> DiabetesPersonalHabits { get; set; }

        public DbSet<DiabetesGeneralExamination> DiabetesGeneralExaminations { get; set; }

        public DbSet<DiabetesCNS> DiabetesCNSs { get; set; }

        public DbSet<DiabetesRespSystem> DiabetesRespSystems { get; set; }

        public DbSet<DiabetesAbdExam> DiabetesAbdExams { get; set; }

        public DbSet<DiabetesCVS> DiabetesCVSs { get; set; }

        public DbSet<DiabetesInvestigation> DiabetesInvestigations { get; set; }

        public DbSet<DiabetesOther> DiabetesOthers { get; set; }
    }
}
