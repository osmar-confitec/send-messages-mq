using Data.Context;
using Data.Repository;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly Contexto _appContext;
        public UnitOfWork(Contexto appContext)
        {
            _appContext = appContext;

        }
        public async Task<bool> CommitAsync() => await _appContext.SaveChangesAsync() > 0;

        public void Dispose() => GC.SuppressFinalize(this);

        public DbContext GetContext() => _appContext;

        public IRepositoryConsult<T> GetRepository<T>() where T : class => new RepositoryConsult<T>(GetContext());
    }
}
