using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Item.API.Migrations
{
    /// <inheritdoc />
    public partial class item_first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaterialInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialInfos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MaterialInfos",
                columns: new[] { "Id", "Description", "IsActive", "MaterialCode", "MaterialName" },
                values: new object[,]
                {
                    { 1, "Aluminum Frame", true, "AluminumFrame", "Aluminum Frame" },
                    { 2, "Glass Pane", true, "GlassPane", "Glass Pane" },
                    { 3, "Latch", true, "Latch", "Latch" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialInfos");
        }
    }
}
