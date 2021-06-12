// <copyright file="CartEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Thực thể Giỏ Hàng.
    /// </summary>
    public class CartEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets mã khách hàng.
        /// </summary>
        public int CustomerId { get; set; }
    }
}
