// <copyright file="ApplicationServicesExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.Startup
{
    using CoffeeManagementSystem.Services.CategoryServices;
    using CoffeeManagementSystem.Services.CustomerServices;
    using CoffeeManagementSystem.Services.ImportFileServices;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationServicesExtensions
    {
        public static void AddApplicationServicesExtensions(this IServiceCollection services)
        {
            services.AddTransient<ICategoryServices, CategoryServices>();
            services.AddTransient<ICustomerServices, CustomerServices>();
            services.AddTransient<IImportFileServices, ImportFileServices>();
        }
    }
    
}
