﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maxishop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modelfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "createdOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdOn",
                table: "Category");
        }
    }
}
