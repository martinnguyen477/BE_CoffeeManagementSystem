// <copyright file="CartServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using AutoMapper;
using CoffeeManagementSystem.Data.EntityContext;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeManagementSystem.Services.CartServices
{
    public class CartServices : BaseServices.BaseServices, ICartServices
    {
        #region Contructors, Variables
        private readonly IMapper _mapper;

        public CartServices(IMapper mapper)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
        }
        #endregion

        #region CreateCart
        public CartModel CreateCart(CartModel cartModel)
        {
            return _mapper.Map<CartModel>(InsertReturnModel(_mapper.Map<CartEntities>(cartModel)));
        }
        #endregion

        #region DeleteCart
        public bool DeleteCart(int cartId)
        {
            CartEntities resultObjectDelete = GetObject<CartEntities>(or => or.Id == cartId);
            return resultObjectDelete != null ? Delete<CartEntities>(resultObjectDelete) : false;
        }
        #endregion

        #region GetListCartAll
        public List<CartModel> GetListCartAll()
        {
            return _mapper.Map<List<CartModel>>(GetList<CartEntities>());
        }
        #endregion

        #region GetListCartAllPaging
        public List<CartModel> GetListCartAllPaging(int pageIndex, int pageSize)
        {
            var listCart = _mapper.Map<List<CartModel>>(GetList<CartEntities>());
            if (pageIndex > 0)
            {
                return listCart.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
            }
            return listCart;
        }
        #endregion

        #region GetCartById
        public CartModel GetCartById(int cartId)
        {
            return _mapper.Map<CartModel>(GetObject<CartEntities>(or => or.Id == cartId));
        }
        #endregion

        #region Update
        public CartModel UpdateCart(CartModel cartModel)
        {
            return _mapper.Map<CartModel>(UpdateReturnModel(_mapper.Map<CartEntities>(cartModel)));
        }
        #endregion
    }
}
