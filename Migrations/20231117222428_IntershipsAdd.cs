using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackathonApi.Migrations
{
    /// <inheritdoc />
    public partial class IntershipsAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interships");

            migrationBuilder.CreateTable(
                name: "Internships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IntershipCreatorId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecrutationStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecrutationEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StudentEmail = table.Column<string>(type: "TEXT", nullable: true),
                    ManagerEmail = table.Column<string>(type: "TEXT", nullable: true),
                    IsSigned = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Internships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Internships_Companies_IntershipCreatorId",
                        column: x => x.IntershipCreatorId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewDateTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentEmail = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    IntershipId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewDateTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewDateTickets_Internships_IntershipId",
                        column: x => x.IntershipId,
                        principalTable: "Internships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Internships_IntershipCreatorId",
                table: "Internships",
                column: "IntershipCreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_NewDateTickets_IntershipId",
                table: "NewDateTickets",
                column: "IntershipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewDateTickets");

            migrationBuilder.DropTable(
                name: "Internships");

            migrationBuilder.CreateTable(
                name: "Interships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IntershipCreatorId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecrutationEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecrutationStart = table.Column<DateTime>(type: "TEXT", nullable: false),
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
    }
}
