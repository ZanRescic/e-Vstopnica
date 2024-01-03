using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Vstopnice.Migrations
{
    /// <inheritdoc />
    public partial class PopravljanjeTicketa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_User",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_User",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Tickets");

            migrationBuilder.AddColumn<string>(
                name: "UserIdId",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserIdId",
                table: "Tickets",
                column: "UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_UserIdId",
                table: "Tickets",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_UserIdId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_UserIdId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "UserIdId",
                table: "Tickets");

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_User",
                table: "Tickets",
                column: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_User",
                table: "Tickets",
                column: "User",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
