// <copyright file="CategoryDetailById.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Response
{
    using CoffeeManagementSystem.Model.BaseModel;

    public class CategoryDetailById : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên Loại.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets tên nhân viên tạo.
        /// </summary>
        public string CreateByUser { get; set; }

        /// <summary>
        /// Gets or sets tên nhân viên chỉnh sửa lần cuối.
        /// </summary>
        public string UpdateByUser { get; set; }

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
