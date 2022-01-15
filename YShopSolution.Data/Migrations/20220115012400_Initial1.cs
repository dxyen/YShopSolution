using Microsoft.EntityFrameworkCore.Migrations;

namespace YShopSolution.Data.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CateroryId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_CateroryId",
                table: "Items",
                column: "CateroryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Caterories_CateroryId",
                table: "Items",
                column: "CateroryId",
                principalTable: "Caterories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Caterories_CateroryId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CateroryId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CateroryId",
                table: "Items");
        }
    }
}
