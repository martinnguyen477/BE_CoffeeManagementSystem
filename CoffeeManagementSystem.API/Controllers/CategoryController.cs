// <copyright file="CategoryController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using CoffeeManagementSystem.API.Functions;
    using CoffeeManagementSystem.Model.BaseModel;
    using CoffeeManagementSystem.Model.Common;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Enum;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Request;
    using CoffeeManagementSystem.Model.Response;
    using CoffeeManagementSystem.Services.CategoryServices;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    public class CategoryController : BaseController.BaseController
    {
        #region Contructors, Variable, Dispose

        private readonly InterCode _internalCode = new InterCode();
        private readonly InternalMessenger _internalMessenger = new InternalMessenger();
        private readonly ICategoryServices _categoryServices;

        public CategoryController(IConfiguration config ,ICategoryServices categoryServices)
        {
            HelperConstants = new HelperConstantsModel(config);
            _categoryServices = categoryServices;
        }

        #endregion

        #region Get Category DONE TEST
        [HttpGet]
        public RepositoryModel<List<CategoryModel>> GetCategory()
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<List<CategoryModel>> result = new RepositoryModel<List<CategoryModel>>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new List<CategoryModel>()
            };

            try
            {
                var listCategory = _categoryServices.GetCategory();
                
                if (listCategory.Count > 0)
                {
                    result.Data = listCategory;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetPositionSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetPositionSuccess
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

        #region Get Category Detail (Được tạo bởi, Update bởi mapping với bảng user) DONE TEST TEST 2
        [HttpGet]
        public RepositoryModel<CategoryDetailById> GetDetailCategoryById([FromForm] int categoryId)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<CategoryDetailById> result = new RepositoryModel<CategoryDetailById>
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new CategoryDetailById()
            };

            try
            {
                if (categoryId == 0)
                {
                    result.PartnerCode = _internalCode.BadRequest;
                    result.RetCode = ERetCodeSystem.BadRequest;
                    result.Data = null;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.BadRequest,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.BadRequest
                    };
                    return result;
                }

                var resultObject = _categoryServices.GetCategoryById(categoryId);
                if (resultObject != null)
                {
                    result.Data = resultObject;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetCategoryByIdSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetCategoryByIdSuccess
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.NoExitData;
                    result.RetCode = ERetCodeSystem.NoExitData;
                    result.Data = null;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.NoExitData,
                        HttpCode = ERepositoryStatus.NoContent,
                        SystemMessage = _internalMessenger.NoExitData
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
                    HttpCode = ERepositoryStatus.NoContent,
                    SystemMessage = _internalMessenger.SystemError
                };
            }
            return result;
        }
        #endregion

        #region Get Category By Status Active (Hoạt động) DONE TEST TEST2
        [HttpGet]
        public RepositoryModel<List<CategoryModel>> GetCategoryActive()
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;

            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<List<CategoryModel>> result = new RepositoryModel<List<CategoryModel>>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new List<CategoryModel>()
            };

            try
            {
                var listCategory = _categoryServices.GetCategoryActive();

                if (listCategory.Count > 0)
                {
                    result.Data = listCategory;
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
                    result.PartnerCode = _internalCode.CreateStudentError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetCategoryNoExists,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.GetCategoryNoExists
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
        #endregion DONE TEST 

        #region Insert Category DONE TEST TEST2

        [HttpPost]
        public RepositoryModel<InsertResponse> InsertCategory([FromForm] CategoryModel categoryModel, IFormFile fileImage)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<InsertResponse> result = new RepositoryModel<InsertResponse>
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new InsertResponse()
            };

            try
            {
                if(categoryModel == null)
                {
                    //Nếu categoryModel == null thì báo lỗi.
                    result.PartnerCode = _internalCode.BadRequest;
                    result.RetCode = ERetCodeSystem.BadRequest;
                    //trả ra message lỗi.
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.BadRequest,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.BadRequest
                    };
                    return result;
                }

                if(categoryModel.CategoryName == null)
                {
                    //Nếu categoryModel == null thì báo lỗi.
                    result.PartnerCode = _internalCode.BadRequest;
                    result.RetCode = ERetCodeSystem.BadRequest;
                    //trả ra message lỗi.
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.CreateCategoryNameIsNull,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.CreateCategoryNameIsNull
                    };
                    return result;
                }    
                categoryModel.UpdateBy = categoryModel.CreateBy = CookieViewModel.Id;
                var insertCategory = _categoryServices.CreateCategory(fileImage, CoffeeManagementSystemConfig.CloudName,CoffeeManagementSystemConfig.APIKey, CoffeeManagementSystemConfig.APISecret,categoryModel);
                if(insertCategory.Id != 0 )
                {
                    result.Data.ReturnId = "" + PrefixResponse.Category + "_" + insertCategory.Id;
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
                    result.PartnerCode = _internalCode.CreateStudentError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.CreateCategoryError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.CreateCategoryError
                    };
                }    
            }
            catch(Exception ex)
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

        #region Update Category DONE TEST TEST2

        [HttpPut]
        public RepositoryModel<InsertResponse> UpdateCategory([FromForm] CategoryModel categoryModel, IFormFile fileImage)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            //Cái này ko biết
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<InsertResponse> result = new RepositoryModel<InsertResponse>
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new InsertResponse()
            };

            try
            {
                if (categoryModel.Id == 0)
                {
                    //Nếu categoryModel == null thì báo lỗi.
                    result.PartnerCode = _internalCode.SystemError;
                    result.RetCode = ERetCodeSystem.SystemError;
                    //trả ra message lỗi.
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.BadRequest,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.BadRequest
                    };
                    return result;
                }
                categoryModel.UpdateBy = CookieViewModel.Id;
                var updateCategory = _categoryServices.UpdateCategory(fileImage, CoffeeManagementSystemConfig.CloudName, CoffeeManagementSystemConfig.APIKey, CoffeeManagementSystemConfig.APISecret, categoryModel);
                if (updateCategory.Id != 0)
                {
                    result.Data.ReturnId = "" + PrefixResponse.Category + "_" + updateCategory.Id;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.UpdateSuccessFull,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.UpdateSuccessFull
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.CreateStudentError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.UpdateCategoryError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.UpdateCategoryError
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

        #region DeleteCategory DONE TEST TEST2
        [HttpDelete]
        public RepositoryModel<bool> DeteleCategory([FromForm] int categoryId)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            //Cái này ko biết
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<bool> result = new RepositoryModel<bool>
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = true
            };

            try
            {
                if (categoryId == 0 )
                {
                    //Nếu categoryModel == null thì báo lỗi.
                    result.PartnerCode = _internalCode.SystemError;
                    result.RetCode = ERetCodeSystem.SystemError;
                    //trả ra message lỗi.
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.BadRequest,
                        HttpCode = ERepositoryStatus.BadRequest,
                        SystemMessage = _internalMessenger.BadRequest
                    };
                    return result;
                }
                var resultObject = _categoryServices.GetObject<CategoryEntities>(cate => cate.Id == categoryId);
                if (resultObject != null)
                {
                    var deleteCategory = _categoryServices.Delete<CategoryEntities>(resultObject.Id);
                    result.Data = true;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.DeleteCategorySuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.DeleteCategorySuccess
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.DeleteCategoryError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.DeleteCategoryError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.DeleteCategoryError
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
    }
}
