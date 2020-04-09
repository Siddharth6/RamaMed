using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class UpdatedGastroCNS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastroCNSs");
        }
    }
}
