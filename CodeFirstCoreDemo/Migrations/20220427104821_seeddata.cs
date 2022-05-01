using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstCoreDemo.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
