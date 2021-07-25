using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeManagementSystem.Data.Migrations
{
    public partial class UpdateDataAttriibute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "AttributeValuesToProduct",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 18000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 22000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 25000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 30000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 22000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 28000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 34000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 38000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 18000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 22000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 23000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 28000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 30000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 32000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 35000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 18000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 28000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 38000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 14000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 18000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 21,
                column: "Price",
                value: 24000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 28000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 17000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 24,
                column: "Price",
                value: 21000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 29000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 34000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 25000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 28000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 29,
                column: "Price",
                value: 30000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 33000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 31,
                column: "Price",
                value: 16000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 32,
                column: "Price",
                value: 24000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 33,
                column: "Price",
                value: 29000);

            migrationBuilder.UpdateData(
                table: "AttributeValuesToProduct",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: 34000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "AttributeValuesToProduct");

            migrationBuilder.InsertData(
                table: "AttributeValue",
                columns: new[] { "Id", "AttributeId", "CreateBy", "CreateDate", "Status", "UpdateBy", "UpdateDate", "Value" },
                values: new object[,]
                {
                    { 5, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "15000" },
                    { 6, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "18000" },
                    { 7, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "20000" },
                    { 8, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "25000" },
                    { 9, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "30000" },
                    { 10, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "32000" },
                    { 11, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "35000" },
                    { 12, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "38000" },
                    { 13, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "40000" }
                });
        }
    }
}
