// <copyright file="IOrderServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;

namespace CoffeeManagementSystem.Services.OrderServices
{
    public interface IOrderServices : BaseServices.IBaseServices
    {
        /// <summary>
        /// Lấy danh sách tất cả các đơn hàng. 
        /// </summary>
        /// <returns>Danh sách tất cả đơn hàng.</returns>
        List<OrderModel> GetListOrderAll();

        /// <summary>
        /// Lấy danh sách tất cả các đơn hàng theo số trang, kích cỡ trang.
        /// </summary>
        /// <param name="pageIndex">Số trang.</param>
        /// <param name="pageSize">Kích cỡ trang.</param>
        /// <returns>Danh sách đơn hàng theo số trang và kích cỡ trang.</returns>
        List<OrderModel> GetListOrderAllPaging(int pageIndex, int pageSize);

        /// <summary>
        /// Tạo đơn hàng mới.
        /// </summary>
        /// <param name="orderModel">Request Model</param>
        /// <returns>Thông tin đơn hàng vừa tạo.</returns>
        OrderModel CreateOrder(OrderModel orderModel);

        /// <summary>
        /// Update đơn hàng.
        /// </summary>
        /// <param name="orderModel">Request Model.</param>
        /// <returns>Thông Tin Đơn Hàng vừa Update.</returns>
        OrderModel UpdateOrder(OrderModel orderModel);

        /// <summary>
        /// Lấy thông tin chi tiết của đơn hàng.
        /// </summary>
        /// <param name="orderId">Mã đơn hàng.</param>
        /// <returns>thông tin chi tiết của đơn hàng.</returns>
        OrderModel GetOrderById(int orderId);

        /// <summary>
        /// Xóa đơn hàng.
        /// </summary>
        /// <param name="orderId">Mã đơn hàng.</param>
        /// <returns>Trả về true or false.</returns>
        bool DeleteOrder(int orderId);
    }
}
