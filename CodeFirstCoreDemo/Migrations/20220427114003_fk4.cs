using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstCoreDemo.Migrations
{
    public partial class fk4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_DepartmentId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Departments",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_DepartmentId",
                table: "Departments",
                newName: "IX_Departments_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_EmployeeId",
                table: "Departments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_EmployeeId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Departments",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                newName: "IX_Departments_DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_DepartmentId",
                table: "Departments",
                column: "DepartmentId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
