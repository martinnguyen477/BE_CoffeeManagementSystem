// <copyright file="CartModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.BaseModel;

namespace CoffeeManagementSystem.Model.Model
{
    /// <summary>
    /// Thực thể Giỏ Hàng.
    /// </summary>
    public class CartModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets mã khách hàng.
        /// </summary>
        public int CustomerId { get; set; }
    }
}
