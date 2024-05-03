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
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _promotionRepository;
        private readonly IMapper _mapper;
        public PromotionService(IPromotionRepository promotionRepository, IMapper mapper)
        {
            _promotionRepository = promotionRepository;
            _mapper = mapper;
        }
        public IEnumerable<PromotionResponseModel> GetAll()
        {
            var categories = _promotionRepository.GetAll();
            return _mapper.Map<IEnumerable<PromotionResponseModel>>(categories);
        }

        public PromotionResponseModel GetById(int id)
        {
            var product = _promotionRepository.GetById(id);
            if (product != null)
            {
                return _mapper.Map<PromotionResponseModel>(product);
            }
            return null;
        }

        public int Delete(int id)
        {
            return _promotionRepository.Delete(id);
        }

        public int Add(PromotionRequestModel model)
        {
            var category = _mapper.Map<Promotion>(model);
            return _promotionRepository.Add(category);
        }

        public int Update(PromotionRequestModel model)
        {
            var category = _mapper.Map<Promotion>(model);
            return _promotionRepository.Update(category);
        }
    }
}