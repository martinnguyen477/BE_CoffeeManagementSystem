// <copyright file="AttributeValueModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Model
{
    /// <summary>
    /// AttributeValue.
    /// </summary>
    public class AttributeValueModel
    {
        /// <summary>
        /// Gets or sets mã thuộc tính.
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// Gets or sets mã sản phẩm.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets giá trị của thuộc tính.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets giá của thuộc tính.
        /// </summary>
        public decimal Price { get; set; }
    }
}
