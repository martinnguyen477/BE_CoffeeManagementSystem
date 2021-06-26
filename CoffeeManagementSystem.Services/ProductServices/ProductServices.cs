// <copyright file="ProductServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.ProductServices
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using CoffeeManagementSystem.Data.EntityContext;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Services.ImportFileServices;
    using Microsoft.AspNetCore.Http;

    public class ProductServices : BaseServices.BaseServices, IProductServices
    {
        #region Contructors, Variable
        private readonly IMapper _mapper;
        private readonly IImportFileServices _importFileServices;

        public ProductServices(IMapper mapper, IImportFileServices importFileServices)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
            _importFileServices = importFileServices;
        }

        #endregion

        #region Create Product 
        public ProductModel CreateProduct(ProductModel productModel, IFormFile avatarImage, List<IFormFile> ImagesDetail, string cloudName, string apiKey, string apiSerect)
        {
            //Upload Avatar Product To Cloud.
            var resultPhoto = _importFileServices.AddPhotoCloudAsync(avatarImage, cloudName, apiKey, apiSerect);
            productModel.PublicId = resultPhoto.Result.PublicId;
            productModel.ProductImage = resultPhoto.Result.UrlImage;

            //Insert product
            var resultObject = InsertReturnModel(_mapper.Map<ProductEntities>(productModel));

            //Upload List Image To Cloud.
            List<ImageProductModel> resultListPhoto = _importFileServices.AddListPhotoCloudAsync(ImagesDetail, cloudName, apiKey, apiSerect, resultObject.Id);
            
            //Insert các publicId UrlImage vào table Image Product.
            BulkInsertExcel(_mapper.Map<List<ImageProductEntities>>(resultListPhoto));

            return _mapper.Map<ProductModel>(resultObject);
        }
        #endregion

        #region Delete
        public bool DeleteProduct(int productId)
        {
            ProductEntities product = GetObject<ProductEntities>(pro => pro.Id == productId);
            if (product.Id != 0)
            {
                Delete<ProductEntities>(product);
                List<ImageProductEntities> listImageProduct = GetList<ImageProductEntities>(ima => ima.ProductId == productId);
                
                return BulkDeleteExcel(listImageProduct);
            }
            else
                return false;
        }
        #endregion

        #region Get List Products
        public List<ProductModel> GetListProducts()
        {
            var test = GetList<ProductEntities>();
            return _mapper.Map<List<ProductModel>>(GetList<ProductEntities>());
        }
        #endregion

        public List<ProductModel> GetListProductsByCategory(int categoryId, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetListProductsTrend(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        #region Get Product By Id
        public ProductModel GetProductById(int productId)
        {
            return _mapper.Map<ProductModel>(GetObject<ProductEntities>(pro => pro.Id == productId));
        }
        #endregion

        #region UpdateProduct
        public ProductModel UpdateProduct(ProductModel productModel, IFormFile avatarImage, List<IFormFile> ImagesDetail, string cloudName, string apiKey, string apiSerect)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
