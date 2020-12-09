using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumePortfolioSite.Migrations
{
    public partial class skills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEnded",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "StartMonth",
                table: "Skills",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Skills",
                newName: "StartMonth");

            migrationBuilder.AddColumn<int>(
                name: "DateEnded",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Skills",
                nullable: true);
        }
    }
}
