using ApplicationCore.Entities;
using ApplicationCore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IProductRepositoryAsync : IBaseRepositoryAsync<Product>
    {
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId, int pageNumber, int pageSize);
    }
}
