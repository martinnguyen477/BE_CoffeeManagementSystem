// <copyright file="ICategoryServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.CategoryServices
{
    using System.Collections.Generic;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Services.BaseServices;
    using Microsoft.AspNetCore.Http;

    public interface ICategoryServices : IBaseServices
    {
        List<CategoryModel> GetCategory();

        CategoryModel CreateCategory(IFormFile formFile, string cloudName, string apiKey, string apiSecret, CategoryModel categoryModel);

        CategoryModel UpdateCategory(IFormFile formFile, string cloudName, string apiKey, string apiSecret, CategoryModel categoryModel);

        bool DeleteCategory(int categoryId);

        CategoryModel GetCategoryById(int categoryId);
    }
}