// <copyright file="OrderServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using AutoMapper;
using CoffeeManagementSystem.Data.EntityContext;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeManagementSystem.Services.OrderServices
{
    public class OrderServices : BaseServices.BaseServices, IOrderServices
    {
        #region Contructors, Variables
        private readonly IMapper _mapper;

        public OrderServices(IMapper mapper)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
        }
        #endregion

        #region CreateOrder
        public OrderModel CreateOrder(OrderModel orderModel)
        {
            return _mapper.Map<OrderModel>(InsertReturnModel(_mapper.Map<OrderEntities>(orderModel)));
        }
        #endregion

        #region DeleteOrder
        public bool DeleteOrder(int orderId)
        {
            OrderEntities resultObjectDelete = GetObject<OrderEntities>(or => or.Id == orderId);
            return resultObjectDelete != null ? Delete<OrderEntities>(resultObjectDelete) : false;
        }
        #endregion

        #region GetListOrderAll
        public List<OrderModel> GetListOrderAll()
        {
            return _mapper.Map<List<OrderModel>>(GetList<OrderEntities>());
        }
        #endregion

        #region GetListOrderAllPaging
        public List<OrderModel> GetListOrderAllPaging(int pageIndex, int pageSize)
        {
            var listOrder = _mapper.Map<List<OrderModel>>(GetList<OrderEntities>());
            if (pageIndex > 0)
            {
                return listOrder.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
            }
            return listOrder;
        }
        #endregion

        #region GetOrderById
        public OrderModel GetOrderById(int orderId)
        {
            return _mapper.Map<OrderModel>(GetObject<OrderEntities>(or => or.Id == orderId));
        }
        #endregion

        #region Update
        public OrderModel UpdateOrder(OrderModel orderModel)
        {
            return _mapper.Map<OrderModel>(UpdateReturnModel(_mapper.Map<OrderEntities>(orderModel)));
        }
        #endregion
    }
}
