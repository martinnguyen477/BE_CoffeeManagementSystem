// <copyright file="IBaseService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.BaseServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using CoffeeManagementSystem.Model.BaseModel;
    using CoffeeManagementSystem.Model.Enum;
    using Microsoft.EntityFrameworkCore.Storage;

    public interface IBaseServices : IDisposable
    {
        IQueryable<T> GetQueryable<T>() where T : BaseTable;

        List<T> GetList<T>() where T : BaseTable;

        List<T> GetList<T>(Expression<Func<T, bool>> predicate) where T : BaseTable;

        T GetObject<T>(object pKey) where T : BaseTable;

        T GetObjectByKey<T>(long pKey) where T : BaseTable;

        T GetObject<T>(Expression<Func<T, bool>> predicate) where T : BaseTable;

        T GetObject<T>(params object[] pKeys) where T : BaseTable;

        bool Insert<T>(T pObj) where T : BaseTable;

        T InsertReturnModel<T>(T pObj) where T : BaseTable;

        bool Insert<T>(IDbContextTransaction pTransaction, T pObj) where T : BaseTable;

        bool Update<T>(T pObj) where T : BaseTable;

        bool Update<T>(T pObj, params string[] pNotUpdatedProperties) where T : BaseTable;

        T UpdateReturnModel<T>(T pObj, params string[] pNotUpdatedProperties) where T : BaseTable;

        bool Update<T>(IDbContextTransaction pTransaction, T pObj, params string[] pNotUpdatedProperties) where T : BaseTable;

        bool UpdateStatus<T>(long pKey, StatusSystem pStatus, int pUserUpdated) where T : BaseTable;

        bool DeleteObject<T>(object pKey, string pUserUpdated = null) where T : BaseTable;

        bool DeleteSinge<T>(int pKey, int pUserUpdated) where T : BaseTable;

        bool Delete<T>(IDbContextTransaction pTransaction, object pKey, int pUpdateBy = 0) where T : BaseTable;

        bool Delete<T>(params object[] pKeys) where T : BaseTable;

        public bool Delete<T>(Expression<Func<T, bool>> predicate) where T : BaseTable;

        bool BulkInsertExcel<T>(List<T> pObjInsertList) where T : BaseTableWithId;

        bool BulkUpdateExcel<T>(List<T> pObjInsertList) where T : BaseTableWithId;

        bool BulkDeleteExcel<T>(List<T> pObjInsertList) where T : BaseTableWithId;
    }
}
