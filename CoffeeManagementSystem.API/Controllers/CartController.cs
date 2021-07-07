using CoffeeManagementSystem.API.Functions;
using CoffeeManagementSystem.Model.BaseModel;
using CoffeeManagementSystem.Model.Common;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Enum;
using CoffeeManagementSystem.Model.Model;
using CoffeeManagementSystem.Model.Request;
using CoffeeManagementSystem.Services.CartServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeManagementSystem.API.Controllers
{
    public class CartController : BaseController.BaseController
    {
        #region Contructors, Variable
        private readonly ICartServices _CartServices;
        private readonly InterCode _internalCode = new InterCode();
        private readonly InternalMessenger _internalMessenger = new InternalMessenger();

        public CartController(IConfiguration configuration, ICartServices CartServices)
        {
            _CartServices = CartServices;
            HelperConstants = new HelperConstantsModel(configuration);
        }
        #endregion

        #region GetListCarts
        [HttpGet]
        public RepositoryModel<List<CartModel>> GetListCarts(int pageSize, int pageNumber)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<List<CartModel>> result = new RepositoryModel<List<CartModel>>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new List<CartModel>()
            };

            try
            {
                var listCart = _CartServices.GetListCartAllPaging(pageSize, pageNumber);

                if (listCart.Count > 0)
                {
                    result.Data = listCart;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetCartSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetCartSuccess
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.GetDataError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetCartNoExists,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.GetCartNoExists
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

        #region GetCartById
        [HttpGet]
        public RepositoryModel<CartModel> GetCartById(int CartById)
        {
            //Lấy tên Controller, Action, Key
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat);

            //Khở tạo model này là success. Và create data = null.
            RepositoryModel<CartModel> result = new RepositoryModel<CartModel>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new CartModel()
            };

            try
            {
                if (CartById == 0)
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

                var Cart = _CartServices.GetCartById(CartById);

                if (Cart != null)
                {
                    result.Data = Cart;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetCartByIdSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.GetCartByIdSuccess
                    };
                }
                else
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.GetDataError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.GetCartByIdError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.GetCartByIdError
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

        #region CreateCart
        [HttpPost]
        public RepositoryModel<CartModel> CreateCart([FromBody] CartModel CartModel)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<CartModel> result = new RepositoryModel<CartModel>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new CartModel()
            };

            try
            {
                if (CartModel == null)
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

                CartModel.CreateBy = CartModel.UpdateBy = CookieViewModel.Id;
                CartModel resultCreate = _CartServices.CreateCart(CartModel);
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
                    result.PartnerCode = _internalCode.CreateCartError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.CreateCartError,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.CreateCartError
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

        #region UpdateCart
        [HttpPut]
        public RepositoryModel<CartModel> UpdateCart([FromBody] CartModel CartModel)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var key = DateTime.Now.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat);

            RepositoryModel<CartModel> result = new RepositoryModel<CartModel>()
            {
                PartnerCode = _internalCode.SuccessFull,
                RetCode = ERetCodeSystem.Successfull,
                Data = new CartModel()
            };

            try
            {
                if (CartModel.Id == 0)
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
                var resultCart = _CartServices.GetObject<CartEntities>(po => po.Id == CartModel.Id);

                if (resultCart != null)
                {
                    CartModel.UpdateBy = CookieViewModel.Id;
                    result.Data = _CartServices.UpdateCart(CartModel);
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.UpdateCartSuccess,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.UpdateCartSuccess
                    };
                }
                else
                {
                    result.Data = null;
                    result.PartnerCode = _internalCode.UpdateCartError;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.UpdateCartError,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.UpdateCartError
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

        #region DeleteCart
        [HttpDelete]
        public RepositoryModel<bool> DeleteCart(int Cart)
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
                if (Cart == 0)
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

                bool resultDelete = _CartServices.DeleteCart(Cart);
                if (resultDelete == true)
                {
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.DeleteCartSucces,
                        HttpCode = ERepositoryStatus.Success,
                        SystemMessage = _internalMessenger.DeleteCartSucces
                    };
                }
                else
                {
                    result.PartnerCode = _internalCode.DeleteCategoryError;
                    result.Data = false;
                    result.Messenger = new MessengerError()
                    {
                        TraceId = Generator.GenerateCodeTracker(controllerName, actionName, key),
                        InternalMessage = _internalMessenger.DeleteCartError,
                        HttpCode = ERepositoryStatus.Error,
                        SystemMessage = _internalMessenger.DeleteCartError
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
