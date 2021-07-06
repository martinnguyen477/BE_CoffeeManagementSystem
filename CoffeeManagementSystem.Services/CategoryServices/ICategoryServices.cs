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
        /// Get DS Category
        /// </summary>
        /// <returns></returns>
        List<CategoryModel> GetCategory();

        /// <summary>
        /// Create Category
        /// </summary>
        /// <param name="formFile">file ảnh.</param>
        /// <param name="cloudName">tên cloud.</param>
        /// <param name="apiKey">api key.</param>
        /// <param name="apiSecret">api secrect.</param>
        /// <param name="categoryModel">Model hứng data từ client.</param>
        /// <returns></returns>
        CategoryModel CreateCategory(IFormFile formFile, string cloudName, string apiKey, string apiSecret, CategoryModel categoryModel);

        /// <summary>
        /// Update Category
        /// </summary>
        /// <param name="formFile">file ảnh.</param>
        /// <param name="cloudName">tên cloud.</param>
        /// <param name="apiKey">api key.</param>
        /// <param name="apiSecret">api secrect.</param>
        /// <param name="categoryModel">Model hứng data từ client.</param>
        /// <returns></returns>
        CategoryModel UpdateCategory(IFormFile formFile, string cloudName, string apiKey, string apiSecret, CategoryModel categoryModel, string publicId);

        /// <summary>
        /// Xóa category
        /// </summary>
        /// <param name="categoryId">mã category</param>
        /// <returns>trả về true hoặc false.</returns>
        bool DeleteCategory(int categoryId);

        /// <summary>
        /// Lấy thông tin category dựa vào Id.
        /// </summary>
        /// <param name="categoryId">Mã category</param>
        /// <returns></returns>
        CategoryDetailById GetCategoryById(int categoryId);

        /// <summary>
        /// Lấy danh sách category hoatdong.
        /// </summary>
        /// <returns></returns>
        List<CategoryModel> GetCategoryActive();

        List<CategoryModel> GetCategoryPaging(int pageIndex, int pageSize);
    }
}