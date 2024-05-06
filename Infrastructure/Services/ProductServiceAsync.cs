using ApplicationCore.Entities;
using ApplicationCore.Models.Requests;
using ApplicationCore.Models.Responses;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using AutoMapper;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProductServiceAsync : IProductServiceAsync
    {
        private readonly IProductRepositoryAsync _productRepository;
        private readonly IProductCategoryRepositoryAsync _categoryRepository;
        private readonly IMapper _mapper;

        public ProductServiceAsync(IProductRepositoryAsync productRepository, IProductCategoryRepositoryAsync categoryRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            
        }

        public async Task<IEnumerable<ProductResponseModel>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductResponseModel>>(products);
        }

        public async Task<ProductResponseModel> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product != null)
            {
                return _mapper.Map<ProductResponseModel>(product);
            }
            return null;
        }

        public async Task<IEnumerable<ProductResponseModel>> GetProductsByCategoryAsync(int categoryId, int pageNumber = 1, int pageSize = 30)
        {
            var products = await _productRepository.GetProductsByCategoryAsync(categoryId, pageNumber, pageSize);
            return _mapper.Map<IEnumerable<ProductResponseModel>>(products);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _productRepository.DeleteAsync(id);
        }

        public async Task<int> AddAsync(ProductRequestModel model)
        {
            model.Category = await _categoryRepository.GetByIdAsync(model.CategoryId);
            var product = _mapper.Map<Product>(model);
            return await _productRepository.AddAsync(product);
        }

        public async Task<int> UpdateAsync(ProductRequestModel model)
        {
            model.Category = await _categoryRepository.GetByIdAsync(model.CategoryId);
            var product = _mapper.Map<Product>(model);
            return await _productRepository.UpdateAsync (product);
        }
    }
}