using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class AddAllExamination_Gastro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GastroAbdExams",
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
                    table.PrimaryKey("PK_GastroAbdExams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GastroCNSs",
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
                    table.PrimaryKey("PK_GastroCNSs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GastroCVSs",
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
                    HEART_SOUNDS_PERICARDIAL_RUB = table.Column<string>(nullable: true),
                    MURMUR_DIASTOLIC = table.Column<string>(nullable: true),
                    MURMUR_SYSTOLIC = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastroCVSs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GastroRespSystems",
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
                    table.PrimaryKey("PK_GastroRespSystems", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastroAbdExams");

            migrationBuilder.DropTable(
                name: "GastroCNSs");

            migrationBuilder.DropTable(
                name: "GastroCVSs");

            migrationBuilder.DropTable(
                name: "GastroRespSystems");
        }
    }
}
