using Microsoft.EntityFrameworkCore.Migrations;

namespace DanismanProject.Data.Migrations
{
    public partial class Mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advisors_Categories_CategoryId",
                table: "Advisors");

            migrationBuilder.DropIndex(
                name: "IX_Advisors_CategoryId",
                table: "Advisors");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Advisors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Advisors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Advisors_CategoryId",
                table: "Advisors",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advisors_Categories_CategoryId",
                table: "Advisors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
