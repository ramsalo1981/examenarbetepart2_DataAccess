﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductRocky_DataAccess.Migrations
{
    public partial class AddShortDescriptiontoproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDesc",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDesc",
                table: "Product");
        }
    }
}
