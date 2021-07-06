// <copyright file="CartItemServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using AutoMapper;
using CoffeeManagementSystem.Data.EntityContext;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeManagementSystem.Services.CartItemServices
{
    public class CartItemServices : BaseServices.BaseServices, ICartItemServices
    {
        #region Contructors, Variables
        private readonly IMapper _mapper;

        public CartItemServices(IMapper mapper)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
        }
        #endregion

        #region CreateCartItem
        public CartItemModel CreateCartItem(CartItemModel CartItemModel)
        {
            return _mapper.Map<CartItemModel>(InsertReturnModel(_mapper.Map<CartItemEntities>(CartItemModel)));
        }
        #endregion

        #region DeleteCartItem
        public bool DeleteCartItem(int CartItemId)
        {
            CartItemEntities resultObjectDelete = GetObject<CartItemEntities>(or => or.Id == CartItemId);
            return resultObjectDelete != null ? Delete<CartItemEntities>(resultObjectDelete) : false;
        }
        #endregion

        #region GetListCartItemAll
        public List<CartItemModel> GetListCartItemAll()
        {
            return _mapper.Map<List<CartItemModel>>(GetList<CartItemEntities>());
        }
        #endregion

        #region GetListCartItemAllPaging
        public List<CartItemModel> GetListCartItemAllPaging(int pageIndex, int pageSize)
        {
            var listCartItem = _mapper.Map<List<CartItemModel>>(GetList<CartItemEntities>());
            if (pageIndex > 0)
            {
                return listCartItem.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
            }
            return listCartItem;
        }
        #endregion

        #region GetCartItemById
        public CartItemModel GetCartItemById(int CartItemId)
        {
            return _mapper.Map<CartItemModel>(GetObject<CartItemEntities>(or => or.Id == CartItemId));
        }
        #endregion

        #region Update
        public CartItemModel UpdateCartItem(CartItemModel CartItemModel)
        {
            return _mapper.Map<CartItemModel>(UpdateReturnModel(_mapper.Map<CartItemEntities>(CartItemModel)));
        }
        #endregion
    }
}
