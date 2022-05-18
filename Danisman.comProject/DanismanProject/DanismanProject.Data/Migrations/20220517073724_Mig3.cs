using Microsoft.EntityFrameworkCore.Migrations;

namespace DanismanProject.Data.Migrations
{
    public partial class Mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobImg",
                table: "Jobs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Jobs",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobImg",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Jobs");
        }
    }
}
