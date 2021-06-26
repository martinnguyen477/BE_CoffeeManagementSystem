// <copyright file="BranchMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.ProjectMapper
{
    using AutoMapper;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;

    public class BranchMapper : Profile
    {
        public BranchMapper()
        {
            CreateMap<BranchModel, BranchEntities>();
            CreateMap<BranchEntities, BranchModel>();
        }
    }
}
