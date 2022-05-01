using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstCoreDemo.Migrations
{
    public partial class fk3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employee_EmployeeId",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Departments",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                newName: "IX_Departments_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_DepartmentId",
                table: "Departments",
                column: "DepartmentId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_DepartmentId",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

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
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employee_EmployeeId",
                table: "Departments",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
