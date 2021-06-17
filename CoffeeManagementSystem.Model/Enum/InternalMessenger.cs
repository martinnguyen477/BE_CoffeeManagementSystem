using System;
using System.Collections.Generic;
using System.Text;

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
        public string CreateCategoryError = "Tạo loại không thành công";
        public string UpdateCategoryError = "Tạo loại không thành công";
        public string DeleteCategorySuccess = "Xóa Category thành công";
        public string DeleteCategoryError = "Xóa Category không thành công";
        public string GetCategoryError = "Lấy danh sách Category không thành công";
        public string GetCategorySuccess = "Lấy danh sách Category thành công";
    }
}
