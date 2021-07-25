// <copyright file="ICartItemServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;

namespace CoffeeManagementSystem.Services.CartItemServices
{
    public interface ICartItemServices : BaseServices.IBaseServices
    {
        /// <summary>
        /// Lấy danh sách tất cả các sản phẩm trong giỏ hàng.
        /// </summary>
        /// <returns>Danh sách giỏ hàng.</returns>
        List<CartItemModel> GetListCartItemAll();

        /// <summary>
        /// Danh sách sản phẩm giỏ hàng.
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<CartItemModel> GetListCartItemAllPaging(int pageIndex, int pageSize);

        CartItemModel CreateCartItem(CartItemModel CartItemModel);

        CartItemModel UpdateCartItem(CartItemModel CartItemModel);

        CartItemModel GetCartItemById(int CartItemId);

        bool DeleteCartItem(int CartItemId);
    }
}
