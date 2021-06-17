using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeManagementSystem.Data.Migrations
{
    public partial class addSeedDatadefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateBy", "CreateDate", "PublicIdImage", "Status", "UpdateBy", "UpdateDate", "UrlImageCategory" },
                values: new object[,]
                {
                    { 1, "Đá xay ", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "mka6z4skydw4ooqhspt5", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg" },
                    { 2, "Chocolate", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "mka6z4skydw4ooqhspt5", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg" },
                    { 3, "Matcha", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "mka6z4skydw4ooqhspt5", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg" },
                    { 4, "Trà Trái Cây", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "mka6z4skydw4ooqhspt5", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg" },
                    { 5, "Trà Sữa", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "mka6z4skydw4ooqhspt5", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg" },
                    { 7, "Cafe", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "mka6z4skydw4ooqhspt5", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg" },
                    { 8, "Sinh tố", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "mka6z4skydw4ooqhspt5", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
