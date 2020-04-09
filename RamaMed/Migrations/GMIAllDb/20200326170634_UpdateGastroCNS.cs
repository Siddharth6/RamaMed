using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class UpdateGastroCNS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastroCNSs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GastroCNSs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AUTONOMIC_SYSTEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEREBELLAR_SIGNS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRANIAL_NERVES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRANIOVERTEBRAL_EXAMINATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATEDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HIGHER_FUNCTIONS_APPEARANCE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGHER_FUNCTIONS_BEHAVIOUR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGHER_FUNCTIONS_CONSCIOUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGHER_FUNCTIONS_DELUSION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGHER_FUNCTIONS_HALLUCINATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGHER_FUNCTIONS_INTELLIGENCE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGHER_FUNCTIONS_MEMORY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGHER_FUNCTIONS_ORIENTATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGHER_FUNCTIONS_SPEECH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGHER_FUNCTIONS_UNCONSCIOUS_E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGHER_FUNCTIONS_UNCONSCIOUS_M = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGHER_FUNCTIONS_UNCONSCIOUS_V = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTOR_SYSTEM_CO_ORDINATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTOR_SYSTEM_GAIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTOR_SYSTEM_NEUTRITION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTOR_SYSTEM_POWER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTOR_SYSTEM_REFLEXES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTOR_SYSTEM_TONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OPDNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PUPIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SENSORY_SYSTEM_CORTICAL_SENSATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SENSORY_SYSTEM_DEEP_SENSATIONS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SENSORY_SYSTEM_SUPERFICIAL_SENSATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIGNS_OF_MENINGIAL_IRRITATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UHID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastroCNSs", x => x.ID);
                });
        }
    }
}
