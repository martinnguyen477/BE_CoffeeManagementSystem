// <copyright file="ImportFileServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.ImportFileServices
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using AutoMapper;
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using CoffeeManagementSystem.Data.EntityContext;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;
    using Microsoft.AspNetCore.Http;

    public class ImportFileServices : BaseServices.BaseServices, IImportFileServices
    {
        #region Contructors, Vabiable, Dipose

        private Cloudinary _cloudinary;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFileServices"/> class.
        /// ImportFileServices.
        /// </summary>
        /// <param name="mapper">mapper.</param>
        public ImportFileServices(IMapper mapper)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
        }

        #endregion Contructors, Vabiable, Dipose

        #region Upload Image To Cloud

        /// <summary>
        /// Hàm upload image to cloud.
        /// </summary>
        /// <param name="formFile">File ảnh.</param>
        /// <param name="cloudName">tên cloud.</param>
        /// <param name="apiKey">api key</param>
        /// <param name="apiSecret">api secrect.</param>
        /// <returns>Model ResponseUploadImageCloud chứa 2 trường là publicId và urlimage.</returns>
        public async Task<ResponseUploadImageCloud> AddPhotoCloudAsync(IFormFile formFile, string cloudName, string apiKey, string apiSecret)
        {
            //Khởi tạo account connect đến cloud.
            var accountCloud = new Account(cloudName, apiKey, apiSecret);
            _cloudinary = new Cloudinary(accountCloud);

            //Khởi tạo kết quả sau khi upload image to cloud.
            var uploadResult = new ImageUploadResult();

            if (formFile.Length > 0)
            {
                using var streams = formFile.OpenReadStream();
                //Lấy thông số hình ảnh.
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(formFile.FileName, streams),
                    Transformation = new Transformation().Height(1280).Width(1920).Crop("fill").Gravity("face"),
                    //test thử
                    //PublicId = "myfolder/mysubfolder/Category"
                };

                //Up load lên cloud.
                uploadResult = await _cloudinary.UploadAsync(uploadParams);
            }
            
            //trả giá trị sau khi upload hình ảnh vào model.
            var resultData = new ResponseUploadImageCloud()
            {
                UrlImage = uploadResult.SecureUrl.AbsoluteUri,
                PublicId = uploadResult.PublicId
            };
            return resultData;
        }
        #endregion

        #region Delete Photo in Cloud.

        /// <summary>
        /// Phương thức xóa hình ảnh trên cloud. 
        /// </summary>
        /// <param name="publicId"></param>
        /// <param name="cloudName"></param>
        /// <param name="apiKey"></param>
        /// <param name="apiSecret"></param>
        /// <returns></returns>
        public async Task<DeletionResult> DeleteImageAsync(string publicId, string cloudName, string apiKey, string apiSecret)
        {
            //Khởi tạo account cloud.
            var accountCloud = new Account(cloudName, apiKey, apiSecret);
            _cloudinary = new Cloudinary(accountCloud);
            //Lấy tham số của hình .
            var deleteParams = new DeletionParams(publicId);
            //Xóa hình.
            var result = await _cloudinary.DestroyAsync(deleteParams);
            return result;
        }

        #endregion

        #region Add List Photo Cloud Async
        public List<ImageProductModel> AddListPhotoCloudAsync(List<IFormFile> listImage, string cloudName, string apiKey, string apiSecret,int productId)
        {
            var accountCloud = new Account(cloudName, apiKey, apiSecret);
            _cloudinary = new Cloudinary(accountCloud);

            var uploadResult = new ImageUploadResult();

            List<ImageProductModel> resultData = new List<ImageProductModel>();
            ImageProductModel resultRespone = new ImageProductModel();
            for (int indexResult = 0; indexResult < listImage.Count; indexResult ++)
            {
                if (listImage[indexResult].Length > 0)
                {
                    using var streams = listImage[indexResult].OpenReadStream();

                    var uploadParams = new ImageUploadParams
                    {
                        File = new FileDescription(listImage[indexResult].FileName, streams),
                        Transformation = new Transformation().Height(500).Width(500).Crop("fill").Gravity("face"),
                       
                    };
                    uploadResult = _cloudinary.Upload(uploadParams);
                }
                
                resultRespone.ProductId = productId;
                resultRespone.UrlImage = uploadResult.SecureUrl.AbsoluteUri;
                resultRespone.PublicId = uploadResult.PublicId;
                resultData.Add(resultRespone);
            }    
            return resultData;
        }
        #endregion
    }
}