using ApplicationCore;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models.Requests;
using ApplicationCore.Models.Responses;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopAPI.Controllers
{
    [ApiController]
    public class PromotionController : BaseController<Promotion, PromotionRequestModel, PromotionResponseModel>
    {
        public PromotionController(IPromotionServiceAsync promotionServiceAsync) : base(promotionServiceAsync)
        {
        }
    }
}