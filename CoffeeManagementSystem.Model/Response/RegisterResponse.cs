// <copyright file="RegisterResponse.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Response
{
    public class RegisterResponse
    {/// <summary>
     /// Gets or sets Id.
     /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets UserName.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets FullName.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets Phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Sex.
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// Gets or sets RoleId.
        /// </summary>
        public int GroupUser { get; set; }

        /// <summary>
        /// Gets or sets AvatarUrl.
        /// </summary>
        public string AvatarUrl { get; set; }
    }
}
