// <copyright file="PositionServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.PositionServices
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using CoffeeManagementSystem.Data.EntityContext;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;
    using CoffeeManagementSystem.Model.Response;

    public class PositionServices : BaseServices.BaseServices, IPositionServices
    {
        #region Contructors, Variable
        private readonly IMapper _mapper;

        public PositionServices(IMapper mapper)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
        }
        #endregion

        #region Create Position
        public PositionModel CreatePosition(PositionModel posititonModel)
        {
            return _mapper.Map<PositionModel>(InsertReturnModel(_mapper.Map<PositionEntities>(posititonModel)));
        }
        #endregion

        #region Delete Position
        public bool DeletePosition(int positionId)
        {
            PositionEntities position = GetObject<PositionEntities>(po => po.Id == positionId);
            if(position != null)
            {
                return Delete<PositionEntities>(position.Id);
            }
            return false;
        }
        #endregion

        #region DetailPositionById
        public PositionDetailRespone DetailPositionById(int positionId)
        {
            var position = (from po in Context.Set<PositionEntities>()
                            from us in Context.Set<UserEntities>().Where(us => us.Id == po.CreateBy).DefaultIfEmpty()
                            from us2 in Context.Set<UserEntities>().Where(us2 => us2.Id == po.UpdateBy).DefaultIfEmpty()
                            where po.Id == positionId
                            select new PositionDetailRespone
                            {
                                Id = po.Id,
                                PositionName = po.PositionName,
                                CreateBy = po.CreateBy,
                                CreateByUser = us.LastName + " " + us.FirstName,
                                UpdateBy = po.UpdateBy,
                                UpdateByUser = us2.LastName + " " + us2.FirstName,
                                Status = po.Status,
                                CreateDate = po.CreateDate,
                                UpdateDate = po.UpdateDate
                            }).FirstOrDefault();
            return position;            
        }
        #endregion

        #region GetListAllPosition
        public List<PositionModel> GetListAllPosition(int pageSize, int pageNumber)
        {
            List<PositionModel> listPosition = _mapper.Map<List<PositionModel>>(GetList<PositionEntities>());

            if (pageSize > 0)
            {
                listPosition = listPosition.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            }
            return listPosition;
        }
        #endregion

        #region UpdatePostion
        public PositionModel UpdatePosition(PositionModel posititonModel)
        {
            return _mapper.Map<PositionModel>(UpdateReturnModel(_mapper.Map<PositionEntities>(posititonModel)));
        }
        #endregion
    }
}
