﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RamaMed.Data;

namespace RamaMed.Migrations.GMIAllDb
{
    [DbContext(typeof(GMIAllDbContext))]
    [Migration("20200326073704_UpdaetGastroTables")]
    partial class UpdaetGastroTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RamaMed.Models.GastroClinicalSymptom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ABDOMINAL_DISTENSION_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ABDOMINAL_PAIN_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ALTERED_BOWEL_HABITS_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ALTERED_SENSORIUM_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ALTERED_SLEEP_PATTERN_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BREATHELESSNESS_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CREATEDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("DYSPESIA_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DYSPHAGIA_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EASY_FATIGUABILITY_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FACIAL_PUFFINESS_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FEVER_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HEMATEMESIS_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HEMATOCHEZIA_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ICTERUS_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INVOLUNTARY_MOVEMENTS_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MALENA_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAUSEA_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ODYNOPHAGIA_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OLIGURIA_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPDNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PERSONALITY_CHANGES_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SWELLING_OF_BOTH_LEGS_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UHID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VOMITING_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WEIGHT_LOSS_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YELLOWISH_DISCOLORATION_OF_URINE_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("GastroClinicalSymptoms");
                });

            modelBuilder.Entity("RamaMed.Models.GastroComorbidity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ANTI_HCV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ASTHMA_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ASTHMA_MEDICATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CKD_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CKD_MEDICATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COPD_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COPD_MEDICATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CORONARY_ARTERY_DISEASE_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CORONARY_ARTERY_DISEASE_MEDICATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CREATEDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("DIABETES_MELLITUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HBSAG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HEART_FAILURE_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HEART_FAILURE_MEDICATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HYPERTENSION_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HYPERTENSION_MEDICATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HYPOTHYROIDISM_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HYPOTHYROIDISM_MEDICATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPDNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PULMONARY_TB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PULMONARY_TB_ATT_REGIMEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PULMONARY_TB_DATE_OF_DIAGNOSIS")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PULMONARY_TB_DATE_OF_ENDING")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PULMONARY_TB_DATE_OF_STARTING")
                        .HasColumnType("datetime2");

                    b.Property<string>("UHID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("GastroComorbidities");
                });

            modelBuilder.Entity("RamaMed.Models.GastroPersonalHabit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ALCOHOL_INTAKE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ALCOHOL_INTAKE_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ALCOHOL_INTAKE_QUANTITY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ALCOHOL_INTAKE_YEARS")
                        .HasColumnType("int");

                    b.Property<DateTime>("CREATEDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("FAMILY_HISTORY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LIFE_STYLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPDNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OTHER_SUBSTANCE_USE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SMOKING")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SMOKING_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SMOKING_PACK_YEARS")
                        .HasColumnType("int");

                    b.Property<int>("SMOKING_YEARS")
                        .HasColumnType("int");

                    b.Property<string>("UHID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("GastroPersonalHabits");
                });
#pragma warning restore 612, 618
        }
    }
}
