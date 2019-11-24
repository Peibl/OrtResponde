using Microsoft.EntityFrameworkCore.Migrations;

namespace OrtResponde.Data.Migrations
{
    public partial class fff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "likes",
                table: "Question",
                newName: "Likes");

            migrationBuilder.RenameColumn(
                name: "dislikes",
                table: "Question",
                newName: "Dislikes");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Question",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Question");

            migrationBuilder.RenameColumn(
                name: "Likes",
                table: "Question",
                newName: "likes");

            migrationBuilder.RenameColumn(
                name: "Dislikes",
                table: "Question",
                newName: "dislikes");
        }
    }
}
