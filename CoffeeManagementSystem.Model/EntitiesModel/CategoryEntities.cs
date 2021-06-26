// <copyright file="CategoryEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Thực thể Loại.
    /// </summary>
    public class CategoryEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên Loại.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets đường dẫn PublicIdImage.
        /// </summary>
        public string PublicIdImage { get; set; }

        /// <summary>
        /// Gets or sets hình ảnh của loại.
        /// </summary>
        public string UrlImageCategory { get; set; }
    }
}
