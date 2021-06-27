// <copyright file="InternalMessenger.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Enum
{
    public class InternalMessenger
    {
        public string NoExitData = "Data không có trong hệ thống";
        public string SuccessFull = "Tạo dữ liệu thành công vào database";
        public string UpdateSuccessFull = "Cập nhật dữ liệu thành công vào database";
        public string GetDataSuccessful = "Lấy dữ liệu thành công";
        public string BadRequest = "Tham số truyền vào không có hoặc bị null";
        public string SystemError = "Lỗi từ hệ thống";
        public string LoginSuccess = "Đăng nhập thành công vào hệ thống";
        public string LoginError = "Tài khoản hoặc mật khẩu không đúng";
        public string ExitUser = "Tài khoản đã tồn tại trong hệ thống";
        public string LogoutSuccessful = "Logout thành công khỏi hệ thống";
        public string LogoutError = "Logout không thành công khỏi hệ thống";
        public string ChangePassSuccess = "Thay đổi mật khẩu thành công";
        public string ChangePassError = "Thay đổi mật khẩu không thành công";
        public string SameOldPassword = "Mật khẩu mới giống mật khẩu cũ";
        public string CheckLoginSuccess = "Check login thành công";
        public string ErrorCookies = "Chưa đăng nhập, lỗi do hệ thống Ctrl + F5 hoặc F5";
        public string NotExitCookies = "Chưa đang nhập vào hệ thống";
        public string GetDataError = "Lấy dữ liệu không thành công";
        public string CreateCustomerError = "Tạo khách hàng không thành công";
        public string CreateVendorError = "Tạo nhà cung cấp không thành công";
        public string UpdateCustomerError = "Cập nhật khách hàng không thành công";
        public string UpdateStatusCustomerSuccessfull = "Cập nhật status khách hàng thành công";
        public string UpdateStatusCustomerError = "Cập nhật status khách hàng không thành công";
        public string CreateProductError = "Tạo sản phẩm không thành công";
        public string UpdateProductError = "Cập nhật sản phẩm không thành công";
        public string CreateReferenceCodeError = "Tạo sản phẩm bảo hành không thành công";
        public string CreateCancelSaleOrderSuccess = "Tạo đơn trả hàng thành công";
        public string CreateCancelSaleOrderErrorr = "Tạo đơn trả hàng không thành công";
        public string UpdateBalanceValueSuccess = "Cập nhật thanh toán thành công";
        public string UpdateBalanceValueError = "Cập nhật thanh toán không thành công";
        public string CreatePurcharseError = "Tạo đơn nhập hàng không thành công";

        public string CheckPasswordSuccess = "Password is correct";
        public string CheckPasswordError = "Password is not correct";



        #region Message Of Category
        public string CreateCategoryError = "Tạo loại không thành công.";
        public string CreateCategoryNameIsNull = "Không được để trống tên loại.";
        public string UpdateCategoryError = "Sửa loại không thành công.";
        public string DeleteCategorySuccess = "Xóa Category thành công.";
        public string DeleteCategoryError = "Không tìm thấy Category này.";
        public string GetCategoryNoExists = "Không có Category nào trong hệ thống.";
        public string GetCategorySuccess = "Lấy danh sách Category thành công.";
        public string GetCategoryByIdSuccess = "Lấy Category chi tiết thành công.";
        public string GetCategoryByIdError = "Lấy Category chi tiết không thành công.";
        #endregion

        #region Message Of Position
        public string GetPositionNoExists = "Không có vị trí nào trong hệ thống.";
        public string GetPositionSuccess = "Lấy danh sách vị trí nào trong hệ thống.";
        public string CreatePositionNameIdNull = "Không được để tên vị trí trống.";
        public string CreatePositionError = "Thêm vị mới không thành công.";
        public string UpdatePositionError = "Sửa vị trí không thành công.";
        public string UpdatePositionSuccess = "Sửa vị trí thành công.";
        public string DeletePositionError = "Xóa vị trí không thành công.";
        public string DeletePositionSucces = "Xóa vị trí thành công.";
        public string GetPositionByIdSuccess = "Lấy chi tiết vị trí thành công.";
        public string GetPositionByIdError = "Lấy chi tiết vị trí không thành công.";

        #endregion

        #region Message Of Account
        public string InsertRoleForGroupUserUnSuccess = "Thêm quyền cho nhóm người dùng không thành công";
        public string InsertRoleForGroupUserSuccess = "Thêm quyền cho nhóm người dùng thành công";
        public string InsertRoleForGroupUserError = "Thêm quyền cho nhóm người dùng lỗi";
        public string InsertUserExist = "Tài khoản người dùng đã tồn tại";
        public string GetInfoUserSuccess = "Lấy thông tin người dùng thành công";
        public string GetInfoUserUnSuccess = "Lấy thông tin người dùng không thành công";
        #endregion

        #region Message Of Product
        public string InsertProductError = "Thêm sản phẩm thất bại";
        public string DeleteProductSucess = "Xóa sản phẩm thành công";
        public string DeleteProductError = "Xóa sản phẩm thất bại";
        #endregion
    }
}
