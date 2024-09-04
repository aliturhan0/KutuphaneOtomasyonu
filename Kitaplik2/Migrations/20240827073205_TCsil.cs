using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kitaplik2.Migrations
{
    /// <inheritdoc />
    public partial class TCsil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TC",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TC",
                table: "Users",
                type: "int",
                nullable: true);
        }
    }
}
