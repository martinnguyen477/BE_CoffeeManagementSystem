// <copyright file="PositionDetailRespone.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Response
{
    using CoffeeManagementSystem.Model.BaseModel;

    public class PositionDetailRespone : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên vị trí.
        /// </summary>
        public string PositionName { get; set; }

        /// <summary>
        /// Gets or sets tên nhân viên tạo.
        /// </summary>
        public string CreateByUser { get; set; }

        /// <summary>
        /// Gets or sets tên nhân viên chỉnh sửa lần cuối.
        /// </summary>
        public string UpdateByUser { get; set; }
    }
}
