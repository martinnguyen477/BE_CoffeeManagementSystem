// <copyright file="PostitonEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Thực thể Vị trí.
    /// </summary>
    public class PositionEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên vị trí.
        /// </summary>
        public string PositionName { get; set; }
    }
}
