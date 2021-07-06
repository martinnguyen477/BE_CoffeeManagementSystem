// <copyright file="OrderDetailMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using AutoMapper;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;

namespace CoffeeManagementSystem.API.ProjectMapper
{
    public class OrderDetailMapper : Profile
    {
        public OrderDetailMapper()
        {
            CreateMap<OrderDetailModel, OrderDetailEntities>();
            CreateMap<OrderDetailEntities, OrderDetailModel>();
        }
    }
}
