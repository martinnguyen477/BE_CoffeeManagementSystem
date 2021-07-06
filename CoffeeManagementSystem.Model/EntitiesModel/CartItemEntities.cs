// <copyright file="CartItemEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// CartItemEntities.
    /// </summary>
    public class CartItemEntities : BaseTableWithId
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
