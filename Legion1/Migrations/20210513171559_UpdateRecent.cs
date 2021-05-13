using Microsoft.EntityFrameworkCore.Migrations;

namespace Legion1.Migrations
{
    public partial class UpdateRecent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Recent",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recent_IdentityUserId",
                table: "Recent",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recent_AspNetUsers_IdentityUserId",
                table: "Recent",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recent_AspNetUsers_IdentityUserId",
                table: "Recent");

            migrationBuilder.DropIndex(
                name: "IX_Recent_IdentityUserId",
                table: "Recent");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Recent");
        }
    }
}
