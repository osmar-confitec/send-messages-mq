using Application.Interfaces;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public abstract class BaseApplication : IBaseApplication
    {

        protected BaseApplication(IUnitOfWork _unitOfWork
                                  )
        {

            unitOfWork = _unitOfWork;

         
        }

        public IUnitOfWork unitOfWork { get; protected set; }

        

        public void Dispose() => GC.SuppressFinalize(this);




    }
}
