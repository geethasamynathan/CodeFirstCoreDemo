using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstCoreDemo.Migrations
{
    public partial class EmptableaddedwithFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentRefId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentRefId",
                table: "Departments",
                column: "DepartmentRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employee_DepartmentRefId",
                table: "Departments",
                column: "DepartmentRefId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employee_DepartmentRefId",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DepartmentRefId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentRefId",
                table: "Departments");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentHead", "Location", "Name" },
                values: new object[] { 1, "Karthik", "Dalllas", "IT" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentHead", "Location", "Name" },
                values: new object[] { 2, "Riya", "Alabama", "HR" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentHead", "Location", "Name" },
                values: new object[] { 3, "Tina", "Masachuset", "Admin" });
        }
    }
}
