// <copyright file="UserServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.UserServices
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using AutoMapper;
    using CoffeeManagementSystem.Data.EntityContext;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.BaseServices;

    public class UserServices : BaseServices, IUserServices
    {
        private readonly IMapper _mapper;

        public UserServices(IMapper mapper)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
        }

        public bool ChangePassword(int userId, string newPassword)
        {
            throw new System.NotImplementedException();
        }

        public bool CheckLoginAccount(string pToken, List<Claim> tokenList)
        {
            throw new System.NotImplementedException();
        }

        public bool CheckPassworkForUser(int userId, string oldPassword)
        {
            throw new System.NotImplementedException();
        }

        public DetailForUser GetInfomationUser(int userId)
        {
            var result = (from guser in Context.Set<GroupUserEntities>()
                          from user in Context.Set<UserEntities>().Where(user => user.GroupUser == guser.Id).DefaultIfEmpty()
                          where user.Id == userId
                          select new DetailForUser
                          {
                              Id = user.Id,
                              FullName = user.LastName + " " + user.FirstName,
                              GroupUserId = user.GroupUser,
                              GroupUserName = guser.GroupUserName,
                              Sex = user.Sex,
                              Address = user.Address,
                              BirthDay = user.BirthDay,
                              NumberPhone = user.NumberPhone,
                              Email = user.Email,
                              UserName = user.UserName,
                              AvartarUrl = user.AvartarUrl
                          }).FirstOrDefault();
            return result;
        }

        public bool RegisterAccount(UserModel customerModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
