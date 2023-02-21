using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeathtrapDungeonAPIver1.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberCard",
                table: "Directions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberCard",
                table: "Directions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
