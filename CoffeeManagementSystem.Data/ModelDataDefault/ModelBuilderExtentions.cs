// <copyright file="ModelBuilderExtentions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Data.ModelDataDefault
{
    using System;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Data seed.
    /// </summary>
    public static class ModelBuilderExtentions
    {
        public static void SeedDataDefault(this ModelBuilder modelBuilder)
        {
            DateTime dateTime = new DateTime(2020, 12, 23, 1, 18, 30, 999);

            #region Data Category
            modelBuilder.Entity<CategoryEntities>().HasData(
                new CategoryEntities { Id = 1, CategoryName = "Đá xay ", PublicIdImage = "cvz5jcwk0zhlrzgre2kn", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726517/cvz5jcwk0zhlrzgre2kn.png", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime},
                new CategoryEntities { Id = 2, CategoryName = "Chocolate", PublicIdImage = "cvz5jcwk0zhlrzgre2kn", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726517/cvz5jcwk0zhlrzgre2kn.png", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new CategoryEntities { Id = 3, CategoryName = "Matcha", PublicIdImage = "cvz5jcwk0zhlrzgre2kn", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726517/cvz5jcwk0zhlrzgre2kn.png", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new CategoryEntities { Id = 4, CategoryName = "Trà Trái Cây", PublicIdImage = "cvz5jcwk0zhlrzgre2kn", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726517/cvz5jcwk0zhlrzgre2kn.png", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new CategoryEntities { Id = 5, CategoryName = "Trà Sữa", PublicIdImage = "cvz5jcwk0zhlrzgre2kn", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726517/cvz5jcwk0zhlrzgre2kn.png", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new CategoryEntities { Id = 6, CategoryName = "Cafe", PublicIdImage = "cvz5jcwk0zhlrzgre2kn", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726517/cvz5jcwk0zhlrzgre2kn.png", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new CategoryEntities { Id = 8, CategoryName = "Sinh tố", PublicIdImage = "cvz5jcwk0zhlrzgre2kn", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726517/cvz5jcwk0zhlrzgre2kn.png", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime }
                );
            #endregion

            #region Data Role
            modelBuilder.Entity<RoleEntities>().HasData(
                new RoleEntities { Id = 1, RoleName = "Add Category", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new RoleEntities { Id = 2, RoleName = "View Detail Category", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new RoleEntities { Id = 3, RoleName = "Update Category", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new RoleEntities { Id = 4, RoleName = "Update Status Category", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new RoleEntities { Id = 5, RoleName = "General List Category", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime });
            #endregion

            #region Data GroupUser
            modelBuilder.Entity<GroupUserEntities>().HasData(
                new GroupUserEntities { Id = 1, GroupUserName = "Admin System", CreateBy = 1, CreateDate = dateTime, Status = Model.Enum.StatusSystem.Active, UpdateBy = 1, UpdateDate = dateTime },
                new GroupUserEntities { Id = 2, GroupUserName = "Manager", CreateBy = 1, CreateDate = dateTime, Status = Model.Enum.StatusSystem.Active, UpdateBy = 1, UpdateDate = dateTime },
                new GroupUserEntities { Id = 3, GroupUserName = "Staff", CreateBy = 1, CreateDate = dateTime, Status = Model.Enum.StatusSystem.Active, UpdateBy = 1, UpdateDate = dateTime },
                new GroupUserEntities { Id = 4, GroupUserName = "Customer", CreateBy = 1, CreateDate = dateTime, Status = Model.Enum.StatusSystem.Active, UpdateBy = 1, UpdateDate = dateTime });
            #endregion

            #region Data User
            modelBuilder.Entity<UserEntities>().HasData(
                new UserEntities { Id = 1, FirstName = "Cường", LastName = "Nguyễn", Email = "nqcuong720@gmail.com", NumberPhone = "0377077630", Address = "351A Lạc Long Quân Phường 5 Quận 11 TP.Hồ Chí Minh" , BirthDay = dateTime, GroupUser = 1, Sex = "Nam", AvartarUrl = null, PublicId = null, UserName = "nqcuong20", Password = "d57587b0f5bbb0c3fe9d8cb16e97b0fe", Status = Model.Enum.StatusSystem.Active , CreateBy = 1, UpdateBy = 1, CreateDate = dateTime , UpdateDate = dateTime },
                new UserEntities { Id = 2, FirstName = "Diệp", LastName = "Võ", Email = "volengocdiep2000@gmail.com", NumberPhone = "035458331", Address = "Phường Lê Hồng Phong TP.Quảng Ngãi" , BirthDay = dateTime, GroupUser = 2, Sex = "Nữ", AvartarUrl = null, PublicId = null, UserName = "vlndiep20", Password = "d57587b0f5bbb0c3fe9d8cb16e97b0fe", Status = Model.Enum.StatusSystem.Active , CreateBy = 1, UpdateBy = 1, CreateDate = dateTime , UpdateDate = dateTime }
                );
            #endregion

            #region Data Product
            modelBuilder.Entity<ProductEntities>().HasData(
                new ProductEntities { Id = 1, ProductName = "ĐÀO VIỆT QUẤT ĐÁ XAY", Description = "Vẫn vị đào quen thuộc, nhưng được khoác lên mình một dáng vẻ đầy thanh mát và giải khát hơn.Kết hợp với mứt berry và lớp kem béo ngậy nhưng ngọt dịu,cho hương vị tươi mới và lôi cuốn,kích thích vị giác đầy thú vị ngay lần đầu thưởng thức.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 1, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 2, ProductName = "CHANH SẢ ĐÁ XAY", Description = "Sự kết hợp hài hoà giữa những nguyên liệu mộc mạc rất đỗi quen thuộc đối với người Việt cho một thức uống thanh mát, giải nhiệt lại tốt cho sức khoẻ.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 1, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 3, ProductName = "CÀ PHÊ ĐÁ XAY", Description = "Một phiên bản nâng cấp từ ly cà phê sữa quen thuộc, nhưng lại đầy tỉnh táo và tươi mát hơn bởi lớp đá xay mát lạnh đi kèm. Nhấp 1 ngụm là thấy đã, ngụm thứ hai thêm tỉnh táo và cứ thế lôi cuốn bạn đến giọt cuối cùng.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 1, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 4, ProductName = "SINH TỐ VIỆT QUẤT", Description = "Mứt Việt Quất chua thanh, ngòn ngọt, phối hợp nhịp nhàng với dòng sữa chua bổ dưỡng. Là món sinh tố thơm ngon mà cả đầu lưỡi và làn da đều thích.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 1, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 5, ProductName = "PHÚC BỒN TỬ CAM ĐÁ XAY", Description = "Tê tái ngay đầu lưỡi bởi sự mát lạnh của đá xay. Hòa quyện thêm hương vị chua chua, ngọt ngọt từ trái cam tươi và trái phúc bồn tử 100% tự nhiên, để cho ra một hương vị thanh mát, kích thích vị giác đầy thú vị ngay từ lần đầu thưởng thức. Lại thêm một lựa chọn mới cho \"team đá xay\" và team trái cây, còn chần chờ gì nữa mà không thử ngay thôi!", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 1, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 6, ProductName = "COOKIES ĐÁ XAY", Description = "Những mẩu bánh cookies giòn rụm kết hợp ăn ý với sữa tươi và kem tươi béo ngọt, đem đến cảm giác lạ miệng gây thích thú. Một món uống phá cách dễ thương.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 1, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 7, ProductName = "MATCHA ĐÁ XAY", Description = "Matcha thanh, nhẫn, và đắng nhẹ được nhân đôi sảng khoái khi uống lạnh. Nhấn nhá thêm những nét bùi béo của kem và sữa. Gây thương nhớ vô cùng!", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 1, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 8, ProductName = "Trà Long Nhãn Hạt Chia", Description = "", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 4, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 9, ProductName = "TRÀ HẠT SEN", Description = "Sự kết hợp của Trà hương thơm nhẹ, vị nồng hậu cùng Hạt sen tươi mềm có vị ngọt, sáp, vừa ngon miệng vừa có tác dụng an thần, tốt cho cơ thể.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 4, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 10, ProductName = "TRÀ ĐÀO CAM SẢ", Description = "Vị thanh ngọt của đào Hy Lạp, vị chua dịu của Cam Vàng nguyên vỏ, vị chát của trà đen tươi được ủ mới mỗi 4 tiếng, cùng hương thơm nồng đặc trưng của sả chính là điểm sáng làm nên sức hấp dẫn của thức uống này. Sản phẩm hiện có 2 phiên bản Nóng và Lạnh phù hợp cho mọi thời gian trong năm.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 4, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 11, ProductName = "TRÀ SỮA MẮC CA TRÂN CHÂU", Description = "", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 4, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 12, ProductName = "TRÀ PHÚC BỒN TỬ", Description = "", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 4, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 13, ProductName = "TRÀ ĐEN MACCHIATO", Description = "Trà đen được ủ mới mỗi ngày, giữ nguyên được vị chát mạnh mẽ đặc trưng của lá trà, phủ bên trên là lớp Macchiato \"homemade\" bồng bềnh quyến rũ vị phô mai mặn mặn mà béo béo.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 4, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 14, ProductName = "HỒNG TRÀ SỮA TRÂN CHÂU", Description = " ", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 4, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 15, ProductName = "AMERICANO", Description = "Americano được pha chế bằng cách thêm nước vào một hoặc hai shot Espresso để pha loãng độ đặc của cà phê, từ đó mang lại hương vị nhẹ nhàng, không gắt mạnh và vẫn thơm nồng nàn. 40,000 đ", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 6, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 16, ProductName = "BẠC SỈU", Description = "Theo chân những người gốc Hoa đến định cư tại Sài Gòn, Bạc sỉu là cách gọi tắt của \"Bạc tẩy sỉu phé\" trong tiếng Quảng Đông, chính là: Ly sữa trắng kèm một chút cà phê.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 6, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 17, ProductName = "CÀ PHÊ ĐEN", Description = "Một tách cà phê đen thơm ngào ngạt, phảng phất mùi cacao là món quà tự thưởng tuyệt vời nhất cho những ai mê đắm tinh chất nguyên bản nhất của cà phê. Một tách cà phê trầm lắng, thi vị giữa dòng đời vồn vã.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 6, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 18, ProductName = "CÀ PHÊ SỮA", Description = "Cà phê phin kết hợp cũng sữa đặc là một sáng tạo đầy tự hào của người Việt, được xem món uống thương hiệu của Việt Nam.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 6, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 19, ProductName = "CAPPUCCINO", Description = "Cappuccino được gọi vui là thức uống \"một - phần - ba\" - 1/3 Espresso, 1/3 Sữa nóng, 1/3 Foam.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 6, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 20, ProductName = "CARAMEL MACCHIATO", Description = "Vị thơm béo của bọt sữa và sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng, và vị ngọt đậm của sốt caramel.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 6, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new ProductEntities { Id = 21, ProductName = "ESPRESSO", Description = "Một cốc Espresso nguyên bản được bắt đầu bởi những hạt Arabica chất lượng, phối trộn với tỉ lệ cân đối hạt Robusta, cho ra vị ngọt caramel, vị chua dịu và sánh đặc. Để đạt được sự kết hợp này, chúng tôi xay tươi hạt cà phê cho mỗi lần pha.", ProductImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1624726478/umggd5qbtmketrfid20r.png" , PublicId = "umggd5qbtmketrfid20r",  CategoryId = 6, Discount = 20, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime }
                );
            #endregion

            #region Data Size
            modelBuilder.Entity<SizeEntities>().HasData(
                new SizeEntities { Id = 1, SizeName = "M", Price = 25000, ProductId = 1, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SizeEntities { Id = 2, SizeName = "L", Price = 30000, ProductId = 1, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SizeEntities { Id = 3, SizeName = "XL", Price = 35000, ProductId = 1, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SizeEntities { Id = 4, SizeName = "M", Price = 28000, ProductId = 2, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SizeEntities { Id = 5, SizeName = "L", Price = 32000, ProductId = 2, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SizeEntities { Id = 6, SizeName = "M", Price = 18000, ProductId = 3, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SizeEntities { Id = 7, SizeName = "L", Price = 22000, ProductId = 3, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SizeEntities { Id = 8, SizeName = "L", Price = 30000, ProductId = 4, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SizeEntities { Id = 9, SizeName = "XL", Price = 35000, ProductId = 4, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SizeEntities { Id = 10, SizeName = "M", Price = 28000, ProductId = 5, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SizeEntities { Id = 11, SizeName = "M", Price = 25000, ProductId = 6, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime }
                );
            #endregion

            #region Position
            modelBuilder.Entity<PositionEntities>().HasData(
                new PositionEntities { Id = 1, PositionName = "Nhân Viên Phục Vụ", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new PositionEntities { Id = 2, PositionName = "Thu Nhân", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new PositionEntities { Id = 3, PositionName = "Nhân Viên Quản Lý", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new PositionEntities { Id = 4, PositionName = "Bảo Vệ", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime }
                );
            #endregion

            #region Data Branch
            modelBuilder.Entity<BranchEntities>().HasData(
                new BranchEntities { Id = 1, BranchName = "572 Ba Tháng Hai", Email = "nqcuong720@gmail.com", NumberPhone = "0377077630", Address = "572 Ba Tháng Hai, Quận 10, Hồ Chí Minh, Việt Nam", ManagerEmployeeId = 1, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new BranchEntities { Id = 2, BranchName = "798 Sư Vạn Hạnh", Email = "nqcuong720@gmail.com", NumberPhone = "0377077630", Address = "798 Sư Vạn Hạnh, Quận 10, Hồ Chí Minh, Việt Nam", ManagerEmployeeId = 2, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new BranchEntities { Id = 3, BranchName = "175B Cao Thắng", Email = "nqcuong720@gmail.com", NumberPhone = "0377077630", Address = "175B Cao Thắng, Quận 10, Hồ Chí Minh, Việt Nam", ManagerEmployeeId = 3, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new BranchEntities { Id = 4, BranchName = "25A Đồng Nai", Email = "nqcuong720@gmail.com", NumberPhone = "0377077630", Address = "25A Đồng Nai, Quận 10, Hồ Chí Minh, Việt Nam", ManagerEmployeeId = 4, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new BranchEntities { Id = 5, BranchName = "159 Phạm Ngũ Lão", Email = "nqcuong720@gmail.com", NumberPhone = "0377077630", Address = "159 Phạm Ngũ Lão, Quận 1, Hồ Chí Minh, Việt Nam", ManagerEmployeeId = 5, Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime }
                );
            #endregion

            #region Data Slide
            modelBuilder.Entity<SlideEntities>().HasData(
                new SlideEntities { Id = 1, SlideName = "Đại Lễ 30-4", PublicId = "ikb4lno0tsinvuhgfg0e", UrlSlideImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SlideEntities { Id = 2, SlideName = "Mừng Tết Thiếu Nhi", PublicId = "ikb4lno0tsinvuhgfg0e", UrlSlideImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SlideEntities { Id = 3, SlideName = "Khuyến Mãi Friday", PublicId = "ikb4lno0tsinvuhgfg0e", UrlSlideImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SlideEntities { Id = 4, SlideName = "Ngày Quốc Tế Phụ Nữ", PublicId = "ikb4lno0tsinvuhgfg0e", UrlSlideImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SlideEntities { Id = 5, SlideName = "Ngày Hội Hiến Máu", PublicId = "ikb4lno0tsinvuhgfg0e", UrlSlideImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SlideEntities { Id = 6, SlideName = "Khuyến Mãi Đầu Tuần", PublicId = "ikb4lno0tsinvuhgfg0e", UrlSlideImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime },
                new SlideEntities { Id = 7, SlideName = "Ưu đãi Tháng 6", PublicId = "ikb4lno0tsinvuhgfg0e", UrlSlideImage = "https://res.cloudinary.com/nqcuong720/image/upload/v1625247148/ikb4lno0tsinvuhgfg0e.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, UpdateBy = 1, CreateDate = dateTime, UpdateDate = dateTime }
                );
            #endregion
        }
    }
}
