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
    public class ShoppingCartItemServiceAsync : IShoppingCartItemServiceAsync
    {
        private readonly IShoppingCartItemRepositoryAsync _shoppingCartItemRepository;
        private readonly IMapper _mapper;
        public ShoppingCartItemServiceAsync(IShoppingCartItemRepositoryAsync shoppingCartItemRepository, IMapper mapper)
        {
            _shoppingCartItemRepository = shoppingCartItemRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ShoppingCartItemResponseModel>> GetAllAsync()
        {
            var categories = await _shoppingCartItemRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ShoppingCartItemResponseModel>>(categories);
        }

        public async Task<ShoppingCartItemResponseModel> GetByIdAsync(int id)
        {
            var product = await _shoppingCartItemRepository.GetByIdAsync(id);
            if (product != null)
            {
                return _mapper.Map<ShoppingCartItemResponseModel>(product);
            }
            return null;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _shoppingCartItemRepository.DeleteAsync(id);
        }

        public async Task<int> AddAsync(ShoppingCartItemRequestModel model)
        {
            var category = _mapper.Map<ShoppingCartItem>(model);
            return await _shoppingCartItemRepository.AddAsync(category);
        }

        public async Task<int> UpdateAsync(ShoppingCartItemRequestModel model)
        {
            var category = _mapper.Map<ShoppingCartItem>(model);
            return await _shoppingCartItemRepository.UpdateAsync(category);
        }
    }
}