// <copyright file="IAuthenticationServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.AuthenticationServices
{
    using System.Collections.Generic;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Services.BaseServices;

    public interface IAuthenticationServices :IBaseServices
    {
        /// <summary>
        /// Lấy danh sách group user của hệ thống.
        /// </summary>
        /// <returns></returns>
        List<GroupUserModel> GetListGroupUser();

        /// <summary>
        /// Lấy danh sách các role của người dùng.
        /// </summary>
        /// <returns></returns>
        List<RoleModel> GetListRoleUserOfGroupUser();

        /// <summary>
        /// Insert list role vào trong 
        /// </summary>
        /// <param name="credentialUserModel"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool InsertListRuleForGroupUser(List<CredentialUserModel> credentialUserModel, int userId);

        /// <summary>
        /// Thay đổi nhóm người dùng cho người dùng.
        /// </summary>
        /// <param name="userId">mã người dùng.</param>
        /// <param name="groupUserId">mã nhóm người dùng.</param>
        /// <returns></returns>
        bool UpdateGroupUserForUser(int userId, int groupUserId);
    }
}