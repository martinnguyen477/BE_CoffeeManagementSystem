// <copyright file="IBranchServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.BranchServices
{
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Services.BaseServices;
    using System.Collections.Generic;

    public interface IBranchServices : IBaseServices
    {
        List<BranchModel> GetListBranchs();

        BranchModel DetailBranchById(int branchId);

        BranchModel CreateBranch(BranchModel branchModel);

        BranchModel UpdateBranch(BranchModel branchModel);

        bool DeleteBranch(int branchId);
    }
}
