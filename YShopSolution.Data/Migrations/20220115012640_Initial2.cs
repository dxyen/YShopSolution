using Microsoft.EntityFrameworkCore.Migrations;

namespace YShopSolution.Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Caterories_CateroryId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "CateroryId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Caterories_CateroryId",
                table: "Items",
                column: "CateroryId",
                principalTable: "Caterories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Caterories_CateroryId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "CateroryId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Caterories_CateroryId",
                table: "Items",
                column: "CateroryId",
                principalTable: "Caterories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
