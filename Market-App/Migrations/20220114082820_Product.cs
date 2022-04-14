using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketApp.Migrations
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductType = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Review = table.Column<decimal>(nullable: false),
                    ProductionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
