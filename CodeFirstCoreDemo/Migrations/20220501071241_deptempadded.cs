using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstCoreDemo.Migrations
{
    public partial class deptempadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_EmployeeId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Departments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_EmployeeId",
                table: "Departments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
