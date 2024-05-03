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
    public class ShipperService : IShipperService
    {
        private readonly IShipperRepository _shipperRepository;
        private readonly IMapper _mapper;
        public ShipperService(IShipperRepository shipperRepository, IMapper mapper)
        {
            _shipperRepository = shipperRepository;
            _mapper = mapper;
        }
        public IEnumerable<ShipperResponseModel> GetAll()
        {
            var categories = _shipperRepository.GetAll();
            return _mapper.Map<IEnumerable<ShipperResponseModel>>(categories);
        }

        public ShipperResponseModel GetById(int id)
        {
            var product = _shipperRepository.GetById(id);
            if (product != null)
            {
                return _mapper.Map<ShipperResponseModel>(product);
            }
            return null;
        }

        public int Delete(int id)
        {
            return _shipperRepository.Delete(id);
        }

        public int Add(ShipperRequestModel model)
        {
            var category = _mapper.Map<Shipper>(model);
            return _shipperRepository.Add(category);
        }

        public int Update(ShipperRequestModel model)
        {
            var category = _mapper.Map<Shipper>(model);
            return _shipperRepository.Update(category);
        }
    }
}