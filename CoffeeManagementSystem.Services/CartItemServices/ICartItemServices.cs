// <copyright file="ICartItemServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;

namespace CoffeeManagementSystem.Services.CartItemServices
{
    public interface ICartItemServices : BaseServices.IBaseServices
    {
        List<CartItemModel> GetListCartItemAll();

        List<CartItemModel> GetListCartItemAllPaging(int pageIndex, int pageSize);

        CartItemModel CreateCartItem(CartItemModel CartItemModel);

        CartItemModel UpdateCartItem(CartItemModel CartItemModel);

        CartItemModel GetCartItemById(int CartItemId);

        bool DeleteCartItem(int CartItemId);
    }
}
