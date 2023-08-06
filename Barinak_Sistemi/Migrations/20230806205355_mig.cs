using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak_Sistemi.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userGender",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "AnimalDescription",
                table: "Animal",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "DropAnimal",
                columns: table => new
                {
                    DropAType = table.Column<string>(type: "text", nullable: false),
                    DropAName = table.Column<string>(type: "text", nullable: false),
                    DropAAge = table.Column<int>(type: "integer", nullable: false),
                    DropAGender = table.Column<string>(type: "text", nullable: false),
                    DropADescription = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DropAnimal");

            migrationBuilder.DropColumn(
                name: "AnimalDescription",
                table: "Animal");

            migrationBuilder.AddColumn<string>(
                name: "userGender",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
