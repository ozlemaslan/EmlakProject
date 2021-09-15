using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmlakProject.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emlakci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmlakciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YetkiliAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emlakci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmlakBilgisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmlakTuru = table.Column<int>(type: "int", nullable: false),
                    EmlakciId = table.Column<int>(type: "int", nullable: false),
                    MetreKare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OdaSayisi = table.Column<int>(type: "int", nullable: false),
                    Kat = table.Column<int>(type: "int", nullable: false),
                    BinaKati = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmlakBilgisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmlakBilgisi_Emlakci_EmlakciId",
                        column: x => x.EmlakciId,
                        principalTable: "Emlakci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmlakciId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CepTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteri_Emlakci_EmlakciId",
                        column: x => x.EmlakciId,
                        principalTable: "Emlakci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmlakBilgisi_EmlakciId",
                table: "EmlakBilgisi",
                column: "EmlakciId");

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_EmlakciId",
                table: "Musteri",
                column: "EmlakciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmlakBilgisi");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "Emlakci");
        }
    }
}
