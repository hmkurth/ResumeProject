using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumePortfolioSite.Migrations
{
    public partial class educationmajor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "Educations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Major",
                table: "Educations");
        }
    }
}
