// <copyright file="IPositionServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.PositionServices
{
    using System.Collections.Generic;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.BaseServices;

    public interface IPositionServices : IBaseServices
    {
        /// <summary>
        /// Lấy danh sách vị trí trong hệ thống.
        /// </summary>
        /// <param name="pageSize">kích cỡ trang.</param>
        /// <param name="pageNumber">số trang.</param>
        /// <returns>Danh sách vị trí trong hệ thống bởi số trang, kích cỡ trang.</returns>
        List<PositionModel> GetListAllPosition(int pageSize, int pageNumber);

        /// <summary>
        /// Lấy thông tin chi tiết của vị trí.
        /// </summary>
        /// <param name="positionId"></param>
        /// <returns>Thông tin chi tiết của vị trí bởi id.</returns>
        PositionDetailRespone DetailPositionById(int positionId);

        /// <summary>
        /// Tạo thêm vị trí mới.
        /// </summary>
        /// <param name="posititonModel">Model Request.</param>
        /// <returns>Thông tin vị trí vừa tạo.</returns>
        PositionModel CreatePosition(PositionModel posititonModel);

        /// <summary>
        /// Update Position.
        /// </summary>
        /// <param name="posititonModel"></param>
        /// <returns>Thông tin position vừa tạo.</returns>
        PositionModel UpdatePosition(PositionModel posititonModel);

        /// <summary>
        /// Xóa vị trí.
        /// </summary>
        /// <param name="positionId"></param>
        /// <returns>Trả về true or false.</returns>
        bool DeletePosition(int positionId);
    }
}
