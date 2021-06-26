// <copyright file="PositionMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.ProjectMapper
{
    using AutoMapper;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;

    public class PositionMapper : Profile
    {
        public PositionMapper()
        {
            CreateMap<PositionModel, PositionEntities>();
            CreateMap<PositionEntities, PositionModel>();
        }
    }
}
