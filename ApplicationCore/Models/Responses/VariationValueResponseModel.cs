using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Responses
{
    public class VariationValueResponseModel
    {
        public int Id { get; set; }
        public string Value { get; set; } = string.Empty;
        public int VariationId { get; set; }
        public CategoryVariation CategoryVariation { get; set; } = new CategoryVariation();
        public List<ProductVariationValue> ProductVariationValues { get; set; } = new List<ProductVariationValue>();
    }
}
