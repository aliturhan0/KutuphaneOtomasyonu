using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kitaplik2.Migrations
{
    /// <inheritdoc />
    public partial class bibakalim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Users_UserID",
                table: "Loans");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Loans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Users_UserID",
                table: "Loans",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Users_UserID",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Loans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Users_UserID",
                table: "Loans",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
