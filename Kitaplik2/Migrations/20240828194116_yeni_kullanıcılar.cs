using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kitaplik2.Migrations
{
    /// <inheritdoc />
    public partial class yeni_kullanıcılar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Users_UserID",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Loans");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Users",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Loans",
                newName: "ID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Users_UserID",
                table: "Loans");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Loans",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Loans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Loans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Users_UserID",
                table: "Loans",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");
        }
    }
}
