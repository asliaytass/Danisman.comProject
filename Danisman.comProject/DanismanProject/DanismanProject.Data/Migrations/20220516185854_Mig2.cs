using Microsoft.EntityFrameworkCore.Migrations;

namespace DanismanProject.Data.Migrations
{
    public partial class Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "Jobs",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "Jobs");
        }
    }
}
