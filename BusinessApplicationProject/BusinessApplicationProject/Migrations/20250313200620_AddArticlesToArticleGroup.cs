using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessApplicationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddArticlesToArticleGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleGroups_GroupId",
                table: "Articles");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleGroups_GroupId",
                table: "Articles",
                column: "GroupId",
                principalTable: "ArticleGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleGroups_GroupId",
                table: "Articles");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleGroups_GroupId",
                table: "Articles",
                column: "GroupId",
                principalTable: "ArticleGroups",
                principalColumn: "Id");
        }
    }
}
