// <copyright file="ImageProductMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.ProjectMapper
{
    using AutoMapper;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;

    public class ImageProductMapper : Profile
    {
        public ImageProductMapper()
        {
            CreateMap<ImageProductModel, ImageProductEntities>();
            CreateMap<ImageProductEntities, ImageProductModel>();
        }
    }
}
