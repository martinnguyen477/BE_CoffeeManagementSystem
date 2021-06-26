// <copyright file="ImageProductModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.Model
{
    using CoffeeManagementSystem.Model.BaseModel;

    public class ImageProductModel : BaseTableWithId
    {
        public int ProductId  { get; set; }

        public string PublicId { get; set; }

        public string UrlImage { get; set; }
    }
}
