using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstCoreDemo.Migrations
{
    public partial class fk1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employee_DepartmentRefId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "DepartmentRefId",
                table: "Departments",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_DepartmentRefId",
                table: "Departments",
                newName: "IX_Departments_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employee_EmployeeId",
                table: "Departments",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employee_EmployeeId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Departments",
                newName: "DepartmentRefId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                newName: "IX_Departments_DepartmentRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employee_DepartmentRefId",
                table: "Departments",
                column: "DepartmentRefId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
