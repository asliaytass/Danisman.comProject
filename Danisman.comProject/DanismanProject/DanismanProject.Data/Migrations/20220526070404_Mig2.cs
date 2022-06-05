using Microsoft.EntityFrameworkCore.Migrations;

namespace DanismanProject.Data.Migrations
{
    public partial class Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdvisprPhone",
                table: "Advisors",
                newName: "AdvisorPhone");

            migrationBuilder.AddColumn<string>(
                name: "AdvisorAbout",
                table: "Advisors",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvisorAbout",
                table: "Advisors");

            migrationBuilder.RenameColumn(
                name: "AdvisorPhone",
                table: "Advisors",
                newName: "AdvisprPhone");
        }
    }
}
