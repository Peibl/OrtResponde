using Microsoft.EntityFrameworkCore.Migrations;

namespace OrtResponde.Data.Migrations
{
    public partial class Algo22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Like_Question_QuestionId",
                table: "Like");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Like",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Question_QuestionId",
                table: "Like",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Like_Question_QuestionId",
                table: "Like");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Like",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Question_QuestionId",
                table: "Like",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
