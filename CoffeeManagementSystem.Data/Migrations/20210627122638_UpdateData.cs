using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeManagementSystem.Data.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "Address", "BranchName", "CreateBy", "CreateDate", "Email", "ManagerEmployeeId", "NumberPhone", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "572 Ba Tháng Hai, Quận 10, Hồ Chí Minh, Việt Nam", "572 Ba Tháng Hai", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "nqcuong720@gmail.com", 1, "0377077630", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 2, "798 Sư Vạn Hạnh, Quận 10, Hồ Chí Minh, Việt Nam", "798 Sư Vạn Hạnh", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "nqcuong720@gmail.com", 2, "0377077630", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 3, "175B Cao Thắng, Quận 10, Hồ Chí Minh, Việt Nam", "175B Cao Thắng", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "nqcuong720@gmail.com", 3, "0377077630", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 4, "25A Đồng Nai, Quận 10, Hồ Chí Minh, Việt Nam", "25A Đồng Nai", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "nqcuong720@gmail.com", 4, "0377077630", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 5, "159 Phạm Ngũ Lão, Quận 1, Hồ Chí Minh, Việt Nam", "159 Phạm Ngũ Lão", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "nqcuong720@gmail.com", 5, "0377077630", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "CreateBy", "CreateDate", "PositionName", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Nhân Viên Phục Vụ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Thu Nhân", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Nhân Viên Quản Lý", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Bảo Vệ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Slide",
                columns: new[] { "Id", "CreateBy", "CreateDate", "PublicId", "SlideName", "Status", "UpdateBy", "UpdateDate", "UrlSlideImage" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "", "Đại Lễ 30-4", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), " " },
                    { 2, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "", "Mừng Tết Thiếu Nhi", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), " " },
                    { 3, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "", "Khuyến Mãi Friday", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), " " },
                    { 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "", "Ngày Quốc Tế Phụ Nữ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), " " },
                    { 5, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "", "Ngày Hội Hiến Máu", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), " " },
                    { 6, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "", "Khuyến Mãi Đầu Tuần", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), " " },
                    { 7, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "", "Ưu đãi Tháng 6", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), " " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Slide",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
