// <copyright file="ResponseUploadImageCloud.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Response
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ResponseUploadImageCloud
    {
        /// <summary>
        /// Đường dẫn hình ảnh.
        /// </summary>
        public string UrlImage { get; set; }

        public string PublicId { get; set; }
    }
}
