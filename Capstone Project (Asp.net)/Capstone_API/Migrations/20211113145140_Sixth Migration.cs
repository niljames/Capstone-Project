using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_API.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category_Name",
                table: "Medicine");

            migrationBuilder.AddColumn<int>(
                name: "MedicineCategoryId",
                table: "Medicine",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicineCategoryId",
                table: "Medicine");

            migrationBuilder.AddColumn<string>(
                name: "Category_Name",
                table: "Medicine",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
