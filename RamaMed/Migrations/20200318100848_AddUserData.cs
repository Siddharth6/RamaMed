using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations
{
    public partial class AddUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDatas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OPDNo = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Dept = table.Column<string>(nullable: false),
                    Doctor = table.Column<string>(nullable: false),
                    Clinic = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDatas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDatas");
        }
    }
}
