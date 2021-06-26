// <copyright file="RoleModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Model
{
    using CoffeeManagementSystem.Model.BaseModel;

    public class RoleModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên Role.
        /// </summary>
        public string RoleName { get; set; }
    }
}
