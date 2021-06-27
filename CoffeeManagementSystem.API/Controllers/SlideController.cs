// <copyright file="SlideController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using CoffeeManagementSystem.API.Functions;
    using CoffeeManagementSystem.Model.BaseModel;
    using CoffeeManagementSystem.Model.Common;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Enum;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Request;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.SlideServices;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    public class SlideController : BaseController.BaseController
    {
        #region Contructors, Variable
        private readonly IMapper _mapper;
        private readonly ISlideServices _slideServices;
        private readonly InterCode _internalCode = new InterCode();
        private readonly InternalMessenger _internalMessenger = new InternalMessenger();

        public SlideController(IConfiguration configuration, ISlideServices slideServices, IMapper mapper)
        {
            _slideServices = slideServices;
            _mapper = mapper;
            HelperConstants = new HelperConstantsModel(configuration);
        }
        #endregion

        #region Get List Slide
        [HttpGet]
        public RepositoryModel<List<SlideModel>> GetListSlides(int pageSize, int pageNumber)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<List<SlideModel>> result = new RepositoryModel<List<SlideModel>>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new List<SlideModel>()
            };

            try
            {
                var listSlide = _slideServices.GetListSlides(pageSize, pageNumber);

                if (listSlide.Count > 0)
                {
                    result.Data = listSlide;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetSlideSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetSlideSuccess
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.GetDataError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetSlideNoExists,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.GetSlideNoExists
                    };
                }
            }
            catch (Exception ex)
            {
                result.RetCode = ERetCodeSystem.SystemError;
                result.PartnerCode = _internalCode.SystemError;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = ex.Message,
                    HttpCode = ERepositoryStatus.InternalError,
                    SystemMessage = ex.ToString()
                };
            }
            return result;
        }
        #endregion

        #region Get List Slide Active
        [HttpGet]
        public RepositoryModel<List<SlideModel>> GetListSlidesActive(int pageSize, int pageNumber)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<List<SlideModel>> result = new RepositoryModel<List<SlideModel>>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new List<SlideModel>()
            };

            try
            {
                var listSlide = _slideServices.GetListSlidesActive(pageSize, pageNumber);

                if (listSlide.Count > 0)
                {
                    result.Data = listSlide;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetSlideSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetSlideSuccess
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.GetDataError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetSlideNoExists,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.GetSlideNoExists
                    };
                }
            }
            catch (Exception ex)
            {
                result.RetCode = ERetCodeSystem.SystemError;
                result.PartnerCode = _internalCode.SystemError;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = ex.Message,
                    HttpCode = ERepositoryStatus.InternalError,
                    SystemMessage = ex.ToString()
                };
            }
            return result;
        }
        #endregion

        #region Get Slide Detail 
        [HttpGet]
        public RepositoryModel<SlideReponse> GetSlideDetail(int slideId)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<SlideReponse> result = new RepositoryModel<SlideReponse>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new SlideReponse()
            };

            try
            {
                if (slideId == 0)
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.BadRequest;
                    result.RetCode = ERetCodeSystem.BadRequest;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.BadRequest,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.BadRequest
                    };
                    return result;
                }

                var branchDetail = _slideServices.DetailSlideById(slideId);

                if (branchDetail != null)
                {
                    result.Data = branchDetail;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetSlideByIdSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetSlideByIdSuccess
                    };
                }
                else
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.GetDataError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetSlideByIdError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.GetSlideByIdError
                    };
                }
            }
            catch (Exception ex)
            {
                result.RetCode = ERetCodeSystem.SystemError;
                result.PartnerCode = _internalCode.SystemError;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = ex.Message,
                    HttpCode = ERepositoryStatus.InternalError,
                    SystemMessage = ex.ToString()
                };
            }
            return result;
        }
        #endregion

        #region Create Slide
        [HttpPost]
        public RepositoryModel<SlideModel> CreateSlide([FromBody] SlideModel slideModel, [FromForm] FormFile formFile)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<SlideModel> result = new RepositoryModel<SlideModel>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new SlideModel()
            };

            try
            {
                if (slideModel == null)
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.BadRequest;
                    result.RetCode = ERetCodeSystem.BadRequest;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.BadRequest,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.BadRequest
                    };
                    return result;
                }
                if (slideModel.SlideName == null)
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.BadRequest;
                    result.RetCode = ERetCodeSystem.BadRequest;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.CreateSlideNameIdNull,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.CreateSlideNameIdNull
                    };
                    return result;
                }
                slideModel.CreateBy = slideModel.UpdateBy = slideModel.Id;
                SlideModel resultCreate = _slideServices.CreateSlide(slideModel, formFile, CoffeeManagementSystemConfig.CloudName, CoffeeManagementSystemConfig.APIKey, CoffeeManagementSystemConfig.APISecret);
                if (resultCreate.Id != 0)
                {
                    result.Data = resultCreate;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.SuccessFull,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.SuccessFull
                    };
                }
                else
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.CreateSlideError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.CreateSlideError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.CreateSlideError
                    };
                }
            }
            catch (Exception ex)
            {
                result.PartnerCode = _internalCode.SystemError;
                result.RetCode = ERetCodeSystem.SystemError;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = _internalMessenger.SystemError + ex.Message,
                    HttpCode = ERepositoryStatus.Error,
                    SystemMessage = _internalMessenger.SystemError + ex.Message
                };
            }
            return result;
        }
        #endregion

        #region Update Slide
        [HttpPut]
        public RepositoryModel<SlideModel> UpdateSlide([FromBody] SlideModel slideModel, [FromForm] FormFile formFile)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<SlideModel> result = new RepositoryModel<SlideModel>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new SlideModel()
            };

            try
            {
                if (slideModel.Id == 0)
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.BadRequest;
                    result.RetCode = ERetCodeSystem.BadRequest;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.BadRequest,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.BadRequest
                    };
                    return result;
                }
                slideModel.UpdateBy = CookieViewModel.Id;
                SlideModel resultUpdate = _slideServices.UpdateSlide(slideModel, formFile, CoffeeManagementSystemConfig.CloudName, CoffeeManagementSystemConfig.APIKey, CoffeeManagementSystemConfig.APISecret);
                if (resultUpdate.Id != 0)
                {
                    result.Data = resultUpdate;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.UpdateSlideSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.UpdateSlideSuccess
                    };
                }
                else
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.UpdateSlideError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.UpdateSlideError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.UpdateSlideError
                    };
                }
            }
            catch (Exception ex)
            {
                result.PartnerCode = _internalCode.SystemError;
                result.RetCode = ERetCodeSystem.SystemError;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = _internalMessenger.SystemError + ex.Message,
                    HttpCode = ERepositoryStatus.Error,
                    SystemMessage = _internalMessenger.SystemError + ex.Message
                };
            }
            return result;
        }
        #endregion 

        #region Delete Slide
        [HttpDelete]
        public RepositoryModel<bool> DeleteSlide(int slideId)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<bool> result = new RepositoryModel<bool>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = true
            };

            try
            {
                if (slideId == 0)
                {
                    result.Data = false;
                    result.PartnerCode = _internalCode.BadRequest;
                    result.RetCode = ERetCodeSystem.BadRequest;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.BadRequest,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.BadRequest
                    };
                    return result;
                }
                var resultObject = _slideServices.GetObject<SlideEntities>(br => br.Id == slideId);
                if (resultObject != null)
                {
                    result.Data = _slideServices.DeleteSlide(slideId);
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.DeleteSlideSucces,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.DeleteSlideSucces
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.DeleteCategoryError;
                    result.Data = false;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.DeleteSlideError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.DeleteSlideError
                    };
                }
            }
            catch (Exception ex)
            {
                result.PartnerCode = _internalCode.SystemError;
                result.RetCode = ERetCodeSystem.SystemError;
                result.Data = false;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = _internalMessenger.SystemError + ex.Message,
                    HttpCode = ERepositoryStatus.Error,
                    SystemMessage = _internalMessenger.SystemError + ex.Message
                };
            }
            return result;
        }
        #endregion
    }
}
