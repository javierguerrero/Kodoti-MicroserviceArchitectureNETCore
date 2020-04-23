using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 851m },
                    { 73, "Description for product 73", "Product 73", 586m },
                    { 72, "Description for product 72", "Product 72", 922m },
                    { 71, "Description for product 71", "Product 71", 744m },
                    { 70, "Description for product 70", "Product 70", 142m },
                    { 69, "Description for product 69", "Product 69", 745m },
                    { 68, "Description for product 68", "Product 68", 905m },
                    { 67, "Description for product 67", "Product 67", 152m },
                    { 66, "Description for product 66", "Product 66", 526m },
                    { 65, "Description for product 65", "Product 65", 354m },
                    { 64, "Description for product 64", "Product 64", 208m },
                    { 63, "Description for product 63", "Product 63", 579m },
                    { 62, "Description for product 62", "Product 62", 541m },
                    { 61, "Description for product 61", "Product 61", 254m },
                    { 60, "Description for product 60", "Product 60", 105m },
                    { 59, "Description for product 59", "Product 59", 998m },
                    { 58, "Description for product 58", "Product 58", 654m },
                    { 57, "Description for product 57", "Product 57", 569m },
                    { 56, "Description for product 56", "Product 56", 578m },
                    { 55, "Description for product 55", "Product 55", 379m },
                    { 54, "Description for product 54", "Product 54", 732m },
                    { 53, "Description for product 53", "Product 53", 141m },
                    { 74, "Description for product 74", "Product 74", 888m },
                    { 52, "Description for product 52", "Product 52", 836m },
                    { 75, "Description for product 75", "Product 75", 377m },
                    { 77, "Description for product 77", "Product 77", 568m },
                    { 98, "Description for product 98", "Product 98", 695m },
                    { 97, "Description for product 97", "Product 97", 982m },
                    { 96, "Description for product 96", "Product 96", 489m },
                    { 95, "Description for product 95", "Product 95", 554m },
                    { 94, "Description for product 94", "Product 94", 220m },
                    { 93, "Description for product 93", "Product 93", 879m },
                    { 92, "Description for product 92", "Product 92", 121m },
                    { 91, "Description for product 91", "Product 91", 932m },
                    { 90, "Description for product 90", "Product 90", 653m },
                    { 89, "Description for product 89", "Product 89", 312m },
                    { 88, "Description for product 88", "Product 88", 530m },
                    { 87, "Description for product 87", "Product 87", 391m },
                    { 86, "Description for product 86", "Product 86", 994m },
                    { 85, "Description for product 85", "Product 85", 341m },
                    { 84, "Description for product 84", "Product 84", 935m },
                    { 83, "Description for product 83", "Product 83", 164m },
                    { 82, "Description for product 82", "Product 82", 117m },
                    { 81, "Description for product 81", "Product 81", 139m },
                    { 80, "Description for product 80", "Product 80", 220m },
                    { 79, "Description for product 79", "Product 79", 337m },
                    { 78, "Description for product 78", "Product 78", 620m },
                    { 76, "Description for product 76", "Product 76", 818m },
                    { 51, "Description for product 51", "Product 51", 442m },
                    { 50, "Description for product 50", "Product 50", 846m },
                    { 49, "Description for product 49", "Product 49", 304m },
                    { 22, "Description for product 22", "Product 22", 372m },
                    { 21, "Description for product 21", "Product 21", 380m },
                    { 20, "Description for product 20", "Product 20", 308m },
                    { 19, "Description for product 19", "Product 19", 598m },
                    { 18, "Description for product 18", "Product 18", 713m },
                    { 17, "Description for product 17", "Product 17", 800m },
                    { 16, "Description for product 16", "Product 16", 420m },
                    { 15, "Description for product 15", "Product 15", 544m },
                    { 14, "Description for product 14", "Product 14", 878m },
                    { 13, "Description for product 13", "Product 13", 497m },
                    { 12, "Description for product 12", "Product 12", 315m },
                    { 11, "Description for product 11", "Product 11", 859m },
                    { 10, "Description for product 10", "Product 10", 185m },
                    { 9, "Description for product 9", "Product 9", 792m },
                    { 8, "Description for product 8", "Product 8", 360m },
                    { 7, "Description for product 7", "Product 7", 810m },
                    { 6, "Description for product 6", "Product 6", 308m },
                    { 5, "Description for product 5", "Product 5", 207m },
                    { 4, "Description for product 4", "Product 4", 911m },
                    { 3, "Description for product 3", "Product 3", 609m },
                    { 2, "Description for product 2", "Product 2", 980m },
                    { 23, "Description for product 23", "Product 23", 511m },
                    { 24, "Description for product 24", "Product 24", 955m },
                    { 25, "Description for product 25", "Product 25", 913m },
                    { 26, "Description for product 26", "Product 26", 201m },
                    { 48, "Description for product 48", "Product 48", 136m },
                    { 47, "Description for product 47", "Product 47", 162m },
                    { 46, "Description for product 46", "Product 46", 792m },
                    { 45, "Description for product 45", "Product 45", 717m },
                    { 44, "Description for product 44", "Product 44", 891m },
                    { 43, "Description for product 43", "Product 43", 803m },
                    { 42, "Description for product 42", "Product 42", 561m },
                    { 41, "Description for product 41", "Product 41", 930m },
                    { 40, "Description for product 40", "Product 40", 709m },
                    { 39, "Description for product 39", "Product 39", 226m },
                    { 99, "Description for product 99", "Product 99", 636m },
                    { 38, "Description for product 38", "Product 38", 878m },
                    { 36, "Description for product 36", "Product 36", 502m },
                    { 35, "Description for product 35", "Product 35", 232m },
                    { 34, "Description for product 34", "Product 34", 592m },
                    { 33, "Description for product 33", "Product 33", 262m },
                    { 32, "Description for product 32", "Product 32", 432m },
                    { 31, "Description for product 31", "Product 31", 831m },
                    { 30, "Description for product 30", "Product 30", 684m },
                    { 29, "Description for product 29", "Product 29", 781m },
                    { 28, "Description for product 28", "Product 28", 369m },
                    { 27, "Description for product 27", "Product 27", 154m },
                    { 37, "Description for product 37", "Product 37", 676m },
                    { 100, "Description for product 100", "Product 100", 290m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 10 },
                    { 73, 73, 8 },
                    { 72, 72, 18 },
                    { 71, 71, 6 },
                    { 70, 70, 1 },
                    { 69, 69, 10 },
                    { 68, 68, 17 },
                    { 67, 67, 17 },
                    { 66, 66, 14 },
                    { 65, 65, 3 },
                    { 64, 64, 3 },
                    { 63, 63, 1 },
                    { 62, 62, 9 },
                    { 61, 61, 18 },
                    { 60, 60, 3 },
                    { 59, 59, 16 },
                    { 58, 58, 2 },
                    { 57, 57, 16 },
                    { 56, 56, 11 },
                    { 55, 55, 0 },
                    { 54, 54, 12 },
                    { 53, 53, 4 },
                    { 74, 74, 2 },
                    { 52, 52, 4 },
                    { 75, 75, 10 },
                    { 77, 77, 4 },
                    { 98, 98, 10 },
                    { 97, 97, 15 },
                    { 96, 96, 7 },
                    { 95, 95, 14 },
                    { 94, 94, 15 },
                    { 93, 93, 11 },
                    { 92, 92, 1 },
                    { 91, 91, 14 },
                    { 90, 90, 7 },
                    { 89, 89, 11 },
                    { 88, 88, 18 },
                    { 87, 87, 5 },
                    { 86, 86, 4 },
                    { 85, 85, 6 },
                    { 84, 84, 8 },
                    { 83, 83, 8 },
                    { 82, 82, 15 },
                    { 81, 81, 17 },
                    { 80, 80, 12 },
                    { 79, 79, 15 },
                    { 78, 78, 11 },
                    { 76, 76, 8 },
                    { 51, 51, 19 },
                    { 50, 50, 18 },
                    { 49, 49, 7 },
                    { 22, 22, 19 },
                    { 21, 21, 5 },
                    { 20, 20, 8 },
                    { 19, 19, 15 },
                    { 18, 18, 7 },
                    { 17, 17, 7 },
                    { 16, 16, 10 },
                    { 15, 15, 12 },
                    { 14, 14, 9 },
                    { 13, 13, 10 },
                    { 12, 12, 9 },
                    { 11, 11, 4 },
                    { 10, 10, 12 },
                    { 9, 9, 9 },
                    { 8, 8, 9 },
                    { 7, 7, 5 },
                    { 6, 6, 3 },
                    { 5, 5, 1 },
                    { 4, 4, 1 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 23, 23, 4 },
                    { 24, 24, 18 },
                    { 25, 25, 4 },
                    { 26, 26, 18 },
                    { 48, 48, 9 },
                    { 47, 47, 1 },
                    { 46, 46, 11 },
                    { 45, 45, 2 },
                    { 44, 44, 13 },
                    { 43, 43, 14 },
                    { 42, 42, 17 },
                    { 41, 41, 17 },
                    { 40, 40, 12 },
                    { 39, 39, 18 },
                    { 99, 99, 9 },
                    { 38, 38, 8 },
                    { 36, 36, 10 },
                    { 35, 35, 19 },
                    { 34, 34, 12 },
                    { 33, 33, 11 },
                    { 32, 32, 10 },
                    { 31, 31, 9 },
                    { 30, 30, 5 },
                    { 29, 29, 7 },
                    { 28, 28, 16 },
                    { 27, 27, 5 },
                    { 37, 37, 3 },
                    { 100, 100, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
