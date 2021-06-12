// <copyright file="AttributeValueBillDetailEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Thực thể AttributeValueBillDetail.
    /// </summary>
    public class AttributeValueBillDetailEntities : BaseTable
    {
        /// <summary>
        /// Gets or sets billDetail.
        /// </summary>
        public int BillDetailId { get; set; }

        /// <summary>
        /// Gets or sets attributeValueId.
        /// </summary>
        public int AttributeValueId { get; set; }
    }
}
