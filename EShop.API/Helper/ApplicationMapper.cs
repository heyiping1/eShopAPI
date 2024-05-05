using ApplicationCore.Entities;
using ApplicationCore.Models.Requests;
using ApplicationCore.Models.Responses;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.API.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<ProductRequestModel, Product>().ReverseMap();
            CreateMap<ProductResponseModel, Product>().ReverseMap();
            CreateMap<ProductCategoryRequestModel, ProductCategory>().ReverseMap();
            CreateMap<ProductCategoryResponseModel, ProductCategory>().ReverseMap();
            CreateMap<PromotionRequestModel, Promotion>().ReverseMap();
            CreateMap<PromotionResponseModel, Promotion>().ReverseMap();
            CreateMap<ShipperRequestModel, Shipper>().ReverseMap();
            CreateMap<ShipperResponseModel, Shipper>().ReverseMap();
            CreateMap<ShoppingCartItemRequestModel, ShoppingCartItem>().ReverseMap();
            CreateMap<ShoppingCartItemResponseModel, ShoppingCartItem>().ReverseMap();
        }
    }
}