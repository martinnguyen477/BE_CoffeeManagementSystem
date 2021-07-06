// <copyright file="OrderDetailServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using AutoMapper;
using CoffeeManagementSystem.Data.EntityContext;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeManagementSystem.Services.OrderDetailServices
{
    public class OrderDetailServices : BaseServices.BaseServices, IOrderDetailServices
    {
        #region Contructors, Variables
        private readonly IMapper _mapper;

        public OrderDetailServices(IMapper mapper)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
        }
        #endregion

        #region CreateOrder
        public OrderDetailModel CreateOrderDetail(OrderDetailModel orderDetailModel)
        {
            return _mapper.Map<OrderDetailModel>(InsertReturnModel(_mapper.Map<OrderDetailEntities>(orderDetailModel)));
        }
        #endregion

        #region DeleteOrder
        public bool DeleteOrderDetail(int orderDetailId)
        {
            OrderDetailEntities resultObjectDelete = GetObject<OrderDetailEntities>(or => or.Id == orderDetailId);
            return resultObjectDelete != null ? Delete<OrderDetailEntities>(resultObjectDelete) : false;
        }
        #endregion

        #region GetListOrderAll
        public List<OrderDetailModel> GetListOrderDetailAll()
        {
            return _mapper.Map<List<OrderDetailModel>>(GetList<OrderDetailEntities>());
        }
        #endregion

        #region GetListOrderAllPaging
        public List<OrderDetailModel> GetListOrderDetailAllPaging(int pageIndex, int pageSize)
        {
            var listOrderDetail = _mapper.Map<List<OrderDetailModel>>(GetList<OrderDetailEntities>());
            if (pageIndex > 0)
            {
                return listOrderDetail.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
            }
            return listOrderDetail;
        }
        #endregion

        #region GetOrderById
        public OrderDetailModel GetOrderDetailById(int orderDetailId)
        {
            return _mapper.Map<OrderDetailModel>(GetObject<OrderDetailEntities>(or => or.Id == orderDetailId));
        }
        #endregion

        #region Update
        public OrderDetailModel UpdateOrderDetail(OrderDetailModel orderDetailModel)
        {
            return _mapper.Map<OrderDetailModel>(UpdateReturnModel(_mapper.Map<OrderDetailEntities>(orderDetailModel)));
        }
        #endregion
    }
}
