using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak_Sistemi.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "SUser");

            migrationBuilder.DropColumn(
                name: "city",
                table: "SUser");

            migrationBuilder.DropColumn(
                name: "salary",
                table: "SUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "SUser",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "SUser",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "salary",
                table: "SUser",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
