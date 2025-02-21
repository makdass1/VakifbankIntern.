using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restoran_Vakifbank.Migrations
{
    /// <inheritdoc />
    public partial class MasaUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Masa_no",
                table: "Masa",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Masa_no",
                table: "Masa");
        }
    }
}
