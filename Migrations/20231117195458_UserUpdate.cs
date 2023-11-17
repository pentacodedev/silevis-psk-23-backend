using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackathonApi.Migrations
{
    /// <inheritdoc />
    public partial class UserUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    NipNumber = table.Column<string>(type: "TEXT", nullable: false),
                    KrsNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    RegonNumber = table.Column<string>(type: "TEXT", nullable: false),
                    RepresentativeFirstname = table.Column<string>(type: "TEXT", nullable: false),
                    RepresentativeSurname = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IntershipCreatorId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecrutationStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecrutationEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StudentEmail = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interships_Companies_IntershipCreatorId",
                        column: x => x.IntershipCreatorId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interships_IntershipCreatorId",
                table: "Interships",
                column: "IntershipCreatorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interships");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
