// <copyright file="CategoryMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using AutoMapper;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;

namespace CoffeeManagementSystem.API.ProjectMapper
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<CategoryModel, CategoryEntities>();
            CreateMap<CategoryEntities, CategoryModel>();
        }
    }
}