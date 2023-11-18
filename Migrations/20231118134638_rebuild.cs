using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackathonApi.Migrations
{
    /// <inheritdoc />
    public partial class rebuild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Internships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyAddress = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyNipNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyKrsNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyEmail = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyRegonNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyRepresentativeFirstname = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyRepresentativeSurname = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StudentEmail = table.Column<string>(type: "TEXT", nullable: true),
                    ManagerEmail = table.Column<string>(type: "TEXT", nullable: true),
                    IsSigned = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Internships", x => x.Id);
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
        }
    }
}
