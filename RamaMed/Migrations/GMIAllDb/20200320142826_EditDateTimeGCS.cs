using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class EditDateTimeGCS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "GastroClinicalSymptoms",
                newName: "CREATEDATE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CREATEDATE",
                table: "GastroClinicalSymptoms",
                newName: "CreateDate");
        }
    }
}
