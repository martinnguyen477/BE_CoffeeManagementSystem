// <copyright file="SlideMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.ProjectMapper
{
    using AutoMapper;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;

    public class SlideMapper : Profile
    {
        public SlideMapper()
        {
            CreateMap<SlideModel, SlideEntities>();
            CreateMap<SlideEntities, SlideModel>();

        }
    }
}
