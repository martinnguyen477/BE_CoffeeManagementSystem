// <copyright file="SlideServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.SlideServices
{
    using System.Collections.Generic;
    using AutoMapper;
    using CoffeeManagementSystem.Data.EntityContext;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.ImportFileServices;
    using Microsoft.AspNetCore.Http;
    using System.Linq;
    using CoffeeManagementSystem.Model.Common;

    public class SlideServices : BaseServices.BaseServices, ISlideServices
    {
        #region Contructors, Variable
        private readonly IMapper _mapper;
        private readonly IImportFileServices _importFileServices;

        public SlideServices(IMapper mapper, IImportFileServices importFileServices)
        {
            _mapper = mapper;
            _importFileServices = importFileServices;
            Context = new CoffeeManagementSystemContext();
        }

        #endregion

        #region GetListSlides
        public List<SlideModel> GetListSlidesPaging(int pageSize, int pageNumber)
        {
            List<SlideModel> slideModels =  _mapper.Map<List<SlideModel>>(GetList<SlideEntities>());
            if(pageNumber != 0)
            {
                slideModels = slideModels.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            }
            return slideModels;
        }
        #endregion

        #region GetListSlidesActive
        public List<SlideModel> GetListSlidesActive(int pageSize, int pageNumber)
        {
            List<SlideModel> slideModels= _mapper.Map<List<SlideModel>>(GetList<SlideEntities>(sl => sl.Status == Model.Enum.StatusSystem.Active));
            if(pageNumber != 0 )
            {
                slideModels = slideModels.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            }
            return slideModels;
        }
        #endregion

        #region DetailSlideById
        public SlideReponse DetailSlideById(int slideId)
        {
            var resultDetail = (from sl in Context.Set<SlideEntities>()
                               from us in Context.Set<UserEntities>().Where(us => us.Id == sl.CreateBy).DefaultIfEmpty()
                               from us2 in Context.Set<UserEntities>().Where(us2 => us2.Id == sl.UpdateBy).DefaultIfEmpty()
                               where sl.Id == slideId && us.Id == sl.CreateBy && us2.Id == sl.UpdateBy
                               select new SlideReponse
                               {
                                   Id = sl.Id,
                                   SlideName = sl.SlideName,
                                   PublicId = sl.PublicId,
                                   UrlSlideImage = sl.UrlSlideImage,
                                   CreateBy = sl.CreateBy,
                                   CreateByUser = us.LastName + " " + us.FirstName,
                                   UpdateBy = sl.UpdateBy,
                                   UpdateByUser = us2.LastName + " " + us2.FirstName,
                                   Status = sl.Status,
                                   CreateDate = sl.CreateDate,
                                   UpdateDate = sl.UpdateDate
                               }).FirstOrDefault();
            return resultDetail;
        }
        #endregion

        #region Create Slide
        public SlideModel CreateSlide(SlideModel slideModel, IFormFile imageSlide, string cloudName, string apiKey, string apiSerect)
        {
            if(imageSlide != null)
            {
                var resultUploadCloud = _importFileServices.AddPhotoCloudAsync(imageSlide, cloudName, apiKey, apiSerect);
                slideModel.PublicId = resultUploadCloud.Result.PublicId;
                slideModel.UrlSlideImage = resultUploadCloud.Result.UrlImage;
            }
            else
            {
                slideModel.UrlSlideImage = CoffeeManagementSystemConfig.DefaultUrlImageSlide;
            }    

            return _mapper.Map<SlideModel>(InsertReturnModel(_mapper.Map<SlideEntities>(slideModel)));
        }
        #endregion

        #region Update Slide
        public SlideModel UpdateSlide(SlideModel slideModel, IFormFile imageSlideUpdate, string cloudName, string apiKey, string apiSerect)
        {
            if(imageSlideUpdate != null)
            {
                _importFileServices.DeleteImageAsync(slideModel.PublicId, cloudName, apiKey, apiSerect);
                var resultUpload = _importFileServices.AddPhotoCloudAsync(imageSlideUpdate, cloudName, apiKey, apiSerect);
                slideModel.PublicId = resultUpload.Result.PublicId;
                slideModel.UrlSlideImage = resultUpload.Result.UrlImage;
            }
            return _mapper.Map<SlideModel>(UpdateReturnModel<SlideEntities>(_mapper.Map<SlideEntities>(slideModel)));
        }
        #endregion

        #region DeleteSlide
        public bool DeleteSlide(int slideId)
        {
            SlideEntities slide = GetObject<SlideEntities>(sl => sl.Id == slideId);
            if(slide.Id != 0 )
            {
                return Delete<SlideEntities>(slide.Id);
            }
            return false;
        }
        #endregion

        #region GetListSlides

        public List<SlideModel> GetListSlides()
        {
           return _mapper.Map<List<SlideModel>>(GetList<SlideEntities>());
        }
        #endregion

    }
}
