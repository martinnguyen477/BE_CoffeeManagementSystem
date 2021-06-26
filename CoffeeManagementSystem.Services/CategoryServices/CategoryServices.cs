// <copyright file="CategoryServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.CategoryServices
{
    using System.Collections.Generic;
    using AutoMapper;
    using CoffeeManagementSystem.Data.EntityContext;
    using CoffeeManagementSystem.Model.Common;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.BaseServices;
    using CoffeeManagementSystem.Services.ImportFileServices;
    using Microsoft.AspNetCore.Http;
    using System.Linq;

    public class CategoryServices : BaseServices, ICategoryServices
    {
        #region Constructor, Varible

        private readonly IMapper _mapper;
        private readonly IImportFileServices _importFileServices;


        public CategoryServices(IMapper mapper, IImportFileServices importFileServices)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
            _importFileServices = importFileServices;
        }

        #endregion

        #region CreateCategory DONE  TEST
        public CategoryModel CreateCategory(IFormFile formFile, string cloudName, string apiKey, string apiSecret, CategoryModel categoryModel)
        {
            if(formFile != null)
            {
                var resultPhoto = _importFileServices.AddPhotoCloudAsync(formFile, cloudName, apiKey, apiSecret);
                categoryModel.UrlImageCategory = resultPhoto.Result.UrlImage;
                categoryModel.PublicIdImage = resultPhoto.Result.PublicId;
            }    
            else
            {
                categoryModel.UrlImageCategory = CoffeeManagementSystemConfig.DefaultUrlImageCategory;
            }    
            
            return _mapper.Map<CategoryModel>(InsertReturnModel(_mapper.Map<CategoryEntities>(categoryModel)));
        }
        #endregion

        #region DeleteCategory DONE
        public bool DeleteCategory(int categoryId)
        {
            CategoryEntities category = GetObject<CategoryEntities>(c => c.Id == categoryId);
            if (category.Id != 0)
            {
                return Delete<CategoryEntities>(categoryId);
            }
            else
                return false;
        }
        #endregion

        #region GetCategory DONE
        public List<CategoryModel> GetCategory()
        {
            return _mapper.Map<List<CategoryModel>>(GetList<CategoryEntities>());
        }

        #endregion

        #region GetCategoryById DONE
        public CategoryDetailById GetCategoryById(int categoryId)
        {
            var resultObject = (from user in Context.Set<UserEntities>()
                               from cate in Context.Set<CategoryEntities>().Where(cate => cate.CreateBy == user.Id).DefaultIfEmpty()
                               from user2 in Context.Set<UserEntities>().Where(user2 => user2.Id == cate.UpdateBy).DefaultIfEmpty()
                               where cate.Id == categoryId && user2.Id == cate.UpdateBy && user.Id == cate.CreateBy
                               select new CategoryDetailById
                               {
                                   Id = cate.Id,
                                   CategoryName = cate.CategoryName,
                                   UrlImageCategory = cate.UrlImageCategory,
                                   PublicIdImage = cate.PublicIdImage,
                                   CreateBy = cate.CreateBy,
                                   CreateByUser = user.FirstName + " " + user.LastName,
                                   UpdateBy = cate.UpdateBy,
                                   UpdateByUser = user2.FirstName + " " + user2.LastName,
                                   Status = cate.Status
                               }).FirstOrDefault();

            return resultObject;
        }
        #endregion

        #region UpdateCategory DONE
        public CategoryModel UpdateCategory(IFormFile formFile, string cloudName, string apiKey, string apiSecret, CategoryModel categoryModel)
        {
            CategoryEntities objectData = GetObject<CategoryEntities>(c => c.Id == categoryModel.Id);
            if(objectData != null)
            {
                if(formFile != null)
                {
                    _importFileServices.DeleteImageAsync(objectData.PublicIdImage, cloudName, apiKey, apiSecret);
                    var resultUploadImage = _importFileServices.AddPhotoCloudAsync(formFile, cloudName, apiKey, apiSecret);
                    categoryModel.PublicIdImage = resultUploadImage.Result.PublicId;
                    categoryModel.UrlImageCategory = resultUploadImage.Result.UrlImage;
                }    
            }    
            var resultData = _mapper.Map<CategoryModel>(UpdateReturnModel(_mapper.Map<CategoryEntities>(categoryModel)));
            
            return resultData;
            
        }
        #endregion

        #region Get List Category Active DONE
        public List<CategoryModel> GetCategoryActive()
        {
            return _mapper.Map<List<CategoryModel>>(GetList<CategoryEntities>(c => c.Status == Model.Enum.StatusSystem.Active));
        }
        #endregion
    }
}
