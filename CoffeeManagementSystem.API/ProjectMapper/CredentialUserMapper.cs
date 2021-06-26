// <copyright file="CredentialUserMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.ProjectMapper
{
    using AutoMapper;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;

    public class CredentialUserMapper : Profile
    {
        public CredentialUserMapper()
        {
            CreateMap<CredentialUserEntities, CredentialUserModel>();
            CreateMap<CredentialUserModel,CredentialUserEntities>();
        }
    }
}
