using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adoptooj_backend.Migrations
{
    /// <inheritdoc />
    public partial class allv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Refresh_Token_User_user_id",
                table: "Refresh_Token");

            migrationBuilder.DropIndex(
                name: "IX_Refresh_Token_user_id",
                table: "Refresh_Token");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Refresh_Token_user_id",
                table: "Refresh_Token",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refresh_Token_User_user_id",
                table: "Refresh_Token",
                column: "user_id",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
