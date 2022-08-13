using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myAPI.Migrations
{
    public partial class added_sorting_col : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sorting",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sorting",
                table: "Experiences",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sorting",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Sorting",
                table: "Experiences");
        }
    }
}
