using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class AddGastroClinical : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GastroClinicalSymptoms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    NAUSEA_DURATION = table.Column<string>(nullable: true),
                    INVOLUNTARY_MOVEMENTS_DURATION = table.Column<string>(nullable: true),
                    VOMITING_DURATION = table.Column<string>(nullable: true),
                    ALTERED_SENSORIUM_DURATION = table.Column<string>(nullable: true),
                    ALTERED_BOWEL_HABITS_DURATION = table.Column<string>(nullable: true),
                    PERSONALITY_CHANGES_DURATION = table.Column<string>(nullable: true),
                    HEMATEMESIS_DURATION = table.Column<string>(nullable: true),
                    ALTERED_SLEEP_PATTERN_DURATION = table.Column<string>(nullable: true),
                    MALENA_DURATION = table.Column<string>(nullable: true),
                    HEMATOCHEZIA_DURATION = table.Column<string>(nullable: true),
                    DYSPESIA_DURATION = table.Column<string>(nullable: true),
                    OLIGURIA_DURATION = table.Column<string>(nullable: true),
                    FEVER_DURATION = table.Column<string>(nullable: true),
                    DYSPHAGIA_DURATION = table.Column<string>(nullable: true),
                    WEIGHT_LOSS_DURATION = table.Column<string>(nullable: true),
                    ODYNOPHAGIA_DURATION = table.Column<string>(nullable: true),
                    ICTERUS_DURATION = table.Column<string>(nullable: true),
                    FACIAL_PUFFINESS_DURATION = table.Column<string>(nullable: true),
                    ABDOMINAL_DISTENSION_DURATION = table.Column<string>(nullable: true),
                    SWELLING_OF_BOTH_LEGS_DURATION = table.Column<string>(nullable: true),
                    ABDOMINAL_PAIN_DURATION = table.Column<string>(nullable: true),
                    YELLOWISH_DISCOLORATION_OF_URINE_DURATION = table.Column<string>(nullable: true),
                    EASY_FATIGUABILITY_DURATION = table.Column<string>(nullable: true),
                    BREATHELESSNESS_DURATION = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastroClinicalSymptoms", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastroClinicalSymptoms");
        }
    }
}
