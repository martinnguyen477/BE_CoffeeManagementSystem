// <copyright file="GroupUserEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Group User Entities.
    /// </summary>
    public class GroupUserEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên nhóm người dùng.
        /// </summary>
        public string GroupUserName { get; set; }
    }
}
