using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Responses {

    public class PromotionDetailResponseModel
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; } = new Promotion();
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; } = new ProductCategory();
        public string ProductCategoryName { get; set; } = string.Empty;
    }
}
