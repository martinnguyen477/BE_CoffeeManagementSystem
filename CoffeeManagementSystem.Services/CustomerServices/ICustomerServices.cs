// <copyright file="ICustomerServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.CustomerServices
{
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Services.BaseServices;
    using System.Collections.Generic;
    using System.Security.Claims;

    public interface ICustomerServices : IBaseServices
    {
        bool RegisterAccount(CustomerModel customerModel);

        CustomerModel GetInfomationUser(int userId);

        bool CheckLoginAccount(string pToken, List<Claim> tokenList);

        bool CheckPassworkForUser(int userId, string oldPassword);

        bool ChangePassword(int userId, string newPassword);
    }
}