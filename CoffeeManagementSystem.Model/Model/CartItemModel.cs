// <copyright file="CartItemModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.BaseModel;

namespace CoffeeManagementSystem.Model.Model
{
    /// <summary>
    /// CartItemEntities.
    /// </summary>
    public class CartItemModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets mã giỏ hàng.
        /// </summary>
        public int CartId { get; set; }

        /// <summary>
        /// Gets or sets mã sản phẩm.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets số lượng.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets tổng tiền.
        /// </summary>
        public decimal TotalPrice { get; set; }
    }
}
