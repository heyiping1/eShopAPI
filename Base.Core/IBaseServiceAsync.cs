using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IBaseServiceAsync<TRequest, TResponse> where TRequest : class where TResponse : class
    {
        Task<IEnumerable<TResponse>> GetAllAsync();
        Task<int> AddAsync(TRequest request);
        Task<int> UpdateAsync(TRequest request);
        Task<int> DeleteAsync(int id);
        Task<TResponse> GetByIdAsync(int id);
    }
}
