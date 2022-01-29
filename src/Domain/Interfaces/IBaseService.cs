using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBaseService<TEntity> : IDisposable where TEntity : class
    {
        public IBaseRepository<TEntity> _iBaseRepository { get; }

        void Add(TEntity entidade);

        void Update(TEntity customer);

        void Remove(TEntity customer);

        void Remove<T>(T customer) where T : class;

        Task AddAsync(TEntity entidade);

        Task AddAsync<T>(T entidade) where T : class;


    }
}
