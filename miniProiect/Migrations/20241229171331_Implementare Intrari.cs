using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace miniProiect.Migrations
{
    /// <inheritdoc />
    public partial class ImplementareIntrari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IntrariDetaliuProdusId",
                table: "Produse",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdIntrari",
                table: "Partener",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IntrariGestiuneId",
                table: "Gestiune",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IntrariDetaliuProdus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntrariDetaliuProdus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "intrariGestiunes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_intrariGestiunes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "intrariParteneris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_intrariParteneris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Intrari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPartner = table.Column<int>(type: "int", nullable: true),
                    IdGestiune = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intrari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Intrari_intrariGestiunes_IdGestiune",
                        column: x => x.IdGestiune,
                        principalTable: "intrariGestiunes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Intrari_intrariParteneris_IdPartner",
                        column: x => x.IdPartner,
                        principalTable: "intrariParteneris",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IntrariDetaliu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantitate = table.Column<float>(type: "real", nullable: false),
                    Valoare = table.Column<float>(type: "real", nullable: false),
                    IdIntrariDetaliuProdus = table.Column<int>(type: "int", nullable: true),
                    IntrariId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntrariDetaliu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IntrariDetaliu_IntrariDetaliuProdus_IdIntrariDetaliuProdus",
                        column: x => x.IdIntrariDetaliuProdus,
                        principalTable: "IntrariDetaliuProdus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IntrariDetaliu_Intrari_IntrariId",
                        column: x => x.IntrariId,
                        principalTable: "Intrari",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produse_IntrariDetaliuProdusId",
                table: "Produse",
                column: "IntrariDetaliuProdusId");

            migrationBuilder.CreateIndex(
                name: "IX_Partener_IdIntrari",
                table: "Partener",
                column: "IdIntrari");

            migrationBuilder.CreateIndex(
                name: "IX_Gestiune_IntrariGestiuneId",
                table: "Gestiune",
                column: "IntrariGestiuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Intrari_IdGestiune",
                table: "Intrari",
                column: "IdGestiune");

            migrationBuilder.CreateIndex(
                name: "IX_Intrari_IdPartner",
                table: "Intrari",
                column: "IdPartner");

            migrationBuilder.CreateIndex(
                name: "IX_IntrariDetaliu_IdIntrariDetaliuProdus",
                table: "IntrariDetaliu",
                column: "IdIntrariDetaliuProdus");

            migrationBuilder.CreateIndex(
                name: "IX_IntrariDetaliu_IntrariId",
                table: "IntrariDetaliu",
                column: "IntrariId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gestiune_intrariGestiunes_IntrariGestiuneId",
                table: "Gestiune",
                column: "IntrariGestiuneId",
                principalTable: "intrariGestiunes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Partener_intrariParteneris_IdIntrari",
                table: "Partener",
                column: "IdIntrari",
                principalTable: "intrariParteneris",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produse_IntrariDetaliuProdus_IntrariDetaliuProdusId",
                table: "Produse",
                column: "IntrariDetaliuProdusId",
                principalTable: "IntrariDetaliuProdus",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gestiune_intrariGestiunes_IntrariGestiuneId",
                table: "Gestiune");

            migrationBuilder.DropForeignKey(
                name: "FK_Partener_intrariParteneris_IdIntrari",
                table: "Partener");

            migrationBuilder.DropForeignKey(
                name: "FK_Produse_IntrariDetaliuProdus_IntrariDetaliuProdusId",
                table: "Produse");

            migrationBuilder.DropTable(
                name: "IntrariDetaliu");

            migrationBuilder.DropTable(
                name: "IntrariDetaliuProdus");

            migrationBuilder.DropTable(
                name: "Intrari");

            migrationBuilder.DropTable(
                name: "intrariGestiunes");

            migrationBuilder.DropTable(
                name: "intrariParteneris");

            migrationBuilder.DropIndex(
                name: "IX_Produse_IntrariDetaliuProdusId",
                table: "Produse");

            migrationBuilder.DropIndex(
                name: "IX_Partener_IdIntrari",
                table: "Partener");

            migrationBuilder.DropIndex(
                name: "IX_Gestiune_IntrariGestiuneId",
                table: "Gestiune");

            migrationBuilder.DropColumn(
                name: "IntrariDetaliuProdusId",
                table: "Produse");

            migrationBuilder.DropColumn(
                name: "IdIntrari",
                table: "Partener");

            migrationBuilder.DropColumn(
                name: "IntrariGestiuneId",
                table: "Gestiune");
        }
    }
}
