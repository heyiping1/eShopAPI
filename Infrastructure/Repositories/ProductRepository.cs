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
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(EShopDbContext context) : base(context) { }
        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
           return GetAll().Where(x => x.CategoryId == categoryId);
        }
    }
}
