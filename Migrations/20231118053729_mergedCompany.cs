using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackathonApi.Migrations
{
    /// <inheritdoc />
    public partial class mergedCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Internships_Companies_CompanyId",
                table: "Internships");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Internships_CompanyId",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Internships");

            migrationBuilder.RenameColumn(
                name: "RecrutationStart",
                table: "Internships",
                newName: "CompanyRepresentativeSurname");

            migrationBuilder.RenameColumn(
                name: "RecrutationEnd",
                table: "Internships",
                newName: "CompanyRepresentativeFirstname");

            migrationBuilder.AddColumn<string>(
                name: "CompanyAddress",
                table: "Internships",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyEmail",
                table: "Internships",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyKrsNumber",
                table: "Internships",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Internships",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyNipNumber",
                table: "Internships",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyPhoneNumber",
                table: "Internships",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyRegonNumber",
                table: "Internships",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyAddress",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "CompanyEmail",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "CompanyKrsNumber",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "CompanyNipNumber",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "CompanyPhoneNumber",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "CompanyRegonNumber",
                table: "Internships");

            migrationBuilder.RenameColumn(
                name: "CompanyRepresentativeSurname",
                table: "Internships",
                newName: "RecrutationStart");

            migrationBuilder.RenameColumn(
                name: "CompanyRepresentativeFirstname",
                table: "Internships",
                newName: "RecrutationEnd");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Internships",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    KrsNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    NipNumber = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    RegonNumber = table.Column<string>(type: "TEXT", nullable: false),
                    RepresentativeFirstname = table.Column<string>(type: "TEXT", nullable: false),
                    RepresentativeSurname = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Internships_CompanyId",
                table: "Internships",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Internships_Companies_CompanyId",
                table: "Internships",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
