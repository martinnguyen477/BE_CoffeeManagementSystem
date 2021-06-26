// <copyright file="RoleMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.ProjectMapper
{
    using AutoMapper;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;

    public class RoleMapper : Profile
    {
        public RoleMapper()
        {
            CreateMap<RoleEntities, RoleModel>();
            CreateMap<RoleModel,RoleEntities>();
        }
    }
}
