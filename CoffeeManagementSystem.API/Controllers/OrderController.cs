// <copyright file="OrderController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.API.Functions;
using CoffeeManagementSystem.Model.BaseModel;
using CoffeeManagementSystem.Model.Common;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Enum;
using CoffeeManagementSystem.Model.Model;
using CoffeeManagementSystem.Model.Request;
using CoffeeManagementSystem.Services.OrderServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace CoffeeManagementSystem.API.Controllers
{
    public class OrderController : BaseController.BaseController
    {
        #region Contructors, Variable
        private readonly IOrderServices _OrderServices;
        private readonly InterCode _internalCode = new InterCode();
        private readonly InternalMessenger _internalMessenger = new InternalMessenger();

        public OrderController(IConfiguration configuration, IOrderServices OrderServices)
        {
            _OrderServices = OrderServices;
            HelperConstants = new HelperConstantsModel(configuration);
        }
        #endregion

        #region GetListOrders
        [HttpGet]
        public RepositoryModel<List<OrderModel>> GetListOrders(int pageSize, int pageNumber)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<List<OrderModel>> result = new RepositoryModel<List<OrderModel>>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new List<OrderModel>()
            };

            try
            {
                var listOrder = _OrderServices.GetListOrderAllPaging(pageSize, pageNumber);

                if (listOrder.Count > 0)
                {
                    result.Data = listOrder;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetOrderSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetOrderSuccess
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.GetDataError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetOrderNoExists,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.GetOrderNoExists
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

        #region GetOrderById
        [HttpGet]
        public RepositoryModel<OrderModel> GetOrderById(int OrderById)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<OrderModel> result = new RepositoryModel<OrderModel>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new OrderModel()
            };

            try
            {
                if (OrderById == 0)
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

                var Order = _OrderServices.GetOrderById(OrderById);

                if (Order != null)
                {
                    result.Data = Order;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetOrderByIdSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetOrderByIdSuccess
                    };
                }
                else
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.GetDataError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetOrderByIdError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.GetOrderByIdError
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

        #region CreateOrder
        [HttpPost]
        public RepositoryModel<OrderModel> CreateOrder([FromBody] OrderModel OrderModel)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<OrderModel> result = new RepositoryModel<OrderModel>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new OrderModel()
            };

            try
            {
                if (OrderModel == null)
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

                OrderModel.CreateBy = OrderModel.UpdateBy = CookieViewModel.Id;
                OrderModel resultCreate = _OrderServices.CreateOrder(OrderModel);
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
                    result.PartnerCode = _internalCode.CreateOrderError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.CreateOrderError,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.CreateOrderError
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

        #region UpdateOrder
        [HttpPut]
        public RepositoryModel<OrderModel> UpdateOrder([FromBody] OrderModel OrderModel)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<OrderModel> result = new RepositoryModel<OrderModel>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new OrderModel()
            };

            try
            {
                if (OrderModel.Id == 0)
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
                var resultOrder = _OrderServices.GetObject<OrderEntities>(po => po.Id == OrderModel.Id);

                if (resultOrder != null)
                {
                    OrderModel.UpdateBy = CookieViewModel.Id;
                    result.Data = _OrderServices.UpdateOrder(OrderModel);
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.UpdateOrderSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.UpdateOrderSuccess
                    };
                }
                else
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.UpdateOrderError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.UpdateOrderError,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.UpdateOrderError
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

        #region DeleteOrder
        [HttpDelete]
        public RepositoryModel<bool> DeleteOrder(int Order)
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
                if (Order == 0)
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

                bool resultDelete = _OrderServices.DeleteOrder(Order);
                if (resultDelete == true)
                {
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.DeleteOrderSucces,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.DeleteOrderSucces
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.DeleteCategoryError;
                    result.Data = false;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.DeleteOrderError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.DeleteOrderError
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
