using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restoran_Vakifbank.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMasaConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MasaId",
                table: "Siparis",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Siparis_MasaId",
                table: "Siparis",
                column: "MasaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Siparis_Masa_MasaId",
                table: "Siparis",
                column: "MasaId",
                principalTable: "Masa",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siparis_Masa_MasaId",
                table: "Siparis");

            migrationBuilder.DropIndex(
                name: "IX_Siparis_MasaId",
                table: "Siparis");

            migrationBuilder.DropColumn(
                name: "MasaId",
                table: "Siparis");
        }
    }
}
