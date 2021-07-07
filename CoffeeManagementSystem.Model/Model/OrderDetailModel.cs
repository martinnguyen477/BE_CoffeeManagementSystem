// <copyright file="OrderDetailModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.BaseModel;

namespace CoffeeManagementSystem.Model.Model
{
    /// <summary>
    /// Thực thể hóa đơn chi tiết.
    /// </summary>
    public class OrderDetailModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets mã sản phẩm.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets tên sản phẩm.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets mã hóa đơn.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets số lượng.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets giá sản phẩm.
        /// </summary>
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// Gets or sets giảm giá.
        /// </summary>
        public int Discount { get; set; }

        /// <summary>
        /// Gets or sets tổng tiền.
        /// </summary>
        public decimal TotalMoney { get; set; }

        /// <summary>
        /// Gets or sets ghi chú.
        /// </summary>
        public string Note { get; set; }
    }
}
