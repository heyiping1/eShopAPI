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

namespace Infrastructure.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductCategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IProductCategoryRepository categoryRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            
        }

        public IEnumerable<ProductResponseModel> GetAll()
        {
            var products = _productRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductResponseModel>>(products);
        }

        public ProductResponseModel GetById(int id)
        {
            var product = _productRepository.GetById(id);
            if (product != null)
            {
                return _mapper.Map<ProductResponseModel>(product);
            }
            return null;
        }

        public int Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public int Add(ProductRequestModel model)
        {
            model.Category = _categoryRepository.GetById(model.CategoryId);
            var product = _mapper.Map<Product>(model);
            return _productRepository.Add(product);
        }

        public int Update(ProductRequestModel model)
        {
            model.Category = _categoryRepository.GetById(model.CategoryId);
            var product = _mapper.Map<Product>(model);
            return _productRepository.Update(product);
        }
    }
}