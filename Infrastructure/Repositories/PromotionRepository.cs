﻿using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Repositories
{
    public class PromotionRepository : BaseRepository<Promotion>, IPromotionRepository
    {
        public PromotionRepository(EShopDbContext context) : base(context) { }
    }
}
