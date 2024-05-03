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
    public class ShoppingCartItemService : IShoppingCartItemService
    {
        private readonly IShoppingCartItemRepository _shoppingCartItemRepository;
        private readonly IMapper _mapper;
        public ShoppingCartItemService(IShoppingCartItemRepository shoppingCartItemRepository, IMapper mapper)
        {
            _shoppingCartItemRepository = shoppingCartItemRepository;
            _mapper = mapper;
        }
        public IEnumerable<ShoppingCartItemResponseModel> GetAll()
        {
            var categories = _shoppingCartItemRepository.GetAll();
            return _mapper.Map<IEnumerable<ShoppingCartItemResponseModel>>(categories);
        }

        public ShoppingCartItemResponseModel GetById(int id)
        {
            var product = _shoppingCartItemRepository.GetById(id);
            if (product != null)
            {
                return _mapper.Map<ShoppingCartItemResponseModel>(product);
            }
            return null;
        }

        public int Delete(int id)
        {
            return _shoppingCartItemRepository.Delete(id);
        }

        public int Add(ShoppingCartItemRequestModel model)
        {
            var category = _mapper.Map<ShoppingCartItem>(model);
            return _shoppingCartItemRepository.Add(category);
        }

        public int Update(ShoppingCartItemRequestModel model)
        {
            var category = _mapper.Map<ShoppingCartItem>(model);
            return _shoppingCartItemRepository.Update(category);
        }
    }
}