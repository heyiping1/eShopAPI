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
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IMapper _mapper;
        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IMapper mapper)
        {
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
        }
        public IEnumerable<ProductCategoryResponseModel> GetAll()
        {
            var categories = _productCategoryRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductCategoryResponseModel>>(categories);
        }

        public ProductCategoryResponseModel GetById(int id)
        {
            var product = _productCategoryRepository.GetById(id);
            if (product != null)
            {
                return _mapper.Map<ProductCategoryResponseModel>(product);
            }
            return null;
        }

        public int Delete(int id)
        {
            return _productCategoryRepository.Delete(id);
        }

        public int Add(ProductCategoryRequestModel model)
        {
            var category = _mapper.Map<ProductCategory>(model);
            return _productCategoryRepository.Add(category);
        }

        public int Update(ProductCategoryRequestModel model)
        {
            var category = _mapper.Map<ProductCategory>(model);
            return _productCategoryRepository.Update(category);
        }
    }
}