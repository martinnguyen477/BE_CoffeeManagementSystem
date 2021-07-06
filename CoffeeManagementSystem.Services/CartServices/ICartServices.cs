// <copyright file="ICartServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;

namespace CoffeeManagementSystem.Services.CartServices
{
    public interface ICartServices : BaseServices.IBaseServices
    {
        List<CartModel> GetListCartAll();

        List<CartModel> GetListCartAllPaging(int pageIndex, int pageSize);

        CartModel CreateCart(CartModel cartModel);

        CartModel UpdateCart(CartModel cartModel);

        CartModel GetCartById(int cartId);

        bool DeleteCart(int cartId);
    }
}
