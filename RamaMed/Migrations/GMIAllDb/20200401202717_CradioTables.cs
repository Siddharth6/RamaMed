using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class CradioTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardioAbdExams",
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
                    SIGNS_OF_HERNIA = table.Column<string>(nullable: true),
                    TESTICULER_SWELLING = table.Column<string>(nullable: true),
                    SHIFTING_DULLNESS = table.Column<string>(nullable: true),
                    FLUID_THRILL = table.Column<string>(nullable: true),
                    HEMORRHOIDS = table.Column<string>(nullable: true),
                    FISSURE = table.Column<string>(nullable: true),
                    PROSTATE_CONDITION = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardioAbdExams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CardioClinicalSymptoms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    BREATHLESNESS_DURATION = table.Column<string>(nullable: true),
                    PALPITATION_DURATION = table.Column<string>(nullable: true),
                    NYHA_CLASS_DURATION = table.Column<string>(nullable: true),
                    PEDAL_EDEMA_DURATION = table.Column<string>(nullable: true),
                    PND_DURATION = table.Column<string>(nullable: true),
                    SPUTUM_HAE_DURATION = table.Column<string>(nullable: true),
                    ORTHOPNOEA_DURATION = table.Column<string>(nullable: true),
                    ABDOMINAL_DISTENSION_DURATION = table.Column<string>(nullable: true),
                    PLATYPNOEA_DURATION = table.Column<string>(nullable: true),
                    DYSPESIA_DURATION = table.Column<string>(nullable: true),
                    CHEST_PAIN_DURATION = table.Column<string>(nullable: true),
                    NOCTURIA_DURATION = table.Column<string>(nullable: true),
                    SYNCOPE_DURATION = table.Column<string>(nullable: true),
                    NAUSEA_VOMITING_DURATION = table.Column<string>(nullable: true),
                    COUGH_DURATION = table.Column<string>(nullable: true),
                    OLIGURIA_DURATION = table.Column<string>(nullable: true),
                    ABDOMINAL_PAIN_DURATION = table.Column<string>(nullable: true),
                    HOARSENESS_OF_VOICE_DURATION = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardioClinicalSymptoms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CardioCNSs",
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
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardioCNSs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CardioComorbidities",
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
                    table.PrimaryKey("PK_CardioComorbidities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CardioCVSs",
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
                    table.PrimaryKey("PK_CardioCVSs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CardioGeneralExaminations",
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
                    table.PrimaryKey("PK_CardioGeneralExaminations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CardioInvestigations",
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
                    UGI_ENDOSCOPY = table.Column<string>(nullable: true),
                    ASCITIC_FLUID_ANALYSIS = table.Column<string>(nullable: true),
                    TUMOR_MARKERS = table.Column<string>(nullable: true),
                    SR_AMYLASE = table.Column<string>(nullable: true),
                    LIPASE = table.Column<string>(nullable: true),
                    CRP = table.Column<string>(nullable: true),
                    ESR = table.Column<string>(nullable: true),
                    ASO_TITRE = table.Column<string>(nullable: true),
                    LIPID_PROFILE = table.Column<string>(nullable: true),
                    THYROID_PROFILE = table.Column<string>(nullable: true),
                    CPK_MB = table.Column<string>(nullable: true),
                    TROPONIN_T = table.Column<string>(nullable: true),
                    TROPONIN_I = table.Column<string>(nullable: true),
                    PERICARDIAL_FLUID_EXAMINATION = table.Column<string>(nullable: true),
                    HOLTER = table.Column<string>(nullable: true),
                    TMT = table.Column<string>(nullable: true),
                    STRESS_ECHOCARDIOGRAPHY = table.Column<string>(nullable: true),
                    ANGIOGRAPHY = table.Column<string>(nullable: true),
                    CARDIAC_CT = table.Column<string>(nullable: true),
                    CARDIAC_MRI = table.Column<string>(nullable: true),
                    TEE = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardioInvestigations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CardioOthers",
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
                    table.PrimaryKey("PK_CardioOthers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CardioPersonals",
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
                    table.PrimaryKey("PK_CardioPersonals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CardioRespSystems",
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
                    table.PrimaryKey("PK_CardioRespSystems", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardioAbdExams");

            migrationBuilder.DropTable(
                name: "CardioClinicalSymptoms");


            migrationBuilder.DropTable(
                name: "CardioCNSs");

            migrationBuilder.DropTable(
                name: "CardioComorbidities");

            migrationBuilder.DropTable(
                name: "CardioCVSs");

            migrationBuilder.DropTable(
                name: "CardioGeneralExaminations");

            migrationBuilder.DropTable(
                name: "CardioInvestigations");

            migrationBuilder.DropTable(
                name: "CardioOthers");

            migrationBuilder.DropTable(
                name: "CardioPersonals");

            migrationBuilder.DropTable(
                name: "CardioRespSystems");
        }
    }
}
