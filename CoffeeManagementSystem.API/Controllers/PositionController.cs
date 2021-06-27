// <copyright file="PositionController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.Controllers
{
    using AutoMapper;
    using CoffeeManagementSystem.API.Functions;
    using CoffeeManagementSystem.Model.BaseModel;
    using CoffeeManagementSystem.Model.Common;
    using CoffeeManagementSystem.Model.Enum;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Request;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.PositionServices;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Collections.Generic;

    public class PositionController : BaseController.BaseController
    {
        #region Contructors, Variable
        private readonly IMapper _mapper;
        private readonly IPositionServices _positionServices;
        private readonly InterCode _internalCode = new InterCode();
        private readonly InternalMessenger _internalMessenger = new InternalMessenger();

        public PositionController(IConfiguration configuration,IPositionServices positionServices, IMapper mapper)
        {
            _positionServices = positionServices;
            _mapper = mapper;
            HelperConstants = new HelperConstantsModel(configuration);
        }
        #endregion

        #region Get List Positions DONE TEST
        [HttpGet]
        public RepositoryModel<List<PositionModel>> GetListPositions(int pageSize, int pageNumber)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<List<PositionModel>> result = new RepositoryModel<List<PositionModel>>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new List<PositionModel>()
            };

            try
            {
                var listPosition = _positionServices.GetListAllPosition(pageSize, pageNumber);

                if (listPosition.Count > 0)
                {
                    result.Data = listPosition;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetCategorySuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetCategorySuccess
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.GetDataError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetPositionNoExists,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.GetPositionNoExists
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

        #region Get Positions Detail DONE TEST
        [HttpGet]
        public RepositoryModel<PositionDetailRespone> GetPositionDetail(int positionId)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<PositionDetailRespone> result = new RepositoryModel<PositionDetailRespone>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new PositionDetailRespone()
            };

            try
            {
                if (positionId == 0)
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

                var positionDetail = _positionServices.DetailPositionById(positionId);

                if (positionDetail != null)
                {
                    result.Data = positionDetail;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetPositionByIdSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetPositionByIdSuccess
                    };
                }
                else
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.GetDataError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetPositionByIdError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.GetPositionByIdError
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

        #region Create Position DONE TEST
        [HttpPost]
        public RepositoryModel<PositionModel> CreatePosition([FromBody] PositionModel positionModel)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<PositionModel> result = new RepositoryModel<PositionModel>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new PositionModel()
            };
            
            try
            {
                if(positionModel == null)
                {
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
                if(positionModel.PositionName == null)
                {
                    result.PartnerCode = _internalCode.BadRequest;
                    result.RetCode = ERetCodeSystem.BadRequest;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.CreatePositionNameIdNull,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.CreatePositionNameIdNull
                    };
                    return result;
                }
                positionModel.CreateBy = positionModel.UpdateBy = CookieViewModel.Id;
                PositionModel resultCreate = _positionServices.CreatePosition(positionModel);
                if(resultCreate.Id != 0)
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
                    result.PartnerCode = _internalCode.CreatePositionError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.CreatePositionError,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.CreatePositionError
                    };
                }    
            }
            catch(Exception ex)
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

        #region Update Position DONE TEST
        [HttpPut]
        public RepositoryModel<PositionModel> UpdatePosition([FromBody] PositionModel positionModel)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<PositionModel> result = new RepositoryModel<PositionModel>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new PositionModel()
            };

            try
            {
                if (positionModel.Id == 0)
                {
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
                positionModel.UpdateBy = CookieViewModel.Id;
                PositionModel resultUpdate = _positionServices.UpdatePosition(positionModel);
                if (resultUpdate.Id != 0)
                {
                    result.Data = resultUpdate;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.UpdatePositionSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.UpdatePositionSuccess
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.UpdatePositionError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.UpdatePositionError,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.UpdatePositionError
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

        #region Delete Position DONE TEST
        [HttpDelete]
        public RepositoryModel<bool> DeletePosition(int positionId)
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
                if (positionId == 0)
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

                bool resultDelete = _positionServices.DeletePosition(positionId);
                if (resultDelete == true)
                {
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.DeletePositionSucces,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.DeletePositionSucces
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.DeleteCategoryError;
                    result.Data = false;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.DeletePositionError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.DeletePositionError
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
