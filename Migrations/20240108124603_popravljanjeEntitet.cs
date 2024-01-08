using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Vstopnice.Migrations
{
    /// <inheritdoc />
    public partial class popravljanjeEntitet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfSpots",
                table: "Places");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSpots",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfSpots",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSpots",
                table: "Places",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
