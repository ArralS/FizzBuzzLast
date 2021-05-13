using Microsoft.EntityFrameworkCore.Migrations;

namespace Legion1.Migrations
{
    public partial class RecentUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Recent",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Recent");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Recent",
                type: "nvarchar(450)",
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
    }
}
