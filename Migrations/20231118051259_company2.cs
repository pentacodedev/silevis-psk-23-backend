﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackathonApi.Migrations
{
    /// <inheritdoc />
    public partial class company2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InternshipCreatorId",
                table: "Internships",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InternshipCreatorId",
                table: "Internships");
        }
    }
}
