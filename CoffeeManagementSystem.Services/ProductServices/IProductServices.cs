// <copyright file="IProductServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.ProductServices
{
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.BaseServices;
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;

    public interface IProductServices : IBaseServices
    {
        /// <summary>
        /// Lấy tất cả danh sách products.
        /// </summary>
        /// <returns>Danh sách sản phẩm.</returns>
        List<ProductModel> GetListProducts();

        /// <summary>
        /// Lấy thông tin của một products bởi id.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Thông tin của một product.</returns>
        GetProductRespone GetProductById(int productId);

        /// <summary>
        /// Lấy danh sách product bởi số trang và kích cỡ trang.
        /// </summary>
        /// <param name="pageIndex">số trang.</param>
        /// <param name="pageSize">kích cỡ của trang.</param>
        /// <returns>Danh sách sản phẩm theo số trang, kích cỡ trang.</returns>
        GetProductRespone GetProductPaging(int pageIndex, int pageSize);

        /// <summary>
        /// Lấy danh sách tất cả product.
        /// </summary>
        /// <returns>Danh sách product.</returns>
        GetProductRespone GetProductAll();

        /// <summary>
        /// Get List Products By Category Paging.
        /// </summary>
        /// <param name="categoryId">Mã loại.</param>
        /// <param name="pageIndex">Chỉ mục trang.</param>
        /// <param name="pageSize">Kích cỡ trang.</param>
        /// <returns>Danh sách sản phẩm dựa vào loại sản phẩm và số trang, kích cỡ trang</returns>
        List<GetProductRespone> GetListProductsByCategory(int categoryId, int pageIndex, int pageSize);

        /// <summary>
        /// Lấy danh sách sản phẩm dựa và loại sản phẩm.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>Lấy danh sách product dựa theo loại sản phẩm.</returns>
        List<GetProductRespone> GetListProductsByCategoryAll(int categoryId);

        /// <summary>
        /// Lấy danh sách sản phẩm mới nhất.
        /// </summary>
        /// <returns>Lấy danh sách sản phẩm mới nhất.</returns>
        List<GetProductRespone> GetListProductsNew();

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
        /// <returns>Thông tin sản phẩm vừa tạo.</returns>
        ProductModel CreateProduct(ProductModel productModel, IFormFile avatarImage, List<IFormFile> ImagesDetail, string cloudName, string apiKey, string apiSerect);

        /// <summary>
        /// Thay đổi thông tin sản phẩm.
        /// </summary>
        /// <param name="productModel">Thông tin sản phẩm từ Client.</param>
        /// <param name="Image">Hình ảnh đại diện.</param>
        /// <param name="ImagesDetail">Hình ảnh chi tiết.</param>
        /// <returns>Thông tin sản phẩm vừa update.</returns>
        ProductModel UpdateProduct(ProductModel productModel, IFormFile avatarImage, List<IFormFile> ImagesDetail, string cloudName, string apiKey, string apiSerect);

        /// <summary>
        /// Xóa sản phẩm.
        /// </summary>
        /// <param name="productId">Id sản phẩm.</param>
        /// <returns>Trả về true or false.</returns>
        bool DeleteProduct(int productId);
    }
}