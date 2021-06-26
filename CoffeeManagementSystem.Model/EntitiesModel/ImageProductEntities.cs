// <copyright file="ImageProductEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    using CoffeeManagementSystem.Model.BaseModel;

    public class ImageProductEntities : BaseTableWithId
    {
        public int ProductId { get; set; }

        public string PublicId { get; set; }

        public string UrlImage { get; set; }
    }
}
