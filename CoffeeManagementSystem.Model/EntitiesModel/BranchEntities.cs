// <copyright file="BranchEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Thực thể Chi Nhánh.
    /// </summary>
    public class BranchEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên Chi Nhánh.
        /// </summary>
        public string BranchName { get; set; }

        /// <summary>
        /// Gets or sets địa chỉ.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets số điện thoại.
        /// </summary>
        public string NumberPhone { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets mã nhân viên quản lí.
        /// </summary>
        public int ManagerEmployeeId { get; set; }
    }
}
