using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kitaplik2.Migrations
{
    /// <inheritdoc />
    public partial class db_fk_pkk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Books_BookID",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "BookID",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Books_BookID",
                table: "Users",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Books_BookID",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "BookID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Books_BookID",
                table: "Users",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
