using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations.GMIAllDb
{
    public partial class UpdateGastroTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "GastroPersonalHabits",
                newName: "UPDATEDATE");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "GastroComorbidities",
                newName: "UPDATEDATE");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "GastroClinicalSymptoms",
                newName: "UPDATEDATE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATEDATE",
                table: "GastroPersonalHabits",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATEDATE",
                table: "GastroComorbidities",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATEDATE",
                table: "GastroClinicalSymptoms",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UPDATEDATE",
                table: "GastroPersonalHabits",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UPDATEDATE",
                table: "GastroComorbidities",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UPDATEDATE",
                table: "GastroClinicalSymptoms",
                newName: "UpdateDate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "GastroPersonalHabits",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "GastroComorbidities",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "GastroClinicalSymptoms",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
