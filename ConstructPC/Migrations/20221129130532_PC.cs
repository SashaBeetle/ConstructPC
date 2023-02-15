using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConstructPC.Migrations
{
    public partial class PC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Case",
                table: "Case");

            migrationBuilder.RenameTable(
                name: "Case",
                newName: "CaseBox");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CaseBox",
                table: "CaseBox",
                column: "id");

            migrationBuilder.CreateTable(
                name: "PC",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orderTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PC", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PCDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pcID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    motherID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    motherboardid = table.Column<int>(type: "int", nullable: true),
                    pcid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_PCDetails_Motherboard_motherboardid",
                        column: x => x.motherboardid,
                        principalTable: "Motherboard",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PCDetails_PC_pcid",
                        column: x => x.pcid,
                        principalTable: "PC",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PCDetails_motherboardid",
                table: "PCDetails",
                column: "motherboardid");

            migrationBuilder.CreateIndex(
                name: "IX_PCDetails_pcid",
                table: "PCDetails",
                column: "pcid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PCDetails");

            migrationBuilder.DropTable(
                name: "PC");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CaseBox",
                table: "CaseBox");

            migrationBuilder.RenameTable(
                name: "CaseBox",
                newName: "Case");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Case",
                table: "Case",
                column: "id");
        }
    }
}
