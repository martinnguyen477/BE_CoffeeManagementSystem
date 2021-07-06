// <copyright file="AttributeMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using AutoMapper;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;

namespace CoffeeManagementSystem.API.ProjectMapper
{
    public class AttributeMapper : Profile
    {
        public AttributeMapper()
        {
            CreateMap<AttributeModel, AttributeEntities>();
            CreateMap<AttributeEntities, AttributeModel>();
        }
    }
}
