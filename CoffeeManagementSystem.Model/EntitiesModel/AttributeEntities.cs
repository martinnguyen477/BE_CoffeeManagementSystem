// <copyright file="AttributeEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Attribute.
    /// </summary>
    public class AttributeEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên thuộc tính.
        /// </summary>
        public string AttributeName { get; set; }
    }
}
