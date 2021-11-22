using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_API.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_MedicineCategory_MedicineCategoryId",
                table: "Medicine");

            migrationBuilder.DropIndex(
                name: "IX_Medicine_MedicineCategoryId",
                table: "Medicine");

            migrationBuilder.DropColumn(
                name: "MedicineCategoryId",
                table: "Medicine");

            migrationBuilder.AddColumn<int>(
                name: "Category_Name",
                table: "Medicine",
                nullable: false,
                defaultValue: 0);
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

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_MedicineCategoryId",
                table: "Medicine",
                column: "MedicineCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_MedicineCategory_MedicineCategoryId",
                table: "Medicine",
                column: "MedicineCategoryId",
                principalTable: "MedicineCategory",
                principalColumn: "MedicineCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
