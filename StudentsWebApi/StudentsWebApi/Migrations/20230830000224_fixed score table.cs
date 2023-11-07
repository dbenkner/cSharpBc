﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsWebApi.Migrations
{
    /// <inheritdoc />
    public partial class fixedscoretable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "Scores");
        }
    }
}
