using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstCoreDemo.Migrations
{
    public partial class departmentheadcolumnadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentHead",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentHead",
                table: "Departments");
        }
    }
}
