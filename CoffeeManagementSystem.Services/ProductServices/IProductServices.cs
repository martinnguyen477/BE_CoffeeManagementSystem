// <copyright file="IProductServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.ProductServices
{
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Services.BaseServices;
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;

    public interface IProductServices : IBaseServices
    {
        /// <summary>
        /// Lấy tất cả products.
        /// </summary>
        /// <returns></returns>
        List<ProductModel> GetListProducts();

        /// <summary>
        /// Lấy thông tin products bởi id.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Thông tin product.</returns>
        ProductModel GetProductById(int productId);

        /// <summary>
        /// GetListProductsByCategory.
        /// </summary>
        /// <param name="categoryId">Mã loại.</param>
        /// <param name="pageIndex">Chỉ mục trang.</param>
        /// <param name="pageSize">Kích cỡ trang.</param>
        /// <returns></returns>
        List<ProductModel> GetListProductsByCategory(int categoryId, int pageIndex, int pageSize);

        /// <summary>
        /// Lấy danh sách sản phẩm thịnh hành.
        /// </summary>
        /// <param name="pageIndex">Chỉ mục trang.</param>
        /// <param name="pageSize">Kích cỡ trang.</param>
        /// <returns>Danh sách sản phẩm thịnh hành.</returns>
        List<ProductModel> GetListProductsTrend(int pageIndex, int pageSize);

        /// <summary>
        /// Create Product.
        /// </summary>
        /// <param name="productModel">Lấy thông tin từ client.</param>
        /// <param name="Image">Hình đại diện.</param>
        /// <param name="ImagesDetail">Danh sách hình ảnh của sản phẩm.</param>
        /// <returns></returns>
        ProductModel CreateProduct(ProductModel productModel, IFormFile avatarImage, List<IFormFile> ImagesDetail, string cloudName, string apiKey, string apiSerect);

        /// <summary>
        /// Thay đổi thông tin sản phẩm.
        /// </summary>
        /// <param name="productModel">Thông tin sản phẩm từ Client.</param>
        /// <param name="Image">Hình ảnh đại diện.</param>
        /// <param name="ImagesDetail">Hình ảnh chi tiết.</param>
        /// <returns></returns>
        ProductModel UpdateProduct(ProductModel productModel, IFormFile avatarImage, List<IFormFile> ImagesDetail, string cloudName, string apiKey, string apiSerect);

        /// <summary>
        /// Xóa sản phẩm.
        /// </summary>
        /// <param name="productId">Id sản phẩm.</param>
        /// <returns></returns>
        bool DeleteProduct(int productId);
    }
}