using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class AddDatetimeGCS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "GastroClinicalSymptoms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "GastroClinicalSymptoms");
        }
    }
}
