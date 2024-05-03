using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IBaseService<TRequest, TResponse> where TRequest : class where TResponse : class
    {
        IEnumerable<TResponse> GetAll();
        int Add(TRequest request);
        int Update(TRequest request);
        int Delete(int id);
        TResponse GetById(int id);
    }
}
