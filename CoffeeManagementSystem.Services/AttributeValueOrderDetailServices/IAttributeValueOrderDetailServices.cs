// <copyright file="IAttributeValueOrderDetailServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.Model;
using System.Collections.Generic;

namespace CoffeeManagementSystem.Services.AttributeValueOrderDetailServices
{
    public interface IAttributeValueOrderDetailServices : BaseServices.IBaseServices
    {
        List<AttributeValueOrderDetailModel> GetListAttributeValueOrderDetailAll();

        List<AttributeValueOrderDetailModel> GetListAttributeValueOrderDetailAllPaging(int pageIndex, int pageSize);

        AttributeValueOrderDetailModel CreateAttributeValueOrderDetail(AttributeValueOrderDetailModel AttributeValueOrderDetailModel);

        AttributeValueOrderDetailModel UpdateAttributeValueOrderDetail(AttributeValueOrderDetailModel AttributeValueOrderDetailModel);

        AttributeValueOrderDetailModel GetAttributeValueOrderDetailById(int AttributeValueOrderDetailId);

        bool DeleteAttributeValueOrderDetail(int AttributeValueOrderDetailId);
    }
}
