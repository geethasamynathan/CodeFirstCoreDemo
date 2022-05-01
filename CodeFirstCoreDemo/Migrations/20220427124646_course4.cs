using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstCoreDemo.Migrations
{
    public partial class course4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course1s",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course1s",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Course1s",
                columns: new[] { "Id", "CourseName" },
                values: new object[] { 5, ".NET FSD" });

            migrationBuilder.InsertData(
                table: "Course1s",
                columns: new[] { "Id", "CourseName" },
                values: new object[] { 6, "Java FSD" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course1s",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Course1s",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Course1s",
                columns: new[] { "Id", "CourseName" },
                values: new object[] { 1, ".NET FSD" });

            migrationBuilder.InsertData(
                table: "Course1s",
                columns: new[] { "Id", "CourseName" },
                values: new object[] { 2, "Java FSD" });
        }
    }
}
