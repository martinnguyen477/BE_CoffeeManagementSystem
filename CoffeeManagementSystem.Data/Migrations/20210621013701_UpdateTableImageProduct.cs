using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeManagementSystem.Data.Migrations
{
    public partial class UpdateTableImageProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "ImageProduct");

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "ImageProduct",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "ImageProduct");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "ImageProduct",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
