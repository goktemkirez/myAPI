using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myAPI.Migrations
{
    public partial class Experiences_table_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Company = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Department = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Website = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExperienceProjects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Project = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExperienceID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceProjects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExperienceProjects_Experiences_ExperienceID",
                        column: x => x.ExperienceID,
                        principalTable: "Experiences",
                        principalColumn: "ExperienceID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExperienceResponsibilities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Responsibility = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExperienceID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceResponsibilities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExperienceResponsibilities_Experiences_ExperienceID",
                        column: x => x.ExperienceID,
                        principalTable: "Experiences",
                        principalColumn: "ExperienceID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceProjects_ExperienceID",
                table: "ExperienceProjects",
                column: "ExperienceID");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceResponsibilities_ExperienceID",
                table: "ExperienceResponsibilities",
                column: "ExperienceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperienceProjects");

            migrationBuilder.DropTable(
                name: "ExperienceResponsibilities");

            migrationBuilder.DropTable(
                name: "Experiences");
        }
    }
}
