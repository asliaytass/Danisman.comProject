using Microsoft.EntityFrameworkCore.Migrations;

namespace DanismanProject.Data.Migrations
{
    public partial class changeOnAdvisor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvisorPassword",
                table: "Advisors");

            migrationBuilder.DropColumn(
                name: "AdvisorUsername",
                table: "Advisors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdvisorPassword",
                table: "Advisors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdvisorUsername",
                table: "Advisors",
                type: "TEXT",
                nullable: true);
        }
    }
}
