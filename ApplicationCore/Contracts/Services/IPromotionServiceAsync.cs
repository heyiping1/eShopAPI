﻿using ApplicationCore.Models.Requests;
using ApplicationCore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IPromotionServiceAsync : IBaseServiceAsync<PromotionRequestModel, PromotionResponseModel>
    {
    }
}
