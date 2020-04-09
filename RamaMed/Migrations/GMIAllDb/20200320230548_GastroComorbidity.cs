using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class GastroComorbidity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GastroComorbidities",
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
                    PULMONARY_TB_DATE_OF_DIAGNOSIS = table.Column<DateTime>(nullable: false),
                    PULMONARY_TB_ATT_REGIMEN = table.Column<string>(nullable: true),
                    PULMONARY_TB_DATE_OF_STARTING = table.Column<DateTime>(nullable: false),
                    PULMONARY_TB_DATE_OF_ENDING = table.Column<DateTime>(nullable: false),
                    HIV = table.Column<string>(nullable: true),
                    HBSAG = table.Column<string>(nullable: true),
                    ANTI_HCV = table.Column<string>(nullable: true),
                    DIABETES_MELLITUS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastroComorbidities", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastroComorbidities");
        }
    }
}
