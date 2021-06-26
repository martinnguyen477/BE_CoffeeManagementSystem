// <copyright file="ProductModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Model
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Thực thể sản phẩm.
    /// </summary>
    public class ProductModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên sản phẩm.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Mã của ảnh up cloud.
        /// </summary>
        public string PublicId { get; set; }

        /// <summary>
        /// Gets or sets ảnh sản phẩm.
        /// </summary>
        public string ProductImage { get; set; }

        /// <summary>
        /// Gets or sets giá sản phẩm.
        /// </summary>
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// Gets or sets mô tả.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets giảm giá.
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or sets loại sản phẩm.
        /// </summary>
        public int CategoryId { get; set; }
    }
}
