using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Requests
{
    public class ProductVariationValueRequestModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public int VariationValueId { get; set; }
        public VariationValue VariationValue { get; set; } = new VariationValue();
    }
}
