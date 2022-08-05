using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myAPI.Migrations
{
    public partial class nested_test_canceled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperienceExperienceProject");

            migrationBuilder.DropTable(
                name: "ExperienceExperienceResponsibility");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceResponsibilities_ExperienceID",
                table: "ExperienceResponsibilities",
                column: "ExperienceID");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceProjects_ExperienceID",
                table: "ExperienceProjects",
                column: "ExperienceID");

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceProjects_Experiences_ExperienceID",
                table: "ExperienceProjects",
                column: "ExperienceID",
                principalTable: "Experiences",
                principalColumn: "ExperienceID");

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceResponsibilities_Experiences_ExperienceID",
                table: "ExperienceResponsibilities",
                column: "ExperienceID",
                principalTable: "Experiences",
                principalColumn: "ExperienceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceProjects_Experiences_ExperienceID",
                table: "ExperienceProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceResponsibilities_Experiences_ExperienceID",
                table: "ExperienceResponsibilities");

            migrationBuilder.DropIndex(
                name: "IX_ExperienceResponsibilities_ExperienceID",
                table: "ExperienceResponsibilities");

            migrationBuilder.DropIndex(
                name: "IX_ExperienceProjects_ExperienceID",
                table: "ExperienceProjects");

            migrationBuilder.CreateTable(
                name: "ExperienceExperienceProject",
                columns: table => new
                {
                    ExperienceProjectsID = table.Column<int>(type: "int", nullable: false),
                    ExperiencesExperienceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceExperienceProject", x => new { x.ExperienceProjectsID, x.ExperiencesExperienceID });
                    table.ForeignKey(
                        name: "FK_ExperienceExperienceProject_ExperienceProjects_ExperiencePro~",
                        column: x => x.ExperienceProjectsID,
                        principalTable: "ExperienceProjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperienceExperienceProject_Experiences_ExperiencesExperienc~",
                        column: x => x.ExperiencesExperienceID,
                        principalTable: "Experiences",
                        principalColumn: "ExperienceID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExperienceExperienceResponsibility",
                columns: table => new
                {
                    ExperienceResponsibilitiesID = table.Column<int>(type: "int", nullable: false),
                    ExperiencesExperienceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceExperienceResponsibility", x => new { x.ExperienceResponsibilitiesID, x.ExperiencesExperienceID });
                    table.ForeignKey(
                        name: "FK_ExperienceExperienceResponsibility_ExperienceResponsibilitie~",
                        column: x => x.ExperienceResponsibilitiesID,
                        principalTable: "ExperienceResponsibilities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperienceExperienceResponsibility_Experiences_ExperiencesEx~",
                        column: x => x.ExperiencesExperienceID,
                        principalTable: "Experiences",
                        principalColumn: "ExperienceID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceExperienceProject_ExperiencesExperienceID",
                table: "ExperienceExperienceProject",
                column: "ExperiencesExperienceID");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceExperienceResponsibility_ExperiencesExperienceID",
                table: "ExperienceExperienceResponsibility",
                column: "ExperiencesExperienceID");
        }
    }
}
