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

        [HttpGet]
        public RepositoryModel<List<PositionModel>> GetListPosition([FromForm] int pageSize, int pageNumber)
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

    }
}
