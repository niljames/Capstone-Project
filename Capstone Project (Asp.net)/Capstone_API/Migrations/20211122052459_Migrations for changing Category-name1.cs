using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_API.Migrations
{
    public partial class MigrationsforchangingCategoryname1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
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

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Medicine",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
