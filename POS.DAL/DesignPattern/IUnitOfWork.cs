using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace POS.DAL

{
    public interface IUnitOfWork<T> : IDisposable where T : DbContext
    {
        #region Props

       public T POSDbContext { get; }
        IDbContextTransaction DbContextTransaction { get; set; }

        public bool IsDisposed { get; }

        #endregion

        #region Methods

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        void Commit();

        #endregion
    }
}
