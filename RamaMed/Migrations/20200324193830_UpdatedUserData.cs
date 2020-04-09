using Microsoft.EntityFrameworkCore.Migrations;

namespace RamaMed.Migrations
{
    public partial class UpdatedUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UHID",
                table: "UserDatas",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UHID",
                table: "UserDatas");
        }
    }
}
