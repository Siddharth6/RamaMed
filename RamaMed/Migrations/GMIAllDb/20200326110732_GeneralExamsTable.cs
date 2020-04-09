using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class GeneralExamsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GastroGeneralExaminations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    BUILT = table.Column<string>(nullable: true),
                    NEUTRITION = table.Column<string>(nullable: true),
                    PULSE_RATE = table.Column<int>(nullable: false),
                    PULSE_RADIO_FEROMAL_DELAY = table.Column<string>(nullable: true),
                    PULSE_RYTHM = table.Column<string>(nullable: true),
                    PULSE_VOLUME = table.Column<string>(nullable: true),
                    PULSE_CONDITION_OF_ARTERIAL_WALL = table.Column<string>(nullable: true),
                    PULSE_CHARACTER = table.Column<string>(nullable: true),
                    PULSE_PERIPHERAL_PULSES = table.Column<string>(nullable: true),
                    BLODD_PRESSURE = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_GastroGeneralExaminations", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastroGeneralExaminations");
        }
    }
}
