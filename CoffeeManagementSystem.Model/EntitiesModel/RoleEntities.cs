// <copyright file="RoleEntities.cs.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    public class RoleEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên Role.
        /// </summary>
        public string RoleName { get; set; }
    }
}
