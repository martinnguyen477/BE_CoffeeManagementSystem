// <copyright file="BranchServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.BranchServices
{
    using System.Collections.Generic;
    using AutoMapper;
    using CoffeeManagementSystem.Data.EntityContext;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;
    using System.Linq;
    using CoffeeManagementSystem.Model.Response;

    public class BranchServices : BaseServices.BaseServices, IBranchServices
    {
        #region Contructors, Variables
        private readonly IMapper _mapper;

        public BranchServices(IMapper mapper)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
        }
        #endregion

        #region CreateBranch

        public BranchModel CreateBranch(BranchModel branchModel)
        {
            return _mapper.Map<BranchModel>(InsertReturnModel(_mapper.Map<BranchEntities>(branchModel)));
        }

        #endregion

        #region DeleteBranch
        public bool DeleteBranch(int branchId)
        {
            BranchEntities branchEntities = GetObject<BranchEntities>(br => br.Id == branchId);
            if(branchEntities.Id != 0 )
            {
                return Delete<BranchEntities>(branchEntities.Id);
            }
            return false;
        }
        #endregion

        #region DetailBranchById
        public BranchDetailResponse DetailBranchById(int branchId)
        {
            var resultBranch = (from br in Context.Set<BranchEntities>()
                                from us in Context.Set<UserEntities>().Where(us => us.Id == br.ManagerEmployeeId).DefaultIfEmpty()
                                from us2 in Context.Set<UserEntities>().Where(us2 => us2.Id == br.CreateBy).DefaultIfEmpty()
                                from us3 in Context.Set<UserEntities>().Where(us3 => us3.Id == br.UpdateBy).DefaultIfEmpty()
                                where br.Id == branchId
                                select new BranchDetailResponse
                                {
                                    Id = br.Id,
                                    BranchName = br.BranchName,
                                    Email = br.Email,
                                    Address = br.Address,
                                    NumberPhone = br.NumberPhone,
                                    ManagerEmployeeId = br.ManagerEmployeeId,
                                    ManagerEmployeeName = us.LastName + " " + us.FirstName,
                                    CreateBy = br.CreateBy,
                                    CreateByUser = us2.LastName + " " + us2.FirstName,
                                    UpdateBy = br.UpdateBy,
                                    UpdateByUser = us3.LastName + " " + us3.FirstName
                                }).FirstOrDefault();
            return resultBranch;
        }
        #endregion

        #region GetListBranchs
        public List<BranchModel> GetListBranchs(int pageSize, int pageNumber)
        {
            List<BranchModel> branchModels = _mapper.Map<List<BranchModel>>(GetList<BranchEntities>());
            if(pageSize != 0)
            {
                branchModels = branchModels.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            }
            return branchModels;
        }
        #endregion

        #region GetListBranchsActive
        public List<BranchModel> GetListBranchsActive(int pageSize, int pageNumber)
        {
            List<BranchModel> branchModels = _mapper.Map<List<BranchModel>>(GetList<BranchEntities>(br => br.Status == Model.Enum.StatusSystem.Active));
            if (pageSize != 0)
            {
                branchModels = branchModels.Skip(pageSize * (pageNumber - 1)).Skip(pageSize).ToList();
            }
            return branchModels;
        }
        #endregion

        #region Update Branch
        public BranchModel UpdateBranch(BranchModel branchModel)
        {
            return _mapper.Map<BranchModel>(UpdateReturnModel(_mapper.Map<BranchEntities>(branchModel)));
        }
        #endregion
    }
}
