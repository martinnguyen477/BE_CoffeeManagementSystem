using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeManagementSystem.Data.Migrations
{
    public partial class UpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attribute");

            migrationBuilder.DropTable(
                name: "AttributeValue");

            migrationBuilder.DropTable(
                name: "AttributeValueBillDetail");

            migrationBuilder.DropTable(
                name: "AttributeValuesToProduct");

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SizeName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Price", "ProductId", "SizeName", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 25000m, 1, "M", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 30000m, 1, "L", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 35000m, 1, "XL", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 28000m, 2, "M", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 32000m, 2, "L", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 18000m, 3, "M", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 22000m, 3, "L", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 30000m, 4, "L", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 35000m, 4, "XL", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 28000m, 5, "M", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 25000m, 6, "M", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.CreateTable(
                name: "Attribute",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attribute", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttributeValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttributeValueBillDetail",
                columns: table => new
                {
                    BillDetailId = table.Column<int>(type: "int", nullable: false),
                    AttributeValueId = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeValueBillDetail", x => new { x.BillDetailId, x.AttributeValueId });
                });

            migrationBuilder.CreateTable(
                name: "AttributeValuesToProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    AttributeValueId = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeValuesToProduct", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Attribute",
                columns: new[] { "Id", "AttributeName", "CreateBy", "CreateDate", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Size", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 2, "Price", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AttributeValue",
                columns: new[] { "Id", "AttributeId", "CreateBy", "CreateDate", "Status", "UpdateBy", "UpdateDate", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "S" },
                    { 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "L" },
                    { 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "XL" }
                });

            migrationBuilder.InsertData(
                table: "AttributeValuesToProduct",
                columns: new[] { "Id", "AttributeId", "AttributeValueId", "CreateBy", "CreateDate", "Price", "ProductId", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 19, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 14000, 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 20, 1, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 18000, 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 21, 1, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 24000, 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 22, 1, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 28000, 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 23, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 17000, 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 24, 2, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 21000, 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 25, 2, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 29000, 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 28, 1, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 28000, 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 27, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 25000, 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 18, 3, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 38000, 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 29, 1, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 30000, 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 30, 1, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 33000, 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 31, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 16000, 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 32, 2, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 24000, 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 26, 2, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 34000, 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 17, 2, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 28000, 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 14, 1, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 32000, 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 15, 1, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 35000, 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 1, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 18000, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 2, 1, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 22000, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 3, 1, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 25000, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 4, 1, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 30000, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 5, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 22000, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 6, 2, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 28000, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 16, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 18000, 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 7, 2, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 34000, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 9, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 18000, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 10, 1, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 22000, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 11, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 23000, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 12, 2, 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 28000, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 13, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 30000, 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 33, 2, 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 29000, 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 8, 2, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 38000, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 34, 2, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 34000, 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) }
                });
        }
    }
}
