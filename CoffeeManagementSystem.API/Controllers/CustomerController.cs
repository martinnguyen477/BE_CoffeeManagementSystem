// <copyright file="CustomerController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading;
    using AutoMapper;
    using CoffeeManagementSystem.API.Functions;
    using CoffeeManagementSystem.Model.BaseModel;
    using CoffeeManagementSystem.Model.Common;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Enum;
    using CoffeeManagementSystem.Model.Exception;
    using CoffeeManagementSystem.Model.Request;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.CustomerServices;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    public class CustomerController : BaseController.BaseController
    {
        #region Constructors, Variables, Dispose

        private readonly IMapper _mapper;
        private readonly ICustomerServices _customerServices;
        private readonly InternalMessenger _internalMessenger = new InternalMessenger();
        private readonly InterCode _internalCode = new InterCode();

        public CustomerController(IConfiguration config, IMapper mapper, ICustomerServices customerServices)
        {
            _mapper = mapper;
            HelperConstants = new HelperConstantsModel(config);
            _customerServices = customerServices ?? throw new CoffeeManagementSystemException(nameof(customerServices));
        }

        #endregion Constructors, Variables, Dispose

        #region CheckLogin

        /// <summary>
        /// CheckLogin.
        /// </summary>
        /// <param name="pToken">pToken.</param>
        /// <returns>Return action login yet or not yes.</returns>
        [HttpGet]
        public IActionResult CheckLogin(string pToken)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<bool> result = new RepositoryModel<bool>()
            {
                PartnerCode = _internalCode.CheckLoginSuccess,
                RetCode = ERetCodeSystem.Successfull,
                Data = true
            };

            try
            {
                var identity = CookieViewModel.Id;
                if (identity == 0)
                {
                    result.RetCode = ERetCodeSystem.ErrorCookie;
                    result.PartnerCode = _internalCode.ErrorCookie;
                    result.Data = false;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.ErrorCookies,
                        HttpCode = ERepositoryStatus.NoCookie,
                        SystemMessage = _internalMessenger.ErrorCookies
                    };
                }
                else
                {
                    var tokenList = HttpContext.User?.Claims?.ToList();
                    var checkLogin = _customerServices.CheckLoginAccount(pToken, tokenList);
                    if (checkLogin)
                    {
                        result.Messenger = new MessengerError()
                        {
                            TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                            InternalMessage = _internalMessenger.CheckLoginSuccess,
                            HttpCode = ERepositoryStatus.Success,
                            SystemMessage = _internalMessenger.CheckLoginSuccess
                        };
                    }
                    else
                    {
                        result.PartnerCode = _internalMessenger.NotExitCookies;
                        result.Data = false;
                        result.Messenger = new MessengerError()
                        {
                            TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                            InternalMessage = _internalMessenger.NotExitCookies,
                            HttpCode = ERepositoryStatus.Success,
                            SystemMessage = _internalMessenger.NotExitCookies
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                result.RetCode = ERetCodeSystem.SystemError;
                result.PartnerCode = _internalCode.SystemError;
                result.Data = false;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = _internalMessenger.ErrorCookies,
                    HttpCode = ERepositoryStatus.InternalError,
                    SystemMessage = ex.ToString()
                };
            }

            return Ok(result);
        }

        #endregion CheckLogin

        #region CheckPasswordForUser

        [HttpGet]
        public RepositoryModel<bool> CheckPasswordForUser(string oldPassword)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<bool> result = new RepositoryModel<bool>()
            {
                RetCode = ERetCodeSystem.Successfull,
                Data = true,
                PartnerCode = _internalCode.ChangePassSuccess
            };

            try
            {
                var user = _customerServices.CheckPassworkForUser(CookieViewModel.Id, oldPassword);
                if (user)
                {
                    result.Data = true;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.CheckPasswordSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.CheckPasswordSuccess
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.SameOldPassword;
                    result.Data = false;
                    result.RetCode = ERetCodeSystem.PasswordNotSame;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.CheckPasswordError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.CheckPasswordError
                    };
                }
            }
            catch (Exception ex)
            {
                result.RetCode = ERetCodeSystem.SystemError;
                result.PartnerCode = _internalCode.ChangePassError;
                result.Data = false;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = _internalCode.ChangePassError,
                    HttpCode = ERepositoryStatus.InternalError,
                    SystemMessage = ex.ToString()
                };
            }

            return result;
        }

        #endregion CheckPasswordForUser

        #region Login

        [AllowAnonymous]
        [HttpPost]
        public RepositoryModel<LoginResponse> Login([FromBody] LoginModel login)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<LoginResponse> result = new RepositoryModel<LoginResponse>()
            {
                PartnerCode = _internalCode.LoginSuccess,
                RetCode = ERetCodeSystem.Successfull,
                Data = new LoginResponse()
            };

            try
            {
                if (login == null)
                {
                    result.PartnerCode = _internalCode.SystemError;
                    result.RetCode = ERetCodeSystem.SystemError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.BadRequest,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.BadRequest
                    };

                    return result;
                }

                CustomerEntities dataLogin = _customerServices.GetObject<CustomerEntities>(lo => lo.UserName == login.UserName && lo.Password == login.Password.Md5());

                // var dataLogin = ChildrenServices.GetObject<User>();
                if (dataLogin != null && dataLogin.Id != 0)
                {
                    var claims = new List<Claim>
                    {
                        new Claim("ID", Convert.ToString(dataLogin.Id)),
                        new Claim("UserName", Convert.ToString(dataLogin.UserName)),
                        new Claim("Email", Convert.ToString(dataLogin.Email)),
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
                    var tokenValue = LibrariesModel.GenerateToken(keyAppSettingsSecret, expiresDate, dataLogin.UserName);

                    if (tokenValue != null)
                    {
                        LoginResponse loginViewReturn = new LoginResponse()
                        {
                            Token = tokenValue,
                            UserName = dataLogin.UserName,
                        };

                        result.Data = loginViewReturn;
                        LibrariesModel.SetCookie();
                        result.Messenger = new MessengerError()
                        {
                            TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                            InternalMessage = _internalMessenger.LoginSuccess,
                            HttpCode = ERepositoryStatus.Success,
                            SystemMessage = _internalMessenger.LoginSuccess
                        };
                    }
                }
                else
                {
                    result.PartnerCode = _internalCode.LoginError;
                    result.RetCode = ERetCodeSystem.LoginError;
                    result.Data = new LoginResponse();
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.LoginError,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.LoginError
                    };
                }
            }
            catch (Exception ex)
            {
                result.RetCode = ERetCodeSystem.SystemError;
                result.PartnerCode = _internalCode.SystemError;
                result.Data = new LoginResponse();
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = _internalMessenger.LoginError,
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
                PartnerCode = _internalCode.LogoutSuccess
            };
            try
            {
                LibrariesModel.ClearCookie();
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch (Exception ex)
            {
                result.RetCode = ERetCodeSystem.SystemError;
                result.PartnerCode = _internalCode.LogoutError;
                result.Data = string.Empty;
                result.Messenger = new MessengerError()
                {
                    TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                    InternalMessage = _internalCode.LogoutError,
                    HttpCode = ERepositoryStatus.InternalError,
                    SystemMessage = ex.ToString()
                };
            }

            return Ok(result);
        }

        #endregion Logout
    }
}

