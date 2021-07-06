// <copyright file="OrderMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using AutoMapper;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;

namespace CoffeeManagementSystem.API.ProjectMapper
{
    public class OrderMapper : Profile
    {
        public OrderMapper()
        {
            CreateMap<OrderModel, OrderEntities>();
            CreateMap<OrderEntities, OrderModel>();
        }
    }
}
