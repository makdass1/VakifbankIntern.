using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restoran_Vakifbank.Migrations
{
    /// <inheritdoc />
    public partial class Tekrar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Toplam_Tutar",
                table: "Masa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Toplam_Tutar",
                table: "Masa");
        }
    }
}
