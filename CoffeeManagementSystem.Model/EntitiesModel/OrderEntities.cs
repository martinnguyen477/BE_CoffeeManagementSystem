// <copyright file="OrderEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Thực thể Hóa đơn.
    /// </summary>
    public class OrderEntities : BaseTableWithId
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
