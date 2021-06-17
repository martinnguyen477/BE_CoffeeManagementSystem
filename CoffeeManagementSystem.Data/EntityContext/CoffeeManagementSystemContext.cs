// <copyright file="CoffeeManagementSystemContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Data.EntityContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using CoffeeManagementSystem.Data.ModelDataDefault;
    using CoffeeManagementSystem.Model.BaseModel;
    using CoffeeManagementSystem.Model.Common;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Enum;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Context.
    /// </summary>
    public class CoffeeManagementSystemContext : DbContext
    {
        /// <summary>
        /// OnConfiguring. Cấu hình chuỗi kết nối đến sql server.
        /// </summary>
        /// <param name="optionsBuilder">optionsBuilder.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CoffeeManagementSystemConfig.ConnectionString);
        }

        #region Table Database

        public virtual DbSet<AttributeEntities> Attribute { get; set; }

        public virtual DbSet<AttributeValueBillDetailEntities> AttributeValueBillDetail { get; set; }

        public virtual DbSet<AttributeValueEntities> AttributeValue { get; set; }

        public virtual DbSet<BranchEntities> Branch { get; set; }

        public virtual DbSet<CartEntities> Cart { get; set; }

        public virtual DbSet<CartItemEntities> CartItem { get; set; }

        public virtual DbSet<CategoryEntities> Category { get; set; }

        public virtual DbSet<CustomerEntities> Customer { get; set; }

        public virtual DbSet<EmployeeEntities> Employee { get; set; }

        public virtual DbSet<OrderDetailEntities> OrderDetail { get; set; }

        public virtual DbSet<PostitonEntities> Postiton { get; set; }

        public virtual DbSet<ProductEntities> Product { get; set; }

        public virtual DbSet<SlideEntities> Slide { get; set; }

        #endregion

        #region ModelBuilder

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttributeEntities>().ToTable("Attribute").HasKey(x => x.Id);
            modelBuilder.Entity<AttributeValueBillDetailEntities>().ToTable("AttributeValueBillDetail").HasKey(x => new { x.BillDetailId, x.AttributeValueId });
            modelBuilder.Entity<AttributeValueEntities>().ToTable("AttributeValue").HasKey(x => x.Id);
            modelBuilder.Entity<BranchEntities>().ToTable("Branch").HasKey(x => x.Id);
            modelBuilder.Entity<CartEntities>().ToTable("Cart").HasKey(x => x.Id);
            modelBuilder.Entity<CartItemEntities>().ToTable("CartItem").HasKey(x => new { x.CartId, x.ProductId });
            modelBuilder.Entity<CategoryEntities>().ToTable("Category").HasKey(x => x.Id);
            modelBuilder.Entity<CustomerEntities>().ToTable("Customer").HasKey(x => x.Id);
            modelBuilder.Entity<EmployeeEntities>().ToTable("Employee").HasKey(x => x.Id);
            modelBuilder.Entity<OrderDetailEntities>().ToTable("OrderDetail").HasKey(x => new { x.ProductId, x.OrderId });
            modelBuilder.Entity<OrderEntities>().ToTable("Order").HasKey(x => x.Id);
            modelBuilder.Entity<PostitonEntities>().ToTable("Postiton").HasKey(x => x.Id);
            modelBuilder.Entity<ProductEntities>().ToTable("Product").HasKey(x => x.Id);
            modelBuilder.Entity<SlideEntities>().ToTable("Slide").HasKey(x => x.Id);
            modelBuilder.SeedDataDefault();
        }

        #endregion

        #region Overide SaveChanges

        /// <summary>
        /// Hàm lấy ngày giờ khi save.
        /// </summary>
        /// <returns>save.</returns>
        public override int SaveChanges()
        {
            //lấy ngày giờ hiện tại.
            var dateNow = DateTime.Now;
            //?
            var errorList = new List<ValidationResult>();

            //Theo dõi thay đổi khi add hoặc modified.
            var entries = ChangeTracker.Entries().Where(p => p.State == EntityState.Added ||
             p.State == EntityState.Modified).ToList();

            foreach (var entry in entries)
            {
                var entity = entry.Entity;

                //Nếu entry state(trạng thái) là thêm
                if (entry.State == EntityState.Added)
                {
                    
                    if (entity is BaseTable itemBase)
                    {
                        itemBase.CreateDate = itemBase.UpdateDate = dateNow;
                        itemBase.Status = StatusSystem.Active;
                    }
                }
                //Ngược lại nếu mà entry state(trạng thái) là thay đổi. 
                else if (entry.State == EntityState.Modified)
                {
                    if (entity is BaseTable itemBase)
                    {
                        itemBase.UpdateDate = dateNow;
                    }
                }

                Validator.TryValidateObject(entity, new ValidationContext(entity), errorList);
            }

            if (errorList.Any())
            {
                throw new Exception(string.Join(", ", errorList.Select(p => p.ErrorMessage)).Trim());
            }

            return base.SaveChanges();
        }
        #endregion
    }
}
