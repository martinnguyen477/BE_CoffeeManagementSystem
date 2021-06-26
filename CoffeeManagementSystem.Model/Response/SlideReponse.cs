// <copyright file="SlideReponse.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.BaseModel;

namespace CoffeeManagementSystem.Model.Response
{
    public class SlideReponse : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets slideName.
        /// </summary>
        public string SlideName { get; set; }

        /// <summary>
        /// Gets or sets tên nhân viên tạo.
        /// </summary>
        public string CreateByUser { get; set; }

        /// <summary>
        /// Gets or sets tên nhân viên chỉnh sửa lần cuối.
        /// </summary>
        public string UpdateByUser { get; set; }

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
