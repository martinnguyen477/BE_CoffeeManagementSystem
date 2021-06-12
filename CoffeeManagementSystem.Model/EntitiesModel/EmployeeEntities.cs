// <copyright file="EmployeeEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using System;
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Thực thể Nhân Viên.
    /// </summary>
    public class EmployeeEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets Họ.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets image.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets gioi tính.
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets birthDay.
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// Gets or sets numberPhone.
        /// </summary>
        public string NumberPhone { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets username.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets mã vị trí.
        /// </summary>
        public int PositionId { get; set; }

        /// <summary>
        /// Gets or sets chi nhánh.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// Gets or sets mật Khẩu.
        /// </summary>
        public string Password { get; set; }
    }
}
