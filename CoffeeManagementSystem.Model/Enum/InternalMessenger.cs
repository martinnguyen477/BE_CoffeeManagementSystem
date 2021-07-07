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
        public string UpdateCategoryError = "Không tìm thấy loại này.";
        public string DeleteCategorySuccess = "Xóa Category thành công.";
        public string DeleteCategoryError = "Không tìm thấy Category này.";
        public string GetCategoryNoExists = "Không có Category nào trong hệ thống.";
        public string GetCategorySuccess = "Lấy danh sách Category thành công.";
        public string GetCategoryByIdSuccess = "Lấy Category chi tiết thành công.";
        public string GetCategoryByIdError = "Lấy Category chi tiết không thành công.";
        #endregion

        #region Message Of Position
        public string GetPositionNoExists = "Không có vị trí nào trong hệ thống.";
        public string GetPositionSuccess = "Lấy danh sách vị trí trong hệ thống.";
        public string CreatePositionNameIdNull = "Không được để tên vị trí trống.";
        public string CreatePositionError = "Thêm vị trí mới không thành công.";
        public string UpdatePositionError = "Không tìm thấy vị trí này.";
        public string UpdatePositionSuccess = "Sửa vị trí thành công.";
        public string DeletePositionError = "Xóa vị trí không thành công.";
        public string DeletePositionSucces = "Xóa vị trí thành công.";
        public string GetPositionByIdSuccess = "Lấy chi tiết vị trí thành công.";
        public string GetPositionByIdError = "Lấy chi tiết vị trí không thành công.";
        #endregion


        #region Message Of Branch
        public string GetBranchNoExists = "Không có chi nhánh nào trong hệ thống.";
        public string GetBranchSuccess = "Lấy danh sách chi nhánh trong hệ thống.";
        public string CreateBranchNameIdNull = "Không được để tên chi nhánh trống.";
        public string CreateBranchError = "Thêm chi nhánh mới không thành công.";
        public string UpdateBranchError = "Sửa chi nhánh không thành công.";
        public string UpdateBranchSuccess = "Sửa chi nhánh thành công.";
        public string DeleteBranchError = "Không tìm thấy chi nhánh này.";
        public string DeleteBranchSucces = "Xóa chi nhánh thành công.";
        public string GetBranchByIdSuccess = "Lấy chi tiết chi nhánh thành công.";
        public string GetBranchByIdError = "Không tìm thấy chi nhánh này.";
        #endregion

        #region Message Of Slide
        public string GetSlideNoExists = "Không có Slide nào trong hệ thống.";
        public string GetSlideSuccess = "Lấy danh sách Slide trong hệ thống.";
        public string CreateSlideNameIdNull = "Không được để tên Slide trống.";
        public string CreateSlideError = "Không tìm thấy Slide này.";
        public string UpdateSlideError = "Sửa Slide không thành công.";
        public string UpdateSlideSuccess = "Sửa Slide thành công.";
        public string DeleteSlideError = "Không tìm thấy Slide này.";
        public string DeleteSlideSuccess = "Xóa Slide thành công.";
        public string GetSlideByIdSuccess = "Lấy chi tiết Slide thành công.";
        public string GetSlideByIdError = "Lấy chi tiết Slide không thành công.";
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

        #region OrderDetail
        public string GetOrderDetailNoExists = "Không có đơn hàng chi tiết nào trong hệ thống.";
        public string GetOrderDetailSuccess = "Lấy danh sách đơn hàng chi tiết trong hệ thống.";
        public string CreateOrderDetailNameIdNull = "Không được để tên vị trí trống.";
        public string CreateOrderDetailError = "Thêm đơn hàng chi tiết mới không thành công.";
        public string CreateOrderDetailSuccess = "Thêm đơn hàng chi tiết mới không thành công.";
        public string UpdateOrderDetailError = "Không tìm thấy đơn hàng chi tiết này.";
        public string UpdateOrderDetailSuccess = "Sửa đơn hàng chi tiết thành công.";
        public string DeleteOrderDetailError = "Xóa đơn hàng chi tiết không thành công.";
        public string DeleteOrderDetailSucces = "Xóa đơn hàng chi tiết thành công.";
        public string GetOrderDetailByIdSuccess = "Lấy chi tiết đơn hàng chi tiết thành công.";
        public string GetOrderDetailByIdError = "Lấy chi tiết đơn hàng chi tiết không thành công.";
        #endregion

        #region Order
        public string GetOrderNoExists = "Không có đơn hàng nào trong hệ thống.";
        public string GetOrderSuccess = "Lấy danh sách đơn hàng trong hệ thống.";
        public string CreateOrderNameIdNull = "Không được để tên vị trí trống.";
        public string CreateOrderError = "Thêm đơn hàng mới không thành công.";
        public string CreateOrderSuccess = "Thêm đơn hàng mới không thành công.";
        public string UpdateOrderError = "Không tìm thấy đơn hàng này.";
        public string UpdateOrderSuccess = "Sửa đơn hàng thành công.";
        public string DeleteOrderError = "Xóa đơn hàng không thành công.";
        public string DeleteOrderSucces = "Xóa đơn hàng thành công.";
        public string GetOrderByIdSuccess = "Lấy chi tiết đơn hàng thành công.";
        public string GetOrderByIdError = "Lấy chi tiết đơn hàng không thành công.";
        #endregion

        #region Order
        public string GetCartItemNoExists = "Không có món nào trong hệ thống.";
        public string GetCartItemSuccess = "Lấy danh sách món trong hệ thống.";
        public string CreateCartItemNameIdNull = "Không được để tên món trống.";
        public string CreateCartItemError = "Thêm món mới vào giỏ hàng không thành công.";
        public string CreateCartItemSuccess = "Thêm món mới vào giỏ hàng không thành công.";
        public string UpdateCartItemError = "Không tìm thấy món này.";
        public string UpdateCartItemSuccess = "Sửa món thành công.";
        public string DeleteCartItemError = "Xóa món không thành công.";
        public string DeleteCartItemSucces = "Xóa món thành công.";
        public string GetCartItemByIdSuccess = "Lấy chi tiết món thành công.";
        public string GetCartItemByIdError = "Lấy chi tiết món không thành công.";
        #endregion

        #region Order
        public string GetCartNoExists = "Không có món nào trong hệ thống.";
        public string GetCartSuccess = "Lấy danh sách món trong hệ thống.";
        public string CreateCartNameIdNull = "Không được để tên món trống.";
        public string CreateCartError = "Thêm món mới vào giỏ hàng không thành công.";
        public string CreateCartSuccess = "Thêm món mới vào giỏ hàng không thành công.";
        public string UpdateCartError = "Không tìm thấy món này.";
        public string UpdateCartSuccess = "Sửa món thành công.";
        public string DeleteCartError = "Xóa món không thành công.";
        public string DeleteCartSucces = "Xóa món thành công.";
        public string GetCartByIdSuccess = "Lấy chi tiết món thành công.";
        public string GetCartByIdError = "Lấy chi tiết món không thành công.";
        #endregion
    }
}
