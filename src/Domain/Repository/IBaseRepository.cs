using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {

        void Add(TEntity entidade);

        Task AddAsync(TEntity entidade);

        Task AddAsync<T>(T entidade) where T : class;

        void Update(TEntity customer);

        void Remove(TEntity customer);

        void Remove<T>(T customer) where T : class;

        IUnitOfWork unitOfWork { get; }

        IRepositoryConsult<TEntity> _repositoryConsult { get; }

    }
}
