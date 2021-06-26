// <copyright file="DetailForUser.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Response
{
    using CoffeeManagementSystem.Model.Model;
    using System;

    public class DetailForUser 
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets gioi tính.
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets birthDay.
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// Gets or sets numberPhone.
        /// </summary>
        public string NumberPhone { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets username.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets nhóm người dùng.
        /// </summary>
        public int GroupUserId { get; set; }

        /// <summary>
        /// Gets or sets tên Nhóm người dùng.
        /// </summary>
        public string GroupUserName { get; set; }

        /// <summary>
        /// Gets or sets hình đại diện.
        /// </summary>
        public string AvartarUrl { get; set; }


    }
}
