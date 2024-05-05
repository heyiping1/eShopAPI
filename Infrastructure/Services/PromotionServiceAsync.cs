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
    public class PromotionServiceAsync : IPromotionServiceAsync
    {
        private readonly IPromotionRepositoryAsync _promotionRepository;
        private readonly IMapper _mapper;
        public PromotionServiceAsync(IPromotionRepositoryAsync promotionRepository, IMapper mapper)
        {
            _promotionRepository = promotionRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PromotionResponseModel>> GetAllAsync()
        {
            var categories = _promotionRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<PromotionResponseModel>>(categories);
        }

        public async Task<PromotionResponseModel> GetByIdAsync(int id)
        {
            var product = _promotionRepository.GetByIdAsync(id);
            if (product != null)
            {
                return _mapper.Map<PromotionResponseModel>(product);
            }
            return null;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _promotionRepository.DeleteAsync(id);
        }

        public async Task<int> AddAsync(PromotionRequestModel model)
        {
            var category = _mapper.Map<Promotion>(model);
            return await _promotionRepository.AddAsync(category);
        }

        public async Task<int> UpdateAsync(PromotionRequestModel model)
        {
            var category = _mapper.Map<Promotion>(model);
            return await _promotionRepository.UpdateAsync(category);
        }
    }
}