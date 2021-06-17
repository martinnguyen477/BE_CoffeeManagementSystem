// <copyright file="ModelBuilderExtentions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.EntitiesModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoffeeManagementSystem.Data.ModelDataDefault
{
    /// <summary>
    /// Data seed.
    /// </summary>
    public static class ModelBuilderExtentions
    {
        public static void SeedDataDefault(this ModelBuilder modelBuilder)
        {
            DateTime dateTime = new DateTime(2020, 12, 23, 1, 18, 30, 999);

            modelBuilder.Entity<CategoryEntities>().HasData(
                new CategoryEntities { Id = 1, CategoryName = "Đá xay ", PublicIdImage = "mka6z4skydw4ooqhspt5", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime},
                new CategoryEntities { Id = 2, CategoryName = "Chocolate", PublicIdImage = "mka6z4skydw4ooqhspt5", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new CategoryEntities { Id = 3, CategoryName = "Matcha", PublicIdImage = "mka6z4skydw4ooqhspt5", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new CategoryEntities { Id = 4, CategoryName = "Trà Trái Cây", PublicIdImage = "mka6z4skydw4ooqhspt5", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new CategoryEntities { Id = 5, CategoryName = "Trà Sữa", PublicIdImage = "mka6z4skydw4ooqhspt5", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new CategoryEntities { Id = 7, CategoryName = "Cafe", PublicIdImage = "mka6z4skydw4ooqhspt5", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new CategoryEntities { Id = 8, CategoryName = "Sinh tố", PublicIdImage = "mka6z4skydw4ooqhspt5", UrlImageCategory = "https://res.cloudinary.com/nqcuong720/image/upload/v1623774698/mka6z4skydw4ooqhspt5.jpg", Status = Model.Enum.StatusSystem.Active, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime }
                );
        }
        
    }
}
