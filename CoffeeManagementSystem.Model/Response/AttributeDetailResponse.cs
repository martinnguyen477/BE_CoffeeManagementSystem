// <copyright file="AttributeDetailResponse.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Response
{
    public class AttributeDetailResponse
    {
        /// <summary>
        /// Mã thuộc tính. Ví dụ là Size, Price
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// Gia trị thuộc tính Size, Price,....
        /// </summary>
        public string AttributeName { get; set; }

        /// <summary>
        /// Mã Gia trị
        /// </summary>
        public int AttributeValueId { get; set; }

        /// <summary>
        /// Gía trị của giá trị thuộc tính
        /// </summary>
        public string AttributeNameValue { get; set; }

        /// <summary>
        /// Gets or sets giá.
        /// </summary>
        public int Price { get; set; }
    }
}
