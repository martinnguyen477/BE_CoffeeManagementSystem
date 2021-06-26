// <copyright file="GroupUserModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Model
{
    using CoffeeManagementSystem.Model.BaseModel;

    public class GroupUserModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên nhóm người dùng.
        /// </summary>
        public string GroupUserName { get; set; }
    }
}
