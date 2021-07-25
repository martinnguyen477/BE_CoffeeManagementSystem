// <copyright file="GetProductRespone.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.BaseModel;
using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;

namespace CoffeeManagementSystem.Model.Response
{
    public class GetProductRespone : BaseTableWithId
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

        /// <summary>
        /// Gets or sets list Size For Product.
        /// </summary>
        public List<SizeModel> Sizes { get; set; }
    }
}
