// <copyright file="RegisterModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Request
{
    using System;
    using System.Text.Json.Serialization;

    public class RegisterModel
    {
        /// <summary>
        /// Gets or sets UserName.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets Birthday.
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Gets or sets FullName.
        /// </summary>
        /// <returns>Return FullName.</returns>
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        /// <summary>
        /// Gets or sets Phone.
        /// </summary>
        public string NumberPhone { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets _Sex.
        /// </summary>
        public string Sex { get; set; }

        public int GroupUser { get; set; }

        /// <summary>
        /// Gets or sets AvatarUrl.
        /// </summary>
        public string AvatarUrl { get; set; }
    }
}
