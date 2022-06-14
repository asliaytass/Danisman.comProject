using Microsoft.EntityFrameworkCore.Migrations;

namespace DanismanProject.Data.Migrations
{
    public partial class AddMessageId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactMessages",
                table: "ContactMessages");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ContactMessages",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "ContactMessages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactMessages",
                table: "ContactMessages",
                column: "MessageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactMessages",
                table: "ContactMessages");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "ContactMessages");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ContactMessages",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactMessages",
                table: "ContactMessages",
                column: "Name");
        }
    }
}
