using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackathonApi.Migrations
{
    /// <inheritdoc />
    public partial class renameToCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Internships_Companies_IntershipCreatorId",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "InternshipCreatorId",
                table: "Internships");

            migrationBuilder.RenameColumn(
                name: "IntershipCreatorId",
                table: "Internships",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Internships_IntershipCreatorId",
                table: "Internships",
                newName: "IX_Internships_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Internships_Companies_CompanyId",
                table: "Internships",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Internships_Companies_CompanyId",
                table: "Internships");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Internships",
                newName: "IntershipCreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Internships_CompanyId",
                table: "Internships",
                newName: "IX_Internships_IntershipCreatorId");

            migrationBuilder.AddColumn<int>(
                name: "InternshipCreatorId",
                table: "Internships",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Internships_Companies_IntershipCreatorId",
                table: "Internships",
                column: "IntershipCreatorId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
