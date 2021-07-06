// <copyright file="CartMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using AutoMapper;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;

namespace CoffeeManagementSystem.API.ProjectMapper
{
    public class CartMapper : Profile
    {
        public CartMapper()
        {
            CreateMap<CartModel, CartEntities>();
            CreateMap<CartEntities, CartModel>();
        }
    }
}
