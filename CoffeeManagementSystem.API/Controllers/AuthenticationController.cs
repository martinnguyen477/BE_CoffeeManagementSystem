// <copyright file="AuthenticationController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using CoffeeManagementSystem.Model.BaseModel;
    using CoffeeManagementSystem.Model.Common;
    using CoffeeManagementSystem.Model.Enum;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Request;
    using CoffeeManagementSystem.Services.AuthenticationServices;
    using Microsoft.AspNetCore.Mvc;

    public class AuthenticationController : BaseController.BaseController
    {
        #region Contructors, Variable, Dispose
        private readonly IAuthenticationServices _authenticationServices;
        private readonly InterCode _interCode = new InterCode();
        private readonly InternalMessenger _internalMessenger = new InternalMessenger();

        public AuthenticationController(IAuthenticationServices authenticationServices)
        {
            _authenticationServices = authenticationServices;
        }
        #endregion

        #region Get List UserGroup
        [HttpGet]
        public RepositoryModel<List<GroupUserModel>> GetListGroupUser()
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<List<GroupUserModel>> result = new RepositoryModel<List<GroupUserModel>>
            {
                PartnerCode = _interCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new List<GroupUserModel>()
            };

            try
            {
                var resultDataServices = _authenticationServices.GetListGroupUser();
                if(resultDataServices.Count > 0 )
                {
                    result.Data = resultDataServices;
                    result.RowCount = resultDataServices.Count;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetDataSuccessful,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetDataSuccessful
                    };
                } 
                else
                {
                    result.PartnerCode = _interCode.NoExitData;
                    result.Data = null;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.NoExitData,
                        HttpCode = ERepositoryStatus.InternalError,
                        SystemMessage = _internalMessenger.NoExitData
                    };
                }  
            }
            catch(Exception ex)
            {
                result.RetCode = ERetCodeSystem.SystemError;
                result.PartnerCode = _interCode.SystemError;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = _internalMessenger.GetDataError,
                    HttpCode = ERepositoryStatus.InternalError,
                    SystemMessage = ex.ToString()
                };
            }
            return result;
        }
        #endregion

        #region Get List Role
        [HttpGet]
        public RepositoryModel<List<RoleModel>> GetListRolesOfUser()
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<List<RoleModel>> result = new RepositoryModel<List<RoleModel>>
            {
                PartnerCode = _interCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new List<RoleModel>()
            };

            try
            {
                var resultDataServices = _authenticationServices.GetListRoleUserOfGroupUser();
                if(resultDataServices.Count > 0 )
                {
                    result.Data = resultDataServices;
                    result.RowCount = resultDataServices.Count;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.SuccessFull,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetDataSuccessful,
                    };
                } 
                else
                {
                    result.PartnerCode = _internalMessenger.NoExitData;
                    result.Data = null;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.NoExitData,
                        HttpCode = ERepositoryStatus.NoContent,
                        SystemMessage = _internalMessenger.NoExitData,
                    };
                }
            }
            catch(Exception ex)
            {
                result.PartnerCode = _internalMessenger.SystemError;
                result.RetCode = ERetCodeSystem.SystemError;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = _internalMessenger.GetDataError,
                    HttpCode = ERepositoryStatus.InternalError,
                    SystemMessage = ex.ToString()
                };
            }
            return result;
        }
        #endregion

        #region Get List User And Group User TODO 

        #endregion

        #region Insert Role For GroupUser
        [HttpPost]
        public RepositoryModel<bool> InsertListRoleForGroupUser([FromBody] List<CredentialUserModel> credentialUserModels)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<bool> result = new RepositoryModel<bool>
            {
                PartnerCode = _interCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = true,
            };
            try
            {
                if(credentialUserModels == null)
                {
                    result.PartnerCode = _interCode.SystemError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.SystemError,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.InsertRoleForGroupUserUnSuccess
                    };
                    return result;
                }
                var resultDataInsertServices = _authenticationServices.InsertListRuleForGroupUser(credentialUserModels, CookieViewModel.Id);
                if(resultDataInsertServices)
                {
                    result.Data = true;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.InsertRoleForGroupUserSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.InsertRoleForGroupUserSuccess
                    };
                }    
                else
                {
                    result.PartnerCode = _internalMessenger.SystemError;
                    result.RetCode = ERetCodeSystem.SystemError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.NoExitData,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.NoExitData
                    };
                }    
            }
            catch(Exception ex)
            {
                result.PartnerCode = _internalMessenger.InsertRoleForGroupUserError;
                result.RetCode = ERetCodeSystem.SystemError;
                result.Data = false;
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

        #region Update Role For Group User TODO
        //Deadline June 20 2021
        #endregion

        #region Get List User Group And Roles For User TODO
        #endregion

        #region Insert GroupUser TODO
        #endregion

        #region Update Roles for user TODO
        #endregion


    }
}
