// <copyright file="GroupUserMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.ProjectMapper
{
    using AutoMapper;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;

    public class GroupUserMapper : Profile
    {
        public GroupUserMapper()
        {
            CreateMap<GroupUserEntities, GroupUserModel>();
            CreateMap<GroupUserModel, GroupUserEntities>();
        }    
    }
}
