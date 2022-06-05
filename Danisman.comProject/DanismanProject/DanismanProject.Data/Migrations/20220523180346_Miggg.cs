using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanismanProject.Data.Migrations
{
    public partial class Miggg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AdvisorDateOfBirth",
                table: "Advisors",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "AdvisorMail",
                table: "Advisors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdvisorPassword",
                table: "Advisors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdvisprPhone",
                table: "Advisors",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvisorDateOfBirth",
                table: "Advisors");

            migrationBuilder.DropColumn(
                name: "AdvisorMail",
                table: "Advisors");

            migrationBuilder.DropColumn(
                name: "AdvisorPassword",
                table: "Advisors");

            migrationBuilder.DropColumn(
                name: "AdvisprPhone",
                table: "Advisors");
        }
    }
}
