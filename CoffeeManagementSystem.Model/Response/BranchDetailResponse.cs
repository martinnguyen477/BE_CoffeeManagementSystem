// <copyright file="BranchDetailResponse.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Response
{
    using CoffeeManagementSystem.Model.BaseModel;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BranchDetailResponse : BaseTableWithId
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

        /// <summary>
        /// Gets or sets tên quản lý của chi nhánh.
        /// </summary>
        public string ManagerEmployeeName { get; set; }

        /// <summary>
        /// Gets or sets tên nhân viên tạo.
        /// </summary>
        public string CreateByUser { get; set; }

        /// <summary>
        /// Gets or sets tên nhân viên chỉnh sửa lần cuối.
        /// </summary>
        public string UpdateByUser { get; set; }
    }
}
