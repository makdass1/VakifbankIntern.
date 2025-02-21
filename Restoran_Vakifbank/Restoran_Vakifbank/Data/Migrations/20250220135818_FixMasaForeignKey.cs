using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restoran_Vakifbank.Migrations
{
    /// <inheritdoc />
    public partial class FixMasaForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siparis_Masa_MasaId",
                table: "Siparis");

            migrationBuilder.AlterColumn<int>(
                name: "MasaId",
                table: "Siparis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Siparis_Masa_MasaId",
                table: "Siparis",
                column: "MasaId",
                principalTable: "Masa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siparis_Masa_MasaId",
                table: "Siparis");

            migrationBuilder.AlterColumn<int>(
                name: "MasaId",
                table: "Siparis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Siparis_Masa_MasaId",
                table: "Siparis",
                column: "MasaId",
                principalTable: "Masa",
                principalColumn: "Id");
        }
    }
}
