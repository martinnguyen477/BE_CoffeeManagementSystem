// <copyright file="ICategoryServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.CategoryServices
{
    using System.Collections.Generic;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.BaseServices;
    using Microsoft.AspNetCore.Http;

    public interface ICategoryServices : IBaseServices
    {
        /// <summary>
        /// Lấy danh sách tất cả category.
        /// </summary>
        /// <returns>Danh sách Category.</returns>
        List<CategoryModel> GetCategory();

        /// <summary>
        /// Tạo category mới.
        /// </summary>
        /// <param name="formFile">file ảnh.</param>
        /// <param name="cloudName">tên cloud.</param>
        /// <param name="apiKey">api key.</param>
        /// <param name="apiSecret">api secrect.</param>
        /// <param name="categoryModel">Model hứng data từ client.</param>
        /// <returns>Thông tin category vừa tạo.</returns>
        CategoryModel CreateCategory(IFormFile formFile, string cloudName, string apiKey, string apiSecret, CategoryModel categoryModel);

        /// <summary>
        /// Update Category
        /// </summary>
        /// <param name="formFile">file ảnh.</param>
        /// <param name="cloudName">tên cloud.</param>
        /// <param name="apiKey">api key.</param>
        /// <param name="apiSecret">api secrect.</param>
        /// <param name="categoryModel">Model hứng data từ client.</param>
        /// <returns>Thông tin của Category vừa Update.</returns>
        CategoryModel UpdateCategory(IFormFile formFile, string cloudName, string apiKey, string apiSecret, CategoryModel categoryModel, string publicId);

        /// <summary>
        /// Xóa category
        /// </summary>
        /// <param name="categoryId">mã category</param>
        /// <returns>Trả về true hoặc false.</returns>
        bool DeleteCategory(int categoryId);

        /// <summary>
        /// Lấy thông tin category dựa vào Id.
        /// </summary>
        /// <param name="categoryId">Mã category</param>
        /// <returns>Thông tin chi tiết của category.</returns>
        CategoryDetailById GetCategoryById(int categoryId);

        /// <summary>
        /// Lấy danh sách category còn hoạt động.
        /// </summary>
        /// <returns>Danh sách category còn hoạt động.</returns>
        List<CategoryModel> GetCategoryActive();

        /// <summary>
        /// Lấy danh sách cateogogy theo số trang và kích cỡ trang.
        /// </summary>
        /// <param name="pageIndex">Số trang.</param>
        /// <param name="pageSize">Kích cỡ trang.</param>
        /// <returns>Danh sách categogy.</returns>
        List<CategoryModel> GetCategoryPaging(int pageIndex, int pageSize);
    }
}