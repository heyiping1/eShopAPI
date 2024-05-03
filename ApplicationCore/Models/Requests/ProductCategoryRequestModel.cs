using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Requests
{
    public class ProductCategoryRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = new List<Product>();
        public List<CategoryVariation> Variations { get; set; } = new List<CategoryVariation>();
    }
}
