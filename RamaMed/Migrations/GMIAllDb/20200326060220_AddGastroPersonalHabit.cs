using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class AddGastroPersonalHabit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GastroPersonalHabits",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UHID = table.Column<string>(nullable: false),
                    OPDNO = table.Column<string>(nullable: false),
                    SMOKING = table.Column<string>(nullable: true),
                    SMOKING_PACK_YEARS = table.Column<int>(nullable: false),
                    SMOKING_DURATION = table.Column<string>(nullable: true),
                    SMOKING_YEARS = table.Column<int>(nullable: false),
                    ALCOHOL_INTAKE = table.Column<string>(nullable: true),
                    ALCOHOL_INTAKE_QUANTITY = table.Column<string>(nullable: true),
                    ALCOHOL_INTAKE_DURATION = table.Column<string>(nullable: true),
                    ALCOHOL_INTAKE_YEARS = table.Column<int>(nullable: false),
                    OTHER_SUBSTANCE_USE = table.Column<string>(nullable: true),
                    LIFE_STYLE = table.Column<string>(nullable: true),
                    FAMILY_HISTORY = table.Column<string>(nullable: true),
                    CREATEDATE = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastroPersonalHabits", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastroPersonalHabits");
        }
    }
}
