// <copyright file="OrderModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.BaseModel;

namespace CoffeeManagementSystem.Model.Model
{
    /// <summary>
    /// Thực thể Hóa đơn.
    /// </summary>
    public class OrderModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets mã nhân viên.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets phương thức vận chuyển.
        /// </summary>
        public int DeliveryMethod { get; set; }

        /// <summary>
        /// Gets or sets mã chi nhánh.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// Gets or sets giảm giá.
        /// </summary>
        public int Discount { get; set; }

        /// <summary>
        /// Gets or sets thành tiền.
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Gets or sets mã khách hàng nếu có.
        /// </summary>
        public int CustomerId { get; set; }
    }
}
