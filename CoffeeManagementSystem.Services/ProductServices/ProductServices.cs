// <copyright file="ProductServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.ProductServices
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using AutoMapper;
    using CoffeeManagementSystem.Data.EntityContext;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;
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

        public ProductModel CreateProduct(ProductModel productModel, IFormFile avatarImage, List<IFormFile> ImagesDetail, List<SizeModel> sizes, string cloudName, string apiKey, string apiSerect)
        {
            throw new NotImplementedException();
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

        public List<GetProductRespone> GetListProductsByCategory(int categoryId, int pageIndex, int pageSize)
        {

            List<GetProductRespone> getProductRespone = new List<GetProductRespone>();
            return getProductRespone;
        }

        public List<GetProductRespone> GetListProductsByCategoryAll(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<GetProductRespone> GetListProductsNew()
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetListProductsTrend(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public GetProductRespone GetProductAll()
        {
            throw new NotImplementedException();
        }

        #region Get Product By Id
        public GetProductRespone GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public GetProductRespone GetProductPaging(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region UpdateProduct
        public ProductModel UpdateProduct(ProductModel productModel, IFormFile avatarImage, List<IFormFile> ImagesDetail, string cloudName, string apiKey, string apiSerect)
        {
            throw new NotImplementedException();
        }

        public ProductModel UpdateProduct(ProductModel productModel, IFormFile avatarImage, List<IFormFile> ImagesDetail, List<SizeModel> sizes, string cloudName, string apiKey, string apiSerect)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
