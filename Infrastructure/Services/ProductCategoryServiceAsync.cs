using ApplicationCore.Entities;
using ApplicationCore.Models.Requests;
using ApplicationCore.Models.Responses;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Infrastructure.Service
{
    public class ProductCategoryServiceAsync : IProductCategoryServiceAsync
    {
        private readonly IProductCategoryRepositoryAsync _productCategoryRepository;
        private readonly IMapper _mapper;
        public ProductCategoryServiceAsync(IProductCategoryRepositoryAsync productCategoryRepository, IMapper mapper)
        {
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductCategoryResponseModel>> GetAllAsync()
        {
            var categories = _productCategoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductCategoryResponseModel>>(categories);
        }

        public async Task<ProductCategoryResponseModel> GetByIdAsync(int id)
        {
            var product = _productCategoryRepository.GetByIdAsync(id);
            if (product != null)
            {
                return _mapper.Map<ProductCategoryResponseModel>(product);
            }
            return null;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _productCategoryRepository.DeleteAsync(id);
        }

        public async Task<int> AddAsync(ProductCategoryRequestModel model)
        {
            var category = _mapper.Map<ProductCategory>(model);
            return await _productCategoryRepository.AddAsync(category);
        }

        public async Task<int> UpdateAsync(ProductCategoryRequestModel model)
        {
            var category = _mapper.Map<ProductCategory>(model);
            return await _productCategoryRepository.UpdateAsync(category);
        }
    }
}