using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductionPlanning.API.Migrations
{
    /// <inheritdoc />
    public partial class dailyproductionupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToTalQuantity",
                table: "DailyProductions",
                newName: "TotalQuantity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalQuantity",
                table: "DailyProductions",
                newName: "ToTalQuantity");
        }
    }
}
