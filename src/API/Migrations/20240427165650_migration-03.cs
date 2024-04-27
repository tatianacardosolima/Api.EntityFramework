using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class migration03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DocumentDate",
                schema: "dbo",
                table: "Client",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentDate",
                schema: "dbo",
                table: "Client");
        }
    }
}
