using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Authentication_isActive_isDelete_implement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UserInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UserInfoMenus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserInfoMenus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UserInfoDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserInfoDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UserInfoActions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserInfoActions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Modules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Modules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Forms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Forms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ActionInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ActionInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UserInfoMenus");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserInfoMenus");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UserInfoDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserInfoDetails");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UserInfoActions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserInfoActions");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ActionInfos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ActionInfos");
        }
    }
}
