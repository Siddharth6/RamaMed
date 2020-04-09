using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class UpdateGeneralExamsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BLODD_PRESSURE",
                table: "GastroGeneralExaminations");

            migrationBuilder.AlterColumn<int>(
                name: "PULSE_RATE",
                table: "GastroGeneralExaminations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BLOOD_PRESSURE",
                table: "GastroGeneralExaminations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BLOOD_PRESSURE",
                table: "GastroGeneralExaminations");

            migrationBuilder.AlterColumn<int>(
                name: "PULSE_RATE",
                table: "GastroGeneralExaminations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BLODD_PRESSURE",
                table: "GastroGeneralExaminations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
