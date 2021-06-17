// <copyright file="CategoryServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.CategoryServices
{
    using System.Collections.Generic;
    using AutoMapper;
    using CoffeeManagementSystem.Data.EntityContext;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Services.BaseServices;
    using CoffeeManagementSystem.Services.ImportFileServices;
    using Microsoft.AspNetCore.Http;

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

        #region CreateCategory DONE
        public CategoryModel CreateCategory(IFormFile formFile, string cloudName, string apiKey, string apiSecret, CategoryModel categoryModel)
        {
            var resultPhoto = _importFileServices.AddPhotoCloudAsync(formFile, cloudName, apiKey, apiSecret);
            categoryModel.UrlImageCategory = resultPhoto.Result.UrlImage;
            categoryModel.PublicIdImage = resultPhoto.Result.PublicId;
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

        #region GetCategory
        public List<CategoryModel> GetCategory()
        {
            return _mapper.Map<List<CategoryModel>>(GetList<CategoryEntities>());
        }
        #endregion

        #region GetCategoryById
        public CategoryModel GetCategoryById(int categoryId)
        {
            return _mapper.Map<CategoryModel>(GetObject<CategoryEntities>(c => c.Id == categoryId));
        }
        #endregion

        #region UpdateCategory DONE
        public CategoryModel UpdateCategory(IFormFile formFile, string cloudName, string apiKey, string apiSecret, CategoryModel categoryModel)
        {
            CategoryEntities objectData = GetObject<CategoryEntities>(c => c.Id == categoryModel.Id);

            if(objectData.PublicIdImage != null && formFile != null)
            {
                _importFileServices.DeleteImageAsync(objectData.PublicIdImage, cloudName, apiKey, apiSecret);
                var resultUploadImage = _importFileServices.AddPhotoCloudAsync(formFile, cloudName, apiKey, apiSecret);
                objectData.PublicIdImage = resultUploadImage.Result.PublicId;
                objectData.UrlImageCategory = resultUploadImage.Result.UrlImage;
            }  
            if(formFile == null)
            {
                objectData.PublicIdImage = objectData.PublicIdImage;
                objectData.UrlImageCategory = objectData.UrlImageCategory;
            }    
            if(categoryModel.CategoryName != null )
            {
                objectData.CategoryName = categoryModel.CategoryName;
            }    
            if(categoryModel.Status != 0)
            {
                objectData.Status = categoryModel.Status;
            }    
            var resultData = _mapper.Map<CategoryModel>(UpdateReturnModel(objectData));
            
            return resultData;
            
        }
        #endregion
    }
}
