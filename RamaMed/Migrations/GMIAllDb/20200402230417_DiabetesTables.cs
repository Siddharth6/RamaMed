using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class DiabetesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiabetesAbdExams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    PAIN = table.Column<string>(nullable: true),
                    TEMPERATURE = table.Column<string>(nullable: true),
                    RIGIDITY = table.Column<string>(nullable: true),
                    VENOUS_DILATATION = table.Column<string>(nullable: true),
                    SCAR_MARKS = table.Column<string>(nullable: true),
                    COLOUR_OF_SKIN = table.Column<string>(nullable: true),
                    POSITION_OF_UMBILICUS = table.Column<string>(nullable: true),
                    MOVEMENT_OF_ABDOMEN = table.Column<string>(nullable: true),
                    SHAPE_OF_ABDOMEN = table.Column<string>(nullable: true),
                    SHIFTING_DULLNESS = table.Column<string>(nullable: true),
                    FLUID_THRILL = table.Column<string>(nullable: true),
                    SIGNS_OF_HERNIA = table.Column<string>(nullable: true),
                    TESTICULER_SWELLING = table.Column<string>(nullable: true),
                    HEMORRHOIDS = table.Column<string>(nullable: true),
                    FISSURE = table.Column<string>(nullable: true),
                    PROSTATE_CONDITION = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesAbdExams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiabetesClinicalSymptoms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    WEIGHT_LOSS_DURATION = table.Column<string>(nullable: true),
                    FATIGUE_GENERALISED_ITCHING_DURATION = table.Column<string>(nullable: true),
                    POLYDIPSIA_DURATION = table.Column<string>(nullable: true),
                    POLYPHAGIA_DURATION = table.Column<string>(nullable: true),
                    DYSURIA_DURATION = table.Column<string>(nullable: true),
                    NOCTURIA_DURATION = table.Column<string>(nullable: true),
                    BURNING_FEET_DURATION = table.Column<string>(nullable: true),
                    TINGLING_NUMBNESS_DURATION = table.Column<string>(nullable: true),
                    IMPOTENCE_DURATION = table.Column<string>(nullable: true),
                    GENITAL_ITCHING_DURATION = table.Column<string>(nullable: true),
                    BLURRING_OF_VISION_DURATION = table.Column<string>(nullable: true),
                    FEVER_DURATION = table.Column<string>(nullable: true),
                    ANGINAL_PAIN_DURATION = table.Column<string>(nullable: true),
                    BREATHLESSNESS_DURATION = table.Column<string>(nullable: true),
                    POSTURAL_DIZZINESS_DURATION = table.Column<string>(nullable: true),
                    POLYURIA_DURATION = table.Column<string>(nullable: true),
                    PAIN_ABDOMEN_DURATION = table.Column<string>(nullable: true),
                    OLIGURIA_DURATION = table.Column<string>(nullable: true),
                    SITE_DURATION = table.Column<string>(nullable: true),
                    WEAKNESS_DURATION = table.Column<string>(nullable: true),
                    SEVERITY_DURATION = table.Column<string>(nullable: true),
                    GENITAL_ULCERS_DURATION = table.Column<string>(nullable: true),
                    RADIATION_DURATION = table.Column<string>(nullable: true),
                    COUGH_WITH_SPUTUM_DURATION = table.Column<string>(nullable: true),
                    CHARACTER_DURATION = table.Column<string>(nullable: true),
                    PALPITATION_DURATION = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesClinicalSymptoms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiabetesCNSs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    HIGHER_FUNCTIONS_CONSCIOUS = table.Column<string>(nullable: true),
                    HIGHER_FUNCTIONS_UNCONSCIOUS_E = table.Column<string>(nullable: true),
                    HIGHER_FUNCTIONS_UNCONSCIOUS_V = table.Column<string>(nullable: true),
                    HIGHER_FUNCTIONS_UNCONSCIOUS_M = table.Column<string>(nullable: true),
                    HIGHER_FUNCTIONS_ORIENTATION = table.Column<string>(nullable: true),
                    HIGHER_FUNCTIONS_APPEARANCE = table.Column<string>(nullable: true),
                    HIGHER_FUNCTIONS_BEHAVIOUR = table.Column<string>(nullable: true),
                    HIGHER_FUNCTIONS_MEMORY = table.Column<string>(nullable: true),
                    HIGHER_FUNCTIONS_SPEECH = table.Column<string>(nullable: true),
                    HIGHER_FUNCTIONS_INTELLIGENCE = table.Column<string>(nullable: true),
                    HIGHER_FUNCTIONS_HALLUCINATION = table.Column<string>(nullable: true),
                    HIGHER_FUNCTIONS_DELUSION = table.Column<string>(nullable: true),
                    CRANIAL_NERVES = table.Column<string>(nullable: true),
                    MOTOR_SYSTEM_NEUTRITION = table.Column<string>(nullable: true),
                    MOTOR_SYSTEM_TONE = table.Column<string>(nullable: true),
                    MOTOR_SYSTEM_POWER = table.Column<string>(nullable: true),
                    MOTOR_SYSTEM_CO_ORDINATION = table.Column<string>(nullable: true),
                    MOTOR_SYSTEM_INVOLUNTRY_MOVEMENTS = table.Column<string>(nullable: true),
                    MOTOR_SYSTEM_REFLEXES = table.Column<string>(nullable: true),
                    MOTOR_SYSTEM_GAIT = table.Column<string>(nullable: true),
                    SENSORY_SYSTEM_SUPERFICIAL_SENSATION = table.Column<string>(nullable: true),
                    SENSORY_SYSTEM_DEEP_SENSATIONS = table.Column<string>(nullable: true),
                    SENSORY_SYSTEM_CORTICAL_SENSATION = table.Column<string>(nullable: true),
                    CRANIOVERTEBRAL_EXAMINATION = table.Column<string>(nullable: true),
                    CEREBELLAR_SIGNS = table.Column<string>(nullable: true),
                    AUTONOMIC_SYSTEM = table.Column<string>(nullable: true),
                    SIGNS_OF_MENINGIAL_IRRITATION = table.Column<string>(nullable: true),
                    PUPIL = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesCNSs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiabetesComorbidities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    HYPERTENSION_DURATION = table.Column<string>(nullable: true),
                    HYPERTENSION_MEDICATION = table.Column<string>(nullable: true),
                    CORONARY_ARTERY_DISEASE_DURATION = table.Column<string>(nullable: true),
                    CORONARY_ARTERY_DISEASE_MEDICATION = table.Column<string>(nullable: true),
                    COPD_DURATION = table.Column<string>(nullable: true),
                    COPD_MEDICATION = table.Column<string>(nullable: true),
                    ASTHMA_DURATION = table.Column<string>(nullable: true),
                    ASTHMA_MEDICATION = table.Column<string>(nullable: true),
                    CKD_DURATION = table.Column<string>(nullable: true),
                    CKD_MEDICATION = table.Column<string>(nullable: true),
                    HEART_FAILURE_DURATION = table.Column<string>(nullable: true),
                    HEART_FAILURE_MEDICATION = table.Column<string>(nullable: true),
                    HYPOTHYROIDISM_DURATION = table.Column<string>(nullable: true),
                    HYPOTHYROIDISM_MEDICATION = table.Column<string>(nullable: true),
                    PULMONARY_TB = table.Column<string>(nullable: true),
                    PULMONARY_TB_DATE_OF_DIAGNOSIS = table.Column<DateTime>(nullable: true),
                    PULMONARY_TB_ATT_REGIMEN = table.Column<string>(nullable: true),
                    PULMONARY_TB_DATE_OF_STARTING = table.Column<DateTime>(nullable: true),
                    PULMONARY_TB_DATE_OF_ENDING = table.Column<DateTime>(nullable: true),
                    HIV = table.Column<string>(nullable: true),
                    HBSAG = table.Column<string>(nullable: true),
                    ANTI_HCV = table.Column<string>(nullable: true),
                    DIABETES_MELLITUS = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesComorbidities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiabetesCVSs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    HEART_RATE = table.Column<int>(nullable: true),
                    RHYTHM = table.Column<string>(nullable: true),
                    SHAPE_OF_CHEST = table.Column<string>(nullable: true),
                    DIALATED_VEINS_OVER_CHEST = table.Column<string>(nullable: true),
                    SCAR_MARKS_OVER_CHEST = table.Column<string>(nullable: true),
                    APEX = table.Column<string>(nullable: true),
                    THRILL = table.Column<string>(nullable: true),
                    HEART_SOUNDS_S1_S2 = table.Column<string>(nullable: true),
                    HEART_SOUNDS_S3 = table.Column<string>(nullable: true),
                    HEART_SOUNDS_S4 = table.Column<string>(nullable: true),
                    PERICARDIAL_RUB = table.Column<string>(nullable: true),
                    MURMUR_DIASTOLIC = table.Column<string>(nullable: true),
                    MURMUR_SYSTOLIC = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesCVSs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiabetesGeneralExaminations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    BUILT = table.Column<string>(nullable: true),
                    NEUTRITION = table.Column<string>(nullable: true),
                    PULSE_RATE = table.Column<int>(nullable: true),
                    PULSE_RADIO_FEROMAL_DELAY = table.Column<string>(nullable: true),
                    PULSE_RYTHM = table.Column<string>(nullable: true),
                    PULSE_VOLUME = table.Column<string>(nullable: true),
                    PULSE_CONDITION_OF_ARTERIAL_WALL = table.Column<string>(nullable: true),
                    PULSE_CHARACTER = table.Column<string>(nullable: true),
                    PULSE_PERIPHERAL_PULSES = table.Column<string>(nullable: true),
                    BLOOD_PRESSURE = table.Column<int>(nullable: true),
                    TEMPERATURE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PALLOR = table.Column<string>(nullable: true),
                    ESTERUS = table.Column<string>(nullable: true),
                    CYNOSIS = table.Column<string>(nullable: true),
                    CLUBBING = table.Column<string>(nullable: true),
                    PEDAL_EDEMA = table.Column<string>(nullable: true),
                    LYMPH_NODE = table.Column<string>(nullable: true),
                    JVP = table.Column<string>(nullable: true),
                    NECK_SWELLING = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesGeneralExaminations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiabetesInvestigations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    CBC = table.Column<string>(nullable: true),
                    PBS = table.Column<string>(nullable: true),
                    RFT = table.Column<string>(nullable: true),
                    RBS = table.Column<string>(nullable: true),
                    LFT = table.Column<string>(nullable: true),
                    BS = table.Column<string>(nullable: true),
                    SR_ELECTROLYTE = table.Column<string>(nullable: true),
                    URINE_ROUTINE_MICROSCOPIC = table.Column<string>(nullable: true),
                    URINE_CULTURE_SESNSITIVITY = table.Column<string>(nullable: true),
                    BT_CT = table.Column<string>(nullable: true),
                    PT_INR = table.Column<string>(nullable: true),
                    ECG = table.Column<string>(nullable: true),
                    ECHOCARDIOLOGY_2D = table.Column<string>(nullable: true),
                    CHEST_X_RAY = table.Column<string>(nullable: true),
                    USG_ABDOMEN_WHOLE = table.Column<string>(nullable: true),
                    USG_ABDOMEN_PELVIS = table.Column<string>(nullable: true),
                    CT_ABDOMEN_PLAIN = table.Column<string>(nullable: true),
                    CT_ABDOMEN_CONTRACT = table.Column<string>(nullable: true),
                    UGI_ENDOSCOPY = table.Column<string>(nullable: true),
                    LIPID_PROFILE = table.Column<string>(nullable: true),
                    ASCITIC_FLUID_ANALYSIS = table.Column<string>(nullable: true),
                    HBA1C = table.Column<string>(nullable: true),
                    FUNDUS_EXAMINATION = table.Column<string>(nullable: true),
                    SR_AMYLASE = table.Column<string>(nullable: true),
                    LIPASE = table.Column<string>(nullable: true),
                    MRCP = table.Column<string>(nullable: true),
                    ERCP = table.Column<string>(nullable: true),
                    THYROID_PROFILE = table.Column<string>(nullable: true),
                    ANTI_GAD_ANTIBODY = table.Column<string>(nullable: true),
                    C_PEPTIDE = table.Column<string>(nullable: true),
                    OTHERS = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesInvestigations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiabetesOthers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    CLINICAL_DIAGNOSIS = table.Column<string>(nullable: true),
                    DIFFERENTIAL_DIAGNOSIS = table.Column<string>(nullable: true),
                    FINAL_DIAGNOSIS = table.Column<string>(nullable: true),
                    TREATMENT = table.Column<string>(nullable: true),
                    FOLLOW_UP = table.Column<string>(nullable: true),
                    REFER_TO_OTHER = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesOthers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiabetesPersonalHabits",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    SMOKING = table.Column<string>(nullable: true),
                    SMOKING_PACK_YEARS = table.Column<int>(nullable: true),
                    SMOKING_DURATION = table.Column<string>(nullable: true),
                    SMOKING_YEARS = table.Column<int>(nullable: true),
                    ALCOHOL_INTAKE = table.Column<string>(nullable: true),
                    ALCOHOL_INTAKE_QUANTITY = table.Column<string>(nullable: true),
                    ALCOHOL_INTAKE_DURATION = table.Column<string>(nullable: true),
                    ALCOHOL_INTAKE_YEARS = table.Column<int>(nullable: true),
                    OTHER_SUBSTANCE_USE = table.Column<string>(nullable: true),
                    LIFE_STYLE = table.Column<string>(nullable: true),
                    FAMILY_HISTORY = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesPersonalHabits", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiabetesRespSystems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    RATE = table.Column<int>(nullable: true),
                    RHYTHM = table.Column<string>(nullable: true),
                    MOVEMENTS = table.Column<string>(nullable: true),
                    POSITION_OF_TRACHEA = table.Column<string>(nullable: true),
                    BREATH_SOUND = table.Column<string>(nullable: true),
                    CREPTS = table.Column<string>(nullable: true),
                    RONCHI = table.Column<string>(nullable: true),
                    WHEEZING = table.Column<string>(nullable: true),
                    PLEURAL_RUB = table.Column<string>(nullable: true),
                    PLEURAL_FLUID = table.Column<string>(nullable: true),
                    PERCUSSION_NOTE = table.Column<string>(nullable: true),
                    BRONCHIAL_BREATH_SOUNDS = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesRespSystems", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiabetesAbdExams");

            migrationBuilder.DropTable(
                name: "DiabetesClinicalSymptoms");

            migrationBuilder.DropTable(
                name: "DiabetesCNSs");

            migrationBuilder.DropTable(
                name: "DiabetesComorbidities");

            migrationBuilder.DropTable(
                name: "DiabetesCVSs");

            migrationBuilder.DropTable(
                name: "DiabetesGeneralExaminations");

            migrationBuilder.DropTable(
                name: "DiabetesInvestigations");

            migrationBuilder.DropTable(
                name: "DiabetesOthers");

            migrationBuilder.DropTable(
                name: "DiabetesPersonalHabits");

            migrationBuilder.DropTable(
                name: "DiabetesRespSystems");
        }
    }
}
