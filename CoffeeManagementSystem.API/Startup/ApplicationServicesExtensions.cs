// <copyright file="ApplicationServicesExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.Startup
{
    using CoffeeManagementSystem.Services.AuthenticationServices;
    using CoffeeManagementSystem.Services.BranchServices;
    using CoffeeManagementSystem.Services.CartItemServices;
    using CoffeeManagementSystem.Services.CartServices;
    using CoffeeManagementSystem.Services.CategoryServices;
    using CoffeeManagementSystem.Services.ImportFileServices;
    using CoffeeManagementSystem.Services.OrderDetailServices;
    using CoffeeManagementSystem.Services.OrderServices;
    using CoffeeManagementSystem.Services.PositionServices;
    using CoffeeManagementSystem.Services.ProductServices;
    using CoffeeManagementSystem.Services.SlideServices;
    using CoffeeManagementSystem.Services.UserServices;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationServicesExtensions
    {
        public static void AddApplicationServicesExtensions(this IServiceCollection services)
        {
            services.AddTransient<IAuthenticationServices, AuthenticationServices>();
            services.AddTransient<IBranchServices, BranchServices>();
            services.AddTransient<ICartItemServices, CartItemServices>();
            services.AddTransient<ICartServices, CartServices>();
            services.AddTransient<ICategoryServices, CategoryServices>();
            services.AddTransient<IImportFileServices, ImportFileServices>();
            services.AddTransient<IOrderDetailServices, OrderDetailServices>();
            services.AddTransient<IOrderServices, OrderServices>();
            services.AddTransient<IPositionServices, PositionServices>();
            services.AddTransient<IProductServices, ProductServices>();
            services.AddTransient<ISlideServices, SlideServices>();
            services.AddTransient<IUserServices, UserServices>();
        }
    }
    
}
