using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations
{
    public partial class intialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicClinics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    InputType = table.Column<int>(nullable: false),
                    InputName = table.Column<string>(nullable: false),
                    InputOptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicClinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardioClinics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    InputType = table.Column<int>(nullable: false),
                    InputName = table.Column<string>(nullable: false),
                    InputOptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardioClinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiabetesClinics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    InputType = table.Column<int>(nullable: false),
                    InputName = table.Column<string>(nullable: false),
                    InputOptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesClinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EndocrinoClinics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    InputType = table.Column<int>(nullable: false),
                    InputName = table.Column<string>(nullable: false),
                    InputOptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndocrinoClinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GastroClinics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    InputType = table.Column<int>(nullable: false),
                    InputName = table.Column<string>(nullable: false),
                    InputOptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastroClinics", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicClinics");

            migrationBuilder.DropTable(
                name: "CardioClinics");

            migrationBuilder.DropTable(
                name: "DiabetesClinics");

            migrationBuilder.DropTable(
                name: "EndocrinoClinics");

            migrationBuilder.DropTable(
                name: "GastroClinics");
        }
    }
}
