// <copyright file="AttributeValueEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// AttributeValue.
    /// </summary>
    public class AttributeValueEntities : BaseTableWithId
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
