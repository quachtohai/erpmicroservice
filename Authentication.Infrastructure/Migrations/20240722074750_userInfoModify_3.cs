using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class userInfoModify_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Description4",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Description5",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Description6",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserInfos");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfoDetails_UserInfoId",
                table: "UserInfoDetails",
                column: "UserInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfoDetails_UserInfos_UserInfoId",
                table: "UserInfoDetails",
                column: "UserInfoId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInfoDetails_UserInfos_UserInfoId",
                table: "UserInfoDetails");

            migrationBuilder.DropIndex(
                name: "IX_UserInfoDetails_UserInfoId",
                table: "UserInfoDetails");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description4",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description5",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description6",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "UserInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
