// <copyright file="UserMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.ProjectMapper
{
    using AutoMapper;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Request;
    using CoffeeManagementSystem.Model.Response;

    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<UserEntities, UserModel>();
            CreateMap<UserModel,UserEntities>();
            CreateMap<UserEntities, RegisterModel>();
            CreateMap<RegisterModel,UserEntities>();
            CreateMap<RegisterResponse, UserEntities>();
            CreateMap<UserEntities, RegisterResponse>();

        }
    }
}
