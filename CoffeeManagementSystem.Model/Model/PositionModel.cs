// <copyright file="PostitonModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Model
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Thực thể Vị trí.
    /// </summary>
    public class PositionModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên vị trí.
        /// </summary>
        public string PositionName { get; set; }
    }
}
