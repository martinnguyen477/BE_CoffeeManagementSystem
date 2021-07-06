using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeManagementSystem.Data.Migrations
{
    public partial class UpdateDataUpload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "ikb4lno0tsinvuhgfg0e", "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg" });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "ikb4lno0tsinvuhgfg0e", "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg" });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "ikb4lno0tsinvuhgfg0e", "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg" });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "ikb4lno0tsinvuhgfg0e", "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg" });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "ikb4lno0tsinvuhgfg0e", "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg" });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "ikb4lno0tsinvuhgfg0e", "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg" });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "ikb4lno0tsinvuhgfg0e", "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "", " " });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "", " " });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "", " " });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "", " " });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "", " " });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "", " " });

            migrationBuilder.UpdateData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PublicId", "UrlSlideImage" },
                values: new object[] { "", " " });
        }
    }
}
