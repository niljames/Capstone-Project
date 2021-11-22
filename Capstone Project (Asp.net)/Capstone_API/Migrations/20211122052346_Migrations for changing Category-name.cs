using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_API.Migrations
{
    public partial class MigrationsforchangingCategoryname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "MedicineCategory");

            migrationBuilder.AddColumn<string>(
                name: "Category_Name",
                table: "MedicineCategory",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category_Name",
                table: "MedicineCategory");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "MedicineCategory",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
