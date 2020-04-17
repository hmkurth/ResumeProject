using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumePortfolioSite.Migrations
{
    public partial class majortodegree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Major",
                table: "Educations",
                newName: "Degree");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "Educations",
                newName: "Major");
        }
    }
}
