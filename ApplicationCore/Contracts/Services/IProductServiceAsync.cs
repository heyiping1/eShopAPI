using ApplicationCore.Models.Requests;
using ApplicationCore.Models.Responses;
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IProductServiceAsync : IBaseServiceAsync<ProductRequestModel, ProductResponseModel>
    {
        Task<IEnumerable<ProductResponseModel>> GetProductsByCategoryAsync(int categoryId, int pageNumber, int pageSize);
    }
}
