using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Item.API.Migrations
{
    /// <inheritdoc />
    public partial class Product_DictionaryInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DictionaryInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DictionaryInfoCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DictionaryInfoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictionaryInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DictionaryInfos");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
