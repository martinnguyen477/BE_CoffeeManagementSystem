// <copyright file="IPositionServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.PositionServices
{
    using System.Collections.Generic;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Services.BaseServices;

    public interface IPositionServices : IBaseServices
    {
        List<PositionModel> GetListAllPosition();

        PositionModel DetailPositionById(int positionId);

        PositionModel CreatePosition(PositionModel posititonModel);

        PositionModel UpdatePosition(PositionModel posititonModel);

        bool DeletePosition(int positionId);
    }
}
