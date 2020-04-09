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
    [Migration("20200320142826_EditDateTimeGCS")]
    partial class EditDateTimeGCS
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

                    b.Property<string>("VOMITING_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WEIGHT_LOSS_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YELLOWISH_DISCOLORATION_OF_URINE_DURATION")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("GastroClinicalSymptoms");
                });
#pragma warning restore 612, 618
        }
    }
}
