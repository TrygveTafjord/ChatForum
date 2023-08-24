using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatForum.Migrations
{
    /// <inheritdoc />
    public partial class oneToManyAnswerRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Posts_Answer",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_userId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Answers_Answer",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Posts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_userId",
                table: "Posts",
                newName: "IX_Posts_UserId");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_PostId",
                table: "Answers",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Posts_PostId",
                table: "Answers",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Posts_PostId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Answers_PostId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Posts",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                newName: "IX_Posts_userId");

            migrationBuilder.AddColumn<int>(
                name: "Answer",
                table: "Answers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_Answer",
                table: "Answers",
                column: "Answer");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Posts_Answer",
                table: "Answers",
                column: "Answer",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_userId",
                table: "Posts",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
