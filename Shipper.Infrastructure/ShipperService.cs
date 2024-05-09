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

namespace Infrastructure.Services
{
    public class ShipperServiceAsync : IShipperServiceAsync
    {
        private readonly IShipperRepositoryAsync _shipperRepository;
        private readonly IMapper _mapper;
        public ShipperServiceAsync(IShipperRepositoryAsync shipperRepository, IMapper mapper)
        {
            _shipperRepository = shipperRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ShipperResponseModel>> GetAllAsync()
        {
            var categories = await _shipperRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ShipperResponseModel>>(categories);
        }

        public async Task<ShipperResponseModel> GetByIdAsync(int id)
        {
            var product = await _shipperRepository.GetByIdAsync(id);
            if (product != null)
            {
                return _mapper.Map<ShipperResponseModel>(product);
            }
            return null;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _shipperRepository.DeleteAsync(id);
        }

        public async Task<int> AddAsync(ShipperRequestModel model)
        {
            var category = _mapper.Map<Shipper>(model);
            return await _shipperRepository.AddAsync(category);
        }

        public async Task<int> UpdateAsync(ShipperRequestModel model)
        {
            var category = _mapper.Map<Shipper>(model);
            return await _shipperRepository.UpdateAsync(category);
        }
    }
}