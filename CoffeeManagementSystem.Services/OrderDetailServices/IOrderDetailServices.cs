// <copyright file="IOrderDetailServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;

namespace CoffeeManagementSystem.Services.OrderDetailServices
{
    public interface IOrderDetailServices : BaseServices.IBaseServices
    {
        List<OrderDetailModel> GetListOrderDetailAll();

        List<OrderDetailModel> GetListOrderDetailAllPaging(int pageIndex, int pageSize);

        OrderDetailModel CreateOrderDetail(OrderDetailModel orderDetailModel);

        OrderDetailModel UpdateOrderDetail(OrderDetailModel orderDetailModel);

        OrderDetailModel GetOrderDetailById(int orderId);

        bool DeleteOrderDetail(int orderId);
    }
}
