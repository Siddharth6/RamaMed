using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class GastroInvestigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GastroInvestigations",
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
                    CT_ABDOMEN_CONTRAST = table.Column<string>(nullable: true),
                    UGI_ENDOSCOPY = table.Column<string>(nullable: true),
                    COLONOSCOPY_SIGMOIDOSCOPY = table.Column<string>(nullable: true),
                    ASCITIC_FLUID_ANALYSIS = table.Column<string>(nullable: true),
                    TUMOR_MARKERS = table.Column<string>(nullable: true),
                    LIVER_BIOPSY = table.Column<string>(nullable: true),
                    SR_AMYLASE = table.Column<string>(nullable: true),
                    LIPASE = table.Column<string>(nullable: true),
                    MRCP = table.Column<string>(nullable: true),
                    ERCP = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false),
                    UPDATEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastroInvestigations", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastroInvestigations");
        }
    }
}
