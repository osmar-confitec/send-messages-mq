using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> CommitAsync();

        DbContext GetContext();

        IRepositoryConsult<T> GetRepository<T>() where T : class;
    }
}
