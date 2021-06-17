// <copyright file="BaseServices.cs" company="PlaceholderCompany">
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
    using CoffeeManagementSystem.Model.Exception;
    using EFCore.BulkExtensions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Storage;

    public class BaseServices : IBaseServices    
    {
        #region Constructors, Variables, Dispose

        protected DbContext Context;
        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    // code is here
                    Context.Dispose();
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion Constructors, Variables, Dispose

        #region Get Model

        public IQueryable<T> GetQueryable<T>() where T : BaseTable
        {
            // return _context.Set<T>().AsNoTracking().Where(p => p.Status != 0);
            return Context.Set<T>().AsNoTracking();
        }

        public List<T> GetList<T>() where T : BaseTable
        {
            return GetQueryable<T>().ToList();

            // return _context.Set<T>().AsParallel().AsOrdered().Where(p => !p.IsDelete).ToList();
        }

        public List<T> GetList<T>(Expression<Func<T, bool>> predicate) where T : BaseTable
        {
            return GetQueryable<T>().Where(predicate).ToList();
        }

        public T GetObject<T>(object pKey) where T : BaseTable
        {
            return Context.Set<T>().Find(pKey);
        }

        public T GetObjectByKey<T>(long pKey) where T : BaseTable
        {
            return Context.Set<T>().Find(pKey);
        }

        public T GetObject<T>(Expression<Func<T, bool>> predicate) where T : BaseTable
        {
            return Context.Set<T>().SingleOrDefault(predicate);
        }

        public T GetObject<T>(params object[] pKeys) where T : BaseTable
        {
            return Context.Set<T>().Find(pKeys);
        }

        #endregion Get Model

        #region Insert Model

        public bool Insert<T>(T pObj) where T : BaseTable
        {
            using var transaction = Context.Database.BeginTransaction();
            try
            {
                bool isOk = Insert(transaction, pObj);
                if (!isOk)
                {
                    return false;
                }

                Context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (SystemException ex)
            {
                Context.Database.RollbackTransaction();
                throw new CoffeeManagementSystemException(ex.Message);
            }
        }

        /// <summary>
        /// InsertReturnModel.
        /// </summary>
        /// <typeparam name="T">Type input.</typeparam>
        /// <param name="pObj">Object.</param>
        /// <returns>Return object.</returns>
        public T InsertReturnModel<T>(T pObj)
            where T : BaseTable
        {
            using var transaction = Context.Database.BeginTransaction();
            try
            {
                bool isOk = Insert(transaction, pObj);
                if (!isOk)
                {
                    return pObj;
                }

                Context.SaveChanges();
                transaction.Commit();
                return pObj;
            }
            catch (SystemException ex)
            {
                Context.Database.RollbackTransaction();
                throw new CoffeeManagementSystemException(ex.Message);
            }
        }

        public bool BulkInsertExcel<T>(List<T> pObjInsertList) where T : BaseTableWithId
        {
            var transaction = Context.Database.BeginTransaction();
            using (transaction)
            {
                try
                {
                    bool isOk = this.BulkInsert(Context, pObjInsertList);
                    if (isOk)
                    {
                        transaction.Commit();
                        return true;
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new CoffeeManagementSystemException(ex.Message);
                }
            }
        }

        public bool BulkUpdateExcel<T>(List<T> pObjInsertList) where T : BaseTableWithId
        {
            var transaction = Context.Database.BeginTransaction();
            using (transaction)
            {
                try
                {
                    bool isOk = this.BulkUpdate(Context, pObjInsertList);
                    if (isOk)
                    {
                        transaction.Commit();
                        return true;
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new CoffeeManagementSystemException(ex.Message);
                }
            }
        }

        private bool BulkInsert<T>(DbContext pContext, List<T> pObjInsertList)
            where T : BaseTableWithId
        {
            DateTime now = DateTime.Now;
            pObjInsertList.ForEach(p =>
            {
                p.CreateDate = now;
                p.UpdateDate = now;
            });

            pContext.BulkInsert(pObjInsertList);
            return true;
        }

        private bool BulkUpdate<T>(DbContext pContext, List<T> pObjInsertList)
            where T : BaseTableWithId
        {
            DateTime now = DateTime.Now;
            pObjInsertList.ForEach(p =>
            {
                p.UpdateDate = now;
            });

            pContext.BulkUpdate(pObjInsertList);
            return true;
        }

        public bool Insert<T>(IDbContextTransaction pTransaction, T pObj)
            where T : BaseTable
        {
            try
            {
                Context.Entry(pObj).State = EntityState.Added;
                return true;
            }
            catch (SystemException ex)
            {
                throw new CoffeeManagementSystemException(ex.Message);
            }
        }

        #endregion Insert Model

        #region Update Model

        public bool Update<T>(T pObj) where T : BaseTable
        {
            return Update(pObj, "CreateDate", "CreateBy");
        }

        public bool Update<T>(T pObj, params string[] pNotUpdatedProperties) where T : BaseTable
        {
            using var transaction = Context.Database.BeginTransaction();
            try
            {
                bool isOk = Update(transaction, pObj, pNotUpdatedProperties);
                if (isOk)
                {
                    Context.SaveChanges();
                    transaction.Commit();
                }

                return isOk;
            }
            catch (SystemException ex)
            {
                Context.Database.RollbackTransaction();
                throw new CoffeeManagementSystemException(ex.Message);
            }
        }

        public T UpdateReturnModel<T>(T pObj, params string[] pNotUpdatedProperties) where T : BaseTable
        {
            using var transaction = Context.Database.BeginTransaction();
            try
            {
                bool isOk = Update(transaction, pObj, pNotUpdatedProperties);
                if (isOk)
                {
                    Context.SaveChanges();
                    transaction.Commit();
                }

                return pObj;
            }
            catch (SystemException ex)
            {
                Context.Database.RollbackTransaction();
                throw new CoffeeManagementSystemException(ex.Message);
            }
        }

        public bool Update<T>(IDbContextTransaction pTransaction, T pObj, params string[] pNotUpdatedProperties) where T : BaseTable
        {
            try
            {
                var keyNames = GetPrimaryKey<T>();
                var keyValues = keyNames.Select(p => pObj.GetType().GetProperty(p)?.GetValue(pObj, null)).ToArray();
                T exist = GetObject<T>(keyValues);
                if (exist != null)
                {
                    Context.Entry(exist).State = EntityState.Detached;
                    Context.Attach(pObj);
                    var entry = Context.Entry(pObj);
                    entry.State = EntityState.Modified;

                    if (pNotUpdatedProperties.Any())
                    {
                        foreach (string prop in pNotUpdatedProperties)
                        {
                            entry.Property(prop).IsModified = false;
                        }
                    }

                    return true;
                }

                return false;
            }
            catch (SystemException ex)
            {
                throw new CoffeeManagementSystemException(ex.Message);
            }
        }

        public bool UpdateStatus<T>(long pKey, StatusSystem pStatus, int pUserUpdated) where T : BaseTable
        {
            using var transaction = Context.Database.BeginTransaction();
            try
            {
                var obj = GetObjectByKey<T>(pKey);
                obj.Status = pStatus;
                obj.UpdateBy = pUserUpdated;
                Context.Entry(obj).State = EntityState.Modified;
                Context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (SystemException ex)
            {
                Context.Database.RollbackTransaction();
                throw new CoffeeManagementSystemException(ex.Message);
            }
        }

        #endregion Update Model

        #region Delete Model

        public bool DeleteObject<T>(object pKey, string pUserUpdated = null) where T : BaseTable
        {
            using var transaction = Context.Database.BeginTransaction();
            try
            {
                bool isOk = Delete<T>(transaction, pKey, pUserUpdated);
                if (isOk)
                {
                    Context.SaveChanges();
                    transaction.Commit();
                }

                return isOk;
            }
            catch (SystemException ex)
            {
                Context.Database.RollbackTransaction();
                throw new CoffeeManagementSystemException(ex.Message);
            }
        }

        public bool DeleteSinge<T>(int pKey, int pUserUpdated) where T : BaseTable
        {
            using var transaction = Context.Database.BeginTransaction();
            try
            {
                var obj = GetObjectByKey<T>(pKey);
                obj.Status = 0;
                obj.UpdateBy = pUserUpdated;
                Context.Entry(obj).State = EntityState.Modified;
                Context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (SystemException ex)
            {
                Context.Database.RollbackTransaction();
                throw new CoffeeManagementSystemException(ex.Message);
            }
        }

        public bool Delete<T>(IDbContextTransaction pTransaction, object pKey, int pUpdateBy = 0) where T : BaseTable
        {
            try
            {
                var obj = GetObject<T>(pKey);
                obj.Status = 0;

                if (pUpdateBy != 0)
                {
                    obj.UpdateBy = pUpdateBy;
                }

                Context.Entry(obj).State = EntityState.Modified;
                return true;
            }
            catch (SystemException ex)
            {
                throw new CoffeeManagementSystemException(ex.Message);
            }
        }

        public bool Delete<T>(params object[] pKeys) where T : BaseTable
        {
            using var transaction = Context.Database.BeginTransaction();
            try
            {
                var obj = GetObject<T>(pKeys);
                obj.Status = 0;
                Context.Entry(obj).State = EntityState.Deleted;
                Context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (SystemException ex)
            {
                Context.Database.RollbackTransaction();
                throw new CoffeeManagementSystemException(ex.Message);
            }
        }

        #endregion Delete Model

        #region Private Base

        private string[] GetPrimaryKey<T>() where T : BaseTable
        {
            return Context.Model.FindEntityType(typeof(T))
                .FindPrimaryKey().Properties
                .Select(x => x.Name).ToArray();
        }

        #endregion Private Base
    }
}
