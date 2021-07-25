using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeManagementSystem.Data.Migrations
{
    public partial class UpdateAttributeEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AttributeValue");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "AttributeValue");

            migrationBuilder.CreateTable(
                name: "AttributeValuesToProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    AttributeId = table.Column<int>(nullable: false),
                    AttributeValueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeValuesToProduct", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Attribute",
                columns: new[] { "Id", "AttributeName", "CreateBy", "CreateDate", "Status", "UpdateBy", "UpdateDate" },
                values: new object[] { 2, "Price", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 3,
                column: "Value",
                value: "L");

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 4,
                column: "Value",
                value: "XL");

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AttributeId", "Value" },
                values: new object[] { 2, "15000" });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 6,
                column: "Value",
                value: "18000");

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 7,
                column: "Value",
                value: "20000");

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "Value",
                value: "25000");

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 9,
                column: "Value",
                value: "30000");

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 10,
                column: "Value",
                value: "32000");

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 11,
                column: "Value",
                value: "35000");

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 12,
                column: "Value",
                value: "38000");

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 13,
                column: "Value",
                value: "40000");

            migrationBuilder.InsertData(
                table: "AttributeValuesToProduct",
                columns: new[] { "Id", "AttributeId", "AttributeValueId", "CreateBy", "CreateDate", "ProductId", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 12, 2, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 1, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 2, 1, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 3, 1, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 4, 1, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 5, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 6, 2, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 7, 2, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 8, 2, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 9, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 34, 2, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 33, 2, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 32, 2, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 31, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 30, 1, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 29, 1, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 28, 1, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 27, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 13, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 14, 1, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 15, 1, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 16, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 17, 2, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 18, 3, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 11, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 19, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 21, 1, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 10, 1, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 23, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 24, 2, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 25, 2, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 26, 2, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 20, 1, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 22, 1, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributeValuesToProduct");

            migrationBuilder.DeleteData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "AttributeValue",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "AttributeValue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProductId" },
                values: new object[] { 28000m, 1 });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProductId" },
                values: new object[] { 35000m, 1 });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProductId", "Value" },
                values: new object[] { 38000m, 1, "XL" });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductId", "Value" },
                values: new object[] { 18000m, 2, "S" });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AttributeId", "Price", "ProductId", "Value" },
                values: new object[] { 1, 25000m, 2, "M" });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProductId", "Value" },
                values: new object[] { 30000m, 2, "XL" });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProductId", "Value" },
                values: new object[] { 23000m, 3, "S" });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProductId", "Value" },
                values: new object[] { 28000m, 3, "M" });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProductId", "Value" },
                values: new object[] { 30000m, 4, "M" });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "ProductId", "Value" },
                values: new object[] { 35000m, 4, "XL" });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Price", "ProductId", "Value" },
                values: new object[] { 25000m, 5, "M" });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Price", "ProductId", "Value" },
                values: new object[] { 27000m, 6, "S" });

            migrationBuilder.UpdateData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Price", "ProductId", "Value" },
                values: new object[] { 32000m, 6, "M" });

            migrationBuilder.InsertData(
                table: "AttributeValue",
                columns: new[] { "Id", "AttributeId", "CreateBy", "CreateDate", "Price", "ProductId", "Status", "UpdateBy", "UpdateDate", "Value" },
                values: new object[,]
                {
                    { 18, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 33000m, 9, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "L" },
                    { 15, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 32000m, 7, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 16, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 35000m, 7, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "XL" },
                    { 22, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 35000m, 12, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "XL" },
                    { 21, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 30000m, 12, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 20, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 23000m, 11, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "S" },
                    { 19, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 32000m, 10, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "XL" },
                    { 17, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 36000m, 8, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 14, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 30000m, 7, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "S" }
                });
        }
    }
}
