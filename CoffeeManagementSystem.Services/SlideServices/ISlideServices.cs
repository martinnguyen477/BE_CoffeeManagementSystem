// <copyright file="ISlideServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.SlideServices
{
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.BaseServices;
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;

    public interface ISlideServices : IBaseServices
    {
        /// <summary>
        /// DS SLIDE
        /// </summary>
        /// <returns></returns>
        List<SlideModel> GetListSlides();

        /// <summary>
        /// Lấy danh sách slide.
        /// </summary>
        /// <returns></returns>
        List<SlideModel> GetListSlidesPaging(int pageSize, int pageNumber);

        /// <summary>
        /// Lấy danh sách slide hoạt động.
        /// </summary>
        /// <returns></returns>
        List<SlideModel> GetListSlidesActive(int pageSize, int pageNumber);

        /// <summary>
        /// Lấy thông tin chi tiết của slide;
        /// </summary>
        /// <param name="slideId">mã slide.</param>
        /// <returns></returns>
        SlideReponse DetailSlideById(int slideId);

        /// <summary>
        /// Tạo slide mới.
        /// </summary>
        /// <param name="slideModel">model slide từ client.</param>
        /// <param name="imageSlide">hình ảnh slide.</param>
        /// <returns></returns>
        SlideModel CreateSlide(SlideModel slideModel, IFormFile imageSlide, string cloudName, string apiKey, string apiSerect);

        /// <summary>
        /// Update slide.
        /// </summary>
        /// <param name="slideModel"></param>
        /// <param name="imageSlideUpdate"></param>
        /// <returns></returns>
        SlideModel UpdateSlide(SlideModel slideModel, IFormFile imageSlideUpdate, string cloudName, string apiKey, string apiSerect);

        /// <summary>
        /// Xóa slide
        /// </summary>
        /// <param name="slideId"></param>
        /// <returns></returns>
        bool DeleteSlide(int slideId);
    }
}
