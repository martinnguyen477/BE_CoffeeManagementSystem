// <copyright file="CredentialUserEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.BaseModel;

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    /// <summary>
    /// Thực thể xác thực thông tin người dùng.
    /// </summary>
    public class CredentialUserEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets groupUserId.
        /// </summary>
        public int GroupUserId { get; set; }

        /// <summary>
        /// Gets or sets rolesId.
        /// </summary>
        public int RolesId { get; set; }

        /// <summary>
        /// Gets or sets rolesName.
        /// </summary>
        public string RolesName { get; set; }
    }
}
