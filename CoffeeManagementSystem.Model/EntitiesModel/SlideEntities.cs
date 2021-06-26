// <copyright file="SlideEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    /// <summary>
    /// Thực thể Slide.
    /// </summary>
    public class SlideEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets slideName.
        /// </summary>
        public string SlideName { get; set; }

        /// <summary>
        /// Gets or sets khóa công khai của image cloud.
        /// </summary>
        public string PublicId { get; set; }

        /// <summary>
        /// Gets or sets hình ảnh Slide.
        /// </summary>
        public string UrlSlideImage { get; set; }
    }
}
