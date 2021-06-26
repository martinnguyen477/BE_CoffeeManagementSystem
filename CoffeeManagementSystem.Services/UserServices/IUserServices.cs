// <copyright file="IUserServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.UserServices
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.BaseServices;

    public interface IUserServices : IBaseServices
    {
        bool RegisterAccount(UserModel customerModel);

        DetailForUser GetInfomationUser(int userId);

        bool CheckLoginAccount(string pToken, List<Claim> tokenList);

        bool CheckPassworkForUser(int userId, string oldPassword);

        bool ChangePassword(int userId, string newPassword);
    }
}
