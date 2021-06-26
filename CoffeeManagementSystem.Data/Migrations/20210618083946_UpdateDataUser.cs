using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeManagementSystem.Data.Migrations
{
    public partial class UpdateDataUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    NumberPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    GroupUser = table.Column<int>(nullable: false),
                    AvartarUrl = table.Column<string>(nullable: true),
                    PublicId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Address", "AvartarUrl", "BirthDay", "CreateBy", "CreateDate", "Email", "FirstName", "GroupUser", "LastName", "NumberPhone", "Password", "PublicId", "Sex", "Status", "UpdateBy", "UpdateDate", "UserName" },
                values: new object[] { 1, "351A Lạc Long Quân Phường 5 Quận 11 TP.Hồ Chí Minh", null, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "nqcuong720@gmail.com", "Cường", 1, "Nguyễn", "0377077630", "d57587b0f5bbb0c3fe9d8cb16e97b0fe", null, "Nam", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "nqcuong20" });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Address", "AvartarUrl", "BirthDay", "CreateBy", "CreateDate", "Email", "FirstName", "GroupUser", "LastName", "NumberPhone", "Password", "PublicId", "Sex", "Status", "UpdateBy", "UpdateDate", "UserName" },
                values: new object[] { 2, "Phường Lê Hồng Phong TP.Quảng Ngãi", null, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "volengocdiep2000@gmail.com", "Diệp", 2, "Võ", "035458331", "d57587b0f5bbb0c3fe9d8cb16e97b0fe", null, "Nữ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "vlndiep20" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserEntities");
        }
    }
}
