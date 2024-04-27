using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class migration02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Document",
                schema: "dbo",
                table: "Client",
                type: "varchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                schema: "dbo",
                table: "Client");
        }
    }
}
