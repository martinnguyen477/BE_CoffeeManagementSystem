// <copyright file="CoffeeManagementSystemConfig.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Common
{
    using System;

    /// <summary>
    /// Class này là class config. Khi cần các config thì gọi hàm này.
    /// </summary>
    public class CoffeeManagementSystemConfig
    {
        /// <summary>
        /// Gets or Sets AppName.
        /// </summary>
        public static string AppName { get; set; }

        /// <summary>
        /// Gets or Sets NumberFormat.
        /// </summary>
        public static string NumberFormat { get; set; }

        /// <summary>
        /// Gets or Sets DateFormat.
        /// </summary>
        public static string DateFormat { get; set; }

        /// <summary>
        /// Gets or Sets DateExpSqlFormat.
        /// </summary>
        public static string DateExpSqlFormat { get; set; }

        /// <summary>
        /// Gets or Sets MaxDateExp.
        /// </summary>
        public static DateTime MaxDateExp { get; set; }

        /// <summary>
        /// Gets or Sets SerialMmDdFormat.
        /// </summary>
        public static string SerialMmDdFormat { get; set; }

        /// <summary>
        /// Gets or Sets SerialMmFormat.
        /// </summary>
        public static string SerialMmFormat { get; set; }

        /// <summary>
        /// Gets or Sets TimeFormat.
        /// </summary>
        public static string TimeFormat { get; set; }

        /// <summary>
        /// Gets or Sets SpecialCharacters.
        /// </summary>
        public static string SpecialCharacters { get; set; }

        /// <summary>
        /// Gets or Sets DateTimeFormat.
        /// </summary>
        public static string DateTimeFormat { get; set; }

        /// <summary>
        /// Gets or Sets DateTimeSqlFormat.
        /// </summary>
        public static string DateTimeSqlFormat { get; set; }

        /// <summary>
        /// Gets or Sets EmailFormat.
        /// </summary>
        public static string EmailFormat { get; set; }

        /// <summary>
        /// Gets or Sets NumberPatternFormat.
        /// </summary>
        public static string NumberPatternFormat { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfNumber.
        /// </summary>
        public static string NumberOfNumber { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPassword.
        /// </summary>
        public static string DefaultPassword { get; set; }

        /// <summary>
        /// Gets or Sets NumberGeneratePassword.
        /// </summary>
        public static int NumberGeneratePassword { get; set; }

        /// <summary>
        /// Gets or Sets EmailTemplateUrl.
        /// </summary>
        public static string EmailTemplateUrl { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionString.
        /// </summary>
        public static string ConnectionString { get; set; }

        /// <summary>
        /// Gets or Sets EMail.
        /// </summary>
        public static string EMail { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName.
        /// </summary>
        public static string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Password.
        /// </summary>
        public static string Password { get; set; }

        /// <summary>
        /// Gets or Sets Host.
        /// </summary>
        public static string Host { get; set; }

        /// <summary>
        /// Gets or Sets Port.
        /// </summary>
        public static int Port { get; set; }

        /// Config Cloud
        /// <summary>
        /// Gets or Sets CloudName.
        /// </summary>
        public static string CloudName { get; set; }

        /// <summary>
        /// Gets or Sets APIKey.
        /// </summary>
        public static string APIKey { get; set; }

        /// <summary>
        /// Gets or Sets APISecret.
        /// </summary>
        public static string APISecret { get; set; }

        // Config Email

        /// <summary>
        /// Gets or Sets ResetPassUserTitle.
        /// </summary>
        public static string ResetPassUserTitle { get; set; }

        /// <summary>
        /// Gets or Sets UrlDefaultOfPrefect.
        /// </summary>
        public static string DefaultUrlImageCategory { get; set; }

        /// <summary>
        /// Gets or Sets UrlDefaultOfStudent.
        /// </summary>
        public static string DefaultUrlImageProduct { get; set; }

        /// <summary>
        /// Gets or sets defaultUrlImageSlide.
        /// </summary>
        public static string DefaultUrlImageSlide { get; set; }

        /// <summary>
        /// Gets or Sets UrlDefaultOfUser.
        /// </summary>
        public static string UrlDefaultOfUser { get; set; }

        /// <summary>
        /// Gets or Sets NotedImportExampoint.
        /// </summary>
        public static string NotedImportExampoint { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionStringPostgres.
        /// </summary>
        public static string ConnectionStringPostgres { get; set; }
    }
}
