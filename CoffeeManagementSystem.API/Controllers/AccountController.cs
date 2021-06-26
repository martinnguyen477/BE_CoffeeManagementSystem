// <copyright file="AccountController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading;
    using AutoMapper;
    using CoffeeManagementSystem.API.Functions;
    using CoffeeManagementSystem.Model.BaseModel;
    using CoffeeManagementSystem.Model.Common;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Enum;
    using CoffeeManagementSystem.Model.Request;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.UserServices;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    public class AccountController : BaseController.BaseController
    {
        #region Contructors, Variable

        private readonly IMapper _mapper;
        private readonly IUserServices _userServices;
        private readonly InterCode _interCode = new InterCode();
        private readonly InternalMessenger _internalMessage = new InternalMessenger();

        public AccountController(IConfiguration config ,IMapper mapper , IUserServices userServices)
        {
            _mapper = mapper;
            HelperConstants = new HelperConstantsModel(config);
            _userServices = userServices;
        }

        #endregion

        #region Login
        [AllowAnonymous]
        [HttpPost]
        public RepositoryModel<LoginResponse> Login ([FromBody] LoginModel loginModel)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<LoginResponse> result = new RepositoryModel<LoginResponse>
            {
                PartnerCode = _interCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new LoginResponse()
            };
            try
            {
                if(loginModel == null)
                {
                    result.PartnerCode = _interCode.SystemError;
                    result.RetCode = ERetCodeSystem.SystemError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessage.BadRequest,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessage.BadRequest,
                    };
                    return result;
                }

                UserEntities resultLogin = _userServices.GetObject<UserEntities>(user => user.UserName == loginModel.UserName && user.Password == loginModel.Password.Md5());

                if(resultLogin != null && resultLogin.Id != 0)
                {
                    var claims = new List<Claim>
                    {
                        new Claim("ID", Convert.ToString(resultLogin.Id)),
                        new Claim("UserName", Convert.ToString(resultLogin.UserName)),
                        new Claim("Email", Convert.ToString(resultLogin.Email)),
                    };

                    // Create Identity
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    // Sign-in
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

                    // Set current principal
                    Thread.CurrentPrincipal = claimsPrincipal;

                    var keyAppSettingsSecret = HelperConstants.GetAppSettingsSecret();
                    var expiresDate = Convert.ToInt16(HelperConstants.GetAppSettingsExpiresDate());
                    var tokenValue = LibrariesModel.GenerateToken(keyAppSettingsSecret, expiresDate, resultLogin.UserName);

                    if (tokenValue != null)
                    {
                        LoginResponse loginViewReturn = new LoginResponse()
                        {
                            Token = tokenValue,
                            UserName = resultLogin.UserName,
                        };

                        result.Data = loginViewReturn;
                        LibrariesModel.SetCookie();
                        result.Messenger = new MessengerError()
                        {
                            TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                            InternalMessage = _internalMessage.LoginSuccess,
                            HttpCode = ERepositoryStatus.Success,
                            SystemMessage = _internalMessage.LoginSuccess
                        };
                    }
                }    
            }  
            catch(Exception ex)
            {
                result.RetCode = ERetCodeSystem.SystemError;
                result.PartnerCode = _interCode.SystemError;
                result.Data = new LoginResponse();
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = _internalMessage.LoginError,
                    HttpCode = ERepositoryStatus.InternalError,
                    SystemMessage = ex.ToString()
                };
            }
            return result;
        }
        #endregion

        #region Logout

        [HttpGet]
        public IActionResult Logout()
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<string> result = new RepositoryModel<string>()
            {
                RetCode = ERetCodeSystem.Successfull,
                Data = string.Empty,
                PartnerCode = _interCode.LogoutSuccess
            };
            try
            {
                LibrariesModel.ClearCookie();
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch (Exception ex)
            {
                result.RetCode = ERetCodeSystem.SystemError;
                result.PartnerCode = _interCode.LogoutError;
                result.Data = string.Empty;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = _interCode.LogoutError,
                    HttpCode = ERepositoryStatus.InternalError,
                    SystemMessage = ex.ToString()
                };
            }

            return Ok(result);
        }

        #endregion Logout

        #region Register User
        [HttpPost]
        public RepositoryModel<RegisterResponse> RegisterUser([FromBody] RegisterModel registerModel)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            RepositoryModel<RegisterResponse> result = new RepositoryModel<RegisterResponse>
            {
                PartnerCode = _interCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new RegisterResponse()
            };

            try
            {
                if(registerModel == null)
                {
                    result.PartnerCode = _interCode.SystemError;
                    result.RetCode = ERetCodeSystem.SystemError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessage.BadRequest,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessage.BadRequest
                    };
                    return result;
                }
                //Check username có tồn tại trong hệ thống hay chưa.
                var resultUser = _userServices.GetObject<UserEntities>(user => user.UserName == registerModel.UserName);
                if(resultUser?.UserName == null || resultUser.UserName == string.Empty)
                {
                    registerModel.AvatarUrl = CoffeeManagementSystemConfig.UrlDefaultOfUser;
                    registerModel.Password = registerModel.Password.Md5();
                    resultUser = _mapper.Map<UserEntities>(registerModel);
                    resultUser.CreateBy = resultUser.UpdateBy = CookieViewModel.Id;

                    UserEntities registerResponse = _userServices.InsertReturnModel(resultUser);
                    RegisterResponse userResponse = _mapper.Map<RegisterResponse>(registerResponse);
                    if(userResponse.UserName != null)
                    {
                        result.Data = userResponse;
                        result.Messenger = new MessengerError()
                        {
                            TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                            InternalMessage = _internalMessage.SuccessFull,
                            HttpCode = ERepositoryStatus.CreateSuccess,
                            SystemMessage = _internalMessage.SuccessFull
                        };
                    }    
                } 
                else
                {
                    result.Data = null;
                    result.RetCode = ERetCodeSystem.ExitAccount;
                    result.PartnerCode = _interCode.ExitUser;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessage.InsertUserExist,
                        HttpCode = ERepositoryStatus.Confict,
                        SystemMessage = _internalMessage.InsertUserExist
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
                    InternalMessage = ex.Message,
                    HttpCode = ERepositoryStatus.InternalError,
                    SystemMessage = ex.ToString()
                };
            }
            return result;
        }

        #endregion

        #region Get Information of User

        [HttpGet]
        public RepositoryModel<DetailForUser> InformationOfUser ([FromForm] int userId)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            RepositoryModel<DetailForUser> result = new RepositoryModel<DetailForUser>
            {
                PartnerCode = _interCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new DetailForUser()
            };

            try
            {
                var resultUser = _userServices.GetInfomationUser(userId);
                if(resultUser != null)
                {
                    result.Data = resultUser;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessage.GetInfoUserSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessage.GetInfoUserSuccess
                    };
                }    
                else
                {
                    result.Data = null;
                    result.PartnerCode = _internalMessage.NoExitData;
                    result.RetCode = ERetCodeSystem.NoExitData;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessage.NoExitData,
                        HttpCode = ERepositoryStatus.NoContent,
                        SystemMessage = _internalMessage.NoExitData
                    };
                }    
            }
            catch(Exception ex)
            {
                result.PartnerCode = _internalMessage.SystemError;
                result.RetCode = ERetCodeSystem.SystemError;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = ex.Message,
                    HttpCode = ERepositoryStatus.NoContent,
                    SystemMessage = ex.Message
                };
            }
            return result;
        }
        #endregion

        #region Change Password
        //Deadline June 26 2021
        #endregion

        #region Update Status For User
        //Deadline June 26 2021
        #endregion

        #region Reset Password for User.
        //Dealine June 28 2021
        #endregion

        #region RecoverAccountUser

        #endregion
    }
}
