using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class DiabetesEndroBasic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicAbdExams",
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
                    table.PrimaryKey("PK_BasicAbdExams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasicClinicalSymptoms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    WEIGHT_GAIN_DURATION = table.Column<string>(nullable: true),
                    GALACTRORRHOEA_DURATION = table.Column<string>(nullable: true),
                    INCREASED_APETITE_DURATION = table.Column<string>(nullable: true),
                    ABDOMEN_PAIN_DURATION = table.Column<string>(nullable: true),
                    PALPITATION_DURATION = table.Column<string>(nullable: true),
                    ENLARGRMENT_OF_FOOT_DURATION = table.Column<string>(nullable: true),
                    EXCESSIVE_SWEATING_DURATION = table.Column<string>(nullable: true),
                    LOSS_OF_LIBIDO_DURATION = table.Column<string>(nullable: true),
                    OLIGOMENOORHEA_DURATION = table.Column<string>(nullable: true),
                    SKIN_DRYNESS_DURATION = table.Column<string>(nullable: true),
                    GYNECOMASTIA_DURATION = table.Column<string>(nullable: true),
                    TREMOR_DURATION = table.Column<string>(nullable: true),
                    DIPLOPIA_DURATION = table.Column<string>(nullable: true),
                    DIARRHOEA_DURATION = table.Column<string>(nullable: true),
                    ENLARGEMENT_OF_HAND_DURATION = table.Column<string>(nullable: true),
                    DYSMEONORRHOEA_DURATION = table.Column<string>(nullable: true),
                    HIRSUTISM_DURATION = table.Column<string>(nullable: true),
                    AMENNORHOEA_DURATION = table.Column<string>(nullable: true),
                    WEIGHT_LOSS_DURATION = table.Column<string>(nullable: true),
                    HEADACHE_DURATION = table.Column<string>(nullable: true),
                    LOSS_OF_APETITE_DURATION = table.Column<string>(nullable: true),
                    SEIZURES_DURATION = table.Column<string>(nullable: true),
                    CONSTIPATION_DURATION = table.Column<string>(nullable: true),
                    INFERTILITY_DURATION = table.Column<string>(nullable: true),
                    FATIGUE_DURATION = table.Column<string>(nullable: true),
                    PAIN_OVER_FINGERS_DURATION = table.Column<string>(nullable: true),
                    POLYMENORRHEA_DURATION = table.Column<string>(nullable: true),
                    YELLOWISH_DISCOLORATION_OF_URINE_DURATION = table.Column<string>(nullable: true),
                    NAUSEA_DURATION = table.Column<string>(nullable: true),
                    VOMITING_DURATION = table.Column<string>(nullable: true),
                    ALTERED_BOWEL_HABITS_DURATION = table.Column<string>(nullable: true),
                    MALENA_DURATION = table.Column<string>(nullable: true),
                    HEMATEMESIS_DURATION = table.Column<string>(nullable: true),
                    DYSPESIA_DURATION = table.Column<string>(nullable: true),
                    FEVER_DURATION = table.Column<string>(nullable: true),
                    ICTERUS_DURATION = table.Column<string>(nullable: true),
                    ABDOMINAL_DISTENSION_DURATION = table.Column<string>(nullable: true),
                    EASY_FATIGUABILITY_DURATION = table.Column<string>(nullable: true),
                    BREATHLESSNESS_DURATION = table.Column<string>(nullable: true),
                    INVOLUNTARY_MOVEMENTS_DURATION = table.Column<string>(nullable: true),
                    ALTERED_SENSORIUM_DURATION = table.Column<string>(nullable: true),
                    PERSONALITY_CHANGES_DURATION = table.Column<string>(nullable: true),
                    ALTERED_SLEEP_PATTERN_DURATION = table.Column<string>(nullable: true),
                    HEMATOCHEZIA_DURATION = table.Column<string>(nullable: true),
                    OLIGURIA_DURATION = table.Column<string>(nullable: true),
                    DYSPHAGIA_DURATION = table.Column<string>(nullable: true),
                    FACIAL_PUFFINESS_DURATION = table.Column<string>(nullable: true),
                    ODYNOPHAGIA_DURATION = table.Column<string>(nullable: true),
                    SWELLING_OF_BOTH_LEGS_DURATION = table.Column<string>(nullable: true),
                    POLYPHAGIA_DURATION = table.Column<string>(nullable: true),
                    POLYDIPSIA_DURATION = table.Column<string>(nullable: true),
                    RADIATION_DURATION = table.Column<string>(nullable: true),
                    DYSURIA_DURATION = table.Column<string>(nullable: true),
                    IMPOTENCE_DURATION = table.Column<string>(nullable: true),
                    BURNING_FEET_DURATION = table.Column<string>(nullable: true),
                    ANGINAL_PAIN_DURATION = table.Column<string>(nullable: true),
                    BLURRING_OF_VISION_DURATION = table.Column<string>(nullable: true),
                    SITE_DURATION = table.Column<string>(nullable: true),
                    POSTURAL_DIZZINESS_DURATION = table.Column<string>(nullable: true),
                    SEVERITY_DURATION = table.Column<string>(nullable: true),
                    FATIGUE_GENERALISED_ITCHING_DURATION = table.Column<string>(nullable: true),
                    CHARACTER_DURATION = table.Column<string>(nullable: true),
                    NOCTURIA_DURATION = table.Column<string>(nullable: true),
                    TINGLING_NUMBNESS_DURATION = table.Column<string>(nullable: true),
                    GENITAL_ITCHING_DURATION = table.Column<string>(nullable: true),
                    WEAKNESS_DURATION = table.Column<string>(nullable: true),
                    COUGH_DURATION = table.Column<string>(nullable: true),
                    SPUTUM_DURATION = table.Column<string>(nullable: true),
                    GENITAL_ULCERS_DURATION = table.Column<string>(nullable: true),
                    PEDAL_EDEMA_DURATION = table.Column<string>(nullable: true),
                    NYHA_CLASS_DURATION = table.Column<string>(nullable: true),
                    PND_DURATION = table.Column<string>(nullable: true),
                    ORTHOPNOEA_DURATION = table.Column<string>(nullable: true),
                    PLATYPNOEA_DURATION = table.Column<string>(nullable: true),
                    SYNCOPE_DURATION = table.Column<string>(nullable: true),
                    CHEST_PAIN_DURATION = table.Column<string>(nullable: true),
                    HOARSENESS_DURATION = table.Column<string>(nullable: true),
                    OTHERS_DURATION = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicClinicalSymptoms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasicCNSs",
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
                    table.PrimaryKey("PK_BasicCNSs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasicComorbidities",
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
                    table.PrimaryKey("PK_BasicComorbidities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasicCVSs",
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
                    table.PrimaryKey("PK_BasicCVSs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasicGeneralExaminations",
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
                    table.PrimaryKey("PK_BasicGeneralExaminations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasicInvestigations",
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
                    URINE_KETONES_BODIES = table.Column<string>(nullable: true),
                    BT_CT = table.Column<string>(nullable: true),
                    PT_INR = table.Column<string>(nullable: true),
                    ECG = table.Column<string>(nullable: true),
                    ECHOCARDIOLOGY_2D = table.Column<string>(nullable: true),
                    CHEST_X_RAY = table.Column<string>(nullable: true),
                    USG_ABDOMEN_WHOLE = table.Column<string>(nullable: true),
                    USG_ABDOMEN_PELVIS = table.Column<string>(nullable: true),
                    USG_NECK = table.Column<string>(nullable: true),
                    UGI_ENDOSCOPY = table.Column<string>(nullable: true),
                    ASCITIC_FLUID_ANALYSIS = table.Column<string>(nullable: true),
                    SR_AMYLASE = table.Column<string>(nullable: true),
                    LIPASE = table.Column<string>(nullable: true),
                    TUMOR_MARKERS = table.Column<string>(nullable: true),
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
                    CT_ABDOMEN_PLAIN = table.Column<string>(nullable: true),
                    CT_ABDOMEN_CONTRAST = table.Column<string>(nullable: true),
                    HBA1C = table.Column<string>(nullable: true),
                    FUNDUS_EXAMINATION = table.Column<string>(nullable: true),
                    MRCP = table.Column<string>(nullable: true),
                    ERCP = table.Column<string>(nullable: true),
                    ANTI_GAD_ANTIBODY = table.Column<string>(nullable: true),
                    C_PEPTIDE = table.Column<string>(nullable: true),
                    ANTI_TPO = table.Column<string>(nullable: true),
                    ANTI_THYROGLOBULIN_ANTI_BODY = table.Column<string>(nullable: true),
                    THYROID_FNAC = table.Column<string>(nullable: true),
                    MRI_BRAIN_WITH_CONTRAST = table.Column<string>(nullable: true),
                    RIU = table.Column<string>(nullable: true),
                    PROLACTIN = table.Column<string>(nullable: true),
                    TESTOSTERONE = table.Column<string>(nullable: true),
                    LH = table.Column<string>(nullable: true),
                    FSH = table.Column<string>(nullable: true),
                    ESTROGEN = table.Column<string>(nullable: true),
                    CORTISOL_LEVEL = table.Column<string>(nullable: true),
                    GROWTH_HORMONE = table.Column<string>(nullable: true),
                    COLONOSCOPY = table.Column<string>(nullable: true),
                    LIVER_BIOPSY = table.Column<string>(nullable: true),
                    OTHERS = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicInvestigations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasicOthers",
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
                    table.PrimaryKey("PK_BasicOthers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasicPersonals",
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
                    table.PrimaryKey("PK_BasicPersonals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasicRespSystems",
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
                    table.PrimaryKey("PK_BasicRespSystems", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EndocrinoAbdExams",
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
                    table.PrimaryKey("PK_EndocrinoAbdExams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EndocrinoClinicalSymptoms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    WEIGHT_GAIN_DURATION = table.Column<string>(nullable: true),
                    GALACTRORRHOEA_DURATION = table.Column<string>(nullable: true),
                    INCREASED_APETITE_DURATION = table.Column<string>(nullable: true),
                    ABDOMEN_PAIN_DURATION = table.Column<string>(nullable: true),
                    PALPITATION_DURATION = table.Column<string>(nullable: true),
                    ENLARGEMENT_OF_FOOT_DURATION = table.Column<string>(nullable: true),
                    EXCESSIVE_SWEATING_DURATION = table.Column<string>(nullable: true),
                    LOSS_OF_LIBIDO_DURATION = table.Column<string>(nullable: true),
                    OLIGOMENOORHEA_DURATION = table.Column<string>(nullable: true),
                    SKIN_DRYNESS_DURATION = table.Column<string>(nullable: true),
                    GYNECOMASTIA_DURATION = table.Column<string>(nullable: true),
                    TREMOR_DURATION = table.Column<string>(nullable: true),
                    DIPLOPIA_DURATION = table.Column<string>(nullable: true),
                    DIARRHOEA_DURATION = table.Column<string>(nullable: true),
                    ENLARGEMENT_OF_HAND_DURATION = table.Column<string>(nullable: true),
                    DYSMEONORRHOEA_DURATION = table.Column<string>(nullable: true),
                    HIRSUTISM_DURATION = table.Column<string>(nullable: true),
                    AMENNORHOEA_DURATION = table.Column<string>(nullable: true),
                    WEIGHT_LOSS_DURATION = table.Column<string>(nullable: true),
                    HEADACHE_DURATION = table.Column<string>(nullable: true),
                    LOSS_OF_APETITE_DURATION = table.Column<string>(nullable: true),
                    SEIZURES_DURATION = table.Column<string>(nullable: true),
                    CONSTIPATION_DURATION = table.Column<string>(nullable: true),
                    INFERTILITY_DURATION = table.Column<string>(nullable: true),
                    FATIGUE_DURATION = table.Column<string>(nullable: true),
                    PAIN_TINGLING_OVER_FINGERS_DURATION = table.Column<string>(nullable: true),
                    POLYMENORRHEA_DURATION = table.Column<string>(nullable: true),
                    OTHERS = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndocrinoClinicalSymptoms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EndocrinoCNSs",
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
                    table.PrimaryKey("PK_EndocrinoCNSs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EndocrinoComorbidities",
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
                    table.PrimaryKey("PK_EndocrinoComorbidities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EndocrinoCVSs",
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
                    table.PrimaryKey("PK_EndocrinoCVSs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EndocrinoGeneralExaminations",
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
                    table.PrimaryKey("PK_EndocrinoGeneralExaminations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EndocrinoInvestigations",
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
                    ANTI_TPO = table.Column<string>(nullable: true),
                    ANTI_THYROGLOBULIN_ANTI_BODY = table.Column<string>(nullable: true),
                    ECG = table.Column<string>(nullable: true),
                    ECHOCARDIOLOGY_2D = table.Column<string>(nullable: true),
                    CHEST_X_RAY = table.Column<string>(nullable: true),
                    USG_ABDOMEN_WHOLE = table.Column<string>(nullable: true),
                    USG_NECK = table.Column<string>(nullable: true),
                    CT_ABDOMEN_PLAIN = table.Column<string>(nullable: true),
                    CT_ABDOMEN_CONTRACT = table.Column<string>(nullable: true),
                    UGI_ENDOSCOPY = table.Column<string>(nullable: true),
                    THYROID_FNAC = table.Column<string>(nullable: true),
                    ASCITIC_FLUID_ANALYSIS = table.Column<string>(nullable: true),
                    TUMOR_MARKERS = table.Column<string>(nullable: true),
                    LIPID_PROFILE = table.Column<string>(nullable: true),
                    SR_AMYLASE = table.Column<string>(nullable: true),
                    LIPASE = table.Column<string>(nullable: true),
                    MRCP = table.Column<string>(nullable: true),
                    ERCP = table.Column<string>(nullable: true),
                    MRI_BRAIN_EITH_CONTRAST = table.Column<string>(nullable: true),
                    RUI = table.Column<string>(nullable: true),
                    PROLACTIN = table.Column<string>(nullable: true),
                    TESTOSTERONE = table.Column<string>(nullable: true),
                    LH = table.Column<string>(nullable: true),
                    FSH = table.Column<string>(nullable: true),
                    ESTROGEN = table.Column<string>(nullable: true),
                    CORTISOL_LEVEL = table.Column<string>(nullable: true),
                    GROWTH_HORMONE = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndocrinoInvestigations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EndocrinoOthers",
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
                    table.PrimaryKey("PK_EndocrinoOthers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EndocrinoPersonalHabits",
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
                    table.PrimaryKey("PK_EndocrinoPersonalHabits", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EndocrinoRespSystems",
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
                    table.PrimaryKey("PK_EndocrinoRespSystems", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicAbdExams");

            migrationBuilder.DropTable(
                name: "BasicClinicalSymptoms");

            migrationBuilder.DropTable(
                name: "BasicCNSs");

            migrationBuilder.DropTable(
                name: "BasicComorbidities");

            migrationBuilder.DropTable(
                name: "BasicCVSs");

            migrationBuilder.DropTable(
                name: "BasicGeneralExaminations");

            migrationBuilder.DropTable(
                name: "BasicInvestigations");

            migrationBuilder.DropTable(
                name: "BasicOthers");

            migrationBuilder.DropTable(
                name: "BasicPersonals");

            migrationBuilder.DropTable(
                name: "BasicRespSystems");

            migrationBuilder.DropTable(
                name: "EndocrinoAbdExams");

            migrationBuilder.DropTable(
                name: "EndocrinoClinicalSymptoms");

            migrationBuilder.DropTable(
                name: "EndocrinoCNSs");

            migrationBuilder.DropTable(
                name: "EndocrinoComorbidities");

            migrationBuilder.DropTable(
                name: "EndocrinoCVSs");

            migrationBuilder.DropTable(
                name: "EndocrinoGeneralExaminations");

            migrationBuilder.DropTable(
                name: "EndocrinoInvestigations");

            migrationBuilder.DropTable(
                name: "EndocrinoOthers");

            migrationBuilder.DropTable(
                name: "EndocrinoPersonalHabits");

            migrationBuilder.DropTable(
                name: "EndocrinoRespSystems");
        }
    }
}
