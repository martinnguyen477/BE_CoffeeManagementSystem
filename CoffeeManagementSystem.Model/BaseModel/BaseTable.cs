// <copyright file="BaseTable.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.BaseModel
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;
    using CoffeeManagementSystem.Model.Enum;

    /// <summary>
    /// BaseTable.
    /// </summary>
    public class BaseTable
    {
        /// <summary>
        /// Gets or sets CreateDate.
        /// </summary>
        /// thuộc tính JsonIgnore dùng để làm lơ nó, có nghĩa nó vẫn tồn tại mà ko thấy nó trong chuỗi JSON.
        [JsonIgnore]
        [IgnoreDataMember]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets CreateBy.
        /// </summary>
        [JsonIgnore]
        [IgnoreDataMember]
        public int CreateBy { get; set; }

        /// <summary>
        /// Gets or sets UpdateDate.
        /// </summary>
        [JsonIgnore]
        [IgnoreDataMember]
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// Gets or sets UpdateBy.
        /// </summary>
        [JsonIgnore]
        [IgnoreDataMember]
        public int UpdateBy { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// Trạng thái của record trong database.
        /// </summary>
        public StatusSystem Status { get; set; }
    }
}
