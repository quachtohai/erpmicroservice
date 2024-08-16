using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductionPlanning.API.Migrations
{
    /// <inheritdoc />
    public partial class dailyproduction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyProductions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToTalQuantity = table.Column<int>(type: "int", nullable: false),
                    NgQuantity1 = table.Column<int>(type: "int", nullable: false),
                    NgQuantity2 = table.Column<int>(type: "int", nullable: false),
                    GoodsQuantity = table.Column<int>(type: "int", nullable: false),
                    QcQuantity = table.Column<int>(type: "int", nullable: false),
                    IncomeQuantity = table.Column<int>(type: "int", nullable: false),
                    ManPower = table.Column<int>(type: "int", nullable: false),
                    WeldingLine = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyProductions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyProductions");
        }
    }
}
