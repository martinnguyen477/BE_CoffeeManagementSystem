// <copyright file="BaseTableWithId.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.BaseModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Base Id cho các bảng.
    /// </summary>
    public class BaseTableWithId : BaseTable
    {
        /// <summary>
        /// Gets or sets id cho các bảng.
        /// [Key] Khóa chính trong bảng.
        /// [DatabaseGenerated(DatabaseGeneratedOption.Identity)].
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
