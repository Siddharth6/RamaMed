using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class GastroOthers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GastroOthers",
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
                    table.PrimaryKey("PK_GastroOthers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastroOthers");
        }
    }
}
