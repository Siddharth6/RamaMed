using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations
{
    public partial class Add_Initial_All_Clinics_GMI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InputName",
                table: "GastroClinics");

            migrationBuilder.DropColumn(
                name: "InputName",
                table: "EndocrinoClinics");

            migrationBuilder.DropColumn(
                name: "InputName",
                table: "DiabetesClinics");

            migrationBuilder.DropColumn(
                name: "InputName",
                table: "CardioClinics");

            migrationBuilder.DropColumn(
                name: "InputName",
                table: "BasicClinics");

            migrationBuilder.AlterColumn<string>(
                name: "InputOptions",
                table: "GastroClinics",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Heading",
                table: "GastroClinics",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "InputOptions",
                table: "EndocrinoClinics",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Heading",
                table: "EndocrinoClinics",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "InputOptions",
                table: "DiabetesClinics",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Heading",
                table: "DiabetesClinics",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "InputOptions",
                table: "CardioClinics",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Heading",
                table: "CardioClinics",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "InputOptions",
                table: "BasicClinics",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Heading",
                table: "BasicClinics",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Heading",
                table: "GastroClinics");

            migrationBuilder.DropColumn(
                name: "Heading",
                table: "EndocrinoClinics");

            migrationBuilder.DropColumn(
                name: "Heading",
                table: "DiabetesClinics");

            migrationBuilder.DropColumn(
                name: "Heading",
                table: "CardioClinics");

            migrationBuilder.DropColumn(
                name: "Heading",
                table: "BasicClinics");

            migrationBuilder.AlterColumn<string>(
                name: "InputOptions",
                table: "GastroClinics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "InputName",
                table: "GastroClinics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "InputOptions",
                table: "EndocrinoClinics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "InputName",
                table: "EndocrinoClinics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "InputOptions",
                table: "DiabetesClinics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "InputName",
                table: "DiabetesClinics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "InputOptions",
                table: "CardioClinics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "InputName",
                table: "CardioClinics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "InputOptions",
                table: "BasicClinics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "InputName",
                table: "BasicClinics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
