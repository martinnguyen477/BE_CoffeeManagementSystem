using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeManagementSystem.Data.Migrations
{
    public partial class updateimagecategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryImage",
                table: "Category");

            migrationBuilder.AddColumn<string>(
                name: "PublicIdImage",
                table: "Category",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlImageCategory",
                table: "Category",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicIdImage",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UrlImageCategory",
                table: "Category");

            migrationBuilder.AddColumn<string>(
                name: "CategoryImage",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
