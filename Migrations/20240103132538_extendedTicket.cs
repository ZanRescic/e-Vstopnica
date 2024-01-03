using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Vstopnice.Migrations
{
    /// <inheritdoc />
    public partial class extendedTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tickets",
                newName: "StVstopnic");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "StVstopnic",
                table: "Tickets",
                newName: "UserId");
        }
    }
}
