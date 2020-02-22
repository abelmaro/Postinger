using Microsoft.EntityFrameworkCore.Migrations;

namespace Postinger.Migrations
{
    public partial class Fix_relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostID",
                table: "Comment",
                column: "PostID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostID",
                table: "Comment",
                column: "PostID",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Post_PostID",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_PostID",
                table: "Comment");
        }
    }
}
