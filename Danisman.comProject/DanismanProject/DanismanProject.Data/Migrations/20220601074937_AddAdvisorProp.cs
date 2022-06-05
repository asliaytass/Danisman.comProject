using Microsoft.EntityFrameworkCore.Migrations;

namespace DanismanProject.Data.Migrations
{
    public partial class AddAdvisorProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdvisorNameSurname",
                table: "Advisors",
                newName: "AdvisorUsername");

            migrationBuilder.AddColumn<string>(
                name: "AdvisorName",
                table: "Advisors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdvisorSurname",
                table: "Advisors",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvisorName",
                table: "Advisors");

            migrationBuilder.DropColumn(
                name: "AdvisorSurname",
                table: "Advisors");

            migrationBuilder.RenameColumn(
                name: "AdvisorUsername",
                table: "Advisors",
                newName: "AdvisorNameSurname");
        }
    }
}
