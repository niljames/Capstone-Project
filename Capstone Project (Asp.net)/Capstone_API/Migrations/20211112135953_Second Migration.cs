using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_API.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_MedicineCategory_MedicineCategoryId",
                table: "Medicine");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineCategoryId",
                table: "Medicine",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_MedicineCategory_MedicineCategoryId",
                table: "Medicine",
                column: "MedicineCategoryId",
                principalTable: "MedicineCategory",
                principalColumn: "MedicineCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_MedicineCategory_MedicineCategoryId",
                table: "Medicine");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineCategoryId",
                table: "Medicine",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_MedicineCategory_MedicineCategoryId",
                table: "Medicine",
                column: "MedicineCategoryId",
                principalTable: "MedicineCategory",
                principalColumn: "MedicineCategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
