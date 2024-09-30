﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using System;
using System.Threading.Tasks;

namespace POS.DAL
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : DbContext
    {
        #region Fields

        bool _IsDisposed = false;

        public UnitOfWork(T POSDbContext) => this.POSDbContext = POSDbContext;

        #endregion

        #region Props

        public T POSDbContext { get; }
        public IDbContextTransaction DbContextTransaction { get; set; }

        public bool IsDisposed { get => _IsDisposed; }

        #endregion

        #region Methods

        public virtual void Commit() => POSDbContext.Database.CurrentTransaction.Commit();

        public bool SaveChanges()
        {
            try
            {
                return POSDbContext.SaveChanges() >= 0;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return false;
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                return (await POSDbContext.SaveChangesAsync()) > 0;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            POSDbContext.Dispose();
            _IsDisposed = true;
        }
        #endregion
    }

}
