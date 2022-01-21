using Microsoft.EntityFrameworkCore.Migrations;

namespace YShopSolution.Data.Migrations
{
    public partial class Initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Caterories",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "For Choco Addicts", "default", "Chocolate" },
                    { 2, "A taste of tropics", "default", "Fruits" },
                    { 3, "Oreo, Rochers & more", "default", "Exotic" },
                    { 4, "The all time Favourite", "default", "Blackforest" },
                    { 5, "For Candy Fans", "default", "Butterscotch" },
                    { 6, "The Evergreen", "default", "Vanilla" },
                    { 7, "For Expresso Lover", "default", "Coffee" },
                    { 8, "An ideal Complement", "default", "Strawberry" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CateroryId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.", "default", "Blackforest Cake ", 1000000m },
                    { 2, 1, "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.", "default", "Blackforest Cake Cherries", 1000000m },
                    { 3, 2, "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.", "default", "Blackforest With Cherries", 1000000m },
                    { 4, 3, "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.", "default", "Blackforest Cake With Cherries", 1000000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Caterories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Caterories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Caterories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Caterories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Caterories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Caterories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Caterories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Caterories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
