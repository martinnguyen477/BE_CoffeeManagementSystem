// <copyright file="AttributeValueOrderDetailServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using AutoMapper;
using CoffeeManagementSystem.Data.EntityContext;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeManagementSystem.Services.AttributeValueOrderDetailServices
{
    public class AttributeValueOrderDetailServices : BaseServices.BaseServices , IAttributeValueOrderDetailServices
    {
        #region Contructors, Variables
        private readonly IMapper _mapper;

        public AttributeValueOrderDetailServices(IMapper mapper)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
        }
        #endregion

        #region CreateAttributeValueOrderDetail
        public AttributeValueOrderDetailModel CreateAttributeValueOrderDetail(AttributeValueOrderDetailModel AttributeValueOrderDetailModel)
        {
            return _mapper.Map<AttributeValueOrderDetailModel>(InsertReturnModel(_mapper.Map<AttributeValueOrderDetailEntities>(AttributeValueOrderDetailModel)));
        }
        #endregion

        #region DeleteAttributeValueOrderDetail
        public bool DeleteAttributeValueOrderDetail(int AttributeValueOrderDetailId)
        {
            AttributeValueOrderDetailEntities resultObjectDelete = GetObject<AttributeValueOrderDetailEntities>(or => or.Id == AttributeValueOrderDetailId);
            return resultObjectDelete != null ? Delete<AttributeValueOrderDetailEntities>(resultObjectDelete) : false;
        }
        #endregion

        #region GetListAttributeValueOrderDetailAll
        public List<AttributeValueOrderDetailModel> GetListAttributeValueOrderDetailAll()
        {
            return _mapper.Map<List<AttributeValueOrderDetailModel>>(GetList<AttributeValueOrderDetailEntities>());
        }
        #endregion

        #region GetListAttributeValueOrderDetailAllPaging
        public List<AttributeValueOrderDetailModel> GetListAttributeValueOrderDetailAllPaging(int pageIndex, int pageSize)
        {
            var listAttributeValueOrderDetail = _mapper.Map<List<AttributeValueOrderDetailModel>>(GetList<AttributeValueOrderDetailEntities>());
            if (pageIndex > 0)
            {
                return listAttributeValueOrderDetail.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
            }
            return listAttributeValueOrderDetail;
        }
        #endregion

        #region GetAttributeValueOrderDetailById
        public AttributeValueOrderDetailModel GetAttributeValueOrderDetailById(int AttributeValueOrderDetailId)
        {
            return _mapper.Map<AttributeValueOrderDetailModel>(GetObject<AttributeValueOrderDetailEntities>(or => or.Id == AttributeValueOrderDetailId));
        }
        #endregion

        #region Update
        public AttributeValueOrderDetailModel UpdateAttributeValueOrderDetail(AttributeValueOrderDetailModel attributeValueOrderDetailModel)
        {
            return _mapper.Map<AttributeValueOrderDetailModel>(UpdateReturnModel(_mapper.Map<AttributeValueOrderDetailEntities>(attributeValueOrderDetailModel)));
        }
        #endregion
    }
}
