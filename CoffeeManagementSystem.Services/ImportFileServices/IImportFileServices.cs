// <copyright file="IImportFileServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.ImportFileServices
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using CloudinaryDotNet.Actions;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.BaseServices;
    using Microsoft.AspNetCore.Http;

    public interface IImportFileServices : IBaseServices
    {
        /// <summary>
        /// Hàm thêm hình ảnh vào cloud.
        /// </summary>
        /// <param name="formFile">File cần up.</param>
        /// <param name="cloudName">Tên cloud.</param>
        /// <param name="apiKey">API key trên cloud.</param>
        /// <param name="apiSecret">API secret trên cloud.</param>
        /// <returns>Thông tin khi upload image to cloud.</returns>
        Task<ResponseUploadImageCloud> AddPhotoCloudAsync(IFormFile formFile, string cloudName, string apiKey, string apiSecret);
        
        /// <summary>
        /// Add list photo cloud.
        /// </summary>
        /// <param name="listImage"></param>
        /// <param name="cloudName"></param>
        /// <param name="apiKey"></param>
        /// <param name="apiSecret"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        List<ImageProductModel> AddListPhotoCloudAsync(List<IFormFile> listImage, string cloudName, string apiKey, string apiSecret, int productId);

        /// <summary>
        /// Hàm xóa hình ảnh trên cloud.
        /// </summary>
        /// <param name="publicId">public Id.</param>
        /// <param name="cloudName">tên cloud.</param>
        /// <param name="apiKey">Api key.</param>
        /// <param name="apiSecret">Api secret.</param>
        /// <returns></returns>
        Task<DeletionResult> DeleteImageAsync(string publicId, string cloudName, string apiKey, string apiSecret);
    }
}