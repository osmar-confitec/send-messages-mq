using Domain.Interfaces;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public abstract class BaseService<TEntity> :IBaseService<TEntity> where TEntity : class
    {
        public IBaseRepository<TEntity> _iBaseRepository { get; protected set; }



        public BaseService(IBaseRepository<TEntity> iBaseRepository)
                                 
        {
            _iBaseRepository = iBaseRepository;
        }

        public void Dispose() => GC.SuppressFinalize(this);

        public void Add(TEntity entidade)
        {
            _iBaseRepository.Add(entidade);
        }

        public async Task AddAsync(TEntity entidade)
        {
            await _iBaseRepository.AddAsync(entidade);
        }

        public void Update(TEntity entidade)
        {
            _iBaseRepository.Update(entidade);
        }

        public void Remove(TEntity entidade)
        {
            _iBaseRepository.Remove(entidade);
        }

        public async Task AddAsync<T>(T entidade) where T : class
        {
            await _iBaseRepository.AddAsync(entidade);
        }

     

        public void Remove<T>(T customer) where T : class
        {
            _iBaseRepository.Remove(customer);
        }
    }
}
