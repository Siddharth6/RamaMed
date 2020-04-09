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
    [Migration("20200326154929_AddAllExamination_Gastro")]
    partial class AddAllExamination_Gastro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RamaMed.Models.GastroAbdExam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("COLOUR_OF_SKIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CREATEDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("FISSURE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FLUID_THRILL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HEMORRHOIDS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOVEMENT_OF_ABDOMEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPDNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POSITION_OF_UMBILICUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROSTATE_CONDITION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RIGIDITY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SCAR_MARKS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SHAPE_OF_ABDOMEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SHIFTING_DULLNESS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SIGNS_OF_HERNIA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TEMPERATURE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TESTICULER_SWELLING")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UHID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATEDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("VENOUS_DILATATION")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("GastroAbdExams");
                });

            modelBuilder.Entity("RamaMed.Models.GastroCNS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AUTONOMIC_SYSTEM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEREBELLAR_SIGNS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRANIAL_NERVES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRANIOVERTEBRAL_EXAMINATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CREATEDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("HIGHER_FUNCTIONS_APPEARANCE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGHER_FUNCTIONS_BEHAVIOUR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGHER_FUNCTIONS_CONSCIOUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGHER_FUNCTIONS_DELUSION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGHER_FUNCTIONS_HALLUCINATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGHER_FUNCTIONS_INTELLIGENCE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGHER_FUNCTIONS_MEMORY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGHER_FUNCTIONS_ORIENTATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGHER_FUNCTIONS_SPEECH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGHER_FUNCTIONS_UNCONSCIOUS_E")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGHER_FUNCTIONS_UNCONSCIOUS_M")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGHER_FUNCTIONS_UNCONSCIOUS_V")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTOR_SYSTEM_CO_ORDINATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTOR_SYSTEM_GAIT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTOR_SYSTEM_NEUTRITION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTOR_SYSTEM_POWER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTOR_SYSTEM_REFLEXES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTOR_SYSTEM_TONE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPDNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PUPIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SENSORY_SYSTEM_CORTICAL_SENSATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SENSORY_SYSTEM_DEEP_SENSATIONS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SENSORY_SYSTEM_SUPERFICIAL_SENSATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SIGNS_OF_MENINGIAL_IRRITATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UHID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATEDATE")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("GastroCNSs");
                });

            modelBuilder.Entity("RamaMed.Models.GastroCVS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("APEX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CREATEDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("DIALATED_VEINS_OVER_CHEST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HEART_RATE")
                        .HasColumnType("int");

                    b.Property<string>("HEART_SOUNDS_PERICARDIAL_RUB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HEART_SOUNDS_S1_S2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HEART_SOUNDS_S3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HEART_SOUNDS_S4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MURMUR_DIASTOLIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MURMUR_SYSTOLIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPDNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RHYTHM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SCAR_MARKS_OVER_CHEST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SHAPE_OF_CHEST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("THRILL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UHID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATEDATE")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("GastroCVSs");
                });

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

                    b.Property<DateTime?>("UPDATEDATE")
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

                    b.Property<DateTime?>("PULMONARY_TB_DATE_OF_DIAGNOSIS")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PULMONARY_TB_DATE_OF_ENDING")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PULMONARY_TB_DATE_OF_STARTING")
                        .HasColumnType("datetime2");

                    b.Property<string>("UHID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATEDATE")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("GastroComorbidities");
                });

            modelBuilder.Entity("RamaMed.Models.GastroGeneralExamination", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BLOOD_PRESSURE")
                        .HasColumnType("int");

                    b.Property<string>("BUILT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CLUBBING")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CREATEDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("CYNOSIS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESTERUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JVP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LYMPH_NODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NECK_SWELLING")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NEUTRITION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPDNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PALLOR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PEDAL_EDEMA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PULSE_CHARACTER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PULSE_CONDITION_OF_ARTERIAL_WALL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PULSE_PERIPHERAL_PULSES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PULSE_RADIO_FEROMAL_DELAY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PULSE_RATE")
                        .HasColumnType("int");

                    b.Property<string>("PULSE_RYTHM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PULSE_VOLUME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TEMPERATURE")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UHID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATEDATE")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("GastroGeneralExaminations");
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

                    b.Property<DateTime?>("UPDATEDATE")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("GastroPersonalHabits");
                });

            modelBuilder.Entity("RamaMed.Models.GastroRespSystem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BREATH_SOUND")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BRONCHIAL_BREATH_SOUNDS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CREATEDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("CREPTS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOVEMENTS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPDNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PERCUSSION_NOTE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLEURAL_FLUID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLEURAL_RUB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POSITION_OF_TRACHEA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RATE")
                        .HasColumnType("int");

                    b.Property<string>("RHYTHM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RONCHI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UHID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATEDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("WHEEZING")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("GastroRespSystems");
                });
#pragma warning restore 612, 618
        }
    }
}
