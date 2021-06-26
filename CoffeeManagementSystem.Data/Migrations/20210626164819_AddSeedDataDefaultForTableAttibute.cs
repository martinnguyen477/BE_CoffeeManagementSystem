using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeManagementSystem.Data.Migrations
{
    public partial class AddSeedDataDefaultForTableAttibute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "Product");

            migrationBuilder.InsertData(
                table: "Attribute",
                columns: new[] { "Id", "AttributeName", "CreateBy", "CreateDate", "Status", "UpdateBy", "UpdateDate" },
                values: new object[] { 1, "Size", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AttributeValue",
                columns: new[] { "Id", "AttributeId", "CreateBy", "CreateDate", "Price", "ProductId", "Status", "UpdateBy", "UpdateDate", "Value" },
                values: new object[,]
                {
                    { 21, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 30000m, 12, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 20, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 23000m, 11, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "S" },
                    { 19, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 32000m, 10, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "XL" },
                    { 18, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 33000m, 9, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "L" },
                    { 17, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 36000m, 8, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 16, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 35000m, 7, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "XL" },
                    { 15, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 32000m, 7, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 14, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 30000m, 7, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "S" },
                    { 13, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 32000m, 6, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 12, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 27000m, 6, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "S" },
                    { 22, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 35000m, 12, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "XL" },
                    { 10, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 35000m, 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "XL" },
                    { 9, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 30000m, 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 8, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 28000m, 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 7, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 23000m, 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "S" },
                    { 6, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 30000m, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "XL" },
                    { 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 25000m, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 18000m, 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "S" },
                    { 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 38000m, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "XL" },
                    { 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 35000m, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" },
                    { 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 28000m, 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "S" },
                    { 11, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), 25000m, 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "M" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateBy", "CreateDate", "PublicIdImage", "Status", "UpdateBy", "UpdateDate", "UrlImageCategory" },
                values: new object[] { 6, "Cafe", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "mka6z4skydw4ooqhspt5", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreateBy", "CreateDate", "Description", "Discount", "ProductImage", "ProductName", "PublicId", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 13, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Trà đen được ủ mới mỗi ngày, giữ nguyên được vị chát mạnh mẽ đặc trưng của lá trà, phủ bên trên là lớp Macchiato \"homemade\" bồng bềnh quyến rũ vị phô mai mặn mặn mà béo béo.", 20m, "", "TRÀ ĐEN MACCHIATO", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 14, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), " ", 20m, "", "HỒNG TRÀ SỮA TRÂN CHÂU", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 15, 6, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Americano được pha chế bằng cách thêm nước vào một hoặc hai shot Espresso để pha loãng độ đặc của cà phê, từ đó mang lại hương vị nhẹ nhàng, không gắt mạnh và vẫn thơm nồng nàn. 40,000 đ", 20m, "", "AMERICANO", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 19, 6, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Cappuccino được gọi vui là thức uống \"một - phần - ba\" - 1/3 Espresso, 1/3 Sữa nóng, 1/3 Foam.", 20m, "", "CAPPUCCINO", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 17, 6, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Một tách cà phê đen thơm ngào ngạt, phảng phất mùi cacao là món quà tự thưởng tuyệt vời nhất cho những ai mê đắm tinh chất nguyên bản nhất của cà phê. Một tách cà phê trầm lắng, thi vị giữa dòng đời vồn vã.", 20m, "", "CÀ PHÊ ĐEN", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 18, 6, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Cà phê phin kết hợp cũng sữa đặc là một sáng tạo đầy tự hào của người Việt, được xem món uống thương hiệu của Việt Nam.", 20m, "", "CÀ PHÊ SỮA", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 12, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "", 20m, "", "TRÀ PHÚC BỒN TỬ", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 16, 6, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Theo chân những người gốc Hoa đến định cư tại Sài Gòn, Bạc sỉu là cách gọi tắt của \"Bạc tẩy sỉu phé\" trong tiếng Quảng Đông, chính là: Ly sữa trắng kèm một chút cà phê.", 20m, "", "BẠC SỈU", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 11, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "", 20m, "", "TRÀ SỮA MẮC CA TRÂN CHÂU", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 5, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Tê tái ngay đầu lưỡi bởi sự mát lạnh của đá xay. Hòa quyện thêm hương vị chua chua, ngọt ngọt từ trái cam tươi và trái phúc bồn tử 100% tự nhiên, để cho ra một hương vị thanh mát, kích thích vị giác đầy thú vị ngay từ lần đầu thưởng thức. Lại thêm một lựa chọn mới cho \"team đá xay\" và team trái cây, còn chần chờ gì nữa mà không thử ngay thôi!", 20m, "", "PHÚC BỒN TỬ CAM ĐÁ XAY", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 9, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Sự kết hợp của Trà hương thơm nhẹ, vị nồng hậu cùng Hạt sen tươi mềm có vị ngọt, sáp, vừa ngon miệng vừa có tác dụng an thần, tốt cho cơ thể.", 20m, "", "TRÀ HẠT SEN", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 8, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "", 20m, "", "Trà Long Nhãn Hạt Chia", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 7, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Matcha thanh, nhẫn, và đắng nhẹ được nhân đôi sảng khoái khi uống lạnh. Nhấn nhá thêm những nét bùi béo của kem và sữa. Gây thương nhớ vô cùng!", 20m, "", "MATCHA ĐÁ XAY", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 6, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Những mẩu bánh cookies giòn rụm kết hợp ăn ý với sữa tươi và kem tươi béo ngọt, đem đến cảm giác lạ miệng gây thích thú. Một món uống phá cách dễ thương.", 20m, "", "COOKIES ĐÁ XAY", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 4, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Mứt Việt Quất chua thanh, ngòn ngọt, phối hợp nhịp nhàng với dòng sữa chua bổ dưỡng. Là món sinh tố thơm ngon mà cả đầu lưỡi và làn da đều thích.", 20m, "", "SINH TỐ VIỆT QUẤT", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 3, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Một phiên bản nâng cấp từ ly cà phê sữa quen thuộc, nhưng lại đầy tỉnh táo và tươi mát hơn bởi lớp đá xay mát lạnh đi kèm. Nhấp 1 ngụm là thấy đã, ngụm thứ hai thêm tỉnh táo và cứ thế lôi cuốn bạn đến giọt cuối cùng.", 20m, "", "CÀ PHÊ ĐÁ XAY", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 2, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Sự kết hợp hài hoà giữa những nguyên liệu mộc mạc rất đỗi quen thuộc đối với người Việt cho một thức uống thanh mát, giải nhiệt lại tốt cho sức khoẻ.", 20m, "", "CHANH SẢ ĐÁ XAY", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 1, 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Vẫn vị đào quen thuộc, nhưng được khoác lên mình một dáng vẻ đầy thanh mát và giải khát hơn.Kết hợp với mứt berry và lớp kem béo ngậy nhưng ngọt dịu,cho hương vị tươi mới và lôi cuốn,kích thích vị giác đầy thú vị ngay lần đầu thưởng thức.", 20m, "", "ĐÀO VIỆT QUẤT ĐÁ XAY", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 20, 6, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Vị thơm béo của bọt sữa và sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng, và vị ngọt đậm của sốt caramel.", 20m, "", "CARAMEL MACCHIATO", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 10, 4, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Vị thanh ngọt của đào Hy Lạp, vị chua dịu của Cam Vàng nguyên vỏ, vị chát của trà đen tươi được ủ mới mỗi 4 tiếng, cùng hương thơm nồng đặc trưng của sả chính là điểm sáng làm nên sức hấp dẫn của thức uống này. Sản phẩm hiện có 2 phiên bản Nóng và Lạnh phù hợp cho mọi thời gian trong năm.", 20m, "", "TRÀ ĐÀO CAM SẢ", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) },
                    { 21, 6, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "Một cốc Espresso nguyên bản được bắt đầu bởi những hạt Arabica chất lượng, phối trộn với tỉ lệ cân đối hạt Robusta, cho ra vị ngọt caramel, vị chua dịu và sánh đặc. Để đạt được sự kết hợp này, chúng tôi xay tươi hạt cà phê cho mỗi lần pha.", 20m, "", "ESPRESSO", " ", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AttributeValue",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.AddColumn<decimal>(
                name: "ProductPrice",
                table: "Product",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateBy", "CreateDate", "PublicIdImage", "Status", "UpdateBy", "UpdateDate", "UrlImageCategory" },
                values: new object[] { 7, "Cafe", 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "mka6z4skydw4ooqhspt5", 1, 1, new DateTime(2020, 12, 23, 1, 18, 30, 999, DateTimeKind.Unspecified), "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg" });
        }
    }
}
