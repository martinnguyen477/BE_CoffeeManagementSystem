// <copyright file="CredentialUserModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Model
{
    using CoffeeManagementSystem.Model.BaseModel;

    public class CredentialUserModel : BaseTableWithId
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
