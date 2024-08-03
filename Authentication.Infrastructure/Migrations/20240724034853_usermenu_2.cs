using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class usermenu_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "UserInfoMenus");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "UserInfoMenus");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "UserInfoMenus");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "UserInfoMenus");

            migrationBuilder.DropColumn(
                name: "UserInfoCode",
                table: "UserInfoMenus");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "UserInfoMenus");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfoMenus_MenuId",
                table: "UserInfoMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfoMenus_UserInfoId",
                table: "UserInfoMenus",
                column: "UserInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfoMenus_Menus_MenuId",
                table: "UserInfoMenus",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfoMenus_UserInfos_UserInfoId",
                table: "UserInfoMenus",
                column: "UserInfoId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInfoMenus_Menus_MenuId",
                table: "UserInfoMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfoMenus_UserInfos_UserInfoId",
                table: "UserInfoMenus");

            migrationBuilder.DropIndex(
                name: "IX_UserInfoMenus_MenuId",
                table: "UserInfoMenus");

            migrationBuilder.DropIndex(
                name: "IX_UserInfoMenus_UserInfoId",
                table: "UserInfoMenus");

            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "UserInfoMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "UserInfoMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "UserInfoMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "UserInfoMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserInfoCode",
                table: "UserInfoMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "UserInfoMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
