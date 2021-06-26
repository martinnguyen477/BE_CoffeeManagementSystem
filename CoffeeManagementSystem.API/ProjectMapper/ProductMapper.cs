// <copyright file="ProductMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.ProjectMapper
{
    using AutoMapper;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;

    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<ProductEntities, ProductModel>();
            CreateMap<ProductModel, ProductEntities>();
        }
    }
}
