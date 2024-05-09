using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using ApplicationCore.Models.Responses;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Repositories
{
    public class ProductRepositoryAsync : BaseRepositoryAsync<Product>, IProductRepositoryAsync
    {
        public ProductRepositoryAsync(EShopDbContext context) : base(context) { }
        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId, int pageNumber = 1, int pageSize = 30)
        {
            var products = await GetAllAsync();
           return products.Where(x => x.CategoryId == categoryId).Skip(pageNumber).Take(pageSize);
        }
    }
}
