using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstCoreDemo.Migrations
{
    public partial class course3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Course1s",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Course1s",
                columns: new[] { "Id", "CourseName" },
                values: new object[] { 1, ".NET FSD" });

            migrationBuilder.InsertData(
                table: "Course1s",
                columns: new[] { "Id", "CourseName" },
                values: new object[] { 2, "Java FSD" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course1s",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course1s",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "CourseName",
                table: "Course1s",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, ".NET FSD" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Java FSD" });
        }
    }
}
