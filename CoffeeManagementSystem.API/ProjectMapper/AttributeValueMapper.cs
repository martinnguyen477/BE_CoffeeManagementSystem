// <copyright file="AttributeValueMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using AutoMapper;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;

namespace CoffeeManagementSystem.API.ProjectMapper
{
    public class AttributeValueMapper : Profile
    {
        public AttributeValueMapper()
        {
            CreateMap<AttributeValueModel, AttributeValueEntities>();
            CreateMap<AttributeValueEntities, AttributeValueModel>();
        }
    }
}
