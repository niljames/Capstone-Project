using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_API.Migrations
{
    public partial class SeventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicineCategoryId",
                table: "Medicine");

            migrationBuilder.AddColumn<string>(
                name: "Category_Name",
                table: "Medicine",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category_Name",
                table: "Medicine");

            migrationBuilder.AddColumn<int>(
                name: "MedicineCategoryId",
                table: "Medicine",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
