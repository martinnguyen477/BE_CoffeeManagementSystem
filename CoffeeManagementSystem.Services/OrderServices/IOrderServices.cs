// <copyright file="IOrderServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;

namespace CoffeeManagementSystem.Services.OrderServices
{
    public interface IOrderServices : BaseServices.IBaseServices
    {
        List<OrderModel> GetListOrderAll();

        List<OrderModel> GetListOrderAllPaging(int pageIndex, int pageSize);

        OrderModel CreateOrder(OrderModel orderModel);

        OrderModel UpdateOrder(OrderModel orderModel);

        OrderModel GetOrderById(int orderId);

        bool DeleteOrder(int orderId);
    }
}
